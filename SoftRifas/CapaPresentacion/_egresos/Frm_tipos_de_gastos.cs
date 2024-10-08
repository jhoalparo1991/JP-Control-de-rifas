using CapaPresentacion._rifas_boletas;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._egresos
{
    public partial class Frm_tipos_de_gastos : Form
    {
        public Frm_tipos_de_gastos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            _helpers.Disenios.dataGridView(Dgv);
            mostrarTiposGastos();
            limpiar();
        }
        private int tipoGastoId = 0;
        #region metodos
        public void mostrarTiposGastos()
        {
            try
            {
                List<TiposGastos> gastos = N_TiposGastos.mostrarTiposGastos().FindAll(x => x.Descripcion.Contains(Txt_buscar.Text.Trim()) || x.Codigo.Contains(Txt_buscar.Text.Trim()));
                Dgv.DataSource = gastos;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void limpiar()
        {
            Txt_id.Text = "0";
            txtCodigo.Text = "";
            txtDescripcion.Text = string.Empty;
            txtCodigo.Select();
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
                if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo descripcion es requerido");
                    txtDescripcion.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo codigo es requerido");
                    txtCodigo.Select();
                    return;
                }

                TiposGastos obj = new TiposGastos()
                {
                    Id = Convert.ToInt32(Txt_id.Text.Trim()),
                    Descripcion= txtDescripcion.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                };

                if (N_TiposGastos.crearTiposGastos(obj))
                {
                    mostrarTiposGastos();
                    limpiar();
                    _helpers.Sesion.guardarDatosLog("Registra el tipo de gasto  - " + txtDescripcion.Text);
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
            mostrarTiposGastos();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            limpiar();
            Pn_mant.Visible = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

       
        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            Pn_mant.Visible = true;
            limpiar();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (tipoGastoId > 0)
            {
                Txt_id.Text = Dgv.CurrentRow.Cells["id"].Value.ToString();
                txtDescripcion.Text = Dgv.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtCodigo.Text = Dgv.CurrentRow.Cells["Codigo"].Value.ToString();
                Pn_mant.Visible = true;
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipoGastoId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_TiposGastos.borrar(tipoGastoId);
                    mostrarTiposGastos();
                    _helpers.Sesion.guardarDatosLog("Borra el tipo de gasto #"+tipoGastoId);
                    tipoGastoId = 0;
                }

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }

        private void Btn_cerrar_ventana_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                tipoGastoId = Convert.ToInt32(Dgv.CurrentRow.Cells["id"].Value.ToString());
                Txt_id.Text = Dgv.CurrentRow.Cells["Id"].Value.ToString();
                txtCodigo.Text = Dgv.CurrentRow.Cells["Codigo"].Value.ToString();
                txtDescripcion.Text =  Dgv.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }
    }
}
