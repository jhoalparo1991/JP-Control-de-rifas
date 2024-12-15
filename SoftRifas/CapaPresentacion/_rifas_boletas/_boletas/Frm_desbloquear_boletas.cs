using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas._boletas
{
    public partial class Frm_desbloquear_boletas : Form
    {
        public Frm_desbloquear_boletas()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            _helpers.Validaciones.soloNumero(sender, e);
        }


        public void desbloquearBoleta()
        {
            try
            {
               DtoMostrarBoletasDatos boleta = N_Boletas.mostrarTodasBoletas().Find(x => x.NroBoleta == Txt_boleta.Text.Trim());
            
                if(boleta != null)
                {
                    DialogResult dialog = 
                        MessageBox.Show("Hemos encontrado la boleta que buscas, si la boleta está bloqueada procederemos a desbloquearla"
                        ,"Aviso del sistema"
                        ,MessageBoxButtons.OKCancel
                        ,MessageBoxIcon.Question);

                   if(dialog == DialogResult.OK)
                    {
                        if (boleta.Pagada)
                        {
                            DialogResult dialogBoletaBloqueda =
                              MessageBox.Show(
                                  "La boleta esta bloqueda, deseas desbloquear esta boleta?"
                              , "Aviso del sistema"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question);
                            if(dialogBoletaBloqueda == DialogResult.OK)
                            {
                                if(N_Boletas.sp_bloquear_desbloquear_boleta(boleta.Id, boleta.NroBoleta))
                                {
                                    _helpers.Mensajes.mensajeInformacion("Boleta desbloqueda");
                                }
                                else
                                {
                                    _helpers.Mensajes.mensajeAdvertencia("No se pudo completar la operacion");
                                }
                            }
                        }else if(boleta.Pagada == false && boleta.Vendida == true)
                        {
                            DialogResult dialogBoletaBloqueda =
                              MessageBox.Show(
                                  "La boleta esta desbloqueda, deseas bloquear esta boleta?"
                              , "Aviso del sistema"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question);
                            if (dialogBoletaBloqueda == DialogResult.OK)
                            {
                                if (N_Boletas.sp_bloquear_desbloquear_boleta(boleta.Id, boleta.NroBoleta))
                                {
                                    _helpers.Mensajes.mensajeInformacion("Boleta bloqueda");
                                }
                                else
                                {
                                    _helpers.Mensajes.mensajeAdvertencia("No se pudo completar la operacion");
                                }
                            }
                        }
                        else
                        {
                            _helpers.Mensajes.mensajeAdvertencia("Actualmente la boleta no esta bloqueada");
                        }
                       
                    }
                }
                else
                {
                    _helpers.Mensajes.mensajeInformacion("La boleta que buscas no existe");
                }            
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            desbloquearBoleta();

        }
    }
}
