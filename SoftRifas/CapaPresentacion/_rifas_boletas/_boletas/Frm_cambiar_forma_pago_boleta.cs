using Domain;
using System;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas._boletas
{
    public partial class Frm_cambiar_forma_pago_boleta : Form
    {
        public Frm_cambiar_forma_pago_boleta()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            cbx_formas_pago.Items.Clear();
            _helpers.DatosMaestros.mostrarFormasDePago(cbx_formas_pago);
        }

       

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Lbl_id.Text.Trim());
                if (string.IsNullOrEmpty(cbx_formas_pago.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar una forma de pago");
                    cbx_formas_pago.Select();
                    return;
                }

                if (id <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("No se pudo cargar el abono");
                    return;
                }

                DialogResult dialog = MessageBox.Show("Deseas hacer un  cambio de la forma de pago de este abono", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialog == DialogResult.OK)
                {
                    bool result = N_Boletas.cambiarFormaPagoBoleta(id, cbx_formas_pago.Text);
                    if (result)
                    {
                        _helpers.Mensajes.mensajeInformacion("Forma de pago cambiada con exito");
                        this.Close();
                    }

                }


            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
