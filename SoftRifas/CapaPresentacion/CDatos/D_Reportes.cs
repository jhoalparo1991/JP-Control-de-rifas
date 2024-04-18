using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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

        public static void mostrarAbonosFecha(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select sum(valor_abono) total_abonos from tbl_abonos_boleta where fecha_abono  between @fecha_ini and @fecha_fin");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.Parameters.AddWithValue("fecha_fin", fechafin);

                total = Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                total = 0;
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void mostrarComisionesPagadaFecha(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select sum(valor_pagado) total_comisiones_pagadas ");
                builder.Append("from tbl_pagos_abono_detalle ");
                builder.Append("where fecha_pago between @fecha_ini and @fecha_fin");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.Parameters.AddWithValue("fecha_fin", fechafin);

                total = Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                total = 0;
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void mostrarComisionesDeldia(ref decimal total, DateTime fechaIni, DateTime fechafin)
        {
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select sum(valor_comision) total_comision from tbl_abonos_boleta  ");
                builder.Append("where fecha_abono  between @fecha_ini and @fecha_fin");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.Parameters.AddWithValue("fecha_fin", fechafin);

                total = Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                total = 0;
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable mostrarAbonosPorFormasPago(DateTime fechaIni, DateTime fechafin)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select forma_pago, sum(valor_abono) valor from tbl_abonos_boleta ");
                builder.Append("where fecha_abono  between @fecha_ini and @fecha_fin ");
                builder.Append("group by forma_pago");
                SqlDataAdapter command = new SqlDataAdapter(builder.ToString(), con);
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechafin);
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
