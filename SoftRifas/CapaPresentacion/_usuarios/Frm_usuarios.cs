using CapaPresentacion._rifas_boletas;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._usuarios
{
    public partial class Frm_usuarios : Form
    {
        public Frm_usuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            mostrarUsuarios();
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            //_helpers.Disenios.dataGridView(Dgv_usuarios);
            limpiar();
        }
        private int usuarioId = 0;

        internal int Seleccion = 0;

        #region metodos

        private void obtenerInfoUsuario()
        {
            Txt_id.Text = Dgv_usuarios.CurrentRow.Cells["id"].Value.ToString();
            Txt_nombres.Text = Dgv_usuarios.CurrentRow.Cells["nombre_completo"].Value.ToString();
            Txt_nro_doc.Text = Dgv_usuarios.CurrentRow.Cells["nro_doc"].Value.ToString();
            Txt_dir.Text = Dgv_usuarios.CurrentRow.Cells["Direccion"].Value.ToString();
            Txt_cel.Text = Dgv_usuarios.CurrentRow.Cells["Celular"].Value.ToString();
            Txt_tel.Text = Dgv_usuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            Txt_clave.Text = Dgv_usuarios.CurrentRow.Cells["Clave"].Value.ToString();
            Txt_clave.Enabled = false;
            Txt_comision.Text = Dgv_usuarios.CurrentRow.Cells["Comision"].Value.ToString();
            Chk_is_admin.Checked = Convert.ToBoolean(Dgv_usuarios.CurrentRow.Cells["is_admin"].Value);
        }
        private void verEditarInformacion(bool edit)
        {
            if (usuarioId > 0)
            {
                obtenerInfoUsuario();
                Pn_mant.Visible = true;

                if(edit == false)
                {
                    Txt_nombres.Enabled = false;
                    Txt_nro_doc.Enabled = false;
                    Txt_dir.Enabled = false;
                    Txt_cel.Enabled = false;
                    Txt_tel.Enabled = false;
                    Txt_clave.Enabled = false;
                    Txt_comision.Enabled = false;
                    Chk_is_admin.Enabled = false;
                }
            }
        }
        private void asignarBoletasPorVendedor()
        {
            if (Dgv_usuarios.Rows.Count > 0)
            {
                if (usuarioId > 0)
                {
                    Frm_boletas_usuarios frm = new Frm_boletas_usuarios();
                    frm.Lbl_usuario_id.Text = usuarioId.ToString();
                    frm.usuarioId = usuarioId;
                    frm.Lbl_vendedor.Text = Txt_nombres.Text.Trim().ToUpper();
                    frm.dibujarBoletas();
                    frm.ShowDialog();
                }
                else
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un vendedor para asignarle boletas");
                }


            }
        }
        public void mostrarUsuarios()
        {
            try
            {
                List<Usuarios> usuarios = N_Usuarios.mostrarUsuarios().FindAll(x => x.NombreCompleto.Contains(Txt_buscar.Text.Trim()) ||
                                                           x.NroDoc.Contains(Txt_buscar.Text.Trim()));
                Dgv_usuarios.DataSource = usuarios;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void limpiar()
        {
            Txt_cel.Text = string.Empty;
            Txt_clave.Text = string.Empty;
            Txt_comision.Text = "30";
            Txt_dir.Text = string.Empty;
            Txt_id.Text = "0";
            Txt_nombres.Text = string.Empty;
            Txt_nro_doc.Text = "0";
            Txt_tel.Text = string.Empty;
            Txt_clave.Enabled = true;
            Txt_nombres.Select();
        }
        private void eliminarVendedor()
        {
            try
            {
                if (usuarioId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Usuarios.borrar(usuarioId);
                    mostrarUsuarios();
                    usuarioId = 0;
                }

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
        private void guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo codigo es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(Txt_nombres.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo nombre es requerido");
                    Txt_nombres.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_nro_doc.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo número de documento es requerido");
                    Txt_nro_doc.Select();
                    return;
                }


                if (Convert.ToBoolean(Chk_is_admin.CheckState) == true)
                {

                    if (string.IsNullOrEmpty(Txt_clave.Text.Trim()))
                    {
                        _helpers.Mensajes.mensajeAdvertencia("El Campo clave es requerido");
                        Txt_clave.Select();
                        return;
                    }
                }

                Usuarios obj = new Usuarios()
                {
                    Id = Convert.ToInt32(Txt_id.Text.Trim()),
                    NombreCompleto = Txt_nombres.Text.Trim(),
                    NroDoc = Txt_nro_doc.Text.Trim(),
                    Direccion = Txt_dir.Text.Trim(),
                    Telefono = Txt_tel.Text.Trim(),
                    Celular = Txt_cel.Text.Trim(),
                    Clave = Txt_clave.Text.Trim(),
                    Comision = Convert.ToDecimal(Txt_comision.Text.Trim()),
                    IsAdmin = Convert.ToBoolean(Chk_is_admin.CheckState),
                };

                if (N_Usuarios.guardar(obj))
                {
                    limpiar();
                    mostrarUsuarios();
                }


            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        #endregion


        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
        }

        private void Dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Dgv_usuarios.Rows.Count > 0)
            {
                usuarioId = Convert.ToInt32(Dgv_usuarios.CurrentRow.Cells["id"].Value.ToString());
                obtenerInfoUsuario();               
            }
        }

    
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Seleccion == 1)
            {
                Frm_boletas.GetIdUsuario = usuarioId;
                Frm_boletas.GetUsuarioNombre = Dgv_usuarios.CurrentRow.Cells["nombre_completo"].Value.ToString();
                Frm_boletas.GetUsuarioNroDoc = Dgv_usuarios.CurrentRow.Cells["nro_doc"].Value.ToString();
                Frm_boletas.porcentajeComision = Convert.ToDecimal(Dgv_usuarios.CurrentRow.Cells["comision"].Value.ToString());
                this.Close();
            }
        }

        private void Btn_asignar_boletas_Click(object sender, EventArgs e)
        {
            asignarBoletasPorVendedor();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void Txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_cel_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_comision_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(Txt_comision, "30");
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Pn_mant.Visible = false;
        }

        private void agregarBoletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignarBoletasPorVendedor();
        }

        private void verInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verEditarInformacion(false);
        }

        private void modificarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verEditarInformacion(true);

        }

        private void borrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarVendedor();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
            Pn_mant.Visible = true;
        }

        private void Chk_is_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_is_admin.Checked)
            {
                Txt_clave.Enabled = true;
            }
            else
            {
                Txt_clave.Enabled = false;
            }
        }

        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            Pn_mant.Visible = true;
            limpiar();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            verEditarInformacion(true);

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            eliminarVendedor();
        }

        private void Btn_cerrar_ventana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
