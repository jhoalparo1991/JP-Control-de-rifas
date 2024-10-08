using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._helpers
{
    public class Formularios
    {
        public static void marcarCampoSeleccionado(Control.ControlCollection control)
        {
            foreach (Control control1 in control)
            {
                if (control1 is TextBox)
                {
                    TextBox textBox = (TextBox)control1;
                    textBox.Enter += (sender, e) =>
                    {
                        textBox.BackColor = Color.LightGreen;
                        textBox.ForeColor = Color.Black;
                    };
                    textBox.Leave += (sender, e) =>
                    {
                        textBox.BackColor = Color.White;
                        textBox.ForeColor = Color.DarkGray;
                    };

                }
                else if (control1.Controls.Count > 0)
                {
                    marcarCampoSeleccionado(control1.Controls);
                }
            }
        }


        public static void agregarPaginas(TabControl control, Form form, string titulo)
        {
            _helpers.Sesion.guardarDatosLog("Se abrió la pagina - " + titulo);
            form.TopLevel = false;
            form.Visible = true;
            form.BringToFront();
            form.Dock = DockStyle.Fill;
            TabPage page = new TabPage();
            page.Text = titulo;
            page.Controls.Add(form);
            control.Controls.Add(page);
            control.SelectedTab = page;
        }

        public static void agregarFormPanel(Form form, Panel panel)
        {
            _helpers.Sesion.guardarDatosLog("Se muestra el formulario - " + form.Text);
            form.TopLevel = false;
            form.Visible = true;
            form.BringToFront();
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
        }

        public static void quitarPaginas(TabControl control)
        {
            int paginasTotales = control.TabCount;

            if (paginasTotales > 0)
            {

                if (control.SelectedIndex != 0)
                {
                    control.Controls.Remove(control.SelectedTab);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void moverFormulario(object sender, MouseEventArgs e,Form frm)
        {
            ReleaseCapture();
            SendMessage(frm.Handle, 0x112, 0xf012, 0);
        }
    }
}
