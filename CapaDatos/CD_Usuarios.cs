using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;

namespace CapaDatos {
    public class CD_Usuarios : Conexion {
        private String table_name = "usuario";

        public String Crear(Usuario user) {
            //Validar si un usuario ya existe, buscando por nombre de usuario
            String yaExiste = existe(table_name, "usuario", user._Usuario, null);
            if (yaExiste.Length > 0) {
                return yaExiste.Equals("Existe")
                    ? $"El nombre de usuario debe ser unico, y \"{user._Usuario}\" ya ha sido utilizado para otro registro"
                    : $"Error Inesperado: {yaExiste}";
            } else {
                try {
                    var comando = new MySqlCommand($"INSERT INTO {table_name}(`nombre`, `usuario`, `contra`, `intentos`, `estado`) VALUES (@nombre, @usuario, @contra, 5, 'activo')", Conn);
                    Conn.Open();
                    comando.Parameters.AddWithValue("@nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@usuario", user._Usuario);
                    comando.Parameters.AddWithValue("@contra", user.Contra);
                    comando.ExecuteNonQuery();
                } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
                return "";
            }
        }

        public String Actualizar(Usuario user) {
            //Validar si un usuario ya existe, buscando por nombre de usuario
            String yaExiste = existe(table_name, "usuario", user._Usuario, user._Id);
            if (yaExiste.Length > 0) {
                return yaExiste.Equals("Existe")
                    ? $"El nombre de usuario debe ser unico, y \"{user._Usuario}\" ya ha sido utilizado para otro registro"
                    : $"Error Inesperado: {yaExiste}";
            } else {
                try {
                    var comando = new MySqlCommand($"update {table_name} set `nombre` = @nombre, `usuario` = @usuario where id = @id", Conn);
                    Conn.Open();
                    comando.Parameters.AddWithValue("@nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@usuario", user._Usuario);
                    comando.Parameters.AddWithValue("@id", user._Id);
                    comando.ExecuteNonQuery();
                } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
                return "";
            }
        }

        public String Desactivar(Usuario user) {
            try {
                var comando = new MySqlCommand($"update {table_name} set `estado` = 'desactivado' where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", user._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
            return "";
        }

        public String Activar(Usuario user) {
            try {
                var comando = new MySqlCommand($"update {table_name} set `estado` = 'activo', intentos = 5 where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", user._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
            return "";
        }

        public string ReduceIntento(Usuario user) {
            int intentos = user.Intentos;
            try {
                string sql = 
                    intentos == 1 
                    ? $"update {table_name} set intentos = @intentos, estado ='bloqueado' where id = @id" 
                    : $"update {table_name} set intentos = @intentos where id = @id";
                var comando = new MySqlCommand(sql, Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@intentos", (user.Intentos - 1));
                comando.Parameters.AddWithValue("@id", user._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return err.Message; } finally { Conn.Close(); }
            return "";
        }

        public List<Usuario> todos() {
            List<Usuario> users = new List<Usuario>();
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from {table_name}", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read()) {
                    users.Add(
                        new Usuario(
                            reader.GetInt32("Id"),
                            reader.GetString("nombre"), 
                            reader.GetString("usuario"), 
                            reader.GetString("contra"), 
                            reader.GetInt32("intentos"),
                            reader.GetString("estado")
                        )
                     );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return users;
        }

        public List<Usuario> Buscar(List<String> campos, String busqueda) {
            busqueda = busqueda.Trim();
            List<Usuario> users = new List<Usuario>();
            if (campos.Count > 0 && !String.IsNullOrEmpty(busqueda)) {
                string sql = "";
                foreach (string campo in campos) {
                    sql = sql.Length == 0 ? $"select * from {table_name} where {campo} like '%{busqueda}%'" : $"{sql} or {campo} like '%{busqueda}%'";
                }
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(sql, Conn);
                try {
                    Conn.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read()) {
                        users.Add(
                            new Usuario(
                                reader.GetInt32("Id"),
                                reader.GetString("nombre"),
                                reader.GetString("usuario"),
                                reader.GetString("contra"),
                                reader.GetInt32("intentos"),
                                reader.GetString("estado")
                            )
                         );
                    }
                } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            }
            
            return users;
        }

        public Usuario find(int id) {
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from {table_name} where id = {id}", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                if(reader.HasRows) {
                    reader.Read();
                    return new Usuario(
                        reader.GetInt32("Id"),
                        reader.GetString("nombre"),
                        reader.GetString("usuario"),
                        reader.GetString("contra"),
                        reader.GetInt32("intentos"),
                        reader.GetString("estado")
                    );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return null;
        }

        public Usuario BuscarUno(String campo, string parameter) {
            String sql = $"select * from {table_name} where {campo} = @campo";
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            try {
                Conn.Open();
                comando.Parameters.AddWithValue("@campo", parameter);
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    return new Usuario(
                        reader.GetInt32("Id"),
                        reader.GetString("nombre"),
                        reader.GetString("usuario"),
                        reader.GetString("contra"),
                        reader.GetInt32("intentos"),
                        reader.GetString("estado")
                    );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return null;
        }



    }
}
