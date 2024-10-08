using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._usuarios
{
    public partial class Frm_mant_usuarios : Form
    {

        Frm_usuarios frm;
        public Frm_mant_usuarios(Frm_usuarios frm)
        {
            InitializeComponent();
            this.frm = frm;
            limpiar();
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
            iniciarPermisos(false);
            
        }

        private void iniciarPermisos(bool estado)
        {
            Chk_backup.Checked = estado;
            Chk_boletas.Checked = estado;
            Chk_borrar_abonos.Checked = estado;
            Chk_borrar_egreso.Checked = estado;
            Chk_cambiar_cliente_abono.Checked = estado;
            Chk_cambiar_fp_abono.Checked = estado;
            Chk_clientes.Checked = estado;
            Chk_crear_egreso.Checked = estado;
            Chk_crear_tipo_egreso.Checked = estado;
            Chk_editar_egreso.Checked = estado;
            Chk_egresos.Checked = estado;
            Chk_imprimir_egreso.Checked = estado;
            Chk_is_admin.Checked = estado;
            Chk_pago_comisiones.Checked = estado;
            Chk_registrar_abonos.Checked = estado;
            Chk_reportes.Checked = estado;
            Chk_rifas.Checked = estado;
            Chk_vendedor.Checked = estado;
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

                UsuariosPermisos obj2 = new UsuariosPermisos()
                {
                    Vendedores = Convert.ToBoolean(Chk_vendedor.CheckState),
                    Clientes = Convert.ToBoolean(Chk_clientes.CheckState),
                    Rifas = Convert.ToBoolean(Chk_rifas.CheckState),
                    Boletas = Convert.ToBoolean(Chk_boletas.CheckState),
                    PagoComisiones = Convert.ToBoolean(Chk_pago_comisiones.CheckState),
                    Reportes = Convert.ToBoolean(Chk_reportes.CheckState),
                    Egresos = Convert.ToBoolean(Chk_egresos.CheckState),
                    CrearTipoEgreso = Convert.ToBoolean(Chk_crear_tipo_egreso.CheckState),
                    BorrarEgreso = Convert.ToBoolean(Chk_borrar_egreso.CheckState),
                    EditarEgreso = Convert.ToBoolean(Chk_editar_egreso.CheckState),
                    CrearEgreso = Convert.ToBoolean(Chk_crear_egreso.CheckState),
                    ImprimirEgreso = Convert.ToBoolean(Chk_imprimir_egreso.CheckState),
                    CrearCopiaSeguridad = Convert.ToBoolean(Chk_backup.CheckState),
                    RegistrarAbono = Convert.ToBoolean(Chk_registrar_abonos.CheckState),
                    BorrarAbono = Convert.ToBoolean(Chk_borrar_abonos.CheckState),
                    CambiarFpAbono = Convert.ToBoolean(Chk_cambiar_fp_abono.CheckState),
                    CambiarClienteAbono = Convert.ToBoolean(Chk_cambiar_cliente_abono.CheckState),
                };

                if (N_Usuarios.registrarVendedor(obj,obj2))
                {
                    limpiar();
                    frm.mostrarUsuarios();
                }


            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
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

        private void Txt_comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
