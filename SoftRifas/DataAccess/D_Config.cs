using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Config
    {
        private static SqlConnection con = Conexion.getConnection();

        public static List<Config> mostrarConfig()
        {
            List<Config> config = new List<Config>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_config");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    config.Add(new Config()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        RutaCopiaSeguridad = reader["ruta_copia_seguridad"].ToString(),
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return config;
        }
        public static bool crearConfig(Config obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_config", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Parameters.AddWithValue("@ruta_copia_seguridad", obj.RutaCopiaSeguridad);

                result = Convert.ToInt32(command.ExecuteNonQuery()) != 0 ? true : false;
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
