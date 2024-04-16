namespace CapaPresentacion._auxiliar_instalacion
{
    partial class Frm_config
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_conectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nro_botones = new System.Windows.Forms.TextBox();
            this.txt_nro_boletas_pagina = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nro_boletas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Size = new System.Drawing.Size(256, 44);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar_ventana_32_blanco;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(208, 6);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(40, 32);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuraciones";
            // 
            // Btn_conectar
            // 
            this.Btn_conectar.BackColor = System.Drawing.Color.Teal;
            this.Btn_conectar.FlatAppearance.BorderSize = 0;
            this.Btn_conectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_conectar.ForeColor = System.Drawing.Color.White;
            this.Btn_conectar.Location = new System.Drawing.Point(57, 292);
            this.Btn_conectar.Name = "Btn_conectar";
            this.Btn_conectar.Size = new System.Drawing.Size(136, 40);
            this.Btn_conectar.TabIndex = 4;
            this.Btn_conectar.Text = "&Guardar";
            this.Btn_conectar.UseVisualStyleBackColor = false;
            this.Btn_conectar.Click += new System.EventHandler(this.Btn_conectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nro Botones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro boletas por pagina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(24, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // txt_nro_botones
            // 
            this.txt_nro_botones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nro_botones.Location = new System.Drawing.Point(24, 84);
            this.txt_nro_botones.Name = "txt_nro_botones";
            this.txt_nro_botones.ReadOnly = true;
            this.txt_nro_botones.Size = new System.Drawing.Size(206, 23);
            this.txt_nro_botones.TabIndex = 7;
            this.txt_nro_botones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_botones_KeyPress);
            this.txt_nro_botones.Leave += new System.EventHandler(this.txt_nro_botones_Leave);
            // 
            // txt_nro_boletas_pagina
            // 
            this.txt_nro_boletas_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nro_boletas_pagina.Location = new System.Drawing.Point(24, 142);
            this.txt_nro_boletas_pagina.Name = "txt_nro_boletas_pagina";
            this.txt_nro_boletas_pagina.Size = new System.Drawing.Size(206, 23);
            this.txt_nro_boletas_pagina.TabIndex = 7;
            this.txt_nro_boletas_pagina.TextChanged += new System.EventHandler(this.txt_nro_boletas_pagina_TextChanged);
            this.txt_nro_boletas_pagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_boletas_pagina_KeyPress);
            this.txt_nro_boletas_pagina.Leave += new System.EventHandler(this.txt_nro_boletas_pagina_Leave);
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_color.Location = new System.Drawing.Point(24, 258);
            this.txt_color.Name = "txt_color";
            this.txt_color.ReadOnly = true;
            this.txt_color.Size = new System.Drawing.Size(206, 23);
            this.txt_color.TabIndex = 7;
            this.txt_color.Click += new System.EventHandler(this.txt_color_Click);
            this.txt_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_color_KeyPress);
            this.txt_color.Leave += new System.EventHandler(this.txt_color_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nro de boletas";
            // 
            // txt_nro_boletas
            // 
            this.txt_nro_boletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nro_boletas.Location = new System.Drawing.Point(24, 200);
            this.txt_nro_boletas.Name = "txt_nro_boletas";
            this.txt_nro_boletas.ReadOnly = true;
            this.txt_nro_boletas.Size = new System.Drawing.Size(206, 23);
            this.txt_nro_boletas.TabIndex = 7;
            // 
            // Frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 343);
            this.Controls.Add(this.txt_nro_boletas);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_nro_boletas_pagina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nro_botones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_conectar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_config";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_conectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nro_botones;
        private System.Windows.Forms.TextBox txt_nro_boletas_pagina;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nro_boletas;
    }
}