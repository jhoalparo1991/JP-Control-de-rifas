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
        }

        private void Frm_reporte_pagos_comision_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        public void mostrarInformacionComisionesVendedor(string nroAbonos,string totalComision,string totalPagado,string totalComisionPendiete,string vendedor)
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
                rpt.txtNroAbonos.Value = nroAbonos.ToString();
                reportViewer1.Report = rpt;

                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }

        public void mostrarTotalAbonos( int _vendedorId, string vendedor)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = N_Boletas.mostrarAbonosBoletaPorVendedor(_vendedorId);
                rptInfoAbonos  rpt = new rptInfoAbonos();
                //rpt.DataSource = dt;

                rpt.table1.DataSource = dt;
                rpt.txtVendedor.Value = vendedor;
                reportViewer2.Report = rpt;

                reportViewer2.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }
    }
}
