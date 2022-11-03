using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;

namespace CapaDatos
{
    public class CD_Documento : Conexion
    {
        private String table_name = "documento";

        CD_Clientes DatosCliente = new CD_Clientes();

        public bool validaDocumento(int serie, int numero)
        {
            MySqlCommand c = new MySqlCommand($"select * from {table_name} where serie = {serie} and numero = {numero}", Conn);
            try
            {
                Conn.Open();
                MySqlDataReader reader = c.ExecuteReader();
                return !reader.HasRows;
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = e.Message;
                return false;
            }
            finally
            {
                Conn.Close();
            }
        }



        public int GuardarDocumento(Documento doc, List<DetalleDocumento> detalles, bool retencion)
        {
            decimal costodVenta = 0.00m;

            Cliente cliente = DatosCliente.find(doc.Cliente);

            CD_Productos cdproductos = new CD_Productos();

            MySqlCommand comando = Conn.CreateCommand();
            MySqlTransaction transaction;
            Conn.Open();

            transaction = Conn.BeginTransaction();

            comando.Connection = Conn;
            comando.Transaction = transaction;
            try
            {
                comando.CommandText = "INSERT INTO `documento`(`numero`, `serie`, `cliente`, `fecha`, `condiciones`, `datos_cliente`, `creacion`, `creado_por`,`Tipo_documento`) " +
                    "VALUES (@numero, @serie, @cliente, @fecha, @condiciones, @datoscliente, CURRENT_TIMESTAMP, 'Diego/Mario', @tipodocumento)";
                comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = doc.Numero;
                comando.Parameters.Add("@serie", MySqlDbType.Int32).Value = doc.Serie;
                comando.Parameters.Add("@cliente", MySqlDbType.Int32).Value = doc.Cliente;
                comando.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = doc.Fecha;
                comando.Parameters.Add("@condiciones", MySqlDbType.Int32).Value = doc.Condiciones;
                comando.Parameters.Add("@datoscliente", MySqlDbType.VarChar).Value = doc.Datos_cliente;
                comando.Parameters.Add("@tipodocumento", MySqlDbType.String).Value = doc.Tipo_documento;

                comando.ExecuteNonQuery();
                var lastInserted = Convert.ToInt32(comando.LastInsertedId);
                doc._Id = lastInserted;
                decimal subtotalAfectas = 0.00m;
                decimal subtotalExentas = 0.00m;

                foreach (DetalleDocumento detalle in detalles)
                {
                    //buscar productos
                    Producto producto = cdproductos.find(detalle._Id);

                    costodVenta += (producto.Costo * detalle.Cant);

                    comando = new MySqlCommand("update producto set existencias = @existencias where id = @id", Conn);
                    comando.Parameters.AddWithValue("@existencias", producto.Existencias - detalle.Cant);
                    comando.Parameters.AddWithValue("@id", producto.Id);
                    comando.ExecuteNonQuery();


                    //registrar movimiento
                    comando = new MySqlCommand($"INSERT INTO `movimiento`(`producto`, `cant`, `existencia_anterior`, `costo`, `costo_anterior`, `tipo`, `fecha`, `cliente`, `doc`) " +
                    $"VALUES (@producto, @cant, @existencia_ant, @costo, @costo_ant, 0, @fecha, @cliente, @doc)", Conn);
                    comando.Parameters.AddWithValue("@producto", producto.Id);
                    comando.Parameters.AddWithValue("@cant", detalle.Cant);

                    comando.Parameters.AddWithValue("@existencia_ant", producto.Existencias);
                    comando.Parameters.AddWithValue("@costo", producto.Costo);
                    comando.Parameters.AddWithValue("@costo_ant", producto.Costo);
                    comando.Parameters.AddWithValue("@fecha", doc.Fecha);
                    comando.Parameters.AddWithValue("@cliente", cliente.Nombre);
                    comando.Parameters.AddWithValue("@doc", $"{doc.Tipo_documento} # {doc.Numero}");
                    comando.ExecuteNonQuery();



                    //detalle del documento

                    comando = new MySqlCommand($"INSERT INTO `detalle_documento`(`documento`, `producto`, `cant`, `precio`) VALUES (@documento, @producto, @cant, @precio)", Conn);
                    comando.Parameters.AddWithValue("@documento", doc._Id);
                    comando.Parameters.AddWithValue("@producto", producto.Id);
                    comando.Parameters.AddWithValue("@cant", detalle.Cant);
                    comando.Parameters.AddWithValue("@precio", detalle.Precio);
                    comando.ExecuteNonQuery();

                    if (doc.Caso == "afectas")
                    {
                        subtotalAfectas += Decimal.Round(detalle.Cant * detalle.Precio, 2);
                    }
                    else
                    {
                        subtotalExentas += Decimal.Round(detalle.Cant * detalle.Precio, 2);
                    }

                    //Actualizar el correlativo y serie de documentos
                    comando = new MySqlCommand($"UPDATE `documento_serie` SET `inicia_desde`= (`inicia_desde` + 1) WHERE `id` = @id", Conn);
                    comando.Parameters.AddWithValue("@id", doc.Serie);

                    comando.ExecuteNonQuery();
                }

                comando = new MySqlCommand($"UPDATE `documento` SET `afectas` = @afectas, `exentas` = @exentas, `iva`= @iva, `retencion` = @retencion, `percepcion` = @percepcion where Id = @id ", Conn);

                comando.Parameters.AddWithValue("@afectas", subtotalAfectas);
                comando.Parameters.AddWithValue("@exentas", subtotalExentas);
                decimal hayIVa = Decimal.Round(subtotalAfectas * Config.iva, 2);

                comando.Parameters.AddWithValue("@iva", Decimal.Round(subtotalAfectas * Config.iva, 2));

                decimal haypercepcion = 0.00m, hayretencion = 0.00m;

                //verificar si aplica retencion o retencion

                //MOnto mayor o igual a 100 dolares segun codigo tributario y si mi empresa es gran contribuyente esta designado a ser agente de retencion
                //Verificar tambien que el cliente no sea gran contribuyente y que el tipo sea ccf, si vendo con factura consumidor final no puedo percibir
                if (subtotalAfectas >= 100.00m && Config.clasificacion == "Gran Contribuyente" && cliente.Clasificacion != "gran" && doc.Tipo_documento == "ccf")
                {
                    haypercepcion = Decimal.Round(subtotalAfectas * Config.percepcion, 2);

                    comando.Parameters.AddWithValue("@retencion", 0.00m);
                    comando.Parameters.AddWithValue("@percepcion", haypercepcion);
                }
                //verificar si a quien le vendemos es agente de retencion, verificar que las ventas afectas sean mayor a 100, nuestra clasificaion sea granContri
                // y que le tipo de documento no sea factura de ex.
                else if (retencion && subtotalAfectas >= 100.00m && Config.clasificacion != "Gran Contribuyente" && doc.Tipo_documento != "fex")
                {
                    hayretencion = Decimal.Round(subtotalAfectas * Config.retencion, 2);

                    comando.Parameters.AddWithValue("@retencion", hayretencion);
                    comando.Parameters.AddWithValue("@percepcion", 0.00m);
                }
                // si no es ninguna enonces la retencion y percepcion quedan en 0
                else
                {
                    comando.Parameters.AddWithValue("@retencion", 0.00m);
                    comando.Parameters.AddWithValue("@percepcion", 0.00m);
                }


                comando.Parameters.AddWithValue("@id", doc._Id);
                comando.ExecuteNonQuery();

                //codigo del bloque superior

                if (subtotalAfectas >= 100.00m && Config.clasificacion == "Gran Contribuyente" && cliente.Clasificacion != "gran" && doc.Tipo_documento == "ccf")
                {
                    haypercepcion = Decimal.Round(subtotalAfectas * Config.percepcion,2);
                }
                else if (retencion && subtotalAfectas >= 100.00m && Config.clasificacion != "Gran Contribuyente" && doc.Tipo_documento!="fex")
                {
                    hayretencion = Decimal.Round(subtotalAfectas * Config.retencion, 2);
                }
                else
                {
                    //nada
                }



                //guardar partida
                //verificar que tipo de partida es la que deseo
                //crear nueva partida
                var partida = new Partida();
                partida.Fecha = DateTime.Today;
                partida.Description = $"Venta a {cliente.Nombre} con { doc.Tipo_documento} #{doc.Numero}";
                partida.Debe = 0.00m;
                partida.Haber = 0.00m;
                partida.Venta_relacionada = doc._Id;
                CD_Conta contaDatos = new CD_Conta();

                //crear lista de detalles
                List<DetallePartida> detallePartida = new List<DetallePartida>();

                if (hayIVa > 0)
                {
                    //Codigo de la partida si hay percepción
                    if (haypercepcion > 0)
                    {
                        //DetallePartida(idCuenta, debe, haber)
                        detallePartida.Add(new DetallePartida(doc.Condiciones > 0 ? 2 :31, (subtotalAfectas+ subtotalExentas) + hayIVa + haypercepcion, 0));
                        detallePartida.Add(new DetallePartida(28, 0, hayIVa + haypercepcion));
                        detallePartida.Add(new DetallePartida(39, 0, (subtotalAfectas + subtotalExentas)));

                        //Efectivo y equivalente      $$ valor neto + IVA + percepcion
                        //Impuesto por pagar          $$ IVA 13% + 1% de la percepcion
                        //Ingresos por venta          $$ valor neto de la venta

                        partida.Debe = (subtotalAfectas + subtotalExentas) + hayIVa + haypercepcion;
                        partida.Haber = (subtotalAfectas + subtotalExentas) + hayIVa + haypercepcion; 

                    }
                    //codigo de la partida si hay retencion
                    else if (hayretencion > 0)
                    {
                        //DetallePartida(idCuenta, debe, haber)
                        detallePartida.Add(new DetallePartida(doc.Condiciones > 0 ? 2 : 31, (subtotalAfectas + subtotalExentas) + hayIVa - hayretencion, 0));
                        detallePartida.Add(new DetallePartida(7, hayretencion,0));
                        detallePartida.Add(new DetallePartida(28, 0, hayIVa));
                        detallePartida.Add(new DetallePartida(39, 0, (subtotalAfectas + subtotalExentas)));

                        //Efectivo y equivalente      $$ valor neto + IVA - percepcion
                        //Impuesto por cobrar         $$ retencion del 1% 
                        //    Impuesto por pagar      $$ IVA 13%
                        //    Ingresos por Venta      $$ Valor neto de la venta

                        partida.Debe = (subtotalAfectas + subtotalExentas) + hayIVa - hayretencion;
                        partida.Haber = (subtotalAfectas + subtotalExentas) + hayIVa - hayretencion;


                    }
                    //codigo de la partida si no hay ninguna de las dos
                    else
                    {

                        //DetallePartida(idCuenta, debe, haber)
                        detallePartida.Add(new DetallePartida(doc.Condiciones > 0 ? 2 : 31, (subtotalAfectas + subtotalExentas) + hayIVa, 0));
                        detallePartida.Add(new DetallePartida(28, 0, hayIVa));
                        detallePartida.Add(new DetallePartida(39, 0, (subtotalAfectas + subtotalExentas)));

                        //Efectivo y equivalente      $$ valor neto + IVA 
                        //    Impuesto por pagar      $$ IVA 13%
                        //    Ingresos por Venta      $$ Valor neto de la venta

                        partida.Debe = (subtotalAfectas + subtotalExentas) + hayIVa;
                        partida.Haber = (subtotalAfectas + subtotalExentas) + hayIVa;

                    }

                }
                else
                {
                    //id de cuenta, debe, haber
                    detallePartida.Add(new DetallePartida(
                        // id 2: cuentas por cobrar, id 31: Efectivo y equivalente
                        doc.Condiciones > 0 ? 2 : 31,     //id cuenta  
                        subtotalExentas + subtotalAfectas, //debe 
                        0    // haber
                        ));

                    detallePartida.Add(new DetallePartida(
                        // id 39: ingresos por ventas
                        39,    //id cuenta       
                        0,      //debe 
                        subtotalExentas + subtotalAfectas // haber

                        ));

                }
                int insertado = contaDatos.GuardarPartida(partida, detallePartida);

                //crear partida de costo de ventas
                partida = new Partida();
                partida.Fecha = DateTime.Today;
                partida.Description = $"Costo de la venta a {cliente.Nombre} con { doc.Tipo_documento} #{doc.Numero}";
                partida.Debe = costodVenta;
                partida.Haber = costodVenta;
                partida.Venta_relacionada = doc._Id;

                detallePartida = new List<DetallePartida>();


                detallePartida.Add(new DetallePartida(
                      // id 36: costo de ventas
                      36,             //id cuenta
                      costodVenta,    //debe
                      0               // haber
                      ));

                detallePartida.Add(new DetallePartida(
                      // id 8: inventario
                      8, //id cuenta
                      0, //debe
                      costodVenta  // haber
                      ));

                insertado = contaDatos.GuardarPartida(partida, detallePartida);
                //fin de guardar partida


                //si falla alguna cosa, se revierte la transacción
                transaction.Commit();
                return doc._Id;
            }
            catch (MySqlException e)
            {
                try
                {
                    transaction.Rollback();
                    //devulevo el error y se revierte la transaccion
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

            //22:48
        }

        public Documento find(int id)
        {
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from `documento` where Id = {id}", Conn);
            try
            {
                Conn.Open();
                reader = comando.ExecuteReader();
                //if (reader.HasRows)
                //{
                    reader.Read();
                    return new Documento(
                        reader.GetInt32("Id"),
                        reader.GetInt32("numero"),
                        reader.GetInt32("serie"),
                        reader.GetInt32("cliente"),
                        reader.GetDateTime("fecha"),
                        reader.IsDBNull(5) ? 0 : reader.GetInt32("documento_anterior"),
                        reader.IsDBNull(6) ? "" : reader.GetString("anulada_por"),
                        reader.IsDBNull(7) ? "" : reader.GetString("anulada_en"),
                        reader.IsDBNull(8) ? "" : reader.GetString("motivo_anulacion"),
                        reader.GetDecimal("afectas"),
                        reader.GetDecimal("exentas"),
                        reader.GetDecimal("iva"),
                        reader.GetDecimal("retencion"),
                        reader.GetDecimal("percepcion"),
                        reader.GetInt32("condiciones"),
                        reader.GetString("datos_cliente"),
                        reader.IsDBNull(16) ? 0 : reader.GetInt32("nota_remision"),
                        reader.GetString("creacion"),
                        reader.GetString("creado_por"),
                        reader.IsDBNull(19) ? "" : reader.GetString("caso"),
                        reader.GetString("tipo_documento")
                    );
              //  }
              //  return null;
              
            }
            catch (MySqlException err)
            {
                Mensaje.ErrorMessage = err.Message;
                return null;
            }
            finally { Conn.Close(); }
            
        }


        public List<DetalleDocumento> Buscar_detalles(int id)
        {
 
            List<DetalleDocumento> products = new List<DetalleDocumento>();
                string sql = "";
                    sql = $"select * from `detalle_documento` where `documento` = {id}";
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(sql, Conn);
                try
                {
                    Conn.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(
                            new DetalleDocumento(
                                reader.GetInt32("Id"),
                                reader.GetInt32("documento"),
                                reader.GetInt32("producto"),
                                reader.GetInt32("cant"),
                                reader.GetDecimal("precio")
                            )
                         );
                    }
                }
                catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; }
                finally { Conn.Close(); }
            
            return products;
        }


