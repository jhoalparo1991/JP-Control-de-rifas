
namespace CapaPresentacion._reportes
{
    partial class Frm_reporte_boletas_vendedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spmostrarabonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_boleta_id = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_mostrar_abonosTableAdapter = new CapaPresentacion.DataSet1TableAdapters.sp_mostrar_abonosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarabonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spmostrarabonosBindingSource
            // 
            this.spmostrarabonosBindingSource.DataMember = "sp_mostrar_abonos";
            this.spmostrarabonosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Size = new System.Drawing.Size(649, 40);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(614, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(31, 30);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte  de boletas por vendedor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txt_boleta_id);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel2.Size = new System.Drawing.Size(649, 589);
            this.panel2.TabIndex = 2;
            // 
            // Txt_boleta_id
            // 
            this.Txt_boleta_id.Location = new System.Drawing.Point(39, 55);
            this.Txt_boleta_id.Name = "Txt_boleta_id";
            this.Txt_boleta_id.Size = new System.Drawing.Size(90, 26);
            this.Txt_boleta_id.TabIndex = 1;
            this.Txt_boleta_id.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrarabonosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion._reportes.Rpt_boletas_vendedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(631, 569);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_mostrar_abonosTableAdapter
            // 
            this.sp_mostrar_abonosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_reporte_boletas_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_reporte_boletas_vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_reporte_boletas_vendedor";
            this.Load += new System.EventHandler(this.Frm_reporte_boletas_vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarabonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrarabonosBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.sp_mostrar_abonosTableAdapter sp_mostrar_abonosTableAdapter;
        internal System.Windows.Forms.TextBox Txt_boleta_id;
    }
}