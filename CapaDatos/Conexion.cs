using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CapaDatos {
    public class Conexion {
        MySqlDataReader reader;
        public MySqlConnection Conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public string existe(String table, String field, String busqueda, int? id) {
            String sql = (id.HasValue)
                ? $"select * from {table} where {field} = '{busqueda}' and id <> {id}"
                : $"select * from {table} where {field} = '{busqueda}'";
            reader = null;
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
                return reader.HasRows ? "Existe" : ""; 
            } catch (MySqlException err) {
                return err.Message;
            } finally {
                Conn.Close();
            }
        }


        public MySqlDataReader select(string consulta) {
            reader = null;
            MySqlCommand comando = new MySqlCommand(consulta, Conn);
            try {
                Conn.Open();
                reader = comando.ExecuteReader();
            } catch (MySqlException err) { 
                Console.WriteLine(err.Message);
            } finally {
                Conn.Close();
            }
            return reader;
        }
    }
}
