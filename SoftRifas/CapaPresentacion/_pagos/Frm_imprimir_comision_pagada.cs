using Domain;
using ReportsModule._rdls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._pagos
{
    public partial class Frm_imprimir_comision_pagada : Form
    {
        public Frm_imprimir_comision_pagada()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            mostrarReporteDetallePago();
        }
        internal int id = 0;
        internal int vendedorId = 0;
        public void mostrarReporteDetallePago()
        {
            try
            {
                DataTable dt = N_Reports.mostrarPagoComisionesPorVendedoresIdDetallePago(id);
                DataTable dtDetalle = N_Pagos.mostrarDetallePagado(id,vendedorId);
                RptMostrarComisionesVendedores2 rpt = new RptMostrarComisionesVendedores2();

                if(dt.Rows.Count <= 0)
                {
                    return;
                }

                decimal _total = 0;

                foreach(DataRow row in dtDetalle.Rows)
                {
                    _total += Convert.ToDecimal(row["valor_comision"]);
                }

                rpt.txtTotalValorAcumulado.Value = _total.ToString("C2");
                rpt.txtVendedor.Value = dt.Rows[0]["nombre_vendedor"].ToString(); 
                rpt.txtFormaDePago.Value = dt.Rows[0]["forma_pago"].ToString(); 
                rpt.txtValorPagado.Value = dt.Rows[0]["valor_pagado"].ToString(); 
                rpt.txtFechaDePago.Value = dt.Rows[0]["fecha_pago"].ToString(); 

                rpt.table2.DataSource = dtDetalle;
                reportViewer1.Report = rpt;
                reportViewer1.RefreshReport();
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }
    }
}
