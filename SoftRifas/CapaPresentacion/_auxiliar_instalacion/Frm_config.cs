using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion._auxiliar_instalacion
{
    public partial class Frm_config : Form
    {
        int id = 0;
        public Frm_config()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            mostrarConfig();
        }

        private static string _DIRECTORIO = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SoftRifas");
        private static string _ARCHIVO_DB = Path.Combine(_DIRECTORIO, "connection_string.txt");

        private static List<string> LeerArchivoconexionDB()
        {

            List<string> listado = new List<string>();

            try
            {
                if (File.Exists(_ARCHIVO_DB))
                {
                    using (StreamReader reader = new StreamReader(_ARCHIVO_DB))
                    {
                        string lineas;
                        while ((lineas = reader.ReadLine()) != null)
                        {
                            listado.Add(lineas);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listado;
        }


        private void mostrarConfig()
        {
            try
            {
                Config config = N_Config.mostrarConfig().FirstOrDefault();

                if (config != null)
                {
                    id = config.Id;
                    txtRutaCopiaSeguridad.Text = config.RutaCopiaSeguridad.ToString();

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

                if (string.IsNullOrEmpty(txtRutaCopiaSeguridad.Text))
                {
                    _helpers.Mensajes.mensajeAdvertencia("Elija la ruta donde se almacenaran las copias de seguridad");
                    button1.Select();
                    return;
                }


                Config config = new Config()
                {
                    Id = id,
                    RutaCopiaSeguridad = txtRutaCopiaSeguridad.Text.Trim()
                };


                if (N_Config.crearConfig(config))
                {
                    mostrarConfig();

                    Lbl_estado.ForeColor = Color.White;
                    if (N_Config.crearBackup(txtRutaCopiaSeguridad.Text.Trim()))
                    {

                        Lbl_estado.Text = "Estado : Copia de base de datos generada con exito";
                        Lbl_estado.BackColor = Color.Green;
                        _helpers.Sesion.guardarDatosLog("Se creó una copia de la base de datos");
                    }
                    else
                    {
                        Lbl_estado.Text = "Estado : Hubo un error, no se pudo crear la copia de seguridad";
                        Lbl_estado.BackColor = Color.Red;
                        _helpers.Sesion.guardarDatosLog("Hubo un error en la creacion de la copia de base de datos");
                    }
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


        private void Btn_conectar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Ruta copias de seguridad";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaCopiaSeguridad.Text = Path.Combine(fbd.SelectedPath.ToString(), "DBRIFAS.BAK");
                }
            }
        }
    }
}
