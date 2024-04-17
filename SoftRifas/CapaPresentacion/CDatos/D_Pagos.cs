using CapaPresentacion.CEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class D_Pagos
    {
        private static SqlConnection con = Conexion.getConnection();
        public static bool registrarPagos(Pagos obj, DataTable detalle)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_registrar_pagos", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@usuario_id", obj.UsuarioId);
                command.Parameters.AddWithValue("@identificador", obj.Identificador);
                command.Parameters.AddWithValue("@fecha_pago", obj.FechaPago);
                command.Parameters.AddWithValue("@hora_pago", obj.HoraPago);
                command.Parameters.AddWithValue("@periodo_pagado", obj.PeriodoPagado);
                command.Parameters.AddWithValue("@valor_pagos", obj.ValorPagos);
                command.Parameters.AddWithValue("@descripcion", obj.Descripcion);
                command.Parameters.AddWithValue("@terminal", Environment.MachineName.Trim());
                command.Parameters.AddWithValue("@detalles", detalle);

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
