using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._reportes
{
    public partial class Frm_reporte_boletas_vendedor : Form
    {
        public Frm_reporte_boletas_vendedor()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_reporte_boletas_vendedor_Load(object sender, EventArgs e)
        {

            this.sp_mostrar_abonosTableAdapter.Fill(this.dataSet1.sp_mostrar_abonos,Convert.ToInt32(Txt_boleta_id.Text.Trim()));
            this.reportViewer1.RefreshReport();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
