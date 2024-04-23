using Domain;
using Entities;
using ReportsModule._rdls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Telerik.Reporting;

namespace CapaPresentacion
{
    public partial class Frm_reports_menu : Form
    {
        public Frm_reports_menu()
        {
            InitializeComponent();
            cargarEstadosBoletas();
            mostrarRifas();
            mostrarVendedores(cbx_vendedor);
            mostrarVendedores(Cbx_vendedor_01);
        }
        private void mostrarVendedores(ComboBox cbx)
        {
            try
            {
                DataTable dt = new DataTable();
                N_Usuarios.mostrarVendedores(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = "nombre_completo".ToString();
                cbx.ValueMember = "id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Aviso del sistema");
            }
        }

        private void mostrarRifas()
        {
            try
            {
                List<Rifas> rifas = N_Rifas.mostrarRifas();
                cbx_rifa.DataSource = rifas;
                cbx_rifa.DisplayMember = "descripcion";
                cbx_rifa.ValueMember = "id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Aviso del sistema");
            }
        }

        private void cargarEstadosBoletas()
        {
            try
            {

                DataTable dt = N_Reports.ObtenerEstadosBoletas();
                RptEstadosBoletas rpt = new RptEstadosBoletas();
                SubReport subReport1 = new SubReport();
                InstanceReportSource instance = new InstanceReportSource();
                instance.ReportDocument = rpt;
                rpt.table1.DataSource = dt;
                reportViewer1.ReportSource = instance;
                reportViewer1.RefreshReport();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Aviso del sistema");
            }
        }

