using System;
using System.Windows.Forms;

namespace CapaPresentacion._helpers
{
    internal class Mensajes
    {
        public static void mensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            _helpers.Sesion.guardarDatosLog(mensaje);
        }

        public static void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            _helpers.Sesion.guardarDatosLog(mensaje);
        }

        public static void mensajeErrorException(Exception e)
        {
            MessageBox.Show(e.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _helpers.Sesion.guardarDatosLog(e.Message);
        }

        public static void mensajeErrorException2(Exception e)
        {
            MessageBox.Show(e.Message + " " + e.StackTrace, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            _helpers.Sesion.guardarDatosLog(e.Message);
        }
        public static void mensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            _helpers.Sesion.guardarDatosLog(mensaje);
        }
    }
}
