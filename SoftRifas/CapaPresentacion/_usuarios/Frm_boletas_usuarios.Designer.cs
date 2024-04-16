
namespace CapaPresentacion._usuarios
{
    partial class Frm_boletas_usuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Lbl_usuario_id = new System.Windows.Forms.Label();
            this.Txt_nro_boleta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fyp_boletas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Size = new System.Drawing.Size(742, 50);
            this.panel1.TabIndex = 1;
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
            this.Btn_cerrar.Location = new System.Drawing.Point(698, 6);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(38, 38);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignacion de boletas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBorrar);
            this.panel2.Controls.Add(this.Btn_registrar);
            this.panel2.Controls.Add(this.Lbl_usuario_id);
            this.panel2.Controls.Add(this.Txt_nro_boleta);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 55);
            this.panel2.TabIndex = 2;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Rojo;
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(610, 4);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(96, 45);
            this.BtnBorrar.TabIndex = 11;
            this.BtnBorrar.Text = "Borrar Boleta";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_registrar.FlatAppearance.BorderSize = 0;
            this.Btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(486, 7);
            this.Btn_registrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(97, 39);
            this.Btn_registrar.TabIndex = 10;
            this.Btn_registrar.Text = "Registrar";
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Lbl_usuario_id
            // 
            this.Lbl_usuario_id.AutoSize = true;
            this.Lbl_usuario_id.Location = new System.Drawing.Point(789, 16);
            this.Lbl_usuario_id.Name = "Lbl_usuario_id";
            this.Lbl_usuario_id.Size = new System.Drawing.Size(112, 20);
            this.Lbl_usuario_id.TabIndex = 2;
            this.Lbl_usuario_id.Text = "Lbl_usuario_id";
            this.Lbl_usuario_id.Visible = false;
            // 
            // Txt_nro_boleta
            // 
            this.Txt_nro_boleta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nro_boleta.Location = new System.Drawing.Point(299, 12);
            this.Txt_nro_boleta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_nro_boleta.Name = "Txt_nro_boleta";
            this.Txt_nro_boleta.Size = new System.Drawing.Size(172, 27);
            this.Txt_nro_boleta.TabIndex = 1;
            this.Txt_nro_boleta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_nro_boleta_KeyDown);
            this.Txt_nro_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nro_boleta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de boleta que deseas asignar";
            // 
            // Fyp_boletas
            // 
            this.Fyp_boletas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fyp_boletas.Location = new System.Drawing.Point(0, 105);
            this.Fyp_boletas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fyp_boletas.Name = "Fyp_boletas";
            this.Fyp_boletas.Size = new System.Drawing.Size(742, 406);
            this.Fyp_boletas.TabIndex = 3;
            // 
            // Frm_boletas_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.Fyp_boletas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_boletas_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_boletas_usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_nro_boleta;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Lbl_usuario_id;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.FlowLayoutPanel Fyp_boletas;
        private System.Windows.Forms.Button BtnBorrar;
    }
}