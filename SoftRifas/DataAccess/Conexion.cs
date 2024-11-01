﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace DataAccess
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
                List<string> properties = LeerArchivoconexionDB();
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
                if (properties != null && properties.Count > 0)
                {
                    b.DataSource = properties[0];
                    b.InitialCatalog = properties[1];
                    b.UserID = properties[2];
                    b.Password = properties[3];
                    b.IntegratedSecurity = Convert.ToBoolean(properties[4]);
                    con = new SqlConnection(b.ToString());
                }
                else
                {
                    con = null;
                }

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

                List<string> properties = LeerArchivoconexionDB();
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
                if (properties != null && properties.Count > 0)
                {
                    b.DataSource = properties[0];
                    b.InitialCatalog = properties[1];
                    b.UserID = properties[2];
                    b.Password = properties[3];
                    b.IntegratedSecurity = Convert.ToBoolean(properties[4]);
                    con = new SqlConnection(b.ToString());
                }
                else
                {
                    con = null;
                }
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

        public static bool crearBackup(string path)
        {

            bool result = true;
            string scriptSQL = $@"BACKUP DATABASE db_rifas TO  DISK = N'{path}' WITH NOFORMAT, NOINIT,  NAME = N'db_rifas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
            try
            {
                List<string> properties = LeerArchivoconexionDB();
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
                if (properties != null && properties.Count > 0)
                {
                    b.DataSource = properties[0];
                    b.InitialCatalog = properties[1];
                    b.UserID = properties[2];
                    b.Password = properties[3];
                    b.IntegratedSecurity = Convert.ToBoolean(properties[4]);
                    using (SqlConnection con = new SqlConnection(b.ConnectionString))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(scriptSQL, con);
                        command.ExecuteNonQuery();
                        con.Close();

                    };
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return result;
        }

    }
}
