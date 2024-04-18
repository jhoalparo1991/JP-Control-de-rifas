using CNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._reportes._cajas
{
    public partial class ReporteCajaPorDia : UserControl
    {
        public ReporteCajaPorDia()
        {
            InitializeComponent();
            panelInfo.Visible = true;
            panelInfo.Dock = DockStyle.Fill;
            panelReporte.Visible = false;
        }

        private void cargarReportes()
        {
            try
            {
                DateTime fechaIni = Convert.ToDateTime(dateTimePicker3.Text);
                DateTime fechaFIn = Convert.ToDateTime(dateTimePicker4.Text);

                decimal totalAbonos = 0;
                decimal totalComisiones = 0;
                decimal totalComisionesDia = 0;

                N_Reportes.mostrarAbonosFecha(ref totalAbonos, fechaIni, fechaFIn);
                N_Reportes.mostrarComisionesPagadaFecha(ref totalComisiones, fechaIni, fechaFIn);
                N_Reportes.mostrarComisionesDeldia(ref totalComisionesDia, fechaIni, fechaFIn);

                txt_abonos.Text = totalAbonos.ToString("C2");
                txt_comisiones_pagada.Text = totalComisiones.ToString("C2");
                txt_comisiones_dia.Text = totalComisionesDia.ToString("C2");

                DataTable dtAbonosFecha =  N_Reportes.mostrarAbonosPorFormasPago(fechaIni,fechaFIn);
                dataGridView1.DataSource = dtAbonosFecha;   

            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            cargarReportes();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            panelReporte.Visible = false;
            panelInfo.Visible = true;
            panelInfo.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panelReporte.Visible = true;
                panelReporte.Dock = DockStyle.Fill;
                panelInfo.Visible = false;

                ReportParameter parAbonosDias = new ReportParameter("AbonosDia", txt_abonos.Text.Trim());
                ReportParameter parComisionesDia = new ReportParameter("Comisiones", txt_comisiones_dia.Text.Trim());
                ReportParameter parComisionesPagada = new ReportParameter("ComisionesPagada", txt_comisiones_dia.Text.Trim());
                ReportParameter parFormasPago = new ReportParameter("formasPago", txt_comisiones_dia.Text.Trim());

                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parAbonosDias, parComisionesDia, parComisionesPagada });
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
    }
}
