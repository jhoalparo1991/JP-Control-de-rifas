using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Clientes
    {

        private static SqlConnection con = Conexion.getConnection();
        public static List<Clientes> mostrarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_clientes order by nombre_completo");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new Clientes()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        NombreCompleto = reader["nombre_completo"].ToString(),
                        NroDoc = reader["nro_doc"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Celular = reader["celular"].ToString()
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
            return clientes;
        }
        public static bool guardar(Clientes obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_clientes", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", obj.Id);
                command.Parameters.AddWithValue("nombre_completo", obj.NombreCompleto);
                command.Parameters.AddWithValue("nro_doc", obj.NroDoc);
                command.Parameters.AddWithValue("direccion", obj.Direccion);
                command.Parameters.AddWithValue("celular", obj.Celular);
                command.Parameters.AddWithValue("telefono", obj.Telefono);

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
                builder.Append("DELETE  FROM tbl_clientes WHERE id=@id");
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

        public static DataTable mostrarBoletasClientes(int clienteId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                StringBuilder b = new StringBuilder();
                b.AppendLine("select cliente_id,nro_boleta from tbl_abonos_boleta");
                b.AppendLine(" where cliente_id=@cliente_id");
                b.AppendLine(" group by nro_boleta,cliente_id");
                b.AppendLine(" order by nro_boleta");
                SqlDataAdapter command = new SqlDataAdapter(b.ToString(), con);
                command.SelectCommand.CommandType = CommandType.Text;
                command.SelectCommand.Parameters.AddWithValue("@cliente_id", clienteId);
                command.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
