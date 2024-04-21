using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._egresos
{
    public partial class Frm_gastos : Form
    {
        public Frm_gastos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            _helpers.Disenios.dataGridView(Dgv);
            mostrarGastos();
        }
        private int gastoId = 0;
        #region metodos
        public void mostrarGastos()
        {
            try
            {
                List<DtoMostarGastos> gastos = N_Gastos.mostrarGastos()
                    .FindAll(x => x.Descripcion.Contains(Txt_buscar.Text.Trim()) 
                               || x.Codigo.Contains(Txt_buscar.Text.Trim()) 
                               || x.TipoGasto.Contains(Txt_buscar.Text.Trim())
                               || x.Referencia.Contains(Txt_buscar.Text.Trim())
                               || x.Valor.ToString().Contains(Txt_buscar.Text.Trim())
                               || x.Fecha.ToString().Contains(Txt_buscar.Text.Trim())
                               );

                decimal total = 0;

                foreach(var gasto in gastos)
                {
                    total += gasto.Valor;
                }

                Lbl_total.Text = total.ToString("C2");

                Dgv.DataSource = gastos;
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
            mostrarGastos();
        }

     
        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            Frm_registrar_egresos frm = new Frm_registrar_egresos(this);
            frm.ShowDialog();
        }

        private void eliminarGasto()
        {
            try
            {
                if (gastoId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Gastos.borrar(gastoId);
                    mostrarGastos();
                    gastoId = 0;
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
                gastoId = Convert.ToInt32(Dgv.CurrentRow.Cells["id"].Value.ToString());

                if(Dgv.Columns[e.ColumnIndex].Name == "btn_editar_egreso")
                {
                    Frm_registrar_egresos frm = new Frm_registrar_egresos(this);
                    frm.Lbl_id.Text = Dgv.CurrentRow.Cells["Id"].Value.ToString();
                    frm.cbx_tipo_egreso.SelectedValue = Convert.ToInt32(Dgv.CurrentRow.Cells["TipoGastoId"].Value.ToString());
                    frm.lblUsuarioId.Text = Dgv.CurrentRow.Cells["UsuarioId"].Value.ToString();
                    frm.txt_referencia.Text = Dgv.CurrentRow.Cells["Referencia"].Value.ToString();
                    frm.txt_descripcion.Text = Dgv.CurrentRow.Cells["Descripcion"].Value.ToString();
                    frm.txt_valor.Text = Dgv.CurrentRow.Cells["Valor"].Value.ToString();
                    frm.dt_fecha.Text = Dgv.CurrentRow.Cells["Fecha"].Value.ToString();
                    frm.ShowDialog();
                }
                else if (Dgv.Columns[e.ColumnIndex].Name == "btn_borrar_egreso")
                {
                    eliminarGasto();
                }
                else if (Dgv.Columns[e.ColumnIndex].Name == "btn_imprimir")
                {
                    Frm_reporte_egresos frm = new Frm_reporte_egresos();
                    frm.gastoId = gastoId;
                    frm.mostrarGasto();
                    frm.ShowDialog();
                }

              
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }
    }
}
