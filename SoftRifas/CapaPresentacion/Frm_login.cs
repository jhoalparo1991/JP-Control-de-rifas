using CapaPresentacion._auxiliar_instalacion;
using CapaPresentacion._menu;
using CapaPresentacion._usuarios;
using Domain;
using Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            limpiar();
            mostrarBotonCrearUsuarios();
        }

        private void mostrarBotonCrearUsuarios()
        {
            int total = N_Usuarios.mostrarUsuarios().Count;

            if(total <= 0) {
                Lbl_usuario.Visible = true;
            }
            else
            {
                Lbl_usuario.Visible = false;
            }
        }

        private void limpiar()
        {
            Txt_clave.Text = "";
            Txt_nro_doc.Text = "";
            Txt_nro_doc.Select();
        }
        private void Txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {

                N_Usuarios.cerrarSesion();
                Usuarios usuario = new Usuarios();
                if (string.IsNullOrEmpty(Txt_nro_doc.Text)) {
                    _helpers.Mensajes.mensajeAdvertencia("El campo número de documento es requerido");
                    Txt_nro_doc.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_clave.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El campo clave es requerido");
                    Txt_clave.Select();
                    return;
                }

                usuario = N_Usuarios.mostrarUsuarios().Find(x=>x.NroDoc == Txt_nro_doc.Text.Trim() && x.Clave ==Txt_clave.Text.Trim() && x.IsAdmin == true);

                if(usuario  != null)
                {
                    if (N_Usuarios.registrarSesion(usuario.Id))
                    {
                        //_helpers.Mensajes.mensajeInformacion($"Bienvenido {usuario.NombreCompleto}");
                        this.Dispose();
                        Frm_menu frm = new Frm_menu();
                        frm.ShowDialog();
                    }
                    else
                    {
                        _helpers.Mensajes.mensajeAdvertencia("No se puedo iniciar la sesion");
                    }
                }
                else
                {
                    _helpers.Mensajes.mensajeAdvertencia("Usuario y/o contraseña incorrectas");

                }

               
                limpiar();

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Lbl_validacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_validar_conexion frm = new Frm_validar_conexion();
            frm.ShowDialog();


        }
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Lbl_usuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_usuarios frm = new Frm_usuarios();
          //  frm.FormBorderStyle = FormBorderStyle.FixedDialog ;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = "Registrar usuarios";
            frm.ControlBox = true;
            frm.Btn_cerrar_ventana.Visible = true;
            frm.ShowDialog();
        }
    }
}
