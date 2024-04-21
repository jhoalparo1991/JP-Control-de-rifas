
namespace CapaPresentacion._egresos
{
    partial class Frm_registrar_egresos
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
            this.cbx_tipo_egreso = new System.Windows.Forms.ComboBox();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(505, 40);
            this.panel1.TabIndex = 1;
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
            this.Btn_cerrar.Location = new System.Drawing.Point(470, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(31, 30);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de egresos";
            // 
            // cbx_tipo_egreso
            // 
            this.cbx_tipo_egreso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_tipo_egreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_tipo_egreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo_egreso.FormattingEnabled = true;
            this.cbx_tipo_egreso.Location = new System.Drawing.Point(114, 63);
            this.cbx_tipo_egreso.Name = "cbx_tipo_egreso";
            this.cbx_tipo_egreso.Size = new System.Drawing.Size(370, 28);
            this.cbx_tipo_egreso.TabIndex = 0;
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_registrar.FlatAppearance.BorderSize = 0;
            this.Btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(295, 361);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(108, 38);
            this.Btn_registrar.TabIndex = 5;
            this.Btn_registrar.Text = "&Guardar";
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(158, 361);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(108, 38);
            this.Btn_cancel.TabIndex = 6;
            this.Btn_cancel.Text = "&Cancelar";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(316, 306);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(16, 17);
            this.Lbl_id.TabIndex = 13;
            this.Lbl_id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo de gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Referencia";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(114, 101);
            this.txt_referencia.MaxLength = 50;
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(370, 23);
            this.txt_referencia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(114, 130);
            this.txt_descripcion.MaxLength = 255;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(370, 167);
            this.txt_descripcion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(114, 303);
            this.txt_valor.MaxLength = 50;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(196, 23);
            this.txt_valor.TabIndex = 3;
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha egreso";
            // 
            // dt_fecha
            // 
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(114, 332);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(141, 23);
            this.dt_fecha.TabIndex = 4;
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Location = new System.Drawing.Point(338, 306);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(16, 17);
            this.lblUsuarioId.TabIndex = 13;
            this.lblUsuarioId.Text = "0";
            // 
            // Frm_registrar_egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuarioId);
            this.Controls.Add(this.Lbl_id);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.cbx_tipo_egreso);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_registrar_egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_cambiar_forma_pago_boleta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_cancel;
        internal System.Windows.Forms.Label Lbl_id;
        internal System.Windows.Forms.ComboBox cbx_tipo_egreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblUsuarioId;
        internal System.Windows.Forms.TextBox txt_referencia;
        internal System.Windows.Forms.TextBox txt_descripcion;
        internal System.Windows.Forms.TextBox txt_valor;
        internal System.Windows.Forms.DateTimePicker dt_fecha;
    }
}