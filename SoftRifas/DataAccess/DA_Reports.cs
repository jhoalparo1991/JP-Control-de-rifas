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

        public static DataTable mostrarListadoComisionesPagadas(DateTime fechaIni, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("rpt_listado_comisiones_pagadas", con);
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
        public static DataTable mostrarPagoComisionesPorVendedoresIdDetallePago(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_reporte_detalle_pago_comisiones_vendedores_por_id", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("id", id);
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

        public static DataTable mostrarReporteCaja(string fecha, string fecha2)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_caja_por_dia", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@fecha1", fecha);
                command.SelectCommand.Parameters.AddWithValue("@fecha2", fecha2);
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

        public static DataTable mostrarAbonosPorFormaDePago(DateTime fecha1, DateTime fecha2, string formaPago)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_todos_abonos_por_formas_pago", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@forma_pago", formaPago);
                command.SelectCommand.Parameters.AddWithValue("@fecha1", fecha1);
                command.SelectCommand.Parameters.AddWithValue("@fecha2", fecha2);
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

        public static DataTable mostrarTotalComisionesPagadas()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_total_comisiones_pagada", con);
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

        public static DataTable mostrarTotalComisionesPorPagar()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_total_comisiones_por_pagada", con);
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


        public static DataTable sumarTotalGastos()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("select sum(valor) as gastos from tbl_gastos", con);
                command.SelectCommand.CommandType = CommandType.Text;
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

        public static DataTable sumarTotalAbonos()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("select sum(valor_abono) from tbl_abonos_boleta where valor_abono >0", con);
                command.SelectCommand.CommandType = CommandType.Text;
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


        public static DataTable abonosPorFormasDePago()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                StringBuilder d = new StringBuilder();
                d.AppendLine("select sum(valor_abono) abono,forma_pago ")
                    .AppendLine("from tbl_abonos_boleta where valor_abono >0")
                    .AppendLine("group by forma_pago ");
                SqlDataAdapter command = new SqlDataAdapter(d.ToString(), con);
                command.SelectCommand.CommandType = CommandType.Text;
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

        public static DataTable mostrarReporteTotalCaja()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_reporte_total_caja", con);
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

    }
}
