using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas
{
    public partial class Frm_rifas : Form
    {
        public Frm_rifas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _helpers.Formularios.marcarCampoSeleccionado(this.Controls);
            _helpers.Disenios.dataGridView(Dgv_rifas);
            limpiar();
            mostrarDatosSesion();
            mostrarRifas();
        }
        private int rifaId = 0;
        private int usuarioId = 0;
        #region metodos
        public void mostrarRifas()
        {
            try
            {
                List<Rifas> clientes = N_Rifas.mostrarRifas().FindAll(x => x.Descripcion.Contains(Txt_buscar.Text.Trim()))
                    .FindAll(x => x.Activa == Convert.ToBoolean(Chk_mostrar_activas.CheckState));
                Dgv_rifas.DataSource = clientes;
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void limpiar()
        {
            txt_id.Text = "0";
            chk_activa.Checked = true;
            txt_descripcion.Text = string.Empty;
            txt_nro_ini.Text = "0";
            txt_nro_fin.Text = "0";
            txt_valor.Text = "0";
            txt_descripcion.Select();
        }
        private void mostrarDatosSesion()
        {
            try
            {
                InicioSesion sesion = N_Usuarios.mostrarUsuarioSesion();
                if (sesion != null)
                {
                    usuarioId = sesion.UsuarioId;
                }
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_id.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo codigo es requerido");
                    return;
                }
                if (string.IsNullOrEmpty(txt_descripcion.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo nombre es requerido");
                    txt_descripcion.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_valor.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo valor es requerido");
                    txt_valor.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_nro_ini.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo número inicial es requerido");
                    txt_nro_ini.Select();
                    return;
                }

                if (string.IsNullOrEmpty(txt_nro_fin.Text.Trim()))
                {
                    _helpers.Mensajes.mensajeAdvertencia("El Campo número final es requerido");
                    txt_nro_fin.Select();
                    return;
                }


                Rifas obj = new Rifas()
                {
                    Id = Convert.ToInt32(txt_id.Text.Trim()),
                    UsuarioId = usuarioId,
                    Descripcion = txt_descripcion.Text.Trim(),
                    FechaInicio = dt_fecha_inicio.Value,
                    FechaFin = dt_fecha_fin.Value,
                    NroInicial = Convert.ToInt32(txt_nro_ini.Text.Trim()),
                    NroFinal = Convert.ToInt32(txt_nro_fin.Text.Trim()),
                    Activa = Convert.ToBoolean(chk_activa.CheckState),
                    ValorRifa = Convert.ToDecimal(txt_valor.Text.Trim()),
                };

                if (N_Rifas.crearRifas(obj))
                {
                    limpiar();
                    mostrarRifas();
                    panel2.Visible = false;
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
            mostrarRifas();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
        }
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void Dgv_rifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_rifas.Rows.Count > 0)
            {
                rifaId = Convert.ToInt32(Dgv_rifas.CurrentRow.Cells["id"].Value.ToString());
            }
        }

        private void Chk_mostrar_activas_CheckedChanged(object sender, EventArgs e)
        {
            mostrarRifas();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void txt_nro_ini_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_nro_fin_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_nro_ini_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_nro_ini);
        }

        private void txt_nro_fin_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_nro_fin);
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_valor);
        }

        private void Btn_nuevos_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            limpiar();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (rifaId > 0)
            {

                txt_id.Text = Dgv_rifas.CurrentRow.Cells["Id"].Value.ToString();
                txt_descripcion.Text = Dgv_rifas.CurrentRow.Cells["Descripcion"].Value.ToString();
                dt_fecha_inicio.Value = Convert.ToDateTime(Dgv_rifas.CurrentRow.Cells["FechaInicio"].Value.ToString());
                dt_fecha_fin.Value = Convert.ToDateTime(Dgv_rifas.CurrentRow.Cells["FechaFin"].Value.ToString());
                txt_nro_ini.Text = Dgv_rifas.CurrentRow.Cells["NroInicial"].Value.ToString();
                txt_nro_fin.Text = Dgv_rifas.CurrentRow.Cells["NroFinal"].Value.ToString();
                chk_activa.Checked = Convert.ToBoolean(Dgv_rifas.CurrentRow.Cells["Activa"].Value);
                txt_valor.Text = Dgv_rifas.CurrentRow.Cells["ValorRifa"].Value.ToString();
                panel2.Visible = true;
            }
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rifaId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un registro");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro  que deseas eliminar este registro", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Rifas.borrar(rifaId);
                    mostrarRifas();
                    rifaId = 0;
                }

            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
    }
}