        public List<Compra> busca_compras(DateTime desde, DateTime hasta)
        {
            List<Compra> docs = new List<Compra>();
            MySqlCommand comando = new MySqlCommand($"select * from `compra` where fecha between @desde and @hasta order by Id", Conn);
            try
            {
                Conn.Open();
                comando.Parameters.Add("@desde", MySqlDbType.DateTime).Value = desde;
                comando.Parameters.Add("@hasta", MySqlDbType.DateTime).Value = hasta;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    docs.Add(
                            new Compra(
                        reader.GetInt32("Id"),
                        reader.GetDecimal("afectas"),
                        reader.GetDecimal("iva"),
                        reader.GetDecimal("retencion"),
                        reader.GetInt32("proveedor"),
                        reader.GetString("registrado_por"),
                        reader.GetInt32("condiciones"),
                        reader.GetString("document_type"),
                        reader.GetString("document_number"),
                        reader.GetDateTime("fecha")
                        ));
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = "Error" + e.ErrorCode + " " + e.Message;
                return null;
            }
            finally
            {
                Conn.Close();
            }
            return docs;
        }




        public List<Documento> busca_facturas(DateTime desde, DateTime hasta)
        {
            List<Documento> docs = new List<Documento>();
            MySqlCommand comando = new MySqlCommand($"select * from {table_name} where tipo_documento <> @tipo and fecha between @desde and @hasta order by numero", Conn);
            try
            {
                Conn.Open();
                comando.Parameters.Add("@tipo", MySqlDbType.String).Value = "ccf";
                comando.Parameters.Add("@desde", MySqlDbType.DateTime).Value = desde;
                comando.Parameters.Add("@hasta", MySqlDbType.DateTime).Value = hasta;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    docs.Add(
                            new Documento(
                        reader.GetInt32("Id"),
                        reader.GetInt32("numero"),
                        reader.GetInt32("serie"),
                        reader.GetInt32("cliente"),
                        reader.GetDateTime("fecha"),
                        reader.IsDBNull(5) ? 0 : reader.GetInt32("documento_anterior"),
                        reader.IsDBNull(6) ? "" : reader.GetString("anulada_por"),
                        reader.IsDBNull(7) ? "" : reader.GetString("anulada_en"),
                        reader.IsDBNull(8) ? "" : reader.GetString("motivo_anulacion"),
                        reader.GetDecimal("afectas"),
                        reader.GetDecimal("exentas"),
                        reader.GetDecimal("iva"),
                        reader.GetDecimal("retencion"),
                        reader.GetDecimal("percepcion"),
                        reader.GetInt32("condiciones"),
                        reader.GetString("datos_cliente"),
                        reader.IsDBNull(16) ? 0 : reader.GetInt32("nota_remision"),
                        reader.GetString("creacion"),
                        reader.GetString("creado_por"),
                        reader.IsDBNull(19) ? "" : reader.GetString("caso"),
                        reader.GetString("tipo_documento")
                        ));
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = "Error" + e.ErrorCode + " " + e.Message;
                return null;
            }
            finally
            {
                Conn.Close();
            }
            return docs;
        }



