using CapaNegocio;
using CapaPresentacion._reportes;
using CEntidades;
using CNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion._rifas_boletas
{
    public partial class Frm_vender_boletas : Form
    {
        public Frm_vender_boletas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            mostrarRifas();
            dibujarBotones();
            mostrarVendedores();
           // mostrarTodasBoletas();
        }
        private int boletaId = 0;
        private int boletaVendedorId = 0;
        private int visualizados = 250;
        private int desde  = 0;
        private int hasta =  250;

        List<Boletas> boletas = new List<Boletas>();

        #region metodos

        private void mostrarFormAgregarAbonos()
        {
            try
            {
                if (boletaId <= 0)
                {
                    _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar la boleta que deseas abonar");
                    return;
                }

                DtoMostrarBoletasDatos boleta = N_Boletas.mostrarTodasBoletas()
                    .Find(x => x.Id == boletaId);

                if (boleta != null)
                {
                    Frm_abonar_boletas frm = new Frm_abonar_boletas(this);

                    if (boleta.Vendida == true && boleta.Pagada == true)
                    {
                        frm.Btn_registrar.Enabled = false;
                        frm.txt_deuda.Enabled = false;
                    }

                    frm.txt_id_boleta.Text = boleta.Id.ToString();
                    frm.Txt_boleta.Text = boleta.NroBoleta.ToString();
                    frm.txt_valor.Text = boleta.ValorBoleta.ToString().Trim();
                    frm.mostrarAbonos(boletaId);
                    frm.ShowDialog();
                }



            }
            catch (Exception ex)
            {

                _helpers.Mensajes.mensajeErrorException(ex);
            }
        }
        private void dibujarBotones()
        {
            Fyp_botones_paginado.Controls.Clear();
            for (int i =1; i<= 40; i++)
            {
                Button btnNum = new Button();
                btnNum.Text = i.ToString();
                btnNum.Name = i.ToString();
                btnNum.Size = new Size(45 , 43);
                btnNum.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                btnNum.ForeColor = Color.White;
                btnNum.BackgroundImage = Properties.Resources.naranja;
                btnNum.BackgroundImageLayout = ImageLayout.Stretch;
                btnNum.FlatAppearance.BorderSize = 0;
                btnNum.FlatStyle = FlatStyle.Flat;
                btnNum.Cursor = Cursors.Hand;
                btnNum.Click += BtnNum_Click;
                Fyp_botones_paginado.Controls.Add(btnNum);
            }
        }
        public void dibujarBoletasPorEstado(bool vendida)
        {
            Fyp_botones.Controls.Clear();
            List<Boletas> boletas = new List<Boletas>();

            boletas = N_Boletas.mostrarBoletasPaginadas(Convert.ToInt32(CbxRifas.SelectedValue), 0, 10000)
                        .FindAll(x => x.Vendida == vendida)
                        .FindAll(x => x.NroBoleta.Contains(Txt_buscar.Text.Trim()));

            foreach (var boleta in boletas)
            {
                Button btnBoleta = new Button();
                btnBoleta.Text = boleta.NroBoleta.ToString();
                btnBoleta.Name = boleta.Id.ToString();
                btnBoleta.Tag = boleta.VendedorId.ToString();
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

                        btnBoleta.BackgroundImage = Properties.Resources.Rojo;
                    }

                }
                else
                {

                    btnBoleta.BackgroundImage = Properties.Resources.verde;
                }

                btnBoleta.Click += BtnBoleta_Click;
                Fyp_botones.Controls.Add(btnBoleta);
            }
        }
        public void dibujarBoletasPagadas()
        {
            Fyp_botones.Controls.Clear();
            List<Boletas> boletas = new List<Boletas>();

            boletas = N_Boletas.mostrarBoletasPaginadas(Convert.ToInt32(CbxRifas.SelectedValue), 0, 10000)
                        .FindAll(x => x.Pagada == true);

            foreach (var boleta in boletas)
            {
                Button btnBoleta = new Button();
                btnBoleta.Text = boleta.NroBoleta.ToString();
                btnBoleta.Name = boleta.Id.ToString();
                btnBoleta.Tag = boleta.VendedorId.ToString();
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

                        btnBoleta.BackgroundImage = Properties.Resources.Rojo;
                    }

                }
                else
                {

                    btnBoleta.BackgroundImage = Properties.Resources.verde;
                }

                btnBoleta.Click += BtnBoleta_Click;
                Fyp_botones.Controls.Add(btnBoleta);
            }
        }
        public void dibujarBoletas()
        {
            Fyp_botones.Controls.Clear();
            List<Boletas> boletas = new List<Boletas>();

            if (string.IsNullOrEmpty(Txt_buscar.Text.Trim()))
            {
                if (Convert.ToBoolean(Chk_filtrar.Checked))
                {
                    boletas = N_Boletas.mostrarBoletasPaginadas(Convert.ToInt32(CbxRifas.SelectedValue), 0, 10000)
                                   .FindAll(x => x.VendedorId == Convert.ToInt32(Cbx_vendedores.SelectedValue))
                                   .FindAll(x => x.NroBoleta.Contains(Txt_buscar.Text.Trim()));
                }
                else
                {
                    boletas = N_Boletas.mostrarBoletasPaginadas(Convert.ToInt32(CbxRifas.SelectedValue), desde, hasta)
                            .FindAll(x => x.NroBoleta.Contains(Txt_buscar.Text.Trim()));
                }
            }
            else
            {
                boletas = N_Boletas.mostrarBoletasPaginadas(Convert.ToInt32(CbxRifas.SelectedValue), 0, 10000)
                            .FindAll(x => x.NroBoleta.Contains(Txt_buscar.Text.Trim()));
            }


            foreach(var boleta in boletas)
            {
                Button btnBoleta = new Button();
                btnBoleta.Text = boleta.NroBoleta.ToString();
                btnBoleta.Name = boleta.Id.ToString();
                btnBoleta.Tag = boleta.VendedorId.ToString();
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

                    btnBoleta.BackgroundImage = Properties.Resources.Rojo;
                    }

                }
                else
                {

                btnBoleta.BackgroundImage = Properties.Resources.verde;
                }

                btnBoleta.Click += BtnBoleta_Click;
                Fyp_botones.Controls.Add(btnBoleta);
            }
        }

        private void BtnBoleta_Click(object sender, EventArgs e)
        {
            boletaId = Convert.ToInt32(((Button)sender).Name);
            boletaVendedorId = Convert.ToInt32(((Button)sender).Tag);
            buscarBoletas();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(((Button)sender).Text);

            //if (num == 1)
            //{
            //    dibujarBoletas(0, visualizados);
            //    return;
            //}

            //if (num >= 2)
            //{
            //    dibujarBoletas(visualizados*num, visualizados*(num+1));
            //    return;
            //}
            desde = visualizados * (num - 1);
            hasta = visualizados * (num);
            dibujarBoletas();
            return;

        }

        internal void mostrarTodasBoletas()
        {
            try
            {
                Lv_boletas.Items.Clear();
               List<DtoMostrarBoletasDatos> boletas = N_Boletas.mostrarTodasBoletas()
                    .FindAll(x=> x.NroBoleta.Contains(Txt_buscar.Text.Trim()))
                    .FindAll(x=> x.Vendida == Convert.ToBoolean(Chk_filtrar.CheckState))
                    .FindAll(x=> x.RifaId == Convert.ToInt32(CbxRifas.SelectedValue));

                foreach(var boleta in boletas)
                {
                    ListViewItem item = new ListViewItem(boleta.Id.ToString());
                    item.SubItems.Add(boleta.NroBoleta);
                    item.SubItems.Add(boleta.ValorBoleta.ToString("C2"));
                    if(boleta.Pagada == true)
                    {
                        item.SubItems.Add("SI");
                    }
                    else
                    {
                        item.SubItems.Add("NO");
                    }
                    Lv_boletas.Items.Add(item);
                }

            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        internal void buscarBoletas()
        {
            try
            {
                 if (boletaId <= 0)
                  {
                      _helpers.Mensajes.mensajeAdvertencia("Debes seleccionar la boleta que deseas vender");
                      return;
                  }

                  DtoMostrarBoletasDatos boleta = N_Boletas.mostrarTodasBoletas()
                      .Find(x => x.Id == boletaId);

                  if (boleta!= null)
                  {

                      if (boleta.Vendida == true && boleta.Pagada == true)
                      {
                        mostrarFormAgregarAbonos();
                      }else if (boleta.Vendida == true && boleta.Pagada == false)
                      {
                        mostrarFormAgregarAbonos();
                        }
                    else if (boleta.Vendida == false && boleta.Pagada == false)
                        {
                            Usuarios usuario =  N_Usuarios.mostrarUsuarios().Find(x => x.Id == boletaVendedorId);

                        if(usuario != null)
                        {
                            Frm_boletas frm = new Frm_boletas(this);
                            frm.txt_valor_boleta.ReadOnly = false;
                            frm.Txt_id_boleta.Text = boleta.Id.ToString();
                            frm.Txt_nro_boleta.Text = boleta.NroBoleta.ToString();
                            frm.txt_valor_boleta.Text = boleta.ValorBoleta.ToString().Trim();
                            frm.Txt_vendedor.Enabled = false;
                            frm.Txt_cc_ve.Enabled = false;
                            frm.Txt_vendedor.Text = usuario.NombreCompleto;
                            frm.Txt_cc_ve.Text = usuario.NroDoc;
                            frm.Txt_vendedor_id.Text = usuario.Id.ToString();
                            frm.dgv_vendedores.Visible = false;
                            frm.Btn_buscar_vendedor.Visible = false;
                            frm.ShowDialog();
                        }
                        else
                        {
                            Frm_boletas frm = new Frm_boletas(this);
                            frm.txt_valor_boleta.ReadOnly = false;
                            frm.Txt_id_boleta.Text = boleta.Id.ToString();
                            frm.Txt_nro_boleta.Text = boleta.NroBoleta.ToString();
                            frm.txt_valor_boleta.Text = boleta.ValorBoleta.ToString().Trim();
                            frm.ShowDialog();
                        }
                        }


                }
               

            }
            catch (Exception e)
            {

                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
      
        private void mostrarRifas()
        {
            try
            {
                List<Rifas> rifas = N_Rifas.mostrarRifas().FindAll(x => x.Activa == true);
                CbxRifas.DataSource = rifas;
                CbxRifas.DisplayMember ="descripcion";
                CbxRifas.ValueMember ="id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeErrorException(e);
            }
        }
        private void mostrarVendedores()
        {
            try
            {
                DataTable dt = new DataTable();
                N_Usuarios.mostrarVendedores(dt);
                Cbx_vendedores.DataSource = dt;
                Cbx_vendedores.DisplayMember = "nombre_completo".ToString();
                Cbx_vendedores.ValueMember = "id";
            }
            catch (Exception e)
            {
                _helpers.Mensajes.mensajeInformacion(e.Message);
            }
        }
        #endregion

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Chk_mostrar_activas_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void CbxRifas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrarTodasBoletas();
        }

        private void Btn_registrar_boleta_Click(object sender, EventArgs e)
        {
            buscarBoletas();
        }

        private void Lv_boletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lv_boletas.SelectedItems.Count > 0)
            {
                ListViewItem item = Lv_boletas.SelectedItems[0];

                boletaId = Convert.ToInt32(item.SubItems[0].Text);
            }
        }

        private void Btn_ver_boleta_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            if (boletaId <= 0)
            {
                _helpers.Mensajes.mensajeAdvertencia("Debes seleccioanr la boleta que deseas generar reporte");
                return;
            }

            Frm_reporte_boletas_vendedor frmR = new Frm_reporte_boletas_vendedor();
            frmR.Txt_boleta_id.Text = boletaId.ToString();
            frmR.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //mostrarTodasBoletas();
            Chk_filtrar.Checked = false;
            if (string.IsNullOrEmpty(Txt_buscar.Text))
            {
                dibujarBoletas();
                return;
            }
            dibujarBoletas();
        }

        private void Btn_pagados_Click(object sender, EventArgs e)
        {
            dibujarBoletasPagadas();
        }

        private void Txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Chk_filtrar.Checked = false;
                if (string.IsNullOrEmpty(Txt_buscar.Text))
                {
                    dibujarBoletas();
                    return;
                }
                dibujarBoletas();
            }
        }

        private void Chk_filtrar_CheckedChanged(object sender, EventArgs e)
        {
            Cbx_vendedores.Visible = Convert.ToBoolean(Chk_filtrar.CheckState);
        }

        private void Cbx_vendedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dibujarBoletas();
        }

        private void Btn_vendidos_Click(object sender, EventArgs e)
        {
            //dibujarBoletasPorEstado(true);
        }

        private void btn_disponibles_Click(object sender, EventArgs e)
        {
            //dibujarBoletasPorEstado(false);
        }
    }
}
