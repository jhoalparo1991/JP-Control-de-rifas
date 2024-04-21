
namespace CapaPresentacion._pagos
{
    partial class Frm_quitar_cobro
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.detalle_pago_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boleta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_boleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(630, 40);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(595, 5);
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
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle pagado";
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.BackgroundColor = System.Drawing.Color.White;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle_pago_id,
            this.id,
            this.boleta_id,
            this.pago_id,
            this.codigo_abono,
            this.vendedor_id,
            this.pagado,
            this.vendedor,
            this.fecha,
            this.nro_boleta,
            this.valor_comision,
            this.btn_quitar});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 40);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowTemplate.Height = 30;
            this.Dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(630, 364);
            this.Dgv.TabIndex = 17;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Seleccionar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.seleccion;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // detalle_pago_id
            // 
            this.detalle_pago_id.DataPropertyName = "detalle_pago_id";
            this.detalle_pago_id.HeaderText = "detalle_pago_id";
            this.detalle_pago_id.Name = "detalle_pago_id";
            this.detalle_pago_id.ReadOnly = true;
            this.detalle_pago_id.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // boleta_id
            // 
            this.boleta_id.DataPropertyName = "boleta_id";
            this.boleta_id.HeaderText = "boleta_id";
            this.boleta_id.Name = "boleta_id";
            this.boleta_id.ReadOnly = true;
            this.boleta_id.Visible = false;
            // 
            // pago_id
            // 
            this.pago_id.DataPropertyName = "pago_id";
            this.pago_id.HeaderText = "pago_id";
            this.pago_id.Name = "pago_id";
            this.pago_id.ReadOnly = true;
            this.pago_id.Visible = false;
            // 
            // codigo_abono
            // 
            this.codigo_abono.DataPropertyName = "codigo_abono";
            this.codigo_abono.HeaderText = "codigo_abono";
            this.codigo_abono.Name = "codigo_abono";
            this.codigo_abono.ReadOnly = true;
            this.codigo_abono.Visible = false;
            // 
            // vendedor_id
            // 
            this.vendedor_id.DataPropertyName = "vendedor_id";
            this.vendedor_id.HeaderText = "vendedor_id";
            this.vendedor_id.Name = "vendedor_id";
            this.vendedor_id.ReadOnly = true;
            this.vendedor_id.Visible = false;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "pagado";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            this.pagado.Visible = false;
            // 
            // vendedor
            // 
            this.vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vendedor.DataPropertyName = "vendedor";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha Pago";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 109;
            // 
            // nro_boleta
            // 
            this.nro_boleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nro_boleta.DataPropertyName = "nro_boleta";
            this.nro_boleta.HeaderText = "Nro Boleta";
            this.nro_boleta.Name = "nro_boleta";
            this.nro_boleta.ReadOnly = true;
            // 
            // valor_comision
            // 
            this.valor_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_comision.DataPropertyName = "valor_comision";
            this.valor_comision.HeaderText = "Valor Pagado";
            this.valor_comision.Name = "valor_comision";
            this.valor_comision.ReadOnly = true;
            this.valor_comision.Width = 119;
            // 
            // btn_quitar
            // 
            this.btn_quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_quitar.HeaderText = "Quitar";
            this.btn_quitar.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.ReadOnly = true;
            this.btn_quitar.Width = 53;
            // 
            // Frm_quitar_cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 404);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_quitar_cobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_quitar_cobro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_pago_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn boleta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_boleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_comision;
        private System.Windows.Forms.DataGridViewImageColumn btn_quitar;
    }
}