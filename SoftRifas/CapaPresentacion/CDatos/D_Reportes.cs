using System;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class D_Reportes
    {
        private static SqlConnection con = Conexion.getConnection();
        public static void mostrar_formas_de_pago(ref DataSet ds, int rifaId, DateTime fIni, DateTime fFin)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_mostrar_reporte_formas_pago", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("fecha_ini", fIni);
                command.Parameters.AddWithValue("fecha_fin", fFin);
                command.Parameters.AddWithValue("rifa_id", rifaId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
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

    }
}
