
namespace CapaPresentacion
{
    partial class Frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_conectar = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Txt_nro_doc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_usuario = new System.Windows.Forms.LinkLabel();
            this.Lbl_validacion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Btn_conectar
            // 
            this.Btn_conectar.BackColor = System.Drawing.Color.Teal;
            this.Btn_conectar.FlatAppearance.BorderSize = 0;
            this.Btn_conectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_conectar.ForeColor = System.Drawing.Color.White;
            this.Btn_conectar.Location = new System.Drawing.Point(155, 163);
            this.Btn_conectar.Name = "Btn_conectar";
            this.Btn_conectar.Size = new System.Drawing.Size(121, 38);
            this.Btn_conectar.TabIndex = 2;
            this.Btn_conectar.Text = "Conectar";
            this.Btn_conectar.UseVisualStyleBackColor = false;
            this.Btn_conectar.Click += new System.EventHandler(this.Btn_conectar_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(20, 163);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(121, 38);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "Cancelar";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(323, 43);
            this.panel1.TabIndex = 2;
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
            this.Btn_cerrar.Location = new System.Drawing.Point(279, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(39, 33);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Txt_clave
            // 
            this.Txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_clave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_clave.Location = new System.Drawing.Point(0, 0);
            this.Txt_clave.MaxLength = 50;
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.PasswordChar = '*';
            this.Txt_clave.Size = new System.Drawing.Size(258, 28);
            this.Txt_clave.TabIndex = 1;
            this.Txt_clave.Text = "1111";
            this.Txt_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_nro_doc
            // 
            this.Txt_nro_doc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_nro_doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_nro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nro_doc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_nro_doc.Location = new System.Drawing.Point(0, 0);
            this.Txt_nro_doc.MaxLength = 20;
            this.Txt_nro_doc.Name = "Txt_nro_doc";
            this.Txt_nro_doc.Size = new System.Drawing.Size(258, 28);
            this.Txt_nro_doc.TabIndex = 1;
            this.Txt_nro_doc.Text = "1";
            this.Txt_nro_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nro_doc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(123, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(114, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Doc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(323, 435);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 431);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LOGO_FINAL_2_page_00011;
            this.pictureBox1.Location = new System.Drawing.Point(108, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.Btn_cancel);
            this.panel8.Controls.Add(this.Lbl_usuario);
            this.panel8.Controls.Add(this.Lbl_validacion);
            this.panel8.Controls.Add(this.Btn_conectar);
            this.panel8.Location = new System.Drawing.Point(10, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(298, 268);
            this.panel8.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.Txt_clave);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(18, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 33);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 2);
            this.panel7.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.Txt_nro_doc);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(18, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 33);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 2);
            this.panel5.TabIndex = 0;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.LinkColor = System.Drawing.Color.Green;
            this.Lbl_usuario.Location = new System.Drawing.Point(93, 206);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(130, 20);
            this.Lbl_usuario.TabIndex = 4;
            this.Lbl_usuario.TabStop = true;
            this.Lbl_usuario.Text = "Registrar usuario";
            this.Lbl_usuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_usuario_LinkClicked);
            // 
            // Lbl_validacion
            // 
            this.Lbl_validacion.AutoSize = true;
            this.Lbl_validacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_validacion.LinkColor = System.Drawing.Color.Green;
            this.Lbl_validacion.Location = new System.Drawing.Point(37, 235);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(230, 20);
            this.Lbl_validacion.TabIndex = 4;
            this.Lbl_validacion.TabStop = true;
            this.Lbl_validacion.Text = "Validar conexion con el servidor";
            this.Lbl_validacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_validacion_LinkClicked);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_conectar;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.TextBox Txt_clave;
        private System.Windows.Forms.TextBox Txt_nro_doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.LinkLabel Lbl_validacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel Lbl_usuario;
    }
}

