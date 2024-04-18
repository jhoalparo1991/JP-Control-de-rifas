using CapaPresentacion.CEntidades;
using CEntidades;
using CNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._pagos
{
    public partial class Frm_pagos_abonos : Form
    {
        public Frm_pagos_abonos()
        {
            InitializeComponent();
            _helpers.Disenios.dataGridView(dgv_vendedores);
            _helpers.Disenios.dataGridView(Dgv_nuevos_pagos);
            _helpers.Disenios.dataGridView(Dgv_pagos);
            _helpers.Disenios.dataGridView(Dgv_detalle_pagos_realizados);
            habilitarBotonoes(false);
            obtenerDatosUsuarioConectado();
            disenioTablas();
            //disenioTablasBoletasSaldar();
            //mostrarPagos();
        }

        DataTable dtDetallePagos = new DataTable();

        #region Metodos

        private void mostrarPagos()
        {
            try
            {
                List<Pagos> pagos = N_Pagos.mostrarPagos().FindAll(
                    x => x.FechaPago >= Convert.ToDateTime(dt_fecha_ini_pago.Text) &&
                        x.FechaPago <= Convert.ToDateTime(dt_fecha_fin_pago.Text)
                    );
                Dgv_pagos.DataSource = pagos;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void mostrarDetallePagos(int pagoId)
        {
            try
            {
                List<DtoMostrarDetallePagos> pagos = N_Pagos.mostrarDetallePagos().FindAll(x => x.PagoId==pagoId);
                Dgv_detalle_pagos_realizados.DataSource = pagos;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void disenioTablas()
        {
            dtDetallePagos = new DataTable();

            dtDetallePagos.Columns.Add("pago_id",typeof(int));
            dtDetallePagos.Columns.Add("vendedor_id",typeof(int));
            dtDetallePagos.Columns.Add("nombre_vendedor",typeof(string));
            dtDetallePagos.Columns.Add("valor_pagado",typeof(decimal));
            dtDetallePagos.Columns.Add("forma_pago",typeof(string));
            dtDetallePagos.Columns.Add("periodo_pagado",typeof(string));

            Dgv_nuevos_pagos.DataSource = dtDetallePagos;
            Dgv_nuevos_pagos.Refresh();
            dtDetallePagos.AcceptChanges();

        }

        private void agregarDetallesPagos(int pagoId)
        {
            DataRow row = dtDetallePagos.NewRow();
            row["pago_id"] = pagoId.ToString();
            row["vendedor_id"] = Txt_vendedor_id.Text.Trim();
            row["nombre_vendedor"] = txt_vendedor.Text.Trim();
            row["valor_pagado"] = txt_valor_pagar.Text.Trim();
            row["forma_pago"] = cbx_forma_pago.Text.Trim();
            row["periodo_pagado"] = $"pagado del {dt_fecha_ini.Text} al {dt_fecha_fin.Text}".Trim();
          
            dtDetallePagos.Rows.Add(row);
            Dgv_nuevos_pagos.DataSource = dtDetallePagos;
            Dgv_nuevos_pagos.Refresh();
            dtDetallePagos.AcceptChanges();
            calcularTotal();
            DataTable dt2 = N_Boletas.obtenerBoletasEntreFechasAndVendedor(
                Convert.ToInt32(Txt_vendedor_id.Text.Trim()),
                Convert.ToDateTime(dt_fecha_ini.Value),
                Convert.ToDateTime(dt_fecha_fin.Value),
                txt_identificador.Text.Trim()
                );
            Txt_nro_doc.Text = string.Empty;
            Txt_vendedor_id.Text = "0";
            txt_valor_pagar.Text = string.Empty;
            Txt_nro_doc.Select();
        }

        private void buscarVendedor()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_nro_doc.Text))
                {
                    Pn_listado_vendedores.Visible = false;
                    txt_vendedor.Text = string.Empty;
                    txt_valor_pagar.Text = "0";
                    Txt_vendedor_id.Text = "0";
                    return;
                }
                List<Usuarios> usuario = N_Usuarios.mostrarUsuarios().FindAll(
                    x => x.NroDoc.ToLower().Contains(Txt_nro_doc.Text.Trim().ToLower()));

                Usuarios usuarioFind = N_Usuarios.mostrarUsuarios().Find(
                    x => x.NroDoc.ToLower().Contains(Txt_nro_doc.Text.Trim().ToLower()));

                if (usuarioFind != null)
                {

                    Txt_vendedor_id.Text = usuarioFind.Id.ToString().Trim();
                    txt_vendedor.Text = usuarioFind.NombreCompleto;

                    obtenerDatosAbono();
                }

                dgv_vendedores.DataSource = usuario;

                if (dgv_vendedores.Rows.Count > 0)
                {
                    Pn_listado_vendedores.Location = Lbl_punto_1.Location;
                    Pn_listado_vendedores.Visible = true;
                    Pn_listado_vendedores.BringToFront();
                }
                else
                {
                    Pn_listado_vendedores.Visible = false;
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void obtenerDatosAbono()
        {
            try
            {
                DataTable dt = N_Boletas.consultarAbonosEntreFechasAndVendedor(
                       Convert.ToInt32(Txt_vendedor_id.Text.Trim()),
                       Convert.ToDateTime(dt_fecha_ini.Value),
                       Convert.ToDateTime(dt_fecha_fin.Value));




                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToInt32(Txt_vendedor_id.Text.Trim()) > 0)
                    {
                        txt_valor_pagar.Text = dt.Rows[0]["total_abono"].ToString();
                    }
                    else
                    {
                        txt_valor_pagar.Text = "0";
                    }
                }
                else
                {
                    txt_valor_pagar.Text = "0";
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
            cbx_forma_pago.SelectedIndex = 0;
            txt_descripcion.Text = string.Empty;
            dt_fecha_ini.Select();
        }
        
        private void calcularTotal()
        {
            decimal valor = 0;
            for(int i=0; i < Dgv_nuevos_pagos.Rows.Count; i++)
            {
                valor += Convert.ToDecimal(Dgv_nuevos_pagos.Rows[i].Cells["valor_pagado"].Value.ToString());
            }
            txt_total.Text = valor.ToString();
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
                obtenerDatosAbono();
                Pn_listado_vendedores.Visible = false;
            }
        }

        private void Dgv_nuevos_pagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pn_listado_vendedores.Visible = false;

            if(Dgv_nuevos_pagos.Rows.Count > 0)
            {
                if(Dgv_nuevos_pagos.Columns[e.ColumnIndex].Name == "btn_quitar")
                {
                    Dgv_nuevos_pagos.Rows.Remove(Dgv_nuevos_pagos.CurrentRow);
                }
            }

            calcularTotal();
        }

        private void Lbl_cerrar_Click(object sender, EventArgs e)
        {
            Pn_listado_vendedores.Visible = false;
        }

        private void btn_agregar_pago_Click(object sender, EventArgs e)
        {
            bool existe = false;

            foreach (DataGridViewRow rows in Dgv_nuevos_pagos.Rows) {
            
                if(Convert.ToInt32(rows.Cells["vendedor_id"].Value.ToString()) == Convert.ToInt32(Txt_vendedor_id.Text.Trim()))
                {
                    existe = true;
                    break;
                }
            
            }
            
            if(existe == true)
            {
                _helpers.Mensajes.mensajeAdvertencia("Este vendedor ya fue agregado");
                return;
            }

            if (string.IsNullOrEmpty(Txt_vendedor_id.Text))
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un vendedor");
                return;
            }

            if (Convert.ToInt32(Txt_vendedor_id.Text) <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un vendedor");
                return;
            }

            if (Convert.ToDecimal(txt_valor_pagar.Text) <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Este vendedor no tiene abonos por pagar en este rango de fecha");
                return;
            }
            DateTime fechaIni = Convert.ToDateTime(dt_fecha_ini.Text);
            DateTime fechaFIn = Convert.ToDateTime(dt_fecha_fin.Text);
            int result = DateTime.Compare(fechaIni,fechaFIn);
            if (result > 0 )
            {
                _helpers.Mensajes.mensajeAdvertencia("Tienes un error con la fecha, la fecha de inicio no puede ser mayor a la fecha de fin");
                return;
            }


            try
            {
               

                

                agregarDetallesPagos(0);
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }

        }

        private void Btn_registrar_pago_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_total.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El total a pagar no es valido");
                    return;
                }

                if (Convert.ToDecimal(txt_total.Text) <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("No puedes hacer pagos a valor CERO");
                    return;
                }

                if(Dgv_nuevos_pagos.Rows.Count <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar vendedores para realizar el pago");
                    return;
                }

                if (dtDetallePagos.Rows.Count <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar vendedores para realizar el pago");
                    return;
                }

                DateTime fechaIni = Convert.ToDateTime(dt_fecha_ini.Text);
                DateTime fechaFIn = Convert.ToDateTime(dt_fecha_fin.Text);
                int result = DateTime.Compare(fechaIni, fechaFIn);

                if (result > 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Tienes un error con la fecha, la fecha de inicio no puede ser mayor a la fecha de fin");
                    return;
                }

                Pagos obj = new Pagos()
                {
                    UsuarioId = Convert.ToInt32(txt_usuario_id.Text.Trim()),
                    Identificador = txt_identificador.Text.Trim(),
                    FechaPago = Convert.ToDateTime(txt_fecha.Text.Trim()),
                    HoraPago = Convert.ToDateTime(txt_hora.Text.Trim()),
                    PeriodoPagado = $"pagado del {dt_fecha_ini.Value} al {dt_fecha_fin.Value}".Trim(),
                    ValorPagos = Convert.ToDecimal(txt_total.Text.Trim()),
                    Descripcion = txt_descripcion.Text.Trim(),

                };

                DialogResult dialog = MessageBox.Show("Seguro que la informacion a ingresar es correcta, si asi lo es puedes proceder a guardar, valida antes de guardar, no podras modificar un pago despues de guardarlo", "Confirmacion pago de abonos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    if (N_Pagos.registrarPagos(obj, dtDetallePagos))
                    {
                        limpiar();
                        mostrarPagos();
                        dtDetallePagos.Rows.Clear();
                    }


                }



            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException2(ex);
            }
        }

        private void dt_fecha_ini_pago_ValueChanged(object sender, EventArgs e)
        {
            mostrarPagos();
        }

        private void dt_fecha_fin_pago_ValueChanged(object sender, EventArgs e)
        {
            mostrarPagos();
        }

        private void Dgv_pagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Dgv_pagos.Rows.Count > 0)
            {
                int _pagoId = Convert.ToInt32(Dgv_pagos.CurrentRow.Cells["p_id"].Value.ToString());
                mostrarDetallePagos(_pagoId);
            }
        }

        private void Dgv_pagos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_pagos.Rows.Count > 0)
            {
                int _pagoId = Convert.ToInt32(Dgv_pagos.CurrentRow.Cells["p_id"].Value.ToString());
                mostrarDetallePagos(_pagoId);
            }
        }
    }
}
