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
                sql.AppendLine("select top(1000) * from tbl_usuarios");
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
                builder.Append("SELECT * FROM tbl_usuarios");
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
                        IsAdmin = Convert.ToBoolean(reader["is_admin"]),
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
        public static InicioSesion mostrarUsuarioSesion()
        {
            InicioSesion sesion = new InicioSesion();
            try
            {
                con.Open();
                StringBuilder builder = new StringBuilder();
                builder.Append("select a.id,a.usuario_id,b.nombre_completo,b.is_admin,");
                builder.Append("a.fecha from tbl_inicio_sesion a ");
                builder.Append("inner join tbl_usuarios b on a.usuario_id=b.id ");
                builder.Append("where a.terminal =@terminal");
                SqlCommand command = new SqlCommand(builder.ToString(), con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("terminal",Environment.MachineName.Trim());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sesion = new InicioSesion()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        UsuarioId = Convert.ToInt32(reader["usuario_id"]),
                        NombreCompleto = reader["nombre_completo"].ToString(),
                        IsAdmin = Convert.ToBoolean(reader["is_admin"]),
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
                command.Parameters.AddWithValue("is_admin", obj.IsAdmin);

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
