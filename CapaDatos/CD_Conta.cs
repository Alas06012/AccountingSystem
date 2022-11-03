using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using MySql.Data.MySqlClient;
using CapaEntidades.Utilities;
using System.Data;

namespace CapaDatos
{
    public  class CD_Conta : Conexion
    {

        public int RegistrarCuenta(CuentaCatalogo cuenta)
        {
            try
            {
                Conn.Open();
                var comando = new MySqlCommand($"select * from c_cuentas where codigo = {cuenta.Codigo}", Conn);
                var reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    Mensaje.ErrorMessage = "El codigo ingresado ya existe.";

                }
                else
                {
                    reader.Dispose();
                    comando = new MySqlCommand("insert into c_cuentas (rubro, Agrupacion, nombre, codigo, debe, haber, tipo_saldo, cuenta_padre, nivel) " +
                    "values (@rubro, @agrupacion, @nombre, @codigo, @debe, @haber, @tipo_saldo, @cuenta_padre, @nivel)", Conn);
                    comando.Parameters.Add("@rubro", MySqlDbType.String).Value = cuenta.Rubro;
                    comando.Parameters.Add("@agrupacion", MySqlDbType.String).Value = cuenta.Agrupacion;
                    comando.Parameters.Add("@nombre", MySqlDbType.String).Value = cuenta.Nombre;
                    comando.Parameters.Add("@codigo", MySqlDbType.String).Value = cuenta.Codigo;
                    comando.Parameters.Add("@debe", MySqlDbType.Decimal).Value = 0.00m;
                    comando.Parameters.Add("@haber", MySqlDbType.Decimal).Value = 0.00m;
                    comando.Parameters.Add("@tipo_saldo", MySqlDbType.String).Value = cuenta.Tipo_saldo;
                    comando.Parameters.Add("@cuenta_padre", MySqlDbType.Int32).Value = cuenta.Cuenta_padre;
                    comando.Parameters.Add("@nivel", MySqlDbType.Int32).Value = cuenta.Nivel;
                    comando.ExecuteNonQuery();

                    //retorna el id insertado  
                    return (int)comando.LastInsertedId;
                }

            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode}: {e.Message} ";
            }
            finally
            {
                Conn.Close();
            }

