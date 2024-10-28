using CapaPresentacion._auxiliar_instalacion;
using CapaPresentacion._clientes;
using CapaPresentacion._egresos;
using CapaPresentacion._logs;
using CapaPresentacion._pagos_comisiones;
using CapaPresentacion._rifas_boletas;
using CapaPresentacion._usuarios;
using Domain;
using Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion._menu
{
    public partial class Frm_menu : Form
    {
        private Form currentChildForm;

        public Frm_menu()
        {
            InitializeComponent();
            Lbl_equipo.Text = Environment.MachineName;
            mostrarDatosSesion();
            inicioForm();
        }

        private void contraerMenuGastos()
        {
            if (panelGastos.Height == 126)
            {
                panelGastos.Height = 41;
            }
            else
            {
                panelGastos.Height = 126;
            }
        }

        private void inicioForm()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AbrirFormularioHijo(Form childForm, string title)
        {
            _helpers.Sesion.guardarDatosLog("Abrió o intentó abrir el menu -- " + title);
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lbl_nombre_form.Text = title;
        }
        private void mostrarDatosSesion()
        {
            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();
                if (sesion != null)
                {
                    Lbl_usuario.Text = sesion.NombreCompleto.ToString();
                    UsuariosPermisos permiso = _helpers.Sesion.permisosUsuarios(sesion.UsuarioId);

                    if (permiso != null)
                    {
                        //MessageBox.Show(permiso.Boletas.ToString());
                        Btn_usuario.Enabled = permiso.Vendedores;
                        Btn_clientes.Enabled = permiso.Clientes;
                        Btn_rifas.Enabled = permiso.Rifas;
                        Btn_boletas.Enabled = permiso.Boletas;
                        Btn_pago_abonos.Enabled = permiso.PagoComisiones;
                        Btn_reportes.Enabled = permiso.Reportes;
                        btnRegistrarGastos.Enabled = permiso.Egresos;
                        btnTiposGastos.Enabled = permiso.CrearTipoEgreso;
                        Btn_config.Enabled = permiso.CrearCopiaSeguridad;
                        Btn_logs.Enabled = permiso.VerLog;
                    }
                    else
                    {
                        _helpers.Sesion.guardarDatosLog("Error con los permisos");
                    }
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Now.ToShortDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_usuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_usuarios(), "Vendedores");
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_clientes(), "Clientes");
        }

        private void Btn_rifas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_rifas(), "Rifas");
        }

        private void Btn_boletas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_vender_boletas(), "Vender boletas");
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_reports_menu(), "Reportes");
        }

        private void Btn_info_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Abrió la opcion de informacion del sistema");
            Frm_about frm = new Frm_about();
            frm.ShowDialog();
        }

        private void Btn_config_Click(object sender, EventArgs e)
        {
            Frm_config frm = new Frm_config();
            frm.ShowDialog();
        }

        private void Btn_pago_abonos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_pago_comisiones(), "Pago de comisiones");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Cerró sesion");
            this.Dispose();
            Frm_login frm = new Frm_login();
            frm.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            contraerMenuGastos();
        }

        private void btnTiposGastos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_tipos_de_gastos(), "Tipos de gasto");
        }

        private void btnRegistrarGastos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_gastos(), "Gastos");
        }

        private void Frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Cerró el sistema");
        }

        private void Btn_logs_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Frm_logs(), "Logs");
        }
    }
}
