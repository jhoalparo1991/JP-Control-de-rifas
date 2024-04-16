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
        }

        public static void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void mensajeErrorException(Exception e)
        {
            MessageBox.Show(e.Message,"Aviso del sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void mensajeErrorException2(Exception e)
        {
            MessageBox.Show(e.Message + " " + e.StackTrace, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public static void mensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
