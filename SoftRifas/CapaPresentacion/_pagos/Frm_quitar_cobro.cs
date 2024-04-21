using Domain;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._pagos
{
    public partial class Frm_quitar_cobro : Form
    {

        Frm_pagos_abonos frm;
        public Frm_quitar_cobro(Frm_pagos_abonos frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.ControlBox = false;
            this.Text = "";
            _helpers.Disenios.dataGridView(Dgv);
            mostrarPagos();
        }

        internal int _idDetallePago = 0;

        public void mostrarPagos()
        {
            try
            {
                DataTable dt = N_Pagos.mostrarDetallePagado(_idDetallePago);
                Dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
   
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                int _detallePagoId = Convert.ToInt32(Dgv.CurrentRow.Cells["detalle_pago_id"].Value.ToString());
                int _id = Convert.ToInt32(Dgv.CurrentRow.Cells["id"].Value.ToString());
                int _boletaId = Convert.ToInt32(Dgv.CurrentRow.Cells["boleta_id"].Value.ToString());
                int _pagoId = Convert.ToInt32(Dgv.CurrentRow.Cells["pago_id"].Value.ToString());
                int _codigoAbonoId = Convert.ToInt32(Dgv.CurrentRow.Cells["codigo_abono"].Value.ToString());
                int _VendedorId = Convert.ToInt32(Dgv.CurrentRow.Cells["vendedor_id"].Value.ToString());
                decimal _valorComision = Convert.ToDecimal(Dgv.CurrentRow.Cells["valor_comision"].Value.ToString());
                string _nroBoleta= Dgv.CurrentRow.Cells["nro_boleta"].Value.ToString();

                if (Dgv.Columns[e.ColumnIndex].Name == "btn_quitar")
                {

                    try
                    {
                        DialogResult dialog = MessageBox.Show("Seguro que deseas quitar el pago de esta comision?, te  aparecerá esta comision como pendiente de pagar","Mensaje de confirmacion",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (dialog == DialogResult.OK)
                        {
                            bool result = N_Pagos.borrarPagos(_detallePagoId,_codigoAbonoId,_VendedorId,_boletaId,_pagoId,_valorComision,_id);

                            if (result)
                            {
                                _helpers.Mensajes.mensajeInformacion("Pago borrado con exito");
                                frm.mostrarPagos();
                                frm.mostrarDetallePagos(_pagoId);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        _helpers.Mensajes.mensajeErrorException(ex);
                    }

                    mostrarPagos();
                }
            }
        }
    }
}
