using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DA_Reports
    {
        private static SqlConnection con = Conexion.getConnection();
        public static DataTable ObtenerEstadosBoletas()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_boletas_por_estados", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        public static DataTable mostrarAbonos()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_todos_abonos", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        public static DataTable mostrarAbonosPorBoleta(string boleta)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_abonos_por_boleta", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("boleta", boleta);
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
        public static DataTable mostrarboletasVendidasPorVendedores()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_boletas_vendida_por_vendedores", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        public static DataTable mostrarReporteFormasPago(DateTime fechaIni, DateTime fechaFin, int rifaId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_reporte_formas_pago", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
                command.SelectCommand.Parameters.AddWithValue("rifa_id", rifaId);
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

        public static DataTable mostrarAbonosFechaValor(DateTime fechaIni, DateTime fechaFin, decimal valor)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_abonos_fecha_monto", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
                command.SelectCommand.Parameters.AddWithValue("valor", valor);
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

        public static DataTable mostrarPagos(DateTime fechaIni, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_pagos", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
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

        public static DataTable mostrarDetallePagoComisiones(DateTime fechaIni, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_detalle_pago_comisiones", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
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
        public static DataTable mostrarPagoComisionesPorVendedores(int vendedorId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_detalle_pago_comisiones_vendedores", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("vendedor_id", vendedorId);
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

        public static DataTable mostrarAbonosComisionesPorVendedores(DateTime fechaIni, DateTime fechaFin, int vendedorId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_abonos_comisiones_por_vendedores", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("fecha_ini", fechaIni);
                command.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
                command.SelectCommand.Parameters.AddWithValue("vendedor_id", vendedorId);
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

        public static DataTable mostrarReporteCaja(DateTime fecha)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_caja", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
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

        public static DataTable mostrarReporteFormasPagoCaja(DateTime fecha)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                StringBuilder b = new StringBuilder();
                b.AppendLine("select forma_pago, sum(valor_abono) valor");
                b.AppendLine(" from tbl_abonos_boleta where fecha_abono=@fecha");
                b.AppendLine("group by forma_pago");
                SqlDataAdapter command = new SqlDataAdapter(b.ToString(), con);
                command.SelectCommand.CommandType = CommandType.Text;
                command.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
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