        private void mostrarBoletasPorNro()
        {
            try
            {

                int nroBoleta = Convert.ToInt32(Txt_nro_boleta.Text.Trim());
                DataTable dt = N_Reports.mostrarAbonosPorBoleta(nroBoleta.ToString("D4"));

                decimal _totalAbonos = 0;
                decimal _totalComision = 0;
                foreach (DataRow row in dt.Rows)
                {
                    _totalAbonos += Convert.ToDecimal(row["abonos"].ToString());
                    _totalComision += Convert.ToDecimal(row["valor_comision"].ToString());
                }

                RptMostrarAbonos rpt = new RptMostrarAbonos();
                rpt.table1.DataSource = dt;
                rpt.Txt_total_abono.Value = _totalAbonos.ToString();
                rpt.Txt_total_comision.Value = _totalComision.ToString();
                reportViewer2.Report = rpt;
                reportViewer2.RefreshReport();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Aviso del sistema");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nro_boleta.Text.Trim()))
            {
                MessageBox.Show("Debes ingresar el número de la boleta");
                return;
            }

            mostrarBoletasPorNro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarboletasVendidasPorVendedores();
                RptVendidasPorVendedores rpt = new RptVendidasPorVendedores();
                //rpt.DataSource = dt;

                int totalVendidas = 0;
                foreach(DataRow row in dt.Rows)
                {
                    totalVendidas += Convert.ToInt32(row["contar"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.Txt_total_vendidas.Value = totalVendidas.ToString();
                reportViewer3.Report = rpt;
                
                reportViewer3.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarReporteFormasPago(dateTimePicker1.Value,dateTimePicker2.Value,
                    Convert.ToInt32(cbx_rifa.SelectedValue));
                RptMostrarAbonosPorFormasDePago rpt = new RptMostrarAbonosPorFormasDePago();
               // rpt.DataSource = dt;

                decimal totalVendidas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalVendidas += Convert.ToDecimal(row["total_abonos"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.Txt_total_vendidas.Value = totalVendidas.ToString();
                reportViewer4.Report = rpt;

                reportViewer4.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarAbonosFechaValor(dateTimePicker3.Value, dateTimePicker4.Value,
                    Convert.ToDecimal(textBox1.Text.Trim()));
                RptAbonosFechaMonto rpt = new RptAbonosFechaMonto();

                decimal totalVendidas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalVendidas += Convert.ToDecimal(row["valor"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.textBox11.Value = totalVendidas.ToString();
                reportViewer5.Report = rpt;
                reportViewer5.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarPagos(dateTimePicker5.Value, dateTimePicker6.Value);
                RptPagosRealizados rpt = new RptPagosRealizados();

                decimal totalVendidas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalVendidas += Convert.ToDecimal(row["valor_pagos"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.textBox11.Value = totalVendidas.ToString();
                rpt.txt_fecha_ini.Value = dateTimePicker5.Value.ToShortDateString();
                rpt.Txt_fecha_fin.Value = dateTimePicker6.Value.ToShortDateString();
                reportViewer6.Report = rpt;
                reportViewer6.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarDetallePagoComisiones(dateTimePicker7.Value, dateTimePicker8.Value);
                RptPagoComisiones rpt = new RptPagoComisiones();

                decimal totalVendidas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalVendidas += Convert.ToDecimal(row["valor_pagado"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.textBox11.Value = totalVendidas.ToString();
                rpt.txt_fecha_ini.Value = dateTimePicker5.Value.ToShortDateString();
                rpt.Txt_fecha_fin.Value = dateTimePicker6.Value.ToShortDateString();
                reportViewer7.Report = rpt;
                reportViewer7.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarAbonos();
                RptMostrarTodosAbonos rpt = new RptMostrarTodosAbonos();

                decimal totalAbonos = 0;
                decimal totalComisiones= 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalAbonos += Convert.ToDecimal(row["abonos"].ToString());
                    totalComisiones += Convert.ToDecimal(row["valor_comision"].ToString());
                }
                rpt.table1.DataSource = dt;
                rpt.txt_abonos.Value = totalAbonos.ToString();
                rpt.txt_comisiones.Value = totalComisiones.ToString();
                reportViewer8.Report = rpt;
                reportViewer8.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarPagoComisionesPorVendedores(Convert.ToInt32(cbx_vendedor.SelectedValue));
                RptMostrarComisionesVendedores rpt = new RptMostrarComisionesVendedores();
             
                rpt.table1.DataSource = dt;
                reportViewer9.Report = rpt;
                reportViewer9.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarAbonosComisionesPorVendedores(dateTimePicker9.Value, dateTimePicker10.Value,
                    Convert.ToInt32(Cbx_vendedor_01.SelectedValue));
               
                RptMostrarComisionAbonosPorVendedores rpt = new RptMostrarComisionAbonosPorVendedores();

                decimal totalAbonos = 0;
                decimal totalComisiones = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalAbonos += Convert.ToDecimal(row["valor_abono"].ToString());
                    totalComisiones += Convert.ToDecimal(row["valor_comision"].ToString());
                }

                rpt.table1.DataSource = dt;
                rpt.txtVendedor.Value = Cbx_vendedor_01.Text.ToString().ToUpper();
                rpt.txtFechaIni.Value = dateTimePicker9.Text.ToString();
                rpt.txtFechaFin.Value = dateTimePicker10.Text.ToString();
                rpt.Txt_total_abono.Value = totalAbonos.ToString();
                rpt.Txt_total_comision.Value = totalComisiones.ToString();

                reportViewer10.Report = rpt;

                reportViewer10.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaIni = Convert.ToDateTime(dateTimePicker11.Text);
                DateTime fechaFin= Convert.ToDateTime(dateTimePicker12.Text);

                List<DtoMostarGastos> dt = N_Gastos.mostrarGastos()
                    .FindAll( x => x.Fecha >= fechaIni && x.Fecha <= fechaFin);

                RptMostrarEgresosPorFecha rpt = new RptMostrarEgresosPorFecha();

                decimal total = 0;
                foreach (var row in dt)
                {
                    total += row.Valor;
                }

                rpt.table1.DataSource = dt;
                rpt.txtFechaIni.Value = dateTimePicker11.Text.ToString();
                rpt.txtFechaFin.Value = dateTimePicker12.Text.ToString();
                rpt.Txt_total_abono.Value = total.ToString();

                reportViewer11.Report = rpt;

                reportViewer11.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = N_Reports.mostrarReporteCaja(dateTimePicker13.Value);

                RptMostrarReporteCajaDiario rpt = new RptMostrarReporteCajaDiario();

                rpt.table1.DataSource = dt;

                decimal total = 0;
                decimal _abonos = 0;
                decimal _comisionPagada = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["valor"].ToString());
                    rpt.txtFecha.Value = dateTimePicker13.Text.ToString();
                    rpt.txtTotalFp.Value = total.ToString("C2");
                    rpt.txtAbonos.Value = Convert.ToDecimal(row["total_abonos"]).ToString("C2");
                    _abonos = Convert.ToDecimal(row["total_abonos"]);
                    _comisionPagada = Convert.ToDecimal(row["total_comision_pagada"]);
                    rpt.txtTotalComisiones.Value = Convert.ToDecimal(row["total_comisiones"]).ToString("C2");
                    rpt.txtComisionesPagada.Value = Convert.ToDecimal(row["total_comision_pagada"]).ToString("C2");
                }

                rpt.Txt_total.Value = (_abonos - _comisionPagada).ToString("C2");
                rpt.txtTotalFp.Value = total.ToString("C2");
                reportViewer12.Report = rpt;

                reportViewer12.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }
    }
}
