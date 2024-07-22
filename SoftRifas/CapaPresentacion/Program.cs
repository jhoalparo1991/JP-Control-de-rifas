using CapaPresentacion._pagos_comisiones;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = new Frm_login();
                frm.FormClosed += Frm_FormClosed;
                frm.ShowDialog();
                Application.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Aviso del sistema");
            }
        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
