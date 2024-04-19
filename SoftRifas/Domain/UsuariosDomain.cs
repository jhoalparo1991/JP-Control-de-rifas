using DataAccess;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public class UsuariosDomain
    {
        public static void mostrarVendedores(DataTable dt)
        {
            Usuarios.mostrarVendedores(dt);
        }
        public static List<DAO_Usuarios> mostrarUsuarios()
        {
            return Usuarios.mostrarUsuarios();
        }
        public static InicioSesion mostrarUsuarioSesion()
        {
            return Usuarios.mostrarUsuarioSesion();
        }
        public static bool guardar(DAO_Usuarios obj)
        {
            return Usuarios.guardar(obj);
        }
        public static bool registrarSesion(int usuarioId)
        {
            return Usuarios.registrarSesion(usuarioId);
        }
        public static bool cerrarSesion()
        {
            return Usuarios.cerrarSesion();
        }
        public static bool borrar(int usuarioId)
        {
            return Usuarios.borrar(usuarioId);
        }
    }
}
