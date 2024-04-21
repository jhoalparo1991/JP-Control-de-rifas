using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Gastos
    {
        private static SqlConnection con = Conexion.getConnection();
        public static List<DtoMostarGastos> mostrarGastos()
        {
            List<DtoMostarGastos> gastos = new List<DtoMostarGastos>();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_mostrar_gastos", con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gastos.Add(new DtoMostarGastos()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        TipoGastoId = Convert.ToInt32(reader["tipo_gasto_id"].ToString()),
                        UsuarioId = Convert.ToInt32(reader["usuario_id"].ToString()),
                        Codigo = reader["codigo"].ToString(),
                        TipoGasto = reader["tipo_gasto"].ToString(),
                        Referencia = reader["referencia"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        Valor = Convert.ToDecimal(reader["valor"].ToString()),
                        Fecha = Convert.ToDateTime(reader["fecha"].ToString()),
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
            return gastos;
        }
        public static bool crearGastos(Gastos obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_gastos", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Parameters.AddWithValue("@tipo_gasto_id", obj.TipoGastoId);
                command.Parameters.AddWithValue("@usuario_id", obj.UsuarioId);
                command.Parameters.AddWithValue("@referencia", obj.Referencia);
                command.Parameters.AddWithValue("@descripcion", obj.Descripcion);
                command.Parameters.AddWithValue("@valor", obj.Valor);
                command.Parameters.AddWithValue("@fecha", obj.Fecha);

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
        public static bool borrar(int id)
        {
            bool result = false;
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("DELETE  FROM tbl_gastos WHERE id=@id");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("id", id);

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
