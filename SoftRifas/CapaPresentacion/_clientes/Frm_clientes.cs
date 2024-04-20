using CapaPresentacion._rifas_boletas;
using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._clientes
{
    public partial class Frm_clientes : Form
    {
        public Frm_clientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            _helpers.Disenios.dataGridView(Dgv_clientes);
            mostrarClientes();
            limpiar();
        }
        private int clienteId = 0;
        #region metodos
        public void mostrarClientes()
        {
            try
            {
                List<Clientes> clientes = N_Clientes.mostrarClientes().FindAll(x => x.NombreCompleto.Contains(Txt_buscar.Text.Trim()) ||
                                                           x.NroDoc.Contains(Txt_buscar.Text.Trim()));
                Dgv_clientes.DataSource = clientes;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void limpiar()
        {
            Txt_cel.Text = string.Empty;
            Txt_dir.Text = string.Empty;
            Txt_id.Text = "0";
            Txt_nombres.Text = string.Empty;
            Txt_nro_doc.Text = "0";
            Txt_tel.Text = string.Empty;
            Txt_nombres.Select();
        }

        private void guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo codigo es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(Txt_nombres.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo nombre es requerido");
                    Txt_nombres.Select();
                    return;
                }

                if (string.IsNullOrEmpty(Txt_nro_doc.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo número de documento es requerido");
                    Txt_nro_doc.Select();
                    return;
                }

                Clientes obj = new Clientes()
                {
                    Id = Convert.ToInt32(Txt_id.Text.Trim()),
                    NombreCompleto = Txt_nombres.Text.Trim(),
                    NroDoc = Txt_nro_doc.Text.Trim(),
                    Direccion = Txt_dir.Text.Trim(),
                    Telefono = Txt_tel.Text.Trim(),
                    Celular = Txt_cel.Text.Trim(),
                };

                if (N_Clientes.guardar(obj))
                {
                    mostrarClientes();
                    limpiar();
                }


            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        #endregion


        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void Dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Dgv_clientes.Rows.Count > 0)
            {
                clienteId = Convert.ToInt32(Dgv_clientes.CurrentRow.Cells["id"].Value.ToString());
                if (Dgv_clientes.Columns[e.ColumnIndex].Name == "btn_sel")
                {
                    Frm_boletas.GetIdCliente = clienteId;
                    Frm_boletas.GetClienteNombre = Dgv_clientes.CurrentRow.Cells["nombre_completo"].Value.ToString();
                    Frm_boletas.GetClienteNroDoc = Dgv_clientes.CurrentRow.Cells["nro_doc"].Value.ToString();
                    this.Close();
                }
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            limpiar();
            Pn_mant.Visible = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void Txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_cel_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            Pn_mant.Visible = true;
            limpiar();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (clienteId > 0)
            {
                Txt_id.Text = Dgv_clientes.CurrentRow.Cells["id"].Value.ToString();
                Txt_nombres.Text = Dgv_clientes.CurrentRow.Cells["nombre_completo"].Value.ToString();
                Txt_nro_doc.Text = Dgv_clientes.CurrentRow.Cells["nro_doc"].Value.ToString();
                Txt_dir.Text = Dgv_clientes.CurrentRow.Cells["Direccion"].Value.ToString();
                Txt_cel.Text = Dgv_clientes.CurrentRow.Cells["Celular"].Value.ToString();
                Txt_tel.Text = Dgv_clientes.CurrentRow.Cells["Telefono"].Value.ToString();
                Pn_mant.Visible = true;
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Clientes.borrar(clienteId);
                    mostrarClientes();
                    clienteId = 0;
                }

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }

        private void Btn_cerrar_ventana_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
