using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;

namespace CapaDatos {
    public class CD_Productos:Conexion {

        //String table_name = "producto";

        public Producto Crear(Producto product) {
            String yaExiste = existe("producto", "nombre", product.Nombre, null);
            if (yaExiste.Length > 0) {
                 Mensaje.ErrorMessage =  yaExiste.Equals("Existe")
                    ? $"el Producto con nombre '{product.Nombre}' ya esta registrado"
                    : $"Error Inesperado: {yaExiste}";
                return null;
            }

            if (product.Codigo.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("producto", "codigo", product.Codigo, null);
                if (yaExiste.Length > 0) {
                    Mensaje.ErrorMessage = yaExiste.Equals("Existe")
                        ? $"Ya hay un Producto registrado con este Codigo"
                        : $"Error Inesperado: {yaExiste}";
                    return null;
                }
            } 
            
            try {
                var comando = new MySqlCommand(
                    $"INSERT INTO `producto` (`nombre`, `existencias`, `precio`, `costo`, `descripcion`,`codigo`) VALUES (@nombre, @existencias, @precio, @costo, @descripcion, @codigo)", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@nombre", product.Nombre);
                comando.Parameters.AddWithValue("@existencias", 0); 
                comando.Parameters.AddWithValue("@precio", product.Precio); 
                comando.Parameters.AddWithValue("@costo", "0.00"); 
                comando.Parameters.AddWithValue("@descripcion", product.Descripcion);
                comando.Parameters.AddWithValue("@codigo", product.Codigo);
                comando.ExecuteNonQuery();
                var lastInserted = Convert.ToInt32(comando.LastInsertedId);
                product.Id = lastInserted; 
                product.Existencias = 0;
                product.Costo = 0.00m;
                return product;
            } catch (MySqlException err) {
                Mensaje.ErrorMessage = err.Message;
                return null;
            } finally { 
                Conn.Close(); 
            }
        }

        public string Actualizar(Producto product) {
            String yaExiste = existe("producto", "nombre", product.Nombre, product.Id);
            if (yaExiste.Length > 0) {
                return yaExiste.Equals("Existe")
                   ? $"otro Producto con nombre '{product.Nombre}' ya esta registrado"
                   : $"Error Inesperado: {yaExiste}";
            }

            if (product.Codigo.Length > 0) {
                //Verificar que el nit es unico
                yaExiste = existe("producto", "codigo", product.Codigo, product.Id);
                if (yaExiste.Length > 0) {
                    return yaExiste.Equals("Existe")
                        ? $"Ya otro un Producto registrado con este Codigo"
                        : $"Error Inesperado: {yaExiste}";
                }
            }

            try {
                var comando = new MySqlCommand(
                    $"UPDATE `producto` set `nombre` = @nombre, `precio` = @precio, `descripcion` = @descripcion,`codigo` = @codigo where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@nombre", product.Nombre);
                comando.Parameters.AddWithValue("@precio", product.Precio);
                comando.Parameters.AddWithValue("@descripcion", product.Descripcion);
                comando.Parameters.AddWithValue("@codigo", product.Codigo);
                comando.Parameters.AddWithValue("@id", product.Id);
                comando.ExecuteNonQuery();

                //return comando.ExecuteReader();
                return "";
            } catch (MySqlException err) {
                return err.Message;
            } finally {
                Conn.Close();
            }
        }

        public String delete(Producto product) {
            try {
                var comando = new MySqlCommand($"delete from `producto` where id = @id", Conn);
                Conn.Open();
                comando.Parameters.AddWithValue("@id", product.Id);
                comando.ExecuteNonQuery();
            } catch (MySqlException err) { return "\tError / Eliminar\n"+"No se puede eliminar un producto\nque esta siendo utilizado."; } finally { Conn.Close(); }
            return "";
        }

        public List<Producto> todos() {
            List<Producto> products = new List<Producto>();
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from `producto`", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read()) {
                    products.Add(
                        new Producto(
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetInt32("existencias"),
                            reader.GetDecimal("precio"),
                            reader.GetDecimal("costo"),
                            reader.GetString("descripcion"),
                            reader.GetString("img"),
                            reader.GetString("codigo")
                        )
                     );
                }
            } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; return null; } finally { Conn.Close(); }
            return products;
        }

        public List<Producto> Buscar(List<String> campos, String busqueda) {
            busqueda = busqueda.Trim();
            List<Producto> products = new List<Producto>();
            if (campos.Count > 0 && !String.IsNullOrEmpty(busqueda)) {
                string sql = "";
                foreach (string campo in campos) {
                    sql = sql.Length == 0 ? $"select * from `producto` where {campo} like '%{busqueda}%'" : $"{sql} or {campo} like '%{busqueda}%'";
                }
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(sql, Conn);
                try {
                    Conn.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read()) {
                        products.Add(
                            new Producto(
                                reader.GetInt32("id"),
                                reader.GetString("nombre"),
                                reader.GetInt32("existencias"),
                                reader.GetDecimal("precio"),
                                reader.GetDecimal("costo"),
                                reader.GetString("descripcion"),
                                reader.GetString("img"),
                                reader.GetString("codigo")
                            )
                         );
                    }
                } catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; } finally { Conn.Close(); }
            }
            return products;
        }

        public Producto find(int id) {
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from `producto` where `id` = {id}", Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    return new Producto(
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetInt32("existencias"),
                            reader.GetDecimal("precio"),
                            reader.GetDecimal("costo"),
                            reader.GetString("descripcion"),
                            reader.GetString("img"),
                            reader.GetString("codigo")
                        );
                }
                return null;
            } catch (MySqlException err) 
                { 
                Mensaje.ErrorMessage = err.Message;
                return null;

            } finally { Conn.Close(); }
           
        }

        public Producto BuscarUno(String campo, string parameter) {
            String sql = $"select * from `producto` where {campo} = @campo";
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            try {
                Conn.Open();
                comando.Parameters.AddWithValue("@campo", parameter);
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    reader.Read();
                    return new Producto(
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetInt32("existencias"),
                            reader.GetDecimal("precio"),
                            reader.GetDecimal("costo"),
                            reader.GetString("descripcion"),
                            reader.GetString("img"),
                            reader.GetString("codigo")
                        );
                }
                return null;
            } catch (MySqlException err) 
            { 
                Mensaje.ErrorMessage = err.Message;
                return null;

            } finally { Conn.Close(); }
            
        }


        public List<Movimiento> movimientos(int product_id, DateTime inicio, DateTime fin)
        {
            List<Movimiento> detalles = new List<Movimiento>();
            MySqlCommand comando = new MySqlCommand("select * from movimiento where producto = @id and fecha between @desde and @hasta",Conn);

            try
            {
                Conn.Open();
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = product_id;
                comando.Parameters.Add("@desde", MySqlDbType.DateTime).Value = inicio;
                comando.Parameters.Add("@hasta", MySqlDbType.DateTime).Value = fin;
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    detalles.Add(new Movimiento(
                        reader.GetInt32("id"),
                        reader.GetInt32("producto"),
                        reader.GetInt32("cant"),
                        reader.GetInt32("existencia_anterior"),
                        reader.GetDecimal("costo"),
                        reader.GetDecimal("costo_anterior"),
                        reader.GetInt32("tipo"),
                        reader.GetDateTime("fecha"),
                        reader.GetString("cliente"),
                        reader.GetString("doc")
                        ));
                }




            }
            catch (MySqlException e)
            {
                Mensaje.ErrorMessage = "Error" + e.ErrorCode + ": " + e.Message;
            }
            finally
            {
                Conn.Close();
            }
            return detalles;
        }



    }
}
