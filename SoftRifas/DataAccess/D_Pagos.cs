using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
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
        public static List<Pagos> mostrarPagos()
        {
            List<Pagos> pagos = new List<Pagos>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_pago_abonos");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pagos.Add(new Pagos()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        UsuarioId = Convert.ToInt32(reader["usuario_id"]),
                        Identificador = reader["identificador"].ToString(),
                        FechaPago = Convert.ToDateTime(reader["fecha_pago"].ToString()),
                        PeriodoPagado = reader["periodo_pagado"].ToString(),
                        HoraPago = Convert.ToDateTime(reader["hora_pago"].ToString()),
                        ValorPagos = Convert.ToDecimal(reader["valor_pagos"].ToString()),
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
            return pagos;
        }
        public static List<DtoMostrarDetallePagos> mostrarDetallePagos()
        {
            List<DtoMostrarDetallePagos> pagos = new List<DtoMostrarDetallePagos>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_pagos_abono_detalle");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pagos.Add(new DtoMostrarDetallePagos()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        PagoId = Convert.ToInt32(reader["pago_id"]),
                        VendedorId = Convert.ToInt32(reader["vendedor_id"]),
                        Vendedor = reader["nombre_vendedor"].ToString(),
                        ValorPagado = Convert.ToDecimal(reader["valor_pagado"].ToString()),
                        FechaPago = Convert.ToDateTime(reader["fecha_pago"].ToString()),
                        FormaPago = reader["forma_pago"].ToString(),
                        PeriodoPago = reader["periodo_pagado"].ToString(),
                        Pagado = Convert.ToBoolean(reader["pagado"]),
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
            return pagos;
        }

        public static DataTable mostrarDetallePagado(int idDetalle, int vendedorId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("sp_mostrar_detalle_pagado", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("id", idDetalle);
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
        public static bool borrarPagos(int id, int abonoId, int vendedorId, int boletaId, int pagoId, decimal valor, int idInfoBoletaPagada)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_borrar_pago_comision", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@abono_id", abonoId);
                command.Parameters.AddWithValue("@vendedor_id", vendedorId);
                command.Parameters.AddWithValue("@boleta_id", boletaId);
                command.Parameters.AddWithValue("@pago_id", pagoId);
                command.Parameters.AddWithValue("@valor", valor);
                command.Parameters.AddWithValue("@idInfoBoletaPagada", idInfoBoletaPagada);

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

        public static bool borrarPagosTemporalesPorTerminal()
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_borrar_pagos_temporales", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@terminal", Environment.MachineName.ToString().Trim());

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

        #region Pago comisiones vendedores
        public static bool sp_pagar_comision_vendedor(int vendedorId, int clienteId, int boletaId, int abonoId, decimal valorPagado)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_pagar_comision_vendedor", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@boleta_id", boletaId);
                command.Parameters.AddWithValue("@vendedor_id", vendedorId);
                command.Parameters.AddWithValue("@cliente_id", clienteId);
                command.Parameters.AddWithValue("@abono_id", abonoId);
                command.Parameters.AddWithValue("@valor_pagado", valorPagado);

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

        public static bool borrar_pago_comision_vendedor(int vendedorId, int clienteId, int boletaId, int abonoId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_borrar_pago_comision_vendedor", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@boleta_id", boletaId);
                command.Parameters.AddWithValue("@vendedor_id", vendedorId);
                command.Parameters.AddWithValue("@cliente_id", clienteId);
                command.Parameters.AddWithValue("@abono_id", abonoId);

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

        public static DataTable mostrarPagoComisionPorVendedor(int vendedorId, DateTime fecha1, DateTime fecha2)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter command = new SqlDataAdapter("rpt_listado_pago_comisiones", con);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("vendedor_id", vendedorId);
                command.SelectCommand.Parameters.AddWithValue("fecha1", fecha1);
                command.SelectCommand.Parameters.AddWithValue("fecha2", fecha2);
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

        public static bool sp_pagar_comision_vendedor_por_fecha(int vendedorId, DateTime fecha1, DateTime fecha2)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_pagar_comision_vendedor_por_fecha", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@vendedor_id", vendedorId);
                command.Parameters.AddWithValue("@fecha_ini", fecha1);
                command.Parameters.AddWithValue("@fecha_fin", fecha2);

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


        #endregion

    }
}
