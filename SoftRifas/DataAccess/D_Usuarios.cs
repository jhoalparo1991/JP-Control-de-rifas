using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class D_Usuarios
    {

        private static SqlConnection con = Conexion.getConnection();
        public static void mostrarVendedores(DataTable dt)
        {

            try
            {
                con.Open();
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("select top(1000) * from tbl_usuarios order by nombre_completo");
                SqlDataAdapter data = new SqlDataAdapter(sql.ToString(), con);
                data.SelectCommand.CommandType = CommandType.Text;
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
        }
        public static List<Usuarios> mostrarUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_usuarios order by nombre_completo");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuarios()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        NombreCompleto = reader["nombre_completo"].ToString(),
                        NroDoc = reader["nro_doc"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Celular = reader["celular"].ToString(),
                        Clave = reader["clave"].ToString(),
                        Comision = Convert.ToDecimal(reader["comision"]),
                        Activo = Convert.ToBoolean(reader["activo"]),
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
            return usuarios;
        }
        public static UsuariosPermisos mostrarPermisosUsuarios(int usuarioId)
        {
            UsuariosPermisos usuarios = new UsuariosPermisos();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM tbl_usuarios_permisos where usuario_id=@usuario_id");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("usuario_id", usuarioId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuarios = new UsuariosPermisos()
                    {
                        Vendedores = Convert.ToBoolean(reader["vendedores"]),
                        Clientes = Convert.ToBoolean(reader["clientes"]),
                        Rifas = Convert.ToBoolean(reader["rifas"]),
                        Boletas = Convert.ToBoolean(reader["boletas"]),
                        PagoComisiones = Convert.ToBoolean(reader["pago_comisiones"]),
                        Reportes = Convert.ToBoolean(reader["reportes"]),
                        Egresos = Convert.ToBoolean(reader["egresos"]),
                        CrearTipoEgreso = Convert.ToBoolean(reader["crear_tipo_egreso"]),
                        BorrarEgreso = Convert.ToBoolean(reader["borrar_egreso"]),
                        EditarEgreso = Convert.ToBoolean(reader["editar_egreso"]),
                        CrearEgreso = Convert.ToBoolean(reader["crear_egreso"]),
                        ImprimirEgreso = Convert.ToBoolean(reader["imprimir_egreso"]),
                        CrearCopiaSeguridad = Convert.ToBoolean(reader["crear_copia_seguridad"]),
                        RegistrarAbono = Convert.ToBoolean(reader["registrar_abono"]),
                        BorrarAbono = Convert.ToBoolean(reader["borrar_abono"]),
                        CambiarFpAbono = Convert.ToBoolean(reader["cambiar_fp_abono"]),
                        CambiarClienteAbono = Convert.ToBoolean(reader["cambiar_cliente_abono"]),
                        CrearVendedores = Convert.ToBoolean(reader["crear_vendedores"]),
                        EditarVendedores = Convert.ToBoolean(reader["editar_vendedores"]),
                        BorrarVendedores = Convert.ToBoolean(reader["borrar_vendedores"]),
                        AsignarBoletasVendedores = Convert.ToBoolean(reader["asignar_boletas_vendedores"]),
                        VerLog = Convert.ToBoolean(reader["ver_log"]),
                        VerBoleta = Convert.ToBoolean(reader["ver_boleta"]),
                        DesbloquearBoleta = Convert.ToBoolean(reader["desbloquear_boleta"]),
                        ver_estado_boletas = Convert.ToBoolean(reader["ver_estado_boletas"]),
                        ver_caja = Convert.ToBoolean(reader["ver_caja"]),
                        ver_acumulado = Convert.ToBoolean(reader["ver_acumulado"]),
                        ver_todos_los_abonos = Convert.ToBoolean(reader["ver_todos_los_abonos"]),
                        ver_abonos_totales_por_clientes = Convert.ToBoolean(reader["ver_abonos_totales_por_clientes"]),
                        ver_comisiones_vendedores_pagada = Convert.ToBoolean(reader["ver_comisiones_vendedores_pagada"]),
                        ver_abonos_por_vendedores = Convert.ToBoolean(reader["ver_abonos_por_vendedores"]),
                        ver_abonos_por_boletas = Convert.ToBoolean(reader["ver_abonos_por_boletas"]),
                        ver_boletas_vendidas = Convert.ToBoolean(reader["ver_boletas_vendidas"]),
                        ver_formas_pago = Convert.ToBoolean(reader["ver_formas_pago"]),
                        ver_filtrar_abonos_fecha_valor = Convert.ToBoolean(reader["ver_filtrar_abonos_fecha_valor"]),
                        ver_comisiones_pagadas = Convert.ToBoolean(reader["ver_comisiones_pagadas"]),
                        ver_gastos = Convert.ToBoolean(reader["ver_gastos"]),
                        ver_reporte_abono_formas_pago = Convert.ToBoolean(reader["ver_reporte_abono_formas_pago"]),
                        ver_reporte_boletas_entre_fechas = Convert.ToBoolean(reader["ver_reporte_boletas_entre_fechas"]),
                    };
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
            return usuarios;
        }
        public static InicioSesion mostrarUsuarioSesion()
        {
            InicioSesion sesion = new InicioSesion();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select a.id,a.usuario_id,b.nombre_completo,b.activo,");
                builder.Append("a.fecha from tbl_inicio_sesion a ");
                builder.Append("inner join tbl_usuarios b on a.usuario_id=b.id ");
                builder.Append("where a.terminal =@terminal and a.estado=1");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("terminal", Environment.MachineName.Trim());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sesion = new InicioSesion()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        UsuarioId = Convert.ToInt32(reader["usuario_id"]),
                        NombreCompleto = reader["nombre_completo"].ToString(),
                        Activo = Convert.ToBoolean(reader["activo"]),
                        Fecha = Convert.ToDateTime(reader["fecha"]),
                    };
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
            return sesion;
        }
        public static bool guardar(Usuarios obj)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_usuarios", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", obj.Id);
                command.Parameters.AddWithValue("nombre_completo", obj.NombreCompleto);
                command.Parameters.AddWithValue("nro_doc", obj.NroDoc);
                command.Parameters.AddWithValue("direccion", obj.Direccion);
                command.Parameters.AddWithValue("celular", obj.Celular);
                command.Parameters.AddWithValue("telefono", obj.Telefono);
                command.Parameters.AddWithValue("clave", obj.Clave);
                command.Parameters.AddWithValue("comision", obj.Comision);
                command.Parameters.AddWithValue("activo", obj.Activo);

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

        public static bool registrarVendedor(Usuarios obj, UsuariosPermisos obj2)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar_usuarios", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", obj.Id);
                command.Parameters.AddWithValue("nombre_completo", obj.NombreCompleto);
                command.Parameters.AddWithValue("nro_doc", obj.NroDoc);
                command.Parameters.AddWithValue("direccion", obj.Direccion);
                command.Parameters.AddWithValue("celular", obj.Celular);
                command.Parameters.AddWithValue("telefono", obj.Telefono);
                command.Parameters.AddWithValue("clave", obj.Clave);
                command.Parameters.AddWithValue("comision", obj.Comision);
                command.Parameters.AddWithValue("activo", obj.Activo);
                //Permisos
                command.Parameters.AddWithValue("vendedores", obj2.Vendedores);
                command.Parameters.AddWithValue("clientes", obj2.Clientes);
                command.Parameters.AddWithValue("rifas", obj2.Rifas);
                command.Parameters.AddWithValue("boletas", obj2.Boletas);
                command.Parameters.AddWithValue("pago_comisiones", obj2.PagoComisiones);
                command.Parameters.AddWithValue("reportes", obj2.Reportes);
                command.Parameters.AddWithValue("egresos", obj2.Egresos);
                command.Parameters.AddWithValue("crear_tipo_egreso", obj2.CrearTipoEgreso);
                command.Parameters.AddWithValue("borrar_egreso", obj2.BorrarEgreso);
                command.Parameters.AddWithValue("editar_egreso", obj2.EditarEgreso);
                command.Parameters.AddWithValue("crear_egreso", obj2.CrearEgreso);
                command.Parameters.AddWithValue("imprimir_egreso", obj2.ImprimirEgreso);
                command.Parameters.AddWithValue("crear_copia_seguridad", obj2.CrearCopiaSeguridad);
                command.Parameters.AddWithValue("registrar_abono", obj2.RegistrarAbono);
                command.Parameters.AddWithValue("borrar_abono", obj2.BorrarAbono);
                command.Parameters.AddWithValue("cambiar_fp_abono", obj2.CambiarFpAbono);
                command.Parameters.AddWithValue("cambiar_cliente_abono", obj2.CambiarClienteAbono);
                command.Parameters.AddWithValue("crear_vendedores", obj2.CrearVendedores);
                command.Parameters.AddWithValue("editar_vendedores", obj2.EditarVendedores);
                command.Parameters.AddWithValue("borrar_vendedores", obj2.BorrarVendedores);
                command.Parameters.AddWithValue("asignar_boletas_vendedores", obj2.AsignarBoletasVendedores);
                command.Parameters.AddWithValue("ver_log", obj2.VerLog);
                command.Parameters.AddWithValue("ver_boleta", obj2.VerBoleta);
                command.Parameters.AddWithValue("bloquear_desbloquear", obj2.DesbloquearBoleta);
                command.Parameters.AddWithValue("ver_estado_boletas", obj2.ver_estado_boletas);
                command.Parameters.AddWithValue("ver_caja", obj2.ver_caja);
                command.Parameters.AddWithValue("ver_acumulado", obj2.ver_acumulado);
                command.Parameters.AddWithValue("ver_todos_los_abonos", obj2.ver_todos_los_abonos);
                command.Parameters.AddWithValue("ver_abonos_totales_por_clientes", obj2.ver_abonos_totales_por_clientes);
                command.Parameters.AddWithValue("ver_comisiones_vendedores_pagada", obj2.ver_comisiones_vendedores_pagada);
                command.Parameters.AddWithValue("ver_abonos_por_vendedores", obj2.ver_abonos_por_vendedores);
                command.Parameters.AddWithValue("ver_abonos_por_boletas", obj2.ver_abonos_por_boletas);
                command.Parameters.AddWithValue("ver_boletas_vendidas", obj2.ver_boletas_vendidas);
                command.Parameters.AddWithValue("ver_formas_pago", obj2.ver_formas_pago);
                command.Parameters.AddWithValue("ver_filtrar_abonos_fecha_valor", obj2.ver_filtrar_abonos_fecha_valor);
                command.Parameters.AddWithValue("ver_comisiones_pagadas", obj2.ver_comisiones_pagadas);
                command.Parameters.AddWithValue("ver_gastos", obj2.ver_gastos);
                command.Parameters.AddWithValue("ver_reporte_abono_formas_pago", obj2.ver_reporte_abono_formas_pago);
                command.Parameters.AddWithValue("ver_reporte_boletas_entre_fechas", obj2.ver_reporte_boletas_entre_fechas);


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
        public static bool registrarSesion(int usuarioId)
        {
            bool result = false;
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_iniciar_sesion", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@usuario_id", usuarioId);
                command.Parameters.AddWithValue("@terminal", Environment.MachineName.Trim());

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
                builder.Append("DELETE  FROM tbl_usuarios WHERE id=@id");
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
        public static bool cerrarSesion()
        {
            bool result = false;
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("UPDATE tbl_inicio_sesion SET estado=0 WHERE terminal=@terminal");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.Parameters.AddWithValue("terminal", Environment.MachineName.Trim());

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
