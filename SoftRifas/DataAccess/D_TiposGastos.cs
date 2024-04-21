using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class D_TiposGastos
    {
        private static SqlConnection con = Conexion.getConnection();
        public static List<TiposGastos> mostrarTiposGastos()
        {
            List<TiposGastos> tiposGastos = new List<TiposGastos>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_tipos_gastos");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tiposGastos.Add(new TiposGastos()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Codigo = reader["codigo"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
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
            return tiposGastos;
        }
        public static bool crearTiposGastos(TiposGastos obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_tipos_gastos", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Parameters.AddWithValue("@codigo", obj.Codigo);
                command.Parameters.AddWithValue("@descripcion", obj.Descripcion);

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
                builder.Append("DELETE  FROM tbl_tipos_gastos WHERE id=@id");
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
