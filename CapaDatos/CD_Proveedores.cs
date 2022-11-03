using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;

namespace CapaDatos {
    public class CD_Proveedores : Conexion {

        private String table_name = "proveedor";

        public Proveedor Crear(Proveedor prov) {
            String yaExiste = existe(table_name, "nombre", prov.Nombre, null);
            if (yaExiste.Length > 0) {
                Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                    ? $"el proveedor con nombre '{prov.Nombre}' ya esta registrado"
                    : $"Error Inesperado: {yaExiste}";
                return null;
            } 
            
            if (prov.Nit.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe(table_name, "nit", prov.Nit, null);
                if (yaExiste.Length > 0) {
                    Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                        ? $"Ya hay un Proveedor registrado con este numero de NIT"
                        : $"Error Inesperado: {yaExiste}";
                    return null;

                }
            } 
            
            if (prov.Nrc.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe(table_name, "nrc", prov.Nrc, null);
                if (yaExiste.Length > 0) {
                    Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                        ? $"Ya hay un Proveedor registrado con este numero de Registro"
                        : $"Error Inesperado: {yaExiste}";
                    return null;

                }
            }
            try {
                var comando = new MySqlCommand(
                    $"INSERT INTO `proveedor`(`tipo`, `clasificacion`, `nit`, `nrc`, `nombre`, `razon_social`, `direccion`, `telefono`) VALUES (@tipo, @clasificacion, @nit, @nrc, @nombre, @razon, @direccion, @telefono)", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@tipo", prov.Tipo);
                comando.Parameters.AddWithValue("@clasificacion", prov.Clasificacion);
                comando.Parameters.AddWithValue("@nit", prov.Nit);
                comando.Parameters.AddWithValue("@nrc", prov.Nrc);
                comando.Parameters.AddWithValue("@nombre", prov.Nombre);
                comando.Parameters.AddWithValue("@razon", prov.Razon_social);
                comando.Parameters.AddWithValue("@direccion", prov.Direccion);
                comando.Parameters.AddWithValue("@telefono", prov.Telefono);
                comando.ExecuteNonQuery();
                prov._Id = Convert.ToInt32(comando.LastInsertedId);
                return prov._Id > 0 ? prov : null;
            } catch (MySqlException err) {
                Mensaje.ErrorMessage = err.Message;
                return null;
            } finally { 
                Conn.Close(); 
            }
        }
       
        public String Actualizar(Proveedor prov) {
            String yaExiste = existe(table_name, "nombre", prov.Nombre, prov._Id);
            if (yaExiste.Length > 0) {
                return yaExiste.Equals("Existe")
                    ? $"el proveedor con nombre '{prov.Nombre}' ya esta registrado"
                    : $"Error Inesperado: {yaExiste}";
            }

            if (prov.Nit.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe(table_name, "nit", prov.Nit, prov._Id);
                if (yaExiste.Length > 0) {
                    return yaExiste.Equals("Existe")
                        ? $"Ya hay un Proveedor registrado con este numero de NIT"
                        : $"Error Inesperado: {yaExiste}";
                }
            }

            if (prov.Nrc.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe(table_name, "nrc", prov.Nrc, prov._Id);
                if (yaExiste.Length > 0) {
                    return yaExiste.Equals("Existe")
                        ? $"Ya hay un Proveedor registrado con este numero de Registro"
                        : $"Error Inesperado: {yaExiste}";
                }
            }
            try {
                var comando = new MySqlCommand(
                    $"Update `proveedor` set `tipo` = @tipo, `clasificacion` = @clasificacion, `nit` = @nit, `nrc` = @nrc, `nombre` = @nombre, `razon_social` = @razon, `direccion` = @direccion, `telefono` = @telefono where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@tipo", prov.Tipo);
                comando.Parameters.AddWithValue("@clasificacion", prov.Clasificacion);
                comando.Parameters.AddWithValue("@nit", prov.Nit);
                comando.Parameters.AddWithValue("@nrc", prov.Nrc);
                comando.Parameters.AddWithValue("@nombre", prov.Nombre);
                comando.Parameters.AddWithValue("@razon", prov.Razon_social);
                comando.Parameters.AddWithValue("@direccion", prov.Direccion);
                comando.Parameters.AddWithValue("@telefono", prov.Telefono);
                comando.Parameters.AddWithValue("@id", prov._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) {
                return err.Message;
            } finally {
                Conn.Close();
            }
            return "";
        }

        public String delete(Proveedor prov) {
            try {
                var comando = new MySqlCommand($"delete from {table_name}  where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", prov._Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return "\tError/Eliminar"+"No se puede eliminar un proveedor con un registro."; } finally { Conn.Close(); }
            return "";
        }

        public List<Proveedor> todos() {
            List<Proveedor> proveedores = new List<Proveedor>();
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from {table_name}", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read()) {
                    proveedores.Add(new Proveedor(
                            reader.GetInt32("Id"),
                            reader.GetString("tipo"),
                            reader.GetString("clasificacion"),
                            reader.GetString("nit"),
                            reader.GetString("nrc"),
                            reader.GetString("nombre"),
                            reader.GetString("razon_social"),
                            reader.GetString("direccion"),
                            reader.GetString("telefono")
                        ));
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return proveedores;
        }

        public List<Proveedor> Buscar(List<String> campos, String busqueda) {
            busqueda = busqueda.Trim();
            List<Proveedor> proveedores = new List<Proveedor>();
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
                        proveedores.Add(new Proveedor(
                            reader.GetInt32("Id"),
                            reader.GetString("tipo"),
                            reader.GetString("clasificacion"),
                            reader.GetString("nit"),
                            reader.GetString("nrc"),
                            reader.GetString("nombre"),
                            reader.GetString("razon_social"),
                            reader.GetString("direccion"),
                            reader.GetString("telefono")
                        ));
                    }
                } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            }
            return proveedores;
        }

        public Proveedor find(int id) {
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from {table_name} where id = {id}", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    return new Proveedor(
                        reader.GetInt32("Id"),
                        reader.GetString("tipo"),
                        reader.GetString("clasificacion"),
                        reader.GetString("nit"),
                        reader.GetString("nrc"),
                        reader.GetString("nombre"),
                        reader.GetString("razon_social"),
                        reader.GetString("direccion"),
                        reader.GetString("telefono")
                    );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return null;
        }

        public Proveedor BuscarUno(String campo, string parameter) {
            String sql = $"select * from {table_name} where {campo} = @campo";
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            try {
                Conn.Open();
                comando.Parameters.AddWithValue("@campo", parameter);
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    return new Proveedor(
                        reader.GetInt32("Id"),
                        reader.GetString("tiupo"),
                        reader.GetString("clasificacion"),
                        reader.GetString("nit"),
                        reader.GetString("nrc"),
                        reader.GetString("nombre"),
                        reader.GetString("razon_social"),
                        reader.GetString("direccion"),
                        reader.GetString("telefono")
                    );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            return null;
        }
    }
}
