
namespace CapaPresentacion._auxiliar_instalacion
{
    partial class Frm_validar_conexion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_conectar = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Txt_db = new System.Windows.Forms.TextBox();
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.Txt_server = new System.Windows.Forms.TextBox();
            this.Chk_security = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(427, 44);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar_ventana_32_blanco;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(388, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validar Conexion";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(427, 218);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Btn_conectar);
            this.panel3.Controls.Add(this.Btn_cancel);
            this.panel3.Controls.Add(this.Txt_pass);
            this.panel3.Controls.Add(this.Txt_db);
            this.panel3.Controls.Add(this.Txt_user);
            this.panel3.Controls.Add(this.Txt_server);
            this.panel3.Controls.Add(this.Chk_security);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 214);
            this.panel3.TabIndex = 0;
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
            this.Btn_conectar.Location = new System.Drawing.Point(294, 164);
            this.Btn_conectar.Name = "Btn_conectar";
            this.Btn_conectar.Size = new System.Drawing.Size(109, 38);
            this.Btn_conectar.TabIndex = 3;
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
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_cancel.Location = new System.Drawing.Point(130, 164);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(109, 38);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "Cancelar";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Txt_pass
            // 
            this.Txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_pass.Location = new System.Drawing.Point(130, 105);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(273, 23);
            this.Txt_pass.TabIndex = 2;
            // 
            // Txt_db
            // 
            this.Txt_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_db.Location = new System.Drawing.Point(130, 73);
            this.Txt_db.Name = "Txt_db";
            this.Txt_db.Size = new System.Drawing.Size(273, 23);
            this.Txt_db.TabIndex = 2;
            // 
            // Txt_user
            // 
            this.Txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_user.Location = new System.Drawing.Point(130, 44);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.Size = new System.Drawing.Size(273, 23);
            this.Txt_user.TabIndex = 2;
            // 
            // Txt_server
            // 
            this.Txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_server.Location = new System.Drawing.Point(130, 13);
            this.Txt_server.Name = "Txt_server";
            this.Txt_server.Size = new System.Drawing.Size(273, 23);
            this.Txt_server.TabIndex = 2;
            // 
            // Chk_security
            // 
            this.Chk_security.AutoSize = true;
            this.Chk_security.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Chk_security.Location = new System.Drawing.Point(130, 136);
            this.Chk_security.Name = "Chk_security";
            this.Chk_security.Size = new System.Drawing.Size(156, 21);
            this.Chk_security.TabIndex = 1;
            this.Chk_security.Text = "Seguridad Integrada";
            this.Chk_security.UseVisualStyleBackColor = true;
            this.Chk_security.CheckedChanged += new System.EventHandler(this.Chk_security_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(22, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(22, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Base de datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servidor";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Frm_validar_conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_validar_conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.TextBox Txt_db;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_server;
        private System.Windows.Forms.CheckBox Chk_security;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_conectar;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.ErrorProvider error;
    }
}