using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaEntidades.Utilities;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Compras : Conexion
    {
        CD_Proveedores CDProveedores = new CD_Proveedores();

        public int RegistrarCompra(List<DetalleCompra> detalles, Compra compra, bool percepcion, bool retencion)
        {
            Conn.Open();
            Proveedor provider = CDProveedores.find(compra.Proveedor);
            CD_Productos CD_Productos = new CD_Productos();
            MySqlCommand comando = Conn.CreateCommand();
            MySqlTransaction Trans;

            Trans = Conn.BeginTransaction();
            comando.Connection = Conn;
            comando.Transaction = Trans;
            try
            {
                comando = new MySqlCommand("INSERT INTO `compra` (`afectas`, `iva`, `retencion`, `proveedor`, `fecha`, `registrado_por`, `condiciones`, `document_type`, `document_number`) " +
                    "VALUES ('0.00', '0.00', '0.00', @proveedor, @fecha, 'Diego/Mario', @condiciones, @documentType, @documentNumber)", Conn);
                comando.Parameters.AddWithValue("@proveedor", compra.Proveedor);
                comando.Parameters.AddWithValue("@fecha", compra.Fecha.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@condiciones", compra.Condiciones);
                comando.Parameters.AddWithValue("@documentType", compra.Document_type);
                comando.Parameters.AddWithValue("@documentNumber", compra.Document_number);
                comando.ExecuteNonQuery();
                var lastInserted = Convert.ToInt32(comando.LastInsertedId);
                compra.Id1 = lastInserted;

                decimal subtotal = 0.00m;
                foreach (DetalleCompra detalle in detalles)
                {
                    //buscar los productos
                    Producto producto = CD_Productos.find(detalle.Producto);
                    int existencias = producto.Existencias;
                    Decimal costo = producto.Costo;

                    Decimal nuevo_costo =( (existencias * costo) + (detalle.Cant * detalle.Price)) / (existencias + detalle.Cant);

                    comando = new MySqlCommand("update producto set costo = @costo, existencias = @existencias where id = @id", Conn);
                    comando.Parameters.AddWithValue("@costo",nuevo_costo);
                    comando.Parameters.AddWithValue("@existencias", existencias + detalle.Cant);
                    comando.Parameters.AddWithValue("@id", detalle.Producto);
                    comando.ExecuteNonQuery();

                    //registrar movimiento de producto
                    //Compra es tipo 1 y venta es tipo 0

                    comando = new MySqlCommand("INSERT INTO `movimiento`(`producto`, `cant`, `existencia_anterior`, `costo`, `costo_anterior`, `tipo`, `fecha`, `cliente`, `doc`) " +
                        "VALUES (@producto, @cant, @existencia_ant, @costo, @costo_anterior, 1, @fecha, @cliente, @doc)", Conn);
                    comando.Parameters.AddWithValue("@producto", producto.Id);
                    comando.Parameters.AddWithValue("@cant", detalle.Cant);

                    comando.Parameters.AddWithValue("@existencia_ant", existencias);
                    comando.Parameters.AddWithValue("@costo", detalle.Price);

                    comando.Parameters.AddWithValue("@costo_anterior", costo);
                    comando.Parameters.AddWithValue("@fecha", compra.Fecha);
                    comando.Parameters.AddWithValue("@cliente", provider.Nombre);
                    comando.Parameters.AddWithValue("@doc", $"{compra.Document_type} # {compra.Document_number}");
                  

                    comando.ExecuteNonQuery();

                    //detalle de compra

                    comando = new MySqlCommand("INSERT INTO `detalle_compra`(`compra`, `producto`, `cant`, `precio`) " +
                        "VALUES (@compra,@producto,@cant,@precio)", Conn);

                    comando.Parameters.AddWithValue("@compra", compra.Id1);
                    comando.Parameters.AddWithValue("@producto", detalle.Producto);

                    comando.Parameters.AddWithValue("@cant", detalle.Cant);
                    comando.Parameters.AddWithValue("@precio", detalle.Price);

                    comando.ExecuteNonQuery();


                    subtotal += (detalle.Price * detalle.Cant);
                }

                comando = new MySqlCommand( "UPDATE `compra` SET `afectas`=@afectas, `iva`=@iva, `retencion`=@retencion where Id = @id ", Conn);

                comando.Parameters.AddWithValue("@afectas", subtotal);
                comando.Parameters.AddWithValue("@iva", compra.Document_type == "ccf" ? (subtotal * Config.iva).ToString() : "0.00");
                comando.Parameters.AddWithValue("@retencion", percepcion ? (subtotal * Config.percepcion).ToString() : "0.00");
                comando.Parameters.AddWithValue("@id", compra.Id1);

                comando.ExecuteNonQuery();

                //registrar partida de compra

                var contaDatos = new CD_Conta();
                var partida = new Partida();
                partida.Fecha = DateTime.Today;
                partida.Description = $"Compra a {provider.Nombre} con {compra.Document_type.ToUpper()} # {compra.Document_number}";
                partida.Debe = 0.00m;
                partida.Haber = 0.00m;
                partida.Compra_relacionada = compra.Id1;

                List<DetallePartida> detallePartida = new List<DetallePartida>();

                if (retencion)
                {
                    //DetallePartida(idCuenta, debe, haber)
                    detallePartida.Add(new DetallePartida(7, (compra.Document_type == "ccf" ? (subtotal * Config.iva) : 0.00m), 0));
                    detallePartida.Add(new DetallePartida(8, subtotal, 0));
                    detallePartida.Add(new DetallePartida(compra.Condiciones > 0 ? 27 : 31, 0, subtotal + (compra.Document_type == "ccf" ? (subtotal * (Config.iva - Config.retencion)) : 0)));

                    detallePartida.Add(new DetallePartida(28,(compra.Document_type == "ccf" ? (subtotal * Config.retencion) : 0.00m),0));

                    //Impuesto por cobrar              $$IVA 13%
                    //Inventario                       $$valor neto de la compra
                    //      Impuesto por pagar         $$ retencion 1%
                    //      Efectivo y Equivalentes    $$ monto de compra - retencion 

                    partida.Debe = subtotal + (subtotal * (1 + Config.iva + Config.retencion));
                    partida.Haber = subtotal + (subtotal * (1 + Config.iva+Config.retencion));

                }
                //codigo de la partida si hay retencion
                else if (percepcion)
                {
                    //DetallePartida(idCuenta, debe, haber)
                    detallePartida.Add(new DetallePartida(7, (compra.Document_type == "ccf" ? (subtotal * (Config.iva + Config.retencion)):0.00m), 0));
                    detallePartida.Add(new DetallePartida(8, subtotal, 0));
                    detallePartida.Add(new DetallePartida(compra.Condiciones > 0 ?27 : 31, 0, subtotal + (compra.Document_type == "ccf" ? (subtotal * (Config.iva + Config.percepcion)) : 0)));

                    //impuesto por cobrar         $$IVA 13% + percepcion 1%
                    //Inventario                  $$ valor neto de compra
                    //    Efectivo y Equivalente / cuenta por pagar     $$ 


                    partida.Debe = subtotal + (compra.Document_type == "ccf" ? subtotal * (Config.iva + Config.percepcion):0);
                    partida.Haber = subtotal + (compra.Document_type == "ccf" ? subtotal * (Config.iva + Config.percepcion): 0);


                }
                //codigo de la partida si no hay ninguna de las dos
                else
                {

                    //DetallePartida(idCuenta, debe, haber)
                    detallePartida.Add(new DetallePartida(7, (compra.Document_type == "ccf" ? (subtotal * Config.iva) : 0.00m), 0));
                    detallePartida.Add(new DetallePartida(8, subtotal, 0));
                    detallePartida.Add(new DetallePartida(compra.Condiciones > 0 ?27 :  31, 0, subtotal + (compra.Document_type == "ccf" ? (subtotal * Config.iva) : 0)));

                    //impuesto por cobrar         $$IVA 13% + percepcion 1%
                    //Inventario                  $$ valor neto de compra
                    //    Efectivo y Equivalente / cuenta por pagar     $$ 

                    partida.Debe = subtotal + (subtotal * (1 + Config.iva));
                    partida.Haber = subtotal + (subtotal * (1 + Config.iva));

                }
                int guardada = contaDatos.GuardarPartida(partida, detallePartida);
                
            //Fin de registrar partida de compra


            Trans.Commit();
                return compra.Id1;
            }
            catch (Exception e)
            {
                try
                {
                    Trans.Rollback();
                    Mensaje.ErrorMessage = e.Message;
                    
                }
                catch (MySqlException ex)
                {
                        Mensaje.ErrorMessage = ex.Message;
                }

            }
            finally
            {
                Conn.Close();
            }
            return 0;

        }



    }
}
