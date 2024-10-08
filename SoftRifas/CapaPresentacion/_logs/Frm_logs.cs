using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._logs
{
    public partial class Frm_logs : Form
    {
        public Frm_logs()
        {
            InitializeComponent();
            _helpers.Disenios.dataGridView(dataGridView1);
            mostrar();
        }

        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                N_Logs.mostrarLog(dt, txt_buscar.Text.Trim());
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeError(e.Message);
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
