using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Logs
    {

        private static SqlConnection con = Conexion.getConnection();
        public static void mostrarLog(DataTable dt, string buscar)
        {

            try
            {
                con.Open();
               
                SqlDataAdapter data = new SqlDataAdapter("sp_mostrar_log", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("buscar", buscar);
                data.Fill(dt);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static bool guardarLog(int usuarioId, string accion)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_log", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("usuario_id", usuarioId);
                command.Parameters.AddWithValue("terminal", Environment.MachineName.ToString().Trim());
                command.Parameters.AddWithValue("accion", accion);

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
