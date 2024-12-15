
namespace CapaPresentacion._rifas_boletas._boletas
{
    partial class Frm_desbloquear_boletas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_boleta = new System.Windows.Forms.TextBox();
            this.btnDesbloquear = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desbloquear boletas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarVentana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrarVentana.IconColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarVentana.IconSize = 32;
            this.btnCerrarVentana.Location = new System.Drawing.Point(238, 0);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(37, 40);
            this.btnCerrarVentana.TabIndex = 1;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 116);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa el numero de la boleta que deseas desbloquear";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_boleta
            // 
            this.Txt_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_boleta.Location = new System.Drawing.Point(18, 192);
            this.Txt_boleta.MaxLength = 10;
            this.Txt_boleta.Name = "Txt_boleta";
            this.Txt_boleta.Size = new System.Drawing.Size(265, 68);
            this.Txt_boleta.TabIndex = 3;
            this.Txt_boleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_boleta_KeyPress);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackColor = System.Drawing.Color.Transparent;
            this.btnDesbloquear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDesbloquear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDesbloquear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnDesbloquear.IconColor = System.Drawing.Color.Green;
            this.btnDesbloquear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesbloquear.IconSize = 32;
            this.btnDesbloquear.Location = new System.Drawing.Point(36, 275);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(230, 40);
            this.btnDesbloquear.TabIndex = 4;
            this.btnDesbloquear.Text = "Desbloquear boleta";
            this.btnDesbloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesbloquear.UseVisualStyleBackColor = false;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // Frm_desbloquear_boletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 328);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.Txt_boleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_desbloquear_boletas";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_desbloquear_boletas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrarVentana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_boleta;
        private FontAwesome.Sharp.IconButton btnDesbloquear;
    }
}