using CapaPresentacion._reportes._cajas;
using CEntidades;
using CNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._reportes
{
    public partial class Frm_reportes : Form
    {
        public Frm_reportes()
        {
            InitializeComponent();
            mostrarRifas();
            mostrarRifas2();
            mostrarVendedores();
            cargarReporteCaja();
        }

        private void cargarReporteCaja()
        {
            panel10.Controls.Clear();
            ReporteCajaPorDia rpt = new ReporteCajaPorDia();
            rpt.Dock = DockStyle.Fill;
            panel10.Controls.Add(rpt);
        }
        private void mostrarVendedores()
        {
            try
            {
                DataTable dt = new DataTable();
                N_Usuarios.mostrarVendedores(dt);
                Cbx_vendedores.DataSource = dt;
                Cbx_vendedores.DisplayMember = "nombre_completo".ToString();
                Cbx_vendedores.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeInformacion(e.Message);
            }
        }
        private void mostrarRifas()
        {
            try
            {
              List<Rifas> rifas =  N_Rifas.mostrarRifas();
                Cbx_rifas.DataSource = rifas;
                Cbx_rifas.DisplayMember = "descripcion";
                Cbx_rifas.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void mostrarRifas2()
        {
            try
            {
                List<Rifas> rifas = N_Rifas.mostrarRifas();
                Cbx_rifas_2.DataSource = rifas;
                Cbx_rifas_2.DisplayMember = "descripcion";
                Cbx_rifas_2.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void Frm_reportes_Load(object sender, EventArgs e)
        {
            this.sp_reporte_boletas_por_estadosTableAdapter.Fill(this.dataSet1.sp_reporte_boletas_por_estados);

            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();

        }
        
        private void Btn_reporte_formas_pago_Click(object sender, EventArgs e)
        {

            try
            {
                 this.sp_mostrar_reporte_formas_pagoTableAdapter.Fill(this.dataSet1.sp_mostrar_reporte_formas_pago, dt_fecha_ini_2.Value, dt_fecha_fin_2.Value, Convert.ToInt32(Cbx_rifas_2.SelectedValue));
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeAdvertencia(ex.Message);
            }
        }

        private void Txt_nro_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_reporte_abonos_por_boletaTableAdapter.Fill(this.dataSet1.sp_reporte_abonos_por_boleta,Txt_nro_boleta.Text.Trim());
                this.reportViewer2.RefreshReport();

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeAdvertencia(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.mostrar_cantidad_boletas_vendida_por_vendedoresTableAdapter.Fill(this.dataSet1.mostrar_cantidad_boletas_vendida_por_vendedores);
                this.reportViewer4.RefreshReport();
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeAdvertencia(ex.Message);
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.mostrar_todos_los_abonosTableAdapter.Fill(this.dataSet1.mostrar_todos_los_abonos);
                this.reportViewer5.RefreshReport();
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeAdvertencia(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_monto.Text.Trim()))
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes ingresar un monto para hacer el filtro");
                Txt_monto.Select();
                return;
            }

            ReportParameter rpFechaIni = new ReportParameter("Fecha_ini",dt_fecha_ini.Value.ToShortDateString());
            ReportParameter rpFechaFIn = new ReportParameter("Fecha_fin",dt_fecha_fin.Value.ToShortDateString());
            ReportParameter rpMonto = new ReportParameter("Monto",Txt_monto.Text.Trim());

            this.reportViewer6.LocalReport.SetParameters(new ReportParameter[] { rpFechaIni,rpFechaFIn,rpMonto });

            this.sp_reporte_abonos_fecha_montoTableAdapter.Fill(this.dataSet1.sp_reporte_abonos_fecha_monto,
                Convert.ToDecimal(Txt_monto.Text.Trim()),dt_fecha_ini.Value, dt_fecha_fin.Value);
            this.reportViewer6.RefreshReport();

        }

        private void Txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.sp_reporte_pagosTableAdapter.Fill(this.dataSet1.sp_reporte_pagos, dt_pagos_1.Value, dt_pagos_2.Value);
            this.reportViewer7.RefreshReport();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.sp_reporte_detalle_pago_comisionesTableAdapter.Fill(this.dataSet1.sp_reporte_detalle_pago_comisiones, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer8.RefreshReport();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.sp_reporte_detalle_pago_comisiones_vendedoresTableAdapter.Fill(this.dataSet1.sp_reporte_detalle_pago_comisiones_vendedores, Convert.ToInt32(Cbx_vendedores.SelectedValue));
            this.reportViewer9.RefreshReport();

        }
    }
}
