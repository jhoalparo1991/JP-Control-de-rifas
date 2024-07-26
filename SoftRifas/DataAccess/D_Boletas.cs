using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Boletas
    {
        private static SqlConnection con = Conexion.getConnection();
        public static void contarBoletas(ref int total, int id)
        {
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select nro_final total from tbl_rifas WHERE id=@id and activa=1");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("id", id);

                total = Convert.ToInt32(command.ExecuteScalar());
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

        public static List<DtoMostrarBoletasDatos> mostrarTodasBoletas()
        {
            List<DtoMostrarBoletasDatos> boletas = new List<DtoMostrarBoletasDatos>();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_mostrar_boletas", con);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    boletas.Add(new DtoMostrarBoletasDatos()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        RifaId = Convert.ToInt32(reader["rifa_id"]),
                        VendedorId = Convert.ToInt32(reader["vendedor_id"]),
                        NroBoleta = reader["nro_boleta"].ToString(),
                        ValorBoleta = Convert.ToDecimal(reader["valor_boleta"]),
                        Pagada = Convert.ToBoolean(reader["pagada"]),
                        Vendida = Convert.ToBoolean(reader["vendida"])
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
            return boletas;
        }
        public static List<Boletas> mostrarBoletasPaginadas(int rifaId, int desde, int hasta)
        {
            List<Boletas> boletas = new List<Boletas>();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_mostrar_boletas_2", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("desde", desde);
                command.Parameters.AddWithValue("hasta", hasta);
                command.Parameters.AddWithValue("rifa_id", rifaId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    boletas.Add(new Boletas()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        RifaId = Convert.ToInt32(reader["rifa_id"]),
                        NroBoleta = reader["nro_boleta"].ToString(),
                        ValorBoleta = Convert.ToDecimal(reader["valor_boleta"]),
                        Pagada = Convert.ToBoolean(reader["pagada"]),
                        Vendida = Convert.ToBoolean(reader["vendida"]),
                        VendedorId = Convert.ToInt32(reader["vendedor_id"]),
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
            return boletas;
        }
        public static bool registrarAbonosBoletas(AbonosBoletas obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_registrar_abono_boleta", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Parameters.AddWithValue("@usuario_id", obj.UsuarioId);
                command.Parameters.AddWithValue("@boleta_id", obj.BoletaId);
                command.Parameters.AddWithValue("@nro_boleta", obj.NroBoleta);
                command.Parameters.AddWithValue("@valor_por_pagar", obj.ValorPorPagar);
                command.Parameters.AddWithValue("@valor_abono", obj.ValorAbono);
                command.Parameters.AddWithValue("@valor_comision", obj.ValorComision);
                command.Parameters.AddWithValue("@forma_pago", obj.FormasPago);
                command.Parameters.AddWithValue("@nombre_ve", obj.Vendedor);
                command.Parameters.AddWithValue("@cc_ve", obj.VendedorCC);
                command.Parameters.AddWithValue("@nombre_cl", obj.Cliente);
                command.Parameters.AddWithValue("@cc_cl", obj.ClienteCC);

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
        public static List<DtoMostrarAbonos> mostrarAbonos(int boletaId)
        {
            List<DtoMostrarAbonos> boletas = new List<DtoMostrarAbonos>();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_mostrar_abonos", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("boleta_id", boletaId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    boletas.Add(new DtoMostrarAbonos()
                    {
                        Id = Convert.ToInt32(reader["id"].ToString()),
                        BoletaId = Convert.ToInt32(reader["boleta_id"].ToString()),
                        NroBoleta = reader["nro_boleta"].ToString(),
                        VendedorId = Convert.ToInt32(reader["vendedor_id"].ToString()),
                        Vendedor = reader["vendedor"].ToString(),
                        VendedorCC = reader["cc_ve"].ToString(),
                        ClienteId = Convert.ToInt32(reader["cliente_id"].ToString()),
                        Cliente = reader["cliente"].ToString(),
                        ClienteCC = reader["cc_cl"].ToString(),
                        ValorPorPagar = Convert.ToDecimal(reader["valor_por_pagar"].ToString()),
                        Abonos = Convert.ToDecimal(reader["abonos"].ToString()),
                        Comision = Convert.ToDecimal(reader["valor_comision"].ToString()),
                        FechaAbono = Convert.ToDateTime(reader["fecha_abono"].ToString()),
                        HoraAbono = Convert.ToDateTime(reader["hora_abono"].ToString()),
                        FormasPago = reader["forma_pago"].ToString(),
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
            return boletas;
        }
        public static DataTable consultarAbonosEntreFechasAndVendedor(int vendedorId, DateTime FIni, DateTime FFin)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter("sp_consultar_abonos_entre_fecha_and_vendedor", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@vendedor_id", vendedorId);
                data.SelectCommand.Parameters.AddWithValue("@fecha_ini", FIni);
                data.SelectCommand.Parameters.AddWithValue("@fecha_fin", FFin);
                data.Fill(dt);
                
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
        public static DataTable obtenerBoletasEntreFechasAndVendedor(int vendedorId, DateTime FIni, DateTime FFin,string codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter("sp_obtner_boletas_entre_fecha_and_vendedor", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@vendedor_id", vendedorId);
                data.SelectCommand.Parameters.AddWithValue("@fecha_ini", FIni);
                data.SelectCommand.Parameters.AddWithValue("@fecha_fin", FFin);
                data.SelectCommand.Parameters.AddWithValue("@codigo", codigo);
                data.SelectCommand.Parameters.AddWithValue("@terminal", Environment.MachineName.ToString());
                data.Fill(dt);

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
        public static List<DtoMostrarAsignarBoletasVendedores> mostrarBoletasAsignadasVendedores()
        {
            List<DtoMostrarAsignarBoletasVendedores> boletas = new List<DtoMostrarAsignarBoletasVendedores>();
            try
            {
                con.Open();
                StringBuilder b = new StringBuilder();
                b.AppendLine("select a.id,a.vendedor_id,a.boleta_id,a.nro_boleta,");
                b.AppendLine("b.pagada,b.vendida,b.rifa_id from tbl_boletas_vendedores a");
                b.AppendLine("inner join tbl_boletas b on a.boleta_id=b.id ");
                SqlCommand command = new SqlCommand(b.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    boletas.Add(new DtoMostrarAsignarBoletasVendedores()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        VendedorId = Convert.ToInt32(reader["vendedor_id"]),
                        BoletaId = Convert.ToInt32(reader["boleta_id"]),
                        NroBoleta = reader["nro_boleta"].ToString(),
                        Pagada = Convert.ToBoolean(reader["pagada"]),
                        Vendida = Convert.ToBoolean(reader["vendida"]),
                        RifaId = Convert.ToInt32(reader["rifa_id"]),
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
            return boletas;
        }
        public static bool asignarBoletasVendedores(AsignarBoletasVendedores obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_asignar_boletas_vendedor", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@vendedor_id", obj.VendedorId);
                command.Parameters.AddWithValue("@nro_boleta", obj.NroBoleta);

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
        public static bool cambiarFormaPagoBoleta(int abonoBoletaId, string formaPago)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_editar_forma_pago_boleta", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@abono_boleta_id", abonoBoletaId);
                command.Parameters.AddWithValue("@forma_pago", formaPago);

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
        public static bool cambiarClienteBoleta(int boletaId, int clienteId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_cambiar_cliente_boleta", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cliente_id", clienteId);
                command.Parameters.AddWithValue("@boleta_id", boletaId);

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
        public static bool borrarBoletaAsignadaVendedor(int boletaId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_quitar_boleta_vendedor", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("boleta_id", boletaId);

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

        public static bool borrarAbonosBoletas(int boletaId, int idAbonoBoleta, int vendedorId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_borrar_abono_boleta", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@boleta_id", boletaId);
                command.Parameters.AddWithValue("@id_abono_boleta", idAbonoBoleta);
                command.Parameters.AddWithValue("@vendedor_id", vendedorId);

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

        public static DataTable mostrarAbonosBoletaPorVendedor(int vendedorId)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "select id,cliente_id,cliente,boleta_id,nro_boleta,valor_abono,valor_comision,abono_pagado " +
                    "from v_listado_abonos where vendedor_id=@vendedor_id and valor_comision>0";
                SqlDataAdapter data = new SqlDataAdapter(sql, con);
                data.SelectCommand.CommandType = CommandType.Text;
                data.SelectCommand.Parameters.AddWithValue("@vendedor_id", vendedorId);
                data.Fill(dt);

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
