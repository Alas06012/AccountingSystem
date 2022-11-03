using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using CapaEntidades.Utilities;
using System.Data;

namespace CapaDatos
{
    public class CD_Series : Conexion
    {

        public String buscarSerie(int serie)
        {
            string Seriee = "";
            string query = $"select `serie` as letra from `documento_serie` where `id` = {serie}";
            MySqlCommand c = new MySqlCommand(query, Conn);
            try
            {
                Conn.Open();
                MySqlDataReader reader = c.ExecuteReader();
                if (reader.Read())
                {
                    Seriee = reader["letra"].ToString();

                }
                else
                {
                    return "Error al generar serie";
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                return Mensaje.ErrorMessage = e.Message;
            }
            finally
            {
                Conn.Close();
            }


            return Seriee;


        }


        public List<Serie> todos()
        {
            List<Serie> serie = new List<Serie>();
            MySqlDataReader reader = null;
            MySqlCommand comando = new MySqlCommand($"select * from documento_serie", Conn);
            try
            {
                Conn.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    serie.Add(
                        new Serie(
                            reader.GetInt32("Id"),
                            reader.GetInt32("inicia_desde"),
                            reader.GetInt32("termina_en"),
                            reader.GetString("serie"),
                            reader.GetString("tipo")
                        )
                     );
                }
            }
            catch (MySqlException err) { Mensaje.ErrorMessage = err.Message; }
            finally { Conn.Close(); }
            return serie;
        }


        public string Ingresar(int desde, int hasta, string serie, string tipo)
        {

            try
            {
                MySqlDataReader reader = null;
                Conn.Open();
                MySqlCommand comando = new MySqlCommand($"insert into documento_serie (inicia_desde, termina_en, serie, tipo) values (@desde,@hasta,@serie,@tipo)", Conn);
                comando.Parameters.AddWithValue("@desde", desde);
                comando.Parameters.AddWithValue("@hasta", hasta);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                Conn.Close();
                return "Se ingreso correctamente.";
            }
            catch (Exception)
            {

                return "No se pudo ingresar la serie.";
            }
            
            
        }












        public string dameSerie(string tipo)
        {
            string serie = "";
            string tipo1 = tipo.ToUpper();
  
            string query = "Select `serie` as serie from `documento_serie` where `tipo` = '"+ tipo1 +"'";
            MySqlCommand c = new MySqlCommand(query, Conn);
            try
            {
                Conn.Open();
                MySqlDataReader reader = c.ExecuteReader();
                if (reader.Read())
                {
                    serie = reader["serie"].ToString();

                }
                else
                {
                    return "Error al generar serie";
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                return Mensaje.ErrorMessage = e.Message;
            }
            finally
            {
                Conn.Close();
            }

          
            return serie;
        }


        public string dameCorrelativo(string tipo)
        {
            
            using (var conexion = Conn)
            {
                string correlativo = "";
                string tipo1 = tipo.ToUpper();
                Int64 currenID;
               
                using (var comando = new MySqlCommand())
                {
                    string query = $"Select `inicia_desde`+1 as correlativo from `documento_serie` where `tipo` = '"+tipo1+"'";
                    MySqlCommand c = new MySqlCommand(query,conexion);
                    try
                    {
                        conexion.Open();
                        MySqlDataReader reader = c.ExecuteReader();
                        if (reader.Read())
                        {
                            currenID = Convert.ToInt64(reader["correlativo"].ToString());
                        }
                        else
                        {
                            return "Error al generar correlativo";
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {

                        return Mensaje.ErrorMessage = e.Message;
                    }
                    finally
                    {
                        Conn.Close();
                    }
                    correlativo = currenID.ToString();

                    return correlativo;

                }
            }


        }
    }
  }

