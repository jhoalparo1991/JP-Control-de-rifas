using Domain;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._pagos_comisiones
{
    public partial class Frm_pago_comisiones : Form
    {
        public Frm_pago_comisiones()
        {
            InitializeComponent();
            _helpers.Sesion.guardarDatosLog("PAGO COMISIONES");
            mostrarDatosSesion();
            mostrarVendedores();
            mostrarAbonosBoletaPorVendedores();
        }

        int _vendedorId = 0;
        int _boletaId = 0;
        int _abonoId = 0;
        int _clienteId = 0;
        decimal _valorPagado = 0;

        private void mostrarDatosSesion()
        {
            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();
                if (sesion != null)
                {
                    UsuariosPermisos permiso = _helpers.Sesion.permisosUsuarios(sesion.UsuarioId);

                    if (permiso != null)
                    {
                        btnReportes.Visible = permiso.Reportes;
                        btnPagarTodos.Visible = permiso.PagoComisiones;

                    }
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void mostrarVendedores()
        {
            try
            {
                DataTable dt = new DataTable();
                N_Usuarios.mostrarVendedores(dt);
                cbxVendedores.DataSource = dt;
                cbxVendedores.DisplayMember = "nombre_completo";
                cbxVendedores.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeAdvertencia(e.Message);
            }
        }

        private void registrarPagoComision()
        {
            try
            {
                N_Pagos.sp_pagar_comision_vendedor(_vendedorId, _clienteId, _boletaId, _abonoId, _valorPagado);
            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeAdvertencia(e.Message);
            }
        }

        private void borrarPagoComisionVendedor()
        {
            try
            {
                N_Pagos.borrar_pago_comision_vendedor(_vendedorId, _clienteId, _boletaId, _abonoId);
            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeAdvertencia(e.Message);
            }
        }

        private void mostrarAbonosBoletaPorVendedores()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = N_Boletas.mostrarAbonosBoletaPorVendedor(_vendedorId, dtFechaIni.Value, dtFechaFinal.Value);
                dgvAbonosBoleta.DataSource = dt;

                txtNroAbonos.Text = dgvAbonosBoleta.Rows.Count.ToString();
                decimal _totalComision = 0;
                decimal _totalPagado = 0;
                decimal _totalPendiente = 0;
                decimal _totalAbono = 0;

                for (int i = 0; i < dgvAbonosBoleta.Rows.Count; i++)
                {
                    _totalComision += Convert.ToDecimal(dgvAbonosBoleta.Rows[i].Cells["valor_comision"].Value.ToString());
                    _totalAbono += Convert.ToDecimal(dgvAbonosBoleta.Rows[i].Cells["valor_abono"].Value.ToString());
                    if (dgvAbonosBoleta.Rows[i].Cells["abono_pagado"].Value.ToString() == "Si")
                    {
                        _totalPagado += Convert.ToDecimal(dgvAbonosBoleta.Rows[i].Cells["valor_comision"].Value.ToString());
                    }
                    else
                    {
                        _totalPendiente += Convert.ToDecimal(dgvAbonosBoleta.Rows[i].Cells["valor_comision"].Value.ToString());

                    }
                }



                txttotalComision.Text = _totalComision.ToString("C2");
                txtTotalComisionPagada.Text = _totalPagado.ToString("C2");
                txtTotalComisionPendiente.Text = _totalPendiente.ToString("C2");
                txtTotalAbonos.Text = _totalAbono.ToString("C2");
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeAdvertencia(e.Message);
            }
        }

        private void cbxVendedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _vendedorId = Convert.ToInt32(cbxVendedores.SelectedValue);
            mostrarAbonosBoletaPorVendedores();
        }

        private void dgvAbonosBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAbonosBoleta.Rows.Count <= 0) return;

            if (dgvAbonosBoleta.Columns[e.ColumnIndex].Name == "abono_pagado")
            {
                string abonoPagado = dgvAbonosBoleta.CurrentRow.Cells["abono_pagado"].Value.ToString().Trim();
                _boletaId = Convert.ToInt32(dgvAbonosBoleta.CurrentRow.Cells["boleta_id"].Value.ToString());
                _abonoId = Convert.ToInt32(dgvAbonosBoleta.CurrentRow.Cells["id"].Value.ToString());
                _clienteId = Convert.ToInt32(dgvAbonosBoleta.CurrentRow.Cells["cliente_id"].Value.ToString());
                _valorPagado = Convert.ToDecimal(dgvAbonosBoleta.CurrentRow.Cells["valor_comision"].Value.ToString());

                if (abonoPagado == "Si")
                {
                    DialogResult dialog = MessageBox.Show("Estas seguro que deseas reversar el pago de esta comision", "Mensaje de confirmacion",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dialog == DialogResult.OK)
                    {
                        borrarPagoComisionVendedor();
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada", "Aviso del sistema");
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Estas seguro que deseas pagara esta comision", "Mensaje de confirmacion",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dialog == DialogResult.OK)
                    {
                        registrarPagoComision();
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada", "Aviso del sistema");
                    }
                }
                mostrarAbonosBoletaPorVendedores();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("PAGO COMISIONES - Reportes");
            int _nroAbonos = Convert.ToInt32(txtNroAbonos.Text.Trim());
            Frm_reporte_pagos_comision frm = new Frm_reporte_pagos_comision();
            frm.mostrarInformacionComisionesVendedor(
                txtNroAbonos.Text.Trim(),
                txttotalComision.Text.Trim(),
                txtTotalComisionPagada.Text.Trim(),
                txtTotalComisionPendiente.Text.Trim(),
                cbxVendedores.Text, dtFechaIni.Text, dtFechaFinal.Text);


            frm.mostrarTotalAbonos(_vendedorId, cbxVendedores.Text, dtFechaIni.Value, dtFechaFinal.Value);
            frm.ShowDialog();
        }

        private void dtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            mostrarAbonosBoletaPorVendedores();
        }

        private void dtFechaIni_ValueChanged(object sender, EventArgs e)
        {
            mostrarAbonosBoletaPorVendedores();
        }

        private void btnPagarTodos_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("PAGO COMISIONES - pagar todos");
            if (dgvAbonosBoleta.Rows.Count <= 0)
            {
                MessageBox.Show("Debes tener registros disponibles");
                return;
            }

            try
            {
                DialogResult dialog = MessageBox.Show("Deseas hacer un pago de comision en bloque, estas seguro?",
                    "Mensaje de confirmacion", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    int vendedorId = Convert.ToInt32(cbxVendedores.SelectedValue);
                    N_Pagos.sp_pagar_comision_vendedor_por_fecha(vendedorId, dtFechaIni.Value, dtFechaFinal.Value);
                    mostrarAbonosBoletaPorVendedores();
                    _helpers.Sesion.guardarDatosLog("PAGO COMISIONES - Pagos realizados de manera exitosa");
                    MessageBox.Show("Pagos realizados de manera exitosa", "Aviso del sistema");
                }
                else
                {
                    _helpers.Mensajes.mensajeError("Operacion cancelada");
                }
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
    }
}
