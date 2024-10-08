using CapaPresentacion._clientes;
using CapaPresentacion._usuarios;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas
{
    public partial class Frm_boletas : Form
    {
        Frm_vender_boletas frm;
        public Frm_boletas(Frm_vender_boletas frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.ControlBox = false;
            this.Text = "";
            _helpers.Disenios.dataGridView(dgv_vendedores);
            _helpers.Disenios.dataGridView(Dgv_clientes);
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            limpiar();
            mostrarDatosSesion();
            obtenerComisionVendedor();
        }
        internal int id = 0;
        int _usuarioId = 0;
        public static decimal porcentajeComision = 0;
        internal static string GetUsuarioNroDoc;
        internal static string GetClienteNroDoc;
        #region metodos

        private void obtenerComisionVendedor()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_vendedor_id.Text))
                {
                    porcentajeComision = 30;
                    return;
                }

                if (Convert.ToInt32(Txt_vendedor_id.Text) <= 0)
                {
                    porcentajeComision = 30;
                    return;
                }

                Usuarios user = N_Usuarios.mostrarUsuarios().Find(x => x.Id == Convert.ToInt32(Txt_vendedor_id.Text.Trim()));

                if (user != null)
                {
                    porcentajeComision = user.Comision;
                }
                else
                {
                    porcentajeComision = 30;
                }

                txt_porc_comision.Text = porcentajeComision.ToString();

            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void limpiar()
        {
            Txt_nro_boleta.Text = "0";
            Txt_id.Text = "0";
            Txt_id_boleta.Text = "0";
            txt_valor_boleta.Text = "0";
            Txt_comision.Text = "0";
            Txt_abono.Text = "0";
            Txt_vendedor.Text = "";
            Txt_vendedor_id.Text = "0";
            Txt_cliente.Text = "";
            txt_cliente_id.Text = "0";
            Cbx_formas_pago.Items.Clear();
            _helpers.DatosMaestros.mostrarFormasDePago(Cbx_formas_pago);
            Cbx_formas_pago.SelectedIndex = 0;
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


        private void buscarVendedor()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_vendedor.Text))
                {
                    dgv_vendedores.Visible = false;
                    Txt_cc_ve.Text = string.Empty;
                    return;
                }
                List<Usuarios> usuario = N_Usuarios.mostrarUsuarios().FindAll(
                    x => x.NombreCompleto.ToLower().Contains(Txt_vendedor.Text.Trim().ToLower()));

                dgv_vendedores.DataSource = usuario;

                if (dgv_vendedores.Rows.Count > 0)
                {
                    dgv_vendedores.Location = Lbl_punto1.Location;
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

        private void buscarCliente()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_cliente.Text))
                {
                    Dgv_clientes.Visible = false;
                    txt_cc_cl.Text = string.Empty;
                    return;
                }

                List<Clientes> clientes = N_Clientes.mostrarClientes().FindAll(
                     x => x.NombreCompleto.ToLower().Contains(Txt_cliente.Text.Trim().ToLower()));

                Dgv_clientes.DataSource = clientes;

                if (Dgv_clientes.Rows.Count > 0)
                {
                    Dgv_clientes.Location = Lbl_punto2.Location;
                    Dgv_clientes.Visible = true;
                    Dgv_clientes.BringToFront();
                }
                else
                {
                    Dgv_clientes.Visible = false;
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_nro_boleta.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo número de boleta es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(Txt_id_boleta.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo id boleta es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(Txt_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo id es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(Txt_vendedor_id.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo vendedor es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(txt_cliente_id.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo cliente es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(txt_valor_boleta.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo valor boleta es requerido");
                    txt_valor_boleta.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_abono.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo abono es requerido");
                    Txt_abono.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_abono.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo abono es requerido");
                    Txt_abono.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_comision.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo comision es requerido");
                    Txt_comision.Select();
                    return;
                }


                if (string.IsNullOrEmpty(Txt_vendedor.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo vendedor es requerido");
                    Txt_vendedor.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_cc_ve.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Número de documento del vendedor es requerido");
                    Txt_cc_ve.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_cliente.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo cliente es requerido");
                    Txt_cliente.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_cc_cl.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Número de documento del cliente es requerido");
                    txt_cc_cl.Select();
                    return;
                }

                decimal valorBoleta = Convert.ToDecimal(txt_valor_boleta.Text.Trim());
                decimal valorAbono = Convert.ToDecimal(Txt_abono.Text.Trim());
                decimal valorComision = Convert.ToDecimal(Txt_comision.Text.Trim());


                if(valorAbono > valorBoleta)
                {
                    _helpers.Mensajes.mensajeAdvertencia("El valor del abono no puede ser mayor que el valor del precio de la boleta");
                    Txt_abono.Select();
                    return;
                }

                AbonosBoletas obj = new AbonosBoletas()
                {
                    Id = Convert.ToInt32(Txt_id.Text.Trim()),
                    UsuarioId = _usuarioId,
                    VendedorId = Convert.ToInt32(Txt_vendedor_id.Text.Trim()),
                    ClienteId = Convert.ToInt32(txt_cliente_id.Text.Trim()),
                    BoletaId = Convert.ToInt32(Txt_id_boleta.Text.Trim()),
                    NroBoleta = Txt_nro_boleta.Text.Trim(),
                    ValorPorPagar = Convert.ToDecimal(txt_valor_boleta.Text.Trim()),
                    ValorAbono = Convert.ToDecimal(Txt_abono.Text.Trim()),
                    ValorComision = Convert.ToDecimal(Txt_comision.Text.Trim()),
                    FormasPago = Cbx_formas_pago.Text.Trim(),
                    Vendedor = Txt_vendedor.Text.Trim(),
                    VendedorCC = Txt_cc_ve.Text.Trim(),
                    ClienteCC = txt_cc_cl.Text.Trim(),
                    Cliente = Txt_cliente.Text.Trim(),
                };

                if (N_Boletas.registrarAbonosBoletas(obj))
                {
                    limpiar();
                    this.Close();
                    _helpers.Sesion.guardarDatosLog("Registra abono de boleta #" +Txt_nro_boleta.Text);
                    frm.dibujarBoletas();
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
            Btn_registrar.Enabled = true;
        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nro_ini_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_nro_fin_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_valor_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender,e);
        }

        private void Txt_abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);

        }

        private void Txt_comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);

        }

        private void txt_valor_boleta_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_valor_boleta);
        }

        private void Txt_abono_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(Txt_abono);

        }

        private void Txt_comision_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(Txt_comision);

        }

        private void Txt_abono_TextChanged(object sender, EventArgs e)
        {
            calcularComision();
        }

        private void calcularComision()
        {
            if (string.IsNullOrEmpty(Txt_abono.Text.Trim()) || string.IsNullOrEmpty(txt_valor_boleta.Text.Trim()))
            {
                return;
            }
            else
            {
                Txt_comision.Text = "0";
            }

            obtenerComisionVendedor();
         //   decimal valorBoleta = Convert.ToDecimal(txt_valor_boleta.Text.Trim());
            decimal valorAbono = Convert.ToDecimal(Txt_abono.Text.Trim());

            decimal comision = (valorAbono * porcentajeComision) / 100;
            Txt_comision.Text = comision.ToString();
        }

        private void Btn_buscar_vendedor_Click(object sender, EventArgs e)
        {
            dgv_vendedores.Visible = false;
            Dgv_clientes.Visible = false;
            Frm_usuarios frmU = new Frm_usuarios();
            frmU.WindowState = FormWindowState.Normal;
            frmU.StartPosition = FormStartPosition.CenterScreen;
            frmU.Seleccion = 1;
            frmU.FormClosed += FrmU_FormClosed;
            frmU.Btn_cerrar_ventana.Visible = true;
            frmU.ShowDialog();
        }

        private void FrmU_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgv_vendedores.Visible = false;
            Dgv_clientes.Visible = false;
            if (GetIdUsuario > 0)
            {
                Txt_vendedor_id.Text = GetIdUsuario.ToString();
                Txt_vendedor.Text = GetUsuarioNombre;
                Txt_cc_ve.Text = GetUsuarioNroDoc;
                txt_porc_comision.Text = porcentajeComision.ToString();
            }
            else
            {
                Txt_vendedor.Text = "";
                Txt_vendedor_id.Text = "0";
                Txt_cc_ve.Text = "";
                txt_porc_comision.Text = "0";
            }
        }

        private void txt_buscar_cliente_Click(object sender, EventArgs e)
        {
            dgv_vendedores.Visible = false;
            Dgv_clientes.Visible = false;
            Frm_clientes frmC = new Frm_clientes();
            frmC.WindowState = FormWindowState.Normal;
            frmC.StartPosition = FormStartPosition.CenterScreen;
            frmC.Dgv_clientes.Columns["btn_sel"].Visible = true;
            frmC.Btn_cerrar_ventana.Visible = true;
            frmC.FormClosed += FrmC_FormClosed;
            frmC.ShowDialog();
        }

        private void FrmC_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgv_vendedores.Visible = false;
            Dgv_clientes.Visible = false;
            if (GetIdCliente > 0)
            {
                txt_cliente_id.Text = GetIdCliente.ToString();
                Txt_cliente.Text = GetClienteNombre;
                txt_cc_cl.Text = GetClienteNroDoc;
            }
            else
            {
                Txt_cliente.Text = "";
                txt_cliente_id.Text = "0";
                txt_cc_cl.Text = "";
            }
        }

        private void Txt_vendedor_TextChanged(object sender, EventArgs e)
        {
            buscarVendedor();
        }

        private void Txt_cc_ve_TextChanged(object sender, EventArgs e)
        {
            buscarVendedor();
           // obtenerComisionVendedor();
        }

        private void txt_cc_cl_KeyPress(object sender, KeyPressEventArgs e)
        {

            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void dgv_vendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_vendedores.Rows.Count > 0)
            {

                Txt_vendedor.Text = dgv_vendedores.CurrentRow.Cells["usNombreCompleto"].Value.ToString();
                Txt_cc_ve.Text = dgv_vendedores.CurrentRow.Cells["usNroDoc"].Value.ToString();
                Txt_vendedor_id.Text = dgv_vendedores.CurrentRow.Cells["usId"].Value.ToString();
                porcentajeComision = Convert.ToDecimal(dgv_vendedores.CurrentRow.Cells["usComision"].Value.ToString());
                txt_porc_comision.Text = dgv_vendedores.CurrentRow.Cells["usComision"].Value.ToString().Trim();
                dgv_vendedores.Visible = false;
            }
        }

        private void Txt_vendedor_TextChanged_1(object sender, EventArgs e)
        {
            buscarVendedor();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            dgv_vendedores.Visible = false;
            Dgv_clientes.Visible = false;
        }

        private void Txt_cliente_TextChanged(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void txt_cc_cl_TextChanged(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void Dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_clientes.Rows.Count > 0)
            {

                Txt_cliente.Text = Dgv_clientes.CurrentRow.Cells["clNombreCliente"].Value.ToString();
                txt_cc_cl.Text = Dgv_clientes.CurrentRow.Cells["clNroDoc"].Value.ToString();
                txt_cliente_id.Text = Dgv_clientes.CurrentRow.Cells["cl_id"].Value.ToString();
                Dgv_clientes.Visible = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }
    }
}
