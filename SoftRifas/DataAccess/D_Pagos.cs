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
                        Identificador= reader["identificador"].ToString(),
                        FechaPago = Convert.ToDateTime(reader["fecha_pago"].ToString()),
                        PeriodoPagado= reader["periodo_pagado"].ToString(),
                        HoraPago = Convert.ToDateTime(reader["hora_pago"].ToString()),
                        ValorPagos = Convert.ToDecimal(reader["valor_pagos"].ToString()),
                        Descripcion= reader["descripcion"].ToString(),
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

        public static bool borrarPagos(int id, int abonoId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_borrar_pago_comision", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
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
    }
}