            return 0;

        }

        //selecciona todas las cuentas y las devuelve en una lista
        public List<CuentaCatalogo> Catalogo()
        {
            List<CuentaCatalogo> cuentas = new List<CuentaCatalogo>();
            try
            {
                var comando = new MySqlCommand("select * from `c_cuentas`", Conn);
                Conn.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cuentas.Add(new CuentaCatalogo(
                        reader.GetInt32("id"),
                        reader.GetString("rubro"),
                        reader.GetString("agrupacion"),
                        reader.GetString("nombre"),
                        reader.GetString("codigo"),
                        reader.GetDecimal("debe"),
                        reader.GetDecimal("haber"),
                        reader.GetString("tipo_saldo"),
                        reader.GetInt32("cuenta_padre"),
                        reader.GetInt32("nivel")
                        ));
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }

            finally
            {
                Conn.Close();
            }
            return cuentas;
        }

        //eliminar la cuenta por id, pero no se elimina si esta siendo ocupada

        public bool elimiar_cuenta(int id)
        {
            var comando = new MySqlCommand("select * from `c_detallepartida` where `cuentaId` = @id",Conn);
            try
            {
                Conn.Open();
                comando.Parameters.AddWithValue("@id", MySqlDbType.Int32).Value = id;
                var reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    Mensaje.ErrorMessage = "No se puede eliminar una cuenta con un historial de movimientos";
                }
                else
                {
                    reader.Dispose();
                    comando.CommandText = "delete from `c_cuentas` where `c_cuentas`.`Id` = @id2";
                    comando.Parameters.AddWithValue("@id2", MySqlDbType.Int32).Value = id;
                    return comando.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }
            finally
            {
                Conn.Close();
            }

            return false;
        }

        public int GuardarPartida(Partida partida, List<DetallePartida> cuerpo)
        {
            try
            {
                //guardar partida y obtener id
                Conn.Open();
                //Guardar registro de partida
                var comando = new MySqlCommand("insert into `c_partida` (`fecha`, `debe`, `haber`, `descripcion`, `compra_relacionada`, `venta_relacionada`) values (@fecha, @debe, @haber, @descripcion, @compra, @venta)", Conn);
                comando.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = partida.Fecha;
                comando.Parameters.Add("@debe", MySqlDbType.Decimal).Value = partida.Debe;
                comando.Parameters.Add("@haber", MySqlDbType.Decimal).Value = partida.Haber;
                comando.Parameters.Add("@descripcion", MySqlDbType.String).Value = partida.Description;
                comando.Parameters.Add("@compra", MySqlDbType.Int32).Value = partida.Compra_relacionada;
                comando.Parameters.Add("@venta", MySqlDbType.Int32).Value = partida.Venta_relacionada;
                comando.ExecuteNonQuery();

                var idPartida = (int)comando.LastInsertedId;

                //guarda los detalles de la partida
                //actualiza los saldos

                foreach (DetallePartida detalle in cuerpo )
                {
                    comando = new MySqlCommand("insert into `c_detallepartida` (`partidaId`, `cuentaId`, `debe`, `haber`, `saldo_anterior`) values (@id_partida, @id_cuenta, @debe, @haber, ( SELECT if(tipo_saldo = 'ACREEDOR', haber - debe, debe - haber) as saldo from c_cuentas where Id = @id_cuenta))", Conn);
                    comando.Parameters.Add("@id_partida", MySqlDbType.Int32).Value = idPartida;
                    comando.Parameters.Add("@id_cuenta", MySqlDbType.Int32).Value = detalle.CuentaId;
                    comando.Parameters.Add("@debe", MySqlDbType.Decimal).Value = detalle.Debe;
                    comando.Parameters.Add("@haber", MySqlDbType.Decimal).Value = detalle.Haber;
                    comando.ExecuteNonQuery();

                    comando = new MySqlCommand("update `c_cuentas` set `debe` = debe + @debe, `haber` = haber + @haber where id = @id_cuenta", Conn);
                    comando.Parameters.Add("@id_cuenta", MySqlDbType.Int32).Value = detalle.CuentaId;
                    comando.Parameters.Add("@debe", MySqlDbType.Decimal).Value = detalle.Debe;
                    comando.Parameters.Add("@haber", MySqlDbType.Decimal).Value = detalle.Haber;
                    comando.ExecuteNonQuery();

                }
                return idPartida;

            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }
            finally
            {
                Conn.Close();
            }
            return 0;
        }



        public DataTable buscarPartida(int? id_partida)
        {
            var table = new DataTable();

            string sql = "SELECT c_cuentas.codigo, c_cuentas.nombre, c_partida.fecha, c_partida.descripcion, c_partida.Id as numero, " +
                "c_detallepartida.debe, c_detallepartida.haber, c_detallepartida.cuentaId as id_cuenta" +
                " FROM c_partida INNER JOIN c_detallepartida on c_detallepartida.partidaId = c_partida.Id " +
                "INNER JOIN c_cuentas on c_detallepartida.cuentaId = c_cuentas.Id ";
            sql = sql + (id_partida.HasValue ? $" where c_partida.Id = {id_partida} ORDER BY c_partida.Id": " ORDER BY c_partida.Id");


            try
            {
                //agarro los datos del inner join y los meto en un datatable
                Conn.Open();
                var cmd = new MySqlCommand(sql, Conn);
                var adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(table);

            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }
            finally
            {
                Conn.Close();
            }








            return table;
        }


        public DataTable buscarDetalleMayor(int idCuenta)
        {
            var table = new DataTable();

            string sql = "SELECT c_cuentas.codigo, c_cuentas.nombre, c_partida.fecha, c_partida.descripcion, c_partida.Id as numero, " +
                "c_detallepartida.debe, c_detallepartida.haber, c_detallepartida.cuentaId as id_cuenta, c_detallepartida.saldo_anterior" +
                " FROM c_partida INNER JOIN c_detallepartida on c_partida.Id = c_detallepartida.partidaId " +
                $"INNER JOIN c_cuentas on c_cuentas.Id = c_detallepartida.cuentaId where c_cuentas.Id = {idCuenta} order by c_detallepartida.partidaId";
    
            try
            {
                //agarro los datos del inner join y los meto en un datatable
                Conn.Open();
                var cmd = new MySqlCommand(sql, Conn);
                var adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(table);

            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }
            finally
            {
                Conn.Close();
            }








            return table;
        }



        public CuentaCatalogo EncontrarCuenta(int idCuenta)
        {
            var comando = new MySqlCommand($"SELECT * FROM c_cuentas where Id = {idCuenta}", Conn);
            try
            {
                Conn.Open();
                var reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return new CuentaCatalogo(
                        reader.GetInt32("id"),
                        reader.GetString("rubro"),
                        reader.GetString("agrupacion"),
                        reader.GetString("nombre"),
                        reader.GetString("codigo"),
                        reader.GetDecimal("debe"),
                        reader.GetDecimal("haber"),
                        reader.GetString("tipo_saldo"),
                        reader.GetInt32("cuenta_padre"),
                        reader.GetInt32("nivel")
                        );
                }

            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }
            finally
            {
                Conn.Close();
            }
            return null;


        }

        public List<ISRrangos> rangos()
        {
            List<ISRrangos> rangos = new List<ISRrangos>();
            try
            {
                var comando = new MySqlCommand("select * from `isr`", Conn);
                Conn.Open();
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    rangos.Add(new ISRrangos(
                        reader.GetDecimal("de"),
                        reader.GetDecimal("hasta"),
                        reader.GetDecimal("exceso"),
                        reader.GetDecimal("cuota_fija"),
                        reader.GetInt32("id"),
                        reader.GetInt32("porcentaje")
                       
                        ));
                }
            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = $"Error {e.ErrorCode} : {e.Message}";
            }

            finally
            {
                Conn.Close();
            }
            return rangos;


        }

    }
}