        public List<Documento> busca_ccf(DateTime desde, DateTime hasta)
        {
            List<Documento> docs = new List<Documento>();
            MySqlCommand comando = new MySqlCommand($"select * from {table_name} where tipo_documento = @tipo and fecha between @desde and @hasta order by numero", Conn);
            try
            {
                Conn.Open();
                comando.Parameters.Add("@tipo", MySqlDbType.String).Value = "ccf";
                comando.Parameters.Add("@desde", MySqlDbType.DateTime).Value = desde;
                comando.Parameters.Add("@hasta", MySqlDbType.DateTime).Value = hasta;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    docs.Add(
                            new Documento(
                        reader.GetInt32("Id"),
                        reader.GetInt32("numero"),
                        reader.GetInt32("serie"),
                        reader.GetInt32("cliente"),
                        reader.GetDateTime("fecha"),
                        reader.IsDBNull(5) ? 0 : reader.GetInt32("documento_anterior"),
                        reader.IsDBNull(6) ? "" : reader.GetString("anulada_por"),
                        reader.IsDBNull(7) ? "" : reader.GetString("anulada_en"),
                        reader.IsDBNull(8) ? "" : reader.GetString("motivo_anulacion"),
                        reader.GetDecimal("afectas"),
                        reader.GetDecimal("exentas"),
                        reader.GetDecimal("iva"),
                        reader.GetDecimal("retencion"),
                        reader.GetDecimal("percepcion"),
                        reader.GetInt32("condiciones"),
                        reader.GetString("datos_cliente"),
                        reader.IsDBNull(16) ? 0 : reader.GetInt32("nota_remision"),
                        reader.GetString("creacion"),
                        reader.GetString("creado_por"),
                        reader.IsDBNull(19) ? "" : reader.GetString("caso"),
                        reader.GetString("tipo_documento")
                        ));
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = "Error" + e.ErrorCode + " " + e.Message;
                return null;
            }
            finally
            {
                Conn.Close();
            }
            return docs;
        }





    }
}
