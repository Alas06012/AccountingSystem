using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;


namespace CapaDatos {
    public class CD_Clientes:Conexion {

        private String table_name = "cliente";

        public Cliente Crear(Cliente client) {
            String yaExiste = existe("cliente", "nombre", client.Nombre, null);
            if (yaExiste.Length > 0) {
                Mensaje.ErrorMessage =  yaExiste.Equals("Existe")
                    ? $"el cliente con nombre '{client.Nombre}' ya esta registrado"
                    : $"Error Inesperado: {yaExiste}";
                return null;
            } 
            
            if (client.Nit.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("cliente", "nit", client.Nit, null);
                if (yaExiste.Length > 0) {
                    Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                        ? $"Ya hay un Cliente registrado con este numero de NIT"
                        : $"Error Inesperado: {yaExiste}";
                    return null;
                }
            } 
            
            if (client.Nrc.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("cliente", "nrc", client.Nrc, null);
                if (yaExiste.Length > 0) {
                    Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                        ? $"Ya hay un Cliente registrado con este numero de Registro"
                        : $"Error Inesperado: {yaExiste}";
                    return null;
                }
            }
            try {
                var comando = new MySqlCommand(
                    $"INSERT INTO `cliente`(`nombre`, `clasificacion`, `direccion`, " +
                    $"`nit`, `nrc`, `razon_social`, `giro`, `telefono`) " +
                    $"VALUES (@nombre,@clasificacion,@direccion,@nit,@registro,@razon,@giro,@telefono)", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@nombre", client.Nombre);
                comando.Parameters.AddWithValue("@clasificacion", client.Clasificacion);
                comando.Parameters.AddWithValue("@direccion", client.Direccion);
                comando.Parameters.AddWithValue("@nit", client.Nit);
                comando.Parameters.AddWithValue("@registro", client.Nrc);
                comando.Parameters.AddWithValue("@razon", client.Razon_social);
                comando.Parameters.AddWithValue("@giro", client.Giro);
                comando.Parameters.AddWithValue("@telefono", client.Telefono);
                comando.ExecuteNonQuery();
                client._Id = Convert.ToInt32(comando.LastInsertedId);
                return client._Id > 0 ? client : null;
            } catch (MySqlException err) {
                Mensaje.ErrorMessage =  err.Message; 
            } finally { 
                Conn.Close(); 
            }
            return null;
        }

        public String Actualizar(Cliente client) {
            String yaExiste = existe("cliente", "nombre", client.Nombre, client._Id);
            if (yaExiste.Length > 0) {
                return yaExiste.Equals("Existe")
                    ? $"el cliente con nombre '{client.Nombre}' ya esta registrado como un cliente diferente a este"
                    : $"Error Inesperado: {yaExiste}";
            }

            if (client.Nit.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("cliente", "nit", client.Nit, client._Id);
                if (yaExiste.Length > 0) {
                    return yaExiste.Equals("Existe")
                        ? $"Ya hay un Cliente diferente a este, registrado con este numero de NIT"
                        : $"Error Inesperado: {yaExiste}";
                }
            }

            if (client.Nrc.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("cliente", "nrc", client.Nrc, client._Id);
                if (yaExiste.Length > 0) {
                    return yaExiste.Equals("Existe")
                        ? $"Ya hay un Cliente diferente a este, registrado con este numero de Registro"
                        : $"Error Inesperado: {yaExiste}";
                }
            }
            try {
                var comando = new MySqlCommand(
                    $"UPDATE `cliente` SET `nombre` = @nombre, `clasificacion` = @clasificacion, `direccion` = @direccion, " +
                    $"`nit` = @nit, `nrc` = @registro, `razon_social` = @razon, `giro` = @giro, `telefono` = @telefono WHERE id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@nombre", client.Nombre);
                comando.Parameters.AddWithValue("@clasificacion", client.Clasificacion);
                comando.Parameters.AddWithValue("@direccion", client.Direccion);
                comando.Parameters.AddWithValue("@nit", client.Nit);
                comando.Parameters.AddWithValue("@registro", client.Nrc);
                comando.Parameters.AddWithValue("@razon", client.Razon_social);
                comando.Parameters.AddWithValue("@giro", client.Giro);
                comando.Parameters.AddWithValue("@telefono", client.Telefono);
                comando.Parameters.AddWithValue("@id", client._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) {
                return err.Message;
            } finally {
                Conn.Close();
            }
            return "";
        }

        public String delete(Cliente client) {
            try {
                var comando = new MySqlCommand($"delete from `cliente`  where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", client._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
            return "";
        }


        public String ActualizarNIT(int id, string nit, string nrc)
        {
            try
            {
                var comando = new MySqlCommand(
                     $"UPDATE `cliente` SET `nit` = @nit, `nrc` = @registro WHERE id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nit", nit);
                comando.Parameters.AddWithValue("@registro", nrc);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException err) { return err.Message; }
            finally { Conn.Close(); }
            return "";
        }


        public List<Cliente> todos() {
            List<Cliente> clients = new List<Cliente>();
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from `cliente`", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read()) {
                    clients.Add(
                        new Cliente(
                            reader.GetInt32("Id"),
                            reader.GetString("nombre"),
                            reader.GetString("clasificacion"),
                            reader.GetString("direccion"),
                            reader.GetString("nit"),
                            reader.GetString("nrc"),
                            reader.GetString("razon_social"),
                            reader.GetString("giro"),
                            reader.GetString("telefono")
                        )
                     );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return clients;
        }

        public List<Cliente> Buscar(List<String> campos, String busqueda) {
            busqueda = busqueda.Trim();
            List<Cliente> clients = new List<Cliente>();
            if (campos.Count > 0 && !String.IsNullOrEmpty(busqueda)) {
                string sql = "";
                foreach (string campo in campos) {
                    sql = sql.Length == 0 ? $"select * from `cliente` where {campo} like '%{busqueda}%'" : $"{sql} or {campo} like '%{busqueda}%'";
                }
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(sql, Conn);
                try {
                    Conn.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read()) {
                        clients.Add(
                            new Cliente(
                                reader.GetInt32("Id"),
                                reader.GetString("nombre"),
                                reader.GetString("clasificacion"),
                                reader.GetString("direccion"),
                                reader.GetString("nit"),
                                reader.GetString("nrc"),
                                reader.GetString("razon_social"),
                                reader.GetString("giro"),
                                reader.GetString("telefono")
                            )
                         );
                    }
                } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            }
            return clients;
        }

        public Cliente find(int id) {
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from `cliente` where id = {id}", Conn);
            try 
            {
                Conn.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                   return new Cliente(
                        reader.GetInt32("Id"),
                        reader.GetString("nombre"),
                        reader.GetString("clasificacion"),
                        reader.GetString("direccion"),
                        reader.GetString("nit"),
                        reader.GetString("nrc"),
                        reader.GetString("razon_social"),
                        reader.GetString("giro"),
                        reader.GetString("telefono")
                    );
                }
                return null;
            } catch (MySqlException err) 
            { 
                Mensaje.ErrorMessage = err.Message;
                return null;
            } finally {
                Conn.Close();
            }
            
        }

        public Cliente BuscarUno(String campo, string parameter) {
            String sql = $"select * from {table_name} where {campo} = @campo";
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            try {
                Conn.Open();
                comando.Parameters.AddWithValue("@campo", parameter);
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    new Cliente(
                        reader.GetInt32("Id"),
                        reader.GetString("nombre"),
                        reader.GetString("clasificacion"),
                        reader.GetString("direccion"),
                        reader.GetString("nit"),
                        reader.GetString("nrc"),
                        reader.GetString("razon_social"),
                        reader.GetString("giro"),
                        reader.GetString("telefono")
                    );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return null;
        }
    }
}
