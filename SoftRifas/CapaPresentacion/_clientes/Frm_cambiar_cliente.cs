using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._clientes
{
    public partial class Frm_cambiar_cliente : Form
    {
        internal int clienteIdActual;
        internal string _clienteActual;
        public Frm_cambiar_cliente()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            _helpers.Sesion.guardarDatosLog("Muestra clientes para cambio en boleta");
            mostrarClientes();
        }

        private void cambiarCliente()
        {
            if (string.IsNullOrEmpty(Lbl_id.Text.Trim()))
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un cliente para hacer el cambio");
                return;
            }

            int _id = Convert.ToInt32(Lbl_id.Text.Trim());
            int _boletaId = Convert.ToInt32(Lbl_boleta_id.Text.Trim());
            if (_id <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un cliente para hacer el cambio");
                return;
            }

            if (_boletaId <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar una boleta para hacer el cambio");
                return;
            }

            try
            {
                DialogResult dialog = MessageBox.Show($"Estas seguro de hacer el cambio de cliente a esta boleta, la boleta está a nombre de {_clienteActual.ToString().ToUpper()}, ahora quedará a nombre de {Lbl_cliente.Text.ToUpper()}",
                                                        "Mensaje de confirmacion",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    bool result = N_Boletas.cambiarClienteBoleta(_boletaId, _id);

                    if (result)
                    {
                        _helpers.Sesion.guardarDatosLog("Cambia cliente a una boleta");
                        _helpers.Mensajes.mensajeInformacion("Cliente cambiado con exito");
                        this.Close();
                    }

                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }


        }
        public void mostrarClientes()
        {
            try
            {
                List<Clientes> clientes = N_Clientes.mostrarClientes().FindAll(x => x.NombreCompleto.Contains(txtBuscar.Text.Trim()) ||
                                                           x.NroDoc.Contains(txtBuscar.Text.Trim()));
                Dgv_clientes.DataSource = clientes;

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void Dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_clientes.Rows.Count > 0)
            {
                Lbl_id.Text = Dgv_clientes.CurrentRow.Cells["id"].Value.ToString();
                Lbl_cliente.Text = Dgv_clientes.CurrentRow.Cells["nombre_completo"].Value.ToString();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            cambiarCliente();
        }
    }
}
