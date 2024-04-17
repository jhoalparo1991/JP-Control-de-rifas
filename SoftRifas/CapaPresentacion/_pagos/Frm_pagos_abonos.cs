using CEntidades;
using CNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._pagos
{
    public partial class Frm_pagos_abonos : Form
    {
        public Frm_pagos_abonos()
        {
            InitializeComponent();
            _helpers.Disenios.dataGridView(dgv_vendedores);
            habilitarBotonoes(false);
            obtenerDatosUsuarioConectado();
        }

        #region Metodos

        private void buscarVendedor()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_nro_doc.Text))
                {
                    dgv_vendedores.Visible = false;
                    txt_vendedor.Text = string.Empty;
                    txt_valor_pagar.Text = "0";
                    Txt_vendedor_id.Text = "0";
                    return;
                }
                List<Usuarios> usuario = N_Usuarios.mostrarUsuarios().FindAll(
                    x => x.NroDoc.ToLower().Contains(Txt_nro_doc.Text.Trim().ToLower()));

                dgv_vendedores.DataSource = usuario;

                if (dgv_vendedores.Rows.Count > 0)
                {
                    dgv_vendedores.Location = Lbl_punto_1.Location;
                    dgv_vendedores.Visible = true;
                    dgv_vendedores.BringToFront();
                }
                else
                {
                    dgv_vendedores.Visible = false;
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void obtenerDatosUsuarioConectado()
        {
            try
            {
               InicioSesion usuario =  N_Usuarios.mostrarUsuarioSesion();

                if(usuario != null)
                {
                    txt_usuario_id.Text = usuario.Id.ToString();
                    Txt_usuario.Text = usuario.NombreCompleto.ToUpper();
                }

            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void limpiar()
        {
            txt_fecha.Text = string.Empty;
            txt_hora.Text = string.Empty;
            txt_identificador.Text = Guid.NewGuid().ToString();
            txt_total.Text = "0";
            txt_valor_pagar.Text = "0";
            txt_vendedor.Text = string.Empty;
            Txt_id.Text = "0";
            Txt_nro_doc.Text = string.Empty;
            Txt_vendedor_id.Text = "0";
            cbx_forma_pago.Items.Clear();
            _helpers.DatosMaestros.mostrarFormasDePago(cbx_forma_pago);
            txt_descripcion.Text = string.Empty;
            dt_fecha_ini.Select();
        }

      

        private void habilitarBotonoes(bool crear)
        {
            Pn_nuevos_pagos.Enabled = crear;
            Btn_cancelar.Enabled = crear;
            Btn_nuevos.Enabled = !crear;
            Btn_borrar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_registrar_pago.Enabled = crear;
            Pn_pagos.Enabled = crear;
            limpiar();
        }
        #endregion
        private void Txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            habilitarBotonoes(true);
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            habilitarBotonoes(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fecha.Text = DateTime.Now.ToShortDateString();
            txt_hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void Txt_nro_doc_TextChanged(object sender, EventArgs e)
        {
            buscarVendedor();
        }

        private void dgv_vendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_vendedores.Rows.Count > 0)
            {
                Txt_vendedor_id.Text = dgv_vendedores.CurrentRow.Cells["usId"].Value.ToString().Trim();
                Txt_nro_doc.Text = dgv_vendedores.CurrentRow.Cells["usNroDoc"].Value.ToString().Trim();
                txt_vendedor.Text = dgv_vendedores.CurrentRow.Cells["usNombreCompleto"].Value.ToString().Trim();
                dgv_vendedores.Visible = false;
            }
        }
    }
}
