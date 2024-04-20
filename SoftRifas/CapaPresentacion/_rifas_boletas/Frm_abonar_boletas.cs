using CapaPresentacion._rifas_boletas._boletas;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas
{
    public partial class Frm_abonar_boletas : Form
    {
        Frm_vender_boletas frm;
        public Frm_abonar_boletas(Frm_vender_boletas frm)
        {
            InitializeComponent();
            this.frm = frm;
            iniciarForm();
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            _helpers.Disenios.dataGridView(Dgv_abonos);
            limpiar();
            mostrarDatosSesion();
        }

        private void iniciarForm()
        {
            this.ControlBox = false;
            this.Text = "";
        }
        internal int id = 0;
        private decimal porcentajeComision = 30;
        private int _usuarioId = 0;
        private bool _editarFpBoleta = false;
       // private int boletaId;
        #region metodos
        private void limpiar()
        {
            txt_saldado.Text = "0";
            txt_vendedor.Select();
            Cbx_formas_pago.Items.Clear();
            _helpers.DatosMaestros.mostrarFormasDePago(Cbx_formas_pago);
            Cbx_formas_pago.SelectedIndex = 0;
        }
        internal void mostrarAbonos(int _id)
        {
            try
            {
                List<DtoMostrarAbonos> abonos = N_Boletas.mostrarAbonos(_id);
                Dgv_abonos.DataSource = abonos;
                decimal _totalAbonos = 0;
                foreach (var abono in abonos)
                {
                    _totalAbonos +=(Convert.ToDecimal(abono.Abonos));
                    txt_cliente.Text = abono.Cliente.ToString().Trim();
                    txt_cliente_id.Text = abono.ClienteId.ToString().Trim();
                    txt_vendedor.Text = abono.Vendedor.ToString().Trim();
                    txt_vendedor_id.Text = abono.VendedorId.ToString().Trim();
                    Txt_cc_ve.Text = abono.VendedorCC.ToString().Trim();
                    Txt_cc_cl.Text = abono.ClienteCC.ToString().Trim();
                }

               

                txt_saldado.Text = (Convert.ToDecimal(txt_valor.Text.Trim()) - _totalAbonos).ToString();
            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void mostrarDatosSesion()
        {
            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();
                if (sesion != null)
                {
                    _usuarioId = sesion.UsuarioId;
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void calcularComision()
        {
            if (string.IsNullOrEmpty(txt_deuda.Text.Trim()))
            {
                return;
            }
            else
            {
                Txt_comision.Text = "0";
            }


            //   decimal valorBoleta = Convert.ToDecimal(txt_valor_boleta.Text.Trim());
            decimal valorAbono = Convert.ToDecimal(txt_deuda.Text.Trim());

            decimal comision = (valorAbono * porcentajeComision) / 100;
            Txt_comision.Text = comision.ToString();
        }
        private void guardar()
        {
            try
            {
                
                if (string.IsNullOrEmpty(Txt_boleta.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El número de boleta es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(txt_vendedor_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo vendedor es requerido");
                    txt_vendedor.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_cliente_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El cliente es requerido");
                    txt_cliente.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_valor.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El valor de la boleta es requerido");
                    txt_valor.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_deuda.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El campo valor a pagar es requerido");
                    txt_deuda.Select();
                    return;
                }

                decimal valorSaldado= Convert.ToDecimal(txt_saldado.Text.Trim());
                decimal valorDeuda= Convert.ToDecimal(txt_deuda.Text.Trim());


                if (valorDeuda > valorSaldado)
                {
                    _helpers.Mensajes.mensajeAdvertencia("El valor del abono no puede ser mayor que el valor del precio de la boleta");
                    txt_deuda.Select();
                    return;
                }

                AbonosBoletas obj = new AbonosBoletas()
                {
                    Id = id,
                    UsuarioId = _usuarioId,
                    //VendedorId = Convert.ToInt32(txt_vendedor_id.Text.Trim()),
                    //ClienteId = Convert.ToInt32(txt_cliente_id.Text.Trim()),
                    BoletaId = Convert.ToInt32(txt_id_boleta.Text.Trim()),
                    NroBoleta = Txt_boleta.Text.Trim(),
                    ValorPorPagar = Convert.ToDecimal(txt_saldado.Text.Trim()),
                    ValorAbono = Convert.ToDecimal(txt_deuda.Text.Trim()),
                    ValorComision = Convert.ToDecimal(Txt_comision.Text.Trim()),
                    FormasPago = Cbx_formas_pago.Text.Trim(),
                    Vendedor = txt_vendedor.Text.Trim(),
                    VendedorCC = Txt_cc_ve.Text.Trim(),
                    Cliente = txt_cliente.Text.Trim(),
                    ClienteCC = Txt_cc_cl.Text.Trim(),
                };

               DialogResult result = MessageBox.Show("Estas seguro con el valor del abono, valida antes de guardar, no podras modificar un abono despues de guardarlo", "Confirmacion de abono", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    if (N_Boletas.registrarAbonosBoletas(obj))
                    {
                        limpiar();
                        frm.dibujarBoletas();
                        mostrarAbonos(Convert.ToInt32(txt_id_boleta.Text.Trim()));
                        calcularComision();
                        _helpers.Mensajes.mensajeInformacion("Abono resgistrado con exito");
                        this.Close();
                    }
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
            limpiar();
        }

      

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            Btn_registrar.Enabled = false;
            guardar();
            mostrarAbonos(Convert.ToInt32(txt_id_boleta.Text.Trim()));
            Btn_registrar.Enabled = true;
        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_comision_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_deuda_TextChanged(object sender, EventArgs e)
        {
            calcularComision();
        }

        private void Btn_usuario_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id_boleta.Text.Trim()) <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccioanr la boleta que deseas generar reporte");
                return;
            }

        
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }

        private void Dgv_abonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Dgv_abonos.Rows.Count > 0)
            {
                if (Dgv_abonos.Columns[e.ColumnIndex].Name == "btn_editar_forma_pago")
                {
                    id = Convert.ToInt32(Dgv_abonos.CurrentRow.Cells["b_Id"].Value.ToString().Trim());
                    //txt_id_boleta.Text = Dgv_abonos.CurrentRow.Cells["b_boletaid"].Value.ToString().Trim();
                    //Txt_boleta.Text = Dgv_abonos.CurrentRow.Cells["b_NroBoleta"].Value.ToString().Trim();
                    //txt_vendedor_id.Text = Dgv_abonos.CurrentRow.Cells["b_VendedorId"].Value.ToString().Trim();
                    //txt_vendedor.Text = Dgv_abonos.CurrentRow.Cells["b_Vendedor"].Value.ToString().Trim();
                    //txt_cliente.Text = Dgv_abonos.CurrentRow.Cells["b_Cliente"].Value.ToString().Trim();
                    //txt_cliente_id.Text = Dgv_abonos.CurrentRow.Cells["b_ClienteId"].Value.ToString().Trim();
                    //txt_saldado.Text = Dgv_abonos.CurrentRow.Cells["b_ValorPorPagar"].Value.ToString().Trim();
                    //Txt_comision.Text = Dgv_abonos.CurrentRow.Cells["b_ValorComision"].Value.ToString().Trim();
                    //txt_deuda.Text = Dgv_abonos.CurrentRow.Cells["b_abonos"].Value.ToString().Trim();
                    //Cbx_formas_pago.Text = Dgv_abonos.CurrentRow.Cells["b_FormasPago"].Value.ToString().Trim();

                    DialogResult result = MessageBox.Show("Deseas hacer un  cambio de la forma de pago de este abono","Mensaje de confirmacion",
                        MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                    if(result == DialogResult.OK)
                    {
                        Frm_cambiar_forma_pago_boleta frmCambio = new Frm_cambiar_forma_pago_boleta();
                        frmCambio.Lbl_id.Text = id.ToString();
                        frmCambio.cbx_formas_pago.Text = Dgv_abonos.CurrentRow.Cells["b_FormasPago"].Value.ToString().Trim();
                        frmCambio.FormClosed += FrmCambio_FormClosed;
                        frmCambio.ShowDialog();
                    }
                }
            }
        }

        private void FrmCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            mostrarAbonos(Convert.ToInt32(txt_id_boleta.Text.Trim()));
        }
    }
}
