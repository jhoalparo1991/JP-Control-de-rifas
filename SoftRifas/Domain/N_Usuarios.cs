using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public class N_Usuarios
    {
        public static void mostrarVendedores(DataTable dt)
        {
            D_Usuarios.mostrarVendedores(dt);
        }
        public static List<Usuarios> mostrarUsuarios()
        {
            return D_Usuarios.mostrarUsuarios();
        }

        public static UsuariosPermisos mostrarPermisosUsuarios(int usuarioId)
        {
            return D_Usuarios.mostrarPermisosUsuarios(usuarioId);
        }
        public static InicioSesion mostrarUsuarioSesion()
        {
            return D_Usuarios.mostrarUsuarioSesion();
        }
        public static bool guardar(Usuarios obj)
        {
            return D_Usuarios.guardar(obj);
        }

        public static bool registrarVendedor(Usuarios obj, UsuariosPermisos obj2)
        {
            return D_Usuarios.registrarVendedor(obj, obj2);
        }
        public static bool registrarSesion(int usuarioId)
        {
            return D_Usuarios.registrarSesion(usuarioId);
        }
        public static bool cerrarSesion()
        {
            return D_Usuarios.cerrarSesion();
        }
        public static bool borrar(int usuarioId)
        {
            return D_Usuarios.borrar(usuarioId);
        }
    }
}
