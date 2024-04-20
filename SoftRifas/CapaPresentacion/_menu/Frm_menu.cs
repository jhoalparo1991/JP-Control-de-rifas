using CapaPresentacion._auxiliar_instalacion;
using CapaPresentacion._clientes;
using CapaPresentacion._pagos;
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

        private void inicioForm()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AbrirFormularioHijo(Form childForm, string title)
        {
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
                if(sesion != null)
                {
                    Lbl_usuario.Text = sesion.NombreCompleto.ToString();
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
            if(WindowState == FormWindowState.Maximized)
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
            AbrirFormularioHijo(new Frm_usuarios(),"Vendedores");
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
            AbrirFormularioHijo(new Frm_pagos_abonos(), "Pago Abonos");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_login frm = new Frm_login();
            frm.ShowDialog();
        }
    }
}
