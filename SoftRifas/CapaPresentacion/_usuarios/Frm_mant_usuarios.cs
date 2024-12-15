using Domain;
using Entities;
using System;
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
            Chk_activo.Checked = true;
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
            Chk_activo.Checked = estado;
            Chk_pago_comisiones.Checked = estado;
            Chk_registrar_abonos.Checked = estado;
            Chk_reportes.Checked = estado;
            Chk_rifas.Checked = estado;
            Chk_vendedor.Checked = estado;
            Chk_crear_vendedores.Checked = estado;
            Chk_borrar_vendedores.Checked = estado;
            Chk_editar_vendedores.Checked = estado;
            Chk_asignar_boletas_vendedores.Checked = estado;
            Chk_ver_log.Checked = estado;
            Chk_ver_boleta.Checked = estado;
            ChkBloquearBoleta.Checked = estado;
            chk_ver_estado_boletas.Checked = estado;
            chk_ver_caja.Checked = estado;
            chk_ver_acumulado.Checked = estado;
            chk_ver_todos_los_abonos.Checked = estado;
            chk_ver_abonos_totales_por_clientes.Checked = estado;
            chk_ver_comisiones_vendedores_pagada.Checked = estado;
            chk_ver_abonos_por_vendedores.Checked = estado;
            chk_ver_abonos_por_boletas.Checked = estado;
            chk_ver_boletas_vendidas.Checked = estado;
            chk_ver_formas_pago.Checked = estado;
            chk_ver_filtrar_abonos_fecha_valor.Checked = estado;
            chk_ver_comisiones_pagadas.Checked = estado;
            chk_ver_gastos.Checked = estado;
            chk_ver_reporte_abono_formas_pago.Checked = estado;
            chk_ver_reporte_boletas_entre_fechas.Checked = estado;


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


                if (Convert.ToBoolean(Chk_activo.CheckState) == true)
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
                    Activo = Convert.ToBoolean(Chk_activo.CheckState),
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
                    CrearVendedores = Convert.ToBoolean(Chk_crear_vendedores.CheckState),
                    EditarVendedores = Convert.ToBoolean(Chk_editar_vendedores.CheckState),
                    BorrarVendedores = Convert.ToBoolean(Chk_borrar_vendedores.CheckState),
                    AsignarBoletasVendedores = Convert.ToBoolean(Chk_asignar_boletas_vendedores.CheckState),
                    VerBoleta = Convert.ToBoolean(Chk_ver_boleta.CheckState),
                    VerLog = Convert.ToBoolean(Chk_ver_log.CheckState),
                    DesbloquearBoleta = Convert.ToBoolean(ChkBloquearBoleta.CheckState),
                    ver_estado_boletas = Convert.ToBoolean(chk_ver_estado_boletas.CheckState),
                    ver_caja = Convert.ToBoolean(chk_ver_caja.CheckState),
                    ver_acumulado = Convert.ToBoolean(chk_ver_acumulado.CheckState),
                    ver_todos_los_abonos = Convert.ToBoolean(chk_ver_todos_los_abonos.CheckState),
                    ver_abonos_totales_por_clientes = Convert.ToBoolean(chk_ver_abonos_totales_por_clientes.CheckState),
                    ver_comisiones_vendedores_pagada = Convert.ToBoolean(chk_ver_comisiones_vendedores_pagada.CheckState),
                    ver_abonos_por_vendedores = Convert.ToBoolean(chk_ver_abonos_por_vendedores.CheckState),
                    ver_abonos_por_boletas = Convert.ToBoolean(chk_ver_abonos_por_boletas.CheckState),
                    ver_boletas_vendidas = Convert.ToBoolean(chk_ver_boletas_vendidas.CheckState),
                    ver_formas_pago = Convert.ToBoolean(chk_ver_formas_pago.CheckState),
                    ver_filtrar_abonos_fecha_valor = Convert.ToBoolean(chk_ver_filtrar_abonos_fecha_valor.CheckState),
                    ver_comisiones_pagadas = Convert.ToBoolean(chk_ver_comisiones_pagadas.CheckState),
                    ver_gastos = Convert.ToBoolean(chk_ver_gastos.CheckState),
                    ver_reporte_abono_formas_pago = Convert.ToBoolean(chk_ver_reporte_abono_formas_pago.CheckState),
                    ver_reporte_boletas_entre_fechas = Convert.ToBoolean(chk_ver_reporte_boletas_entre_fechas.CheckState)
                };

                if (N_Usuarios.registrarVendedor(obj, obj2))
                {
                    _helpers.Sesion.guardarDatosLog("USUARIOS - usuario guardado con exito");
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
