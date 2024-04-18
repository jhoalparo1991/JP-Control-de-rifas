using CEntidades;
using CNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion._auxiliar_instalacion
{
    public partial class Frm_config : Form
    {
        int total = 0;
        int id = 0;
        public Frm_config()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            limpiar();
            cargarBoletas();
        }

        private void limpiar()
        {
            txt_color.Text = "0";
            txt_nro_boletas.Text = "0";
            txt_nro_boletas.Text = "0";
            txt_nro_botones.Text = "0";
            id = 0;
        }
        private void cargarBoletas()
        {
            int rifaId = N_Rifas.mostrarRifas().Find(x=>x.Activa==true).Id;
            N_Boletas.contarBoletas(ref total,rifaId);
            txt_nro_boletas.Text = total.ToString();
        }
        private void mostrarConfig()
        {
            try
            {
               Config config =  N_Config.mostrarConfig().FirstOrDefault();
            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void calcularPaginas()
        {

            if (string.IsNullOrEmpty(txt_nro_boletas_pagina.Text))
            {
                return;
            }


            int _nroBoletasPagina = Convert.ToInt32(txt_nro_boletas_pagina.Text.Trim());

            int paginas = (total / _nroBoletasPagina);

            txt_nro_botones.Text = paginas.ToString();

        }

        private void guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_color.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar un color");
                    return;
                }
                if (string.IsNullOrEmpty(txt_nro_boletas.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes tener boletas registradas");
                    return;
                }
                if (string.IsNullOrEmpty(txt_nro_boletas_pagina.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes tener boletas registradas");
                    return;
                }


                Config config = new Config() { 
                    Id = id,
                    NroBotones = Convert.ToInt32(txt_nro_botones.Text.Trim()),
                    NroRegistrosPorPagina = Convert.ToInt32(txt_nro_boletas_pagina.Text.Trim()),
                    Color = Convert.ToInt32(txt_color.Text.Trim()),
                };

                if (N_Config.crearConfig(config))
                {

                }

            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _helpers.Formularios.moverFormulario(sender, e, this);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nro_botones_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender,e);
        }

        private void txt_nro_boletas_pagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }

        private void txt_nro_botones_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_nro_botones);
        }

        private void txt_nro_boletas_pagina_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_nro_boletas_pagina);
        }

        private void txt_color_Leave(object sender, EventArgs e)
        {
            _helpers.Validaciones.completarCampos(txt_color);
        }

        private void txt_nro_boletas_pagina_TextChanged(object sender, EventArgs e)
        {
            calcularPaginas();
        }

        private void txt_color_Click(object sender, EventArgs e)
        {
            using(ColorDialog cd = new ColorDialog())
            {
                if(cd.ShowDialog() == DialogResult.OK)
                {
                    int color = cd.Color.ToArgb();
                    txt_color.Text = color.ToString();
                }
                    
            }
        }

        private void Btn_conectar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
