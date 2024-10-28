using Domain;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion._pagos_comisiones
{
    public partial class Frm_reporte_pagos_comision : Form
    {
        public Frm_reporte_pagos_comision()
        {
            InitializeComponent();
            _helpers.Sesion.guardarDatosLog("RPORTE PAGO COMISIONES");
        }


        private void Frm_reporte_pagos_comision_Load(object sender, EventArgs e)
        {
            mostrarVendedores();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
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
                MessageBox.Show(e.Message, "Aviso del sistema");
            }
        }

        public void mostrarInformacionComisionesVendedor(string nroAbonos, string totalComision, string totalPagado, string totalComisionPendiete, string vendedor, string fechaIni, string fechaFin)
        {
            try
            {

                rptInfoPagoComisiones rpt = new rptInfoPagoComisiones();
                //rpt.DataSource = dt;

                //rpt.table1.DataSource = dt;
                rpt.txtVendedor.Value = vendedor;
                rpt.txtTotalComisionPendiente.Value = totalComisionPendiete;
                rpt.txtTotalComision.Value = totalComision;
                rpt.txtTotalComisionPagada.Value = totalPagado;
                rpt.Txt_fecha_ini.Value = fechaIni;
                rpt.Txt_fecha_fin.Value = fechaFin;
                rpt.txtNroAbonos.Value = nroAbonos.ToString();
                reportViewer1.Report = rpt;

                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        public void mostrarTotalAbonos(int _vendedorId, string vendedor, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = N_Boletas.mostrarAbonosBoletaPorVendedor(_vendedorId, fechaIni, fechaFin);
                rptInfoAbonos rpt = new rptInfoAbonos();
                //rpt.DataSource = dt;

                rpt.table1.DataSource = dt;
                rpt.txtVendedor.Value = vendedor;
                reportViewer2.Report = rpt;
                rpt.Txt_fecha_ini.Value = fechaIni.ToString();
                rpt.Txt_fecha_fin.Value = fechaFin.ToString();
                reportViewer2.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("RPORTE PAGO COMISIONES - comisiones por vendedores");
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            int _vendedorId = Convert.ToInt32(cbxVendedores.SelectedValue);

            DataTable dt = N_Pagos.mostrarPagoComisionPorVendedor(_vendedorId, fecha1, fecha2);

            rptListadoComisionPagada rpt = new rptListadoComisionPagada();
            //rpt.DataSource = dt;
            rpt.txtVendedor.Value = cbxVendedores.Text.Trim().ToUpper();
            rpt.txtFecha1.Value = fecha1.ToShortDateString();
            rpt.txtFecha2.Value = fecha2.ToShortDateString();
            rpt.table1.DataSource = dt;
            reportViewer3.Report = rpt;
            reportViewer3.RefreshReport();
        }
    }
}
