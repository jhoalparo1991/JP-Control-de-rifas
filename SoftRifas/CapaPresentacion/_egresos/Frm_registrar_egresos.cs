using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._egresos
{
    public partial class Frm_registrar_egresos : Form
    {

        Frm_gastos frm;
        public Frm_registrar_egresos(Frm_gastos frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.ControlBox = false;
            this.Text = "";
            limpiar();
            cargarSesion();
        }

        private void limpiar()
        {
            Lbl_id.Text = "0";
            txt_descripcion.Text = string.Empty;
            txt_referencia.Text = string.Empty;
            txt_valor.Text = string.Empty;
            cbx_tipo_egreso.Select();
            mostrarTiposGasto();
        }
       
        private void cargarSesion()
        {
            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();

                if(sesion != null)
                {
                    lblUsuarioId.Text = sesion.UsuarioId.ToString();
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void mostrarTiposGasto()
        {
            try
            {
                List<TiposGastos> tiposGastos = N_TiposGastos.mostrarTiposGastos();
                cbx_tipo_egreso.DataSource = tiposGastos;
                cbx_tipo_egreso.DisplayMember = "descripcion";
                cbx_tipo_egreso.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
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
                if (string.IsNullOrEmpty(cbx_tipo_egreso.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un tipo de egreso");
                    cbx_tipo_egreso.Select();
                    return;
                }

                if (Convert.ToInt32(cbx_tipo_egreso.SelectedValue) <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un tipo de egreso");
                    cbx_tipo_egreso.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_descripcion.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar una descripcion para este egreso");
                    txt_descripcion.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_valor.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar el valor de este egreso");
                    txt_valor.Select();
                    return;
                }

                if (Convert.ToDecimal(txt_valor.Text) < 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar el valor de este egreso");
                    txt_valor.Select();
                    return;
                }

                DialogResult dialog = MessageBox.Show("Deseas registrar este egreso?", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialog == DialogResult.OK)
                {

                    Gastos obj = new Gastos()
                    {
                        Id = Convert.ToInt32(Lbl_id.Text.Trim()),
                        TipoGastoId = Convert.ToInt32(cbx_tipo_egreso.SelectedValue),
                        UsuarioId = Convert.ToInt32(lblUsuarioId.Text.Trim()),
                        Referencia = txt_referencia.Text.Trim(),
                        Descripcion = txt_descripcion.Text.Trim(),
                        Valor = Convert.ToDecimal(txt_valor.Text.Trim()),
                        Fecha = Convert.ToDateTime(dt_fecha.Text),
                    };

                    bool result = N_Gastos.crearGastos(obj);
                    if (result)
                    {
                        _helpers.Sesion.guardarDatosLog("se registra el gasto - " + txt_descripcion.Text.Trim());
                        _helpers.Mensajes.mensajeInformacion("Gasto registrado con exito");
                        limpiar();
                        frm.mostrarGastos();
                    }

                }


            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException2(ex);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Sale de la ventana de registro de gastos");
            this.Close();
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.numeroDecimal(sender,e);
        }
    }
}
