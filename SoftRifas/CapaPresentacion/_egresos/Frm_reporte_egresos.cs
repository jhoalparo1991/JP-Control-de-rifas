using Domain;
using Entities;
using ReportsModule._rdls;
using System;
using System.Windows.Forms;

namespace CapaPresentacion._egresos
{
    public partial class Frm_reporte_egresos : Form
    {
        public Frm_reporte_egresos()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        internal int gastoId = 0;

        public void mostrarGasto()
        {
            try
            {

                DtoMostarGastos dt = N_Gastos.mostrarGastos().Find(x => x.Id == gastoId);

                RptMostrarEgresosPorFecha rpt = new RptMostrarEgresosPorFecha();

                rpt.table1.DataSource = dt;
                rpt.txtFechaIni.Value = dt.Fecha.ToString();
                rpt.txtFechaFin.Value = dt.Fecha.ToString();
                rpt.Txt_total_abono.Value = dt.Valor.ToString();

                reportViewer1.Report = rpt;

                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema");
            }
        }
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Cierra reporte de gastos");
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }

        private void Frm_reporte_egresos_Load(object sender, EventArgs e)
        {
            _helpers.Sesion.guardarDatosLog("Se carga el reporte de gastos");
        }
    }
}
