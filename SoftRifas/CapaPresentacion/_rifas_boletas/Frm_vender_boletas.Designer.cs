
namespace CapaPresentacion._rifas_boletas
{
    partial class Frm_vender_boletas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Cbx_vendedores = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Chk_filtrar = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_disponibles = new System.Windows.Forms.Button();
            this.Btn_vendidos = new System.Windows.Forms.Button();
            this.Btn_pagados = new System.Windows.Forms.Button();
            this.CbxRifas = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Lv_boletas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Fyp_botones_paginado = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Fyp_botones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.Fyp_botones_paginado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_disponibles);
            this.panel1.Controls.Add(this.Btn_vendidos);
            this.panel1.Controls.Add(this.Btn_pagados);
            this.panel1.Controls.Add(this.CbxRifas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(860, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(534, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 85);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Cbx_vendedores);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 27);
            this.panel5.TabIndex = 2;
            // 
            // Cbx_vendedores
            // 
            this.Cbx_vendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cbx_vendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbx_vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_vendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbx_vendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cbx_vendedores.ForeColor = System.Drawing.Color.Black;
            this.Cbx_vendedores.FormattingEnabled = true;
            this.Cbx_vendedores.Location = new System.Drawing.Point(0, 0);
            this.Cbx_vendedores.Margin = new System.Windows.Forms.Padding(2);
            this.Cbx_vendedores.Name = "Cbx_vendedores";
            this.Cbx_vendedores.Size = new System.Drawing.Size(322, 24);
            this.Cbx_vendedores.TabIndex = 6;
            this.Cbx_vendedores.Visible = false;
            this.Cbx_vendedores.SelectionChangeCommitted += new System.EventHandler(this.Cbx_vendedores_SelectionChangeCommitted);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Chk_filtrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 27);
            this.panel4.TabIndex = 1;
            // 
            // Chk_filtrar
            // 
            this.Chk_filtrar.AutoSize = true;
            this.Chk_filtrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Chk_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Chk_filtrar.ForeColor = System.Drawing.Color.White;
            this.Chk_filtrar.Location = new System.Drawing.Point(155, 0);
            this.Chk_filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.Chk_filtrar.Name = "Chk_filtrar";
            this.Chk_filtrar.Size = new System.Drawing.Size(167, 27);
            this.Chk_filtrar.TabIndex = 3;
            this.Chk_filtrar.Text = "Filtrar por vendedores";
            this.Chk_filtrar.UseVisualStyleBackColor = true;
            this.Chk_filtrar.CheckedChanged += new System.EventHandler(this.Chk_filtrar_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 24);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Txt_buscar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(70, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 24);
            this.panel7.TabIndex = 1;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_buscar.Location = new System.Drawing.Point(0, 0);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(252, 23);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            this.Txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 24);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtrar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_disponibles
            // 
            this.btn_disponibles.BackgroundImage = global::CapaPresentacion.Properties.Resources.verde;
            this.btn_disponibles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_disponibles.FlatAppearance.BorderSize = 0;
            this.btn_disponibles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_disponibles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_disponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_disponibles.ForeColor = System.Drawing.Color.White;
            this.btn_disponibles.Location = new System.Drawing.Point(116, 43);
            this.btn_disponibles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disponibles.Name = "btn_disponibles";
            this.btn_disponibles.Size = new System.Drawing.Size(111, 40);
            this.btn_disponibles.TabIndex = 0;
            this.btn_disponibles.Text = "Disponibles";
            this.btn_disponibles.UseVisualStyleBackColor = true;
            this.btn_disponibles.Click += new System.EventHandler(this.btn_disponibles_Click);
            // 
            // Btn_vendidos
            // 
            this.Btn_vendidos.BackgroundImage = global::CapaPresentacion.Properties.Resources.Rojo;
            this.Btn_vendidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_vendidos.FlatAppearance.BorderSize = 0;
            this.Btn_vendidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_vendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_vendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_vendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_vendidos.ForeColor = System.Drawing.Color.White;
            this.Btn_vendidos.Location = new System.Drawing.Point(242, 43);
            this.Btn_vendidos.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_vendidos.Name = "Btn_vendidos";
            this.Btn_vendidos.Size = new System.Drawing.Size(166, 40);
            this.Btn_vendidos.TabIndex = 0;
            this.Btn_vendidos.Text = "Vendidas sin pagar";
            this.Btn_vendidos.UseVisualStyleBackColor = true;
            this.Btn_vendidos.Click += new System.EventHandler(this.Btn_vendidos_Click);
            // 
            // Btn_pagados
            // 
            this.Btn_pagados.BackgroundImage = global::CapaPresentacion.Properties.Resources.azul;
            this.Btn_pagados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_pagados.FlatAppearance.BorderSize = 0;
            this.Btn_pagados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_pagados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_pagados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pagados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_pagados.ForeColor = System.Drawing.Color.White;
            this.Btn_pagados.Location = new System.Drawing.Point(10, 43);
            this.Btn_pagados.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_pagados.Name = "Btn_pagados";
            this.Btn_pagados.Size = new System.Drawing.Size(87, 40);
            this.Btn_pagados.TabIndex = 0;
            this.Btn_pagados.Text = "Pagadas";
            this.Btn_pagados.UseVisualStyleBackColor = true;
            this.Btn_pagados.Click += new System.EventHandler(this.Btn_pagados_Click);
            // 
            // CbxRifas
            // 
            this.CbxRifas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxRifas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbxRifas.FormattingEnabled = true;
            this.CbxRifas.Location = new System.Drawing.Point(11, 8);
            this.CbxRifas.Margin = new System.Windows.Forms.Padding(2);
            this.CbxRifas.Name = "CbxRifas";
            this.CbxRifas.Size = new System.Drawing.Size(363, 24);
            this.CbxRifas.TabIndex = 4;
            this.CbxRifas.SelectionChangeCommitted += new System.EventHandler(this.CbxRifas_SelectionChangeCommitted);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Lv_boletas
            // 
            this.Lv_boletas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lv_boletas.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_boletas.FullRowSelect = true;
            this.Lv_boletas.GridLines = true;
            this.Lv_boletas.HideSelection = false;
            this.Lv_boletas.Location = new System.Drawing.Point(480, 355);
            this.Lv_boletas.Margin = new System.Windows.Forms.Padding(2);
            this.Lv_boletas.Name = "Lv_boletas";
            this.Lv_boletas.Size = new System.Drawing.Size(190, 88);
            this.Lv_boletas.TabIndex = 3;
            this.Lv_boletas.UseCompatibleStateImageBehavior = false;
            this.Lv_boletas.View = System.Windows.Forms.View.Details;
            this.Lv_boletas.Visible = false;
            this.Lv_boletas.SelectedIndexChanged += new System.EventHandler(this.Lv_boletas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nro Boleta";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pagada";
            this.columnHeader4.Width = 103;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Borrar";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // Fyp_botones_paginado
            // 
            this.Fyp_botones_paginado.AutoScroll = true;
            this.Fyp_botones_paginado.Controls.Add(this.button1);
            this.Fyp_botones_paginado.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fyp_botones_paginado.Location = new System.Drawing.Point(0, 93);
            this.Fyp_botones_paginado.Margin = new System.Windows.Forms.Padding(2);
            this.Fyp_botones_paginado.Name = "Fyp_botones_paginado";
            this.Fyp_botones_paginado.Size = new System.Drawing.Size(65, 425);
            this.Fyp_botones_paginado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Fyp_botones
            // 
            this.Fyp_botones.AutoScroll = true;
            this.Fyp_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fyp_botones.Location = new System.Drawing.Point(65, 93);
            this.Fyp_botones.Margin = new System.Windows.Forms.Padding(2);
            this.Fyp_botones.Name = "Fyp_botones";
            this.Fyp_botones.Size = new System.Drawing.Size(795, 425);
            this.Fyp_botones.TabIndex = 6;
            // 
            // Frm_vender_boletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 518);
            this.ControlBox = false;
            this.Controls.Add(this.Fyp_botones);
            this.Controls.Add(this.Fyp_botones_paginado);
            this.Controls.Add(this.Lv_boletas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_vender_boletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.Fyp_botones_paginado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.CheckBox Chk_filtrar;
        private System.Windows.Forms.ComboBox CbxRifas;
        private System.Windows.Forms.ListView Lv_boletas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel Fyp_botones_paginado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_disponibles;
        private System.Windows.Forms.Button Btn_vendidos;
        private System.Windows.Forms.Button Btn_pagados;
        internal System.Windows.Forms.FlowLayoutPanel Fyp_botones;
        private System.Windows.Forms.ComboBox Cbx_vendedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}