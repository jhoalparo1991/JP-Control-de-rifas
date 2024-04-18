using CEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace CDatos
{
    public class Conexion
    {
        private static string _DIRECTORIO = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SoftRifas");
        private static string _ARCHIVO_DB = Path.Combine(_DIRECTORIO, "connection_string.txt");

        private static List<string> LeerArchivoconexionDB()
        {

            List<string> listado = new List<string>();

            try
            {
                if (File.Exists(_ARCHIVO_DB))
                {
                    using (StreamReader reader = new StreamReader(_ARCHIVO_DB))
                    {
                        string lineas;
                        while ((lineas = reader.ReadLine()) != null)
                        {
                            listado.Add(lineas);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listado;
        }

        public static SqlConnection getConnection()
        {
            SqlConnection con = null;
            try
            {
                string conexion = ConfigurationManager.ConnectionStrings["db_rifasConnectionString"].ToString();

                con = new SqlConnection(conexion);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return con;
        }

        public static bool getConnectionTest()
        {
            bool result = false;

            SqlConnection con = new SqlConnection();
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["db_rifasConnectionString"].ToString();

                con = new SqlConnection(conn);
                con.Open();
                result = true;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

    }
}
