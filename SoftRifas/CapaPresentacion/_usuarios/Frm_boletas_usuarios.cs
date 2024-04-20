using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion._usuarios
{
    public partial class Frm_boletas_usuarios : Form
    {
        public Frm_boletas_usuarios()
        {
            InitializeComponent();
            Txt_nro_boleta.Select();
            this.ControlBox = false;
            this.Text = "";
            dibujarBoletas();
        }
        internal int usuarioId = 0;
        int boletaId= 0;
        public void dibujarBoletas()
        {
            Fyp_boletas.Controls.Clear();

            List<DtoMostrarAsignarBoletasVendedores> boletas = N_Boletas.mostrarBoletasAsignadasVendedores().FindAll(x => x.VendedorId == usuarioId);

            foreach (var boleta in boletas)
            {
                Button btnBoleta = new Button();
                btnBoleta.Text = boleta.NroBoleta.ToString();
                btnBoleta.Name = boleta.BoletaId.ToString();
                btnBoleta.Tag = boleta.Id.ToString();
                btnBoleta.Size = new Size(84, 50);
                btnBoleta.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                btnBoleta.ForeColor = Color.White;
                btnBoleta.BackgroundImageLayout = ImageLayout.Stretch;
                btnBoleta.FlatAppearance.BorderSize = 0;
                btnBoleta.FlatStyle = FlatStyle.Flat;
                btnBoleta.Cursor = Cursors.Hand;
                btnBoleta.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnBoleta.FlatAppearance.MouseOverBackColor = Color.Transparent;
                if (boleta.Vendida)
                {
                    if (boleta.Pagada)
                    {
                        btnBoleta.BackgroundImage = Properties.Resources.azul;
                    }
                    else
                    {

                    }
                    btnBoleta.BackgroundImage = Properties.Resources.Rojo;

                }
                else
                {

                }
                btnBoleta.BackgroundImage = Properties.Resources.verde;
                btnBoleta.Click += BtnBoleta_Click;
                Fyp_boletas.Controls.Add(btnBoleta);
            }
        }

        private void BtnBoleta_Click(object sender, EventArgs e)
        {
            boletaId = Convert.ToInt32(((Button)sender).Name);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }

        private void registrarBoleta()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_nro_boleta.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes ingresar el número de la boleta");
                    Txt_nro_boleta.Select();
                    return;
                }

                if (Convert.ToInt32(Lbl_usuario_id.Text.Trim()) <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un vendedor");
                    return;
                }

                int nroBoleta = Convert.ToInt32(Txt_nro_boleta.Text.Trim());


                AsignarBoletasVendedores obj = new AsignarBoletasVendedores()
                {
                    VendedorId = Convert.ToInt32(Lbl_usuario_id.Text.Trim()),
                    NroBoleta = nroBoleta.ToString("D4")
                };

                N_Boletas.asignarBoletasVendedores(obj);
                Txt_nro_boleta.Text = string.Empty;
                Txt_nro_boleta.Select();
                dibujarBoletas();

            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void Txt_nro_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void Txt_nro_boleta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                registrarBoleta();
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            registrarBoleta();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (boletaId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar una boleta");
                    return;
                }

                DialogResult result = MessageBox.Show($"Seguro  que deseas quitar la boleta { boletaId }", "Mensaje de confirmacion",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    N_Boletas.borrarBoletaAsignadaVendedor(boletaId);
                   
                   // usuarioId = 0;
                }
                dibujarBoletas();
            }
            catch (Exception ex)
            {
                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
    }
}
