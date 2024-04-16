using CapaNegocio;
using CEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion._auxiliar_instalacion
{
    public partial class Frm_validar_conexion : Form
    {
        public Frm_validar_conexion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            iniciarCampos();
        }

        #region metodos

        private void iniciarCampos()
        {

            List<string> properties = _helpers.Configuraciones.LeerArchivoconexionDB();
            if (properties == null || properties.Count <= 0)
            {
                Txt_pass.Text = "";
                Txt_db.Text = "db_rifas";
                Txt_server.Text = Path.Combine(Environment.MachineName, "SQLEXPRESS");
                Txt_user.Text = "sa";
                Chk_security.Checked = true;
                Txt_server.Select();
            }
            else
            {
                Txt_server.Text = properties[0];
                Txt_db.Text = properties[1];
                Txt_user.Text = properties[2];
                Txt_pass.Text = properties[3];
                Chk_security.Checked = Convert.ToBoolean(properties[4]);
                Txt_server.Select();
            }

        }
        private bool validarCampos()
        {
            if (!string.IsNullOrEmpty(Txt_server.Text))
            {
                error.SetError(Txt_server, "");
                if (!string.IsNullOrEmpty(Txt_db.Text))
                {
                    error.SetError(Txt_db, "");
                    if (!string.IsNullOrEmpty(Txt_user.Text))
                    {
                        error.SetError(Txt_user, "");
                        return true;
                    }
                    else
                    {
                        error.SetError(Txt_user, "El usuario es requerido");
                        Txt_user.Select();
                        return false;
                    }
                }
                else
                {
                    error.SetError(Txt_db, "La base de datos es requerida");
                    Txt_db.Select();
                    return false;
                }
            }
            else
            {
                error.SetError(Txt_server, "El servidor es requerido");
                Txt_server.Select();
                return false;
            }
        }
        private void probarConexion()
        {
            try
            {

                ProcesoConexion proceso = new ProcesoConexion()
                {
                    Servidor = Txt_server.Text.Trim(),
                    BaseDeDatos = Txt_db.Text.Trim(),
                    Usuario = Txt_user.Text.Trim(),
                    Password = Txt_pass.Text.Trim(),
                    SeguridadIntegrada = Convert.ToBoolean(Chk_security.CheckState),
                };


                _helpers.Configuraciones.crearArchivoConfConexionDB(proceso).Wait();

                iniciarCampos();

                if (N_Procesos.getConnectionTest(proceso))
                {


                    MessageBox.Show("Conexion exitosa con el servidor de base de datos", "Aviso del sistema");
                }
                else
                {
                    MessageBox.Show("Error en la conexion con el servidor de base de datos", "Aviso del sistema");
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        #endregion
        private void Chk_security_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_security.Checked)
            {
                Txt_pass.Enabled = false;
                Txt_user.Enabled = false;
                Txt_pass.Text = "";
                Txt_user.Text = "sa";
            }
            else
            {
                Txt_pass.Enabled = true;
                Txt_user.Enabled = true;
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_conectar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                probarConexion();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
