using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class Rifas
    {

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NroInicial { get; set; }
        public int NroFinal { get; set; }
        public bool Activa { get; set; }
        public decimal ValorRifa { get; set; }


        private static SqlConnection con = Conexion.getConnection();
        public static List<Rifas> mostrarRifas()
        {
            List<Rifas> rifas = new List<Rifas>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_rifas");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rifas.Add(new Rifas()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        UsuarioId = Convert.ToInt32(reader["usuario_id"]),
                        Descripcion = reader["descripcion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["fecha_inicio"].ToString()),
                        FechaFin = Convert.ToDateTime(reader["fecha_final"].ToString()),
                        NroInicial = Convert.ToInt32(reader["nro_inicial"]),
                        NroFinal = Convert.ToInt32(reader["nro_final"]),
                        Activa = Convert.ToBoolean(reader["activa"]),
                        ValorRifa = Convert.ToDecimal(reader["valor_rifa"]),
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
            return rifas;
        }
        public static bool crearRifas(Rifas obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_crear_rifa", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Parameters.AddWithValue("@usuario_id", obj.UsuarioId);
                command.Parameters.AddWithValue("@descripcion", obj.Descripcion);
                command.Parameters.AddWithValue("@fecha_inicio", obj.FechaInicio);
                command.Parameters.AddWithValue("@fecha_final", obj.FechaFin);
                command.Parameters.AddWithValue("@nro_inicial", obj.NroInicial);
                command.Parameters.AddWithValue("@nro_final", obj.NroFinal);
                command.Parameters.AddWithValue("@activa", obj.Activa);
                command.Parameters.AddWithValue("@valor_rifa", obj.ValorRifa);

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
                builder.Append("DELETE  FROM tbl_rifas WHERE id=@id");
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
