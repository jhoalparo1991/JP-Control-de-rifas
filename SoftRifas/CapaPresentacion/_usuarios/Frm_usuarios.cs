using CapaPresentacion._rifas_boletas;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._usuarios
{
    public partial class Frm_usuarios : Form
    {
        public Frm_usuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            mostrarUsuarios();
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            //_helpers.Disenios.dataGridView(Dgv_usuarios);
        }
        private int usuarioId = 0;

        internal int Seleccion = 0;

        #region metodos

     
        private void verEditarInformacion(bool edit)
        {
           Frm_mant_usuarios frm = new Frm_mant_usuarios(this);
            frm.Txt_id.Text = Dgv_usuarios.CurrentRow.Cells["id"].Value.ToString();
            frm.Txt_nombres.Text = Dgv_usuarios.CurrentRow.Cells["nombre_completo"].Value.ToString();
            frm.Txt_nro_doc.Text = Dgv_usuarios.CurrentRow.Cells["nro_doc"].Value.ToString();
            frm.Txt_dir.Text = Dgv_usuarios.CurrentRow.Cells["Direccion"].Value.ToString();
            frm.Txt_cel.Text = Dgv_usuarios.CurrentRow.Cells["Celular"].Value.ToString();
            frm.Txt_tel.Text = Dgv_usuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            frm.Txt_clave.Text = Dgv_usuarios.CurrentRow.Cells["Clave"].Value.ToString();
            frm.Txt_clave.Enabled = false;
            frm.Txt_comision.Text = Dgv_usuarios.CurrentRow.Cells["Comision"].Value.ToString();
            frm.Chk_activo.Checked = Convert.ToBoolean(Dgv_usuarios.CurrentRow.Cells["activo"].Value);

            UsuariosPermisos permisos = N_Usuarios.mostrarPermisosUsuarios(usuarioId);

            if(permisos != null)
            {
                frm.Chk_backup.Checked = permisos.CrearCopiaSeguridad ;
                frm.Chk_boletas.Checked = permisos.Boletas ;
                frm.Chk_borrar_abonos.Checked = permisos.BorrarAbono ;
                frm.Chk_borrar_egreso.Checked = permisos.BorrarEgreso ;
                frm.Chk_cambiar_cliente_abono.Checked = permisos.CambiarClienteAbono ;
                frm.Chk_cambiar_fp_abono.Checked = permisos.CambiarFpAbono ;
                frm.Chk_clientes.Checked = permisos.Clientes ;
                frm.Chk_crear_egreso.Checked = permisos.CrearEgreso ;
                frm.Chk_crear_tipo_egreso.Checked = permisos. CrearTipoEgreso;
                frm.Chk_editar_egreso.Checked = permisos.EditarEgreso ;
                frm.Chk_egresos.Checked = permisos. Egresos;
                frm.Chk_imprimir_egreso.Checked = permisos.ImprimirEgreso ;
                frm.Chk_pago_comisiones.Checked = permisos.PagoComisiones ;
                frm.Chk_registrar_abonos.Checked = permisos.RegistrarAbono ;
                frm.Chk_reportes.Checked = permisos.Reportes ;
                frm.Chk_rifas.Checked = permisos.Rifas ;
                frm.Chk_vendedor.Checked = permisos.Vendedores ;
            }

            if (edit == true)
            {
         
                frm.Btn_registrar.Enabled = false;
                frm.Txt_id.Enabled = false;
                frm.Txt_nombres.Enabled = true;
                frm.Txt_nro_doc.Enabled = true;
                frm.Txt_dir.Enabled = true;
                frm.Txt_cel.Enabled = true;
                frm.Txt_tel.Enabled = true;
                frm.Txt_clave.Enabled = true;
                frm.Txt_clave.Enabled = true;
                frm.Txt_comision.Enabled = true;
                frm.Chk_activo.Enabled = true;
                frm.Btn_registrar.Enabled = true;

                frm.Chk_backup.Enabled = true;
                frm.Chk_boletas.Enabled = true;
                frm.Chk_borrar_abonos.Enabled = true;
                frm.Chk_borrar_egreso.Enabled = true;
                frm.Chk_cambiar_cliente_abono.Enabled = true;
                frm.Chk_cambiar_fp_abono.Enabled = true;
                frm.Chk_clientes.Enabled = true;
                frm.Chk_crear_egreso.Enabled = true;
                frm.Chk_crear_tipo_egreso.Enabled = true;
                frm.Chk_editar_egreso.Enabled = true;
                frm.Chk_egresos.Enabled = true;
                frm.Chk_imprimir_egreso.Enabled = true;
                frm.Chk_activo.Enabled = true;
                frm.Chk_pago_comisiones.Enabled = true;
                frm.Chk_registrar_abonos.Enabled = true;
                frm.Chk_reportes.Enabled = true;
                frm.Chk_rifas.Enabled = true;
                frm.Chk_vendedor.Enabled = true;
            }
            else
            {
                frm.Txt_id.Enabled = false;
                frm.Txt_nombres.Enabled = false;
                frm.Txt_nro_doc.Enabled = false;
                frm.Txt_dir.Enabled = false;
                frm.Txt_cel.Enabled = false;
                frm.Txt_tel.Enabled = false;
                frm.Txt_clave.Enabled = false;
                frm.Txt_clave.Enabled = false;
                frm.Txt_comision.Enabled = false;
                frm.Chk_activo.Enabled = false;
                frm.Btn_registrar.Enabled = false;

                frm.Chk_backup.Enabled = false;
                frm.Chk_boletas.Enabled = false;
                frm.Chk_borrar_abonos.Enabled = false;
                frm.Chk_borrar_egreso.Enabled = false;
                frm.Chk_cambiar_cliente_abono.Enabled = false;
                frm.Chk_cambiar_fp_abono.Enabled = false;
                frm.Chk_clientes.Enabled = false;
                frm.Chk_crear_egreso.Enabled = false;
                frm.Chk_crear_tipo_egreso.Enabled = false;
                frm.Chk_editar_egreso.Enabled = false;
                frm.Chk_egresos.Enabled = false;
                frm.Chk_imprimir_egreso.Enabled = false;
                frm.Chk_activo.Enabled = false;
                frm.Chk_pago_comisiones.Enabled = false;
                frm.Chk_registrar_abonos.Enabled = false;
                frm.Chk_reportes.Enabled = false;
                frm.Chk_rifas.Enabled = false;
                frm.Chk_vendedor.Enabled = false;
            }
           frm.ShowDialog();
        }
        private void asignarBoletasPorVendedor()
        {
            if (Dgv_usuarios.Rows.Count > 0)
            {
                if (usuarioId > 0)
                {
                    string nombreUsuario = N_Usuarios.mostrarUsuarios().Find(x => x.Id == usuarioId).NombreCompleto;
                    Frm_boletas_usuarios frm = new Frm_boletas_usuarios();
                    frm.Lbl_usuario_id.Text = usuarioId.ToString();
                    frm.usuarioId = usuarioId;
                    frm.Lbl_vendedor.Text = nombreUsuario.Trim().ToUpper();
                    frm.dibujarBoletas();
                    frm.ShowDialog();
                }
                else
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un vendedor para asignarle boletas");
                }


            }
        }
        public void mostrarUsuarios()
        {
            try
            {
                List<Usuarios> usuarios = N_Usuarios.mostrarUsuarios().FindAll(x => x.NombreCompleto.Contains(Txt_buscar.Text.Trim()) ||
                                                           x.NroDoc.Contains(Txt_buscar.Text.Trim()));
                Dgv_usuarios.DataSource = usuarios;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

      
        private void eliminarVendedor()
        {
            try
            {
                if (usuarioId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Usuarios.borrar(usuarioId);
                    mostrarUsuarios();
                    _helpers.Sesion.guardarDatosLog("USUARIOS - usuario borrado con exito");
                    usuarioId = 0;
                }

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
       
        #endregion


        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
        }

        private void Dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Dgv_usuarios.Rows.Count > 0)
            {
                usuarioId = Convert.ToInt32(Dgv_usuarios.CurrentRow.Cells["id"].Value.ToString());
                           
            }
        }

    
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Seleccion == 1)
            {
                Frm_boletas.GetIdUsuario = usuarioId;
                Frm_boletas.GetUsuarioNombre = Dgv_usuarios.CurrentRow.Cells["nombre_completo"].Value.ToString();
                Frm_boletas.GetUsuarioNroDoc = Dgv_usuarios.CurrentRow.Cells["nro_doc"].Value.ToString();
                Frm_boletas.porcentajeComision = Convert.ToDecimal(Dgv_usuarios.CurrentRow.Cells["comision"].Value.ToString());
                this.Close();
            }
        }

        private void Btn_asignar_boletas_Click(object sender, EventArgs e)
        {
            asignarBoletasPorVendedor();
        }

        
        private void agregarBoletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignarBoletasPorVendedor();
        }

        private void verInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verEditarInformacion(false);
        }

        private void modificarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verEditarInformacion(true);

        }

        private void borrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarVendedor();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mant_usuarios frm = new Frm_mant_usuarios(this);
            frm.ShowDialog();
        }

        

        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            Frm_mant_usuarios frm = new Frm_mant_usuarios(this);
            frm.ShowDialog();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            verEditarInformacion(true);

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            eliminarVendedor();
        }

        private void Btn_cerrar_ventana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
