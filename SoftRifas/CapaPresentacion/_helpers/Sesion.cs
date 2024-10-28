using Domain;
using Entities;
using System;

namespace CapaPresentacion._helpers
{
    public class Sesion
    {

        public static UsuariosPermisos permisosUsuarios(int usuarioId)
        {

            UsuariosPermisos permisos = new UsuariosPermisos();
            try
            {
                permisos = N_Usuarios.mostrarPermisosUsuarios(usuarioId);
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
            return permisos;
        }

        public static void guardarDatosLog(string accion)
        {

            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();
                if (sesion != null)
                {
                    N_Logs.guardarLog(sesion.UsuarioId, accion);
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

    }
}
