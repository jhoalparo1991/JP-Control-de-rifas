
namespace CapaPresentacion._egresos
{
    partial class Frm_gastos
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
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_nuevos = new System.Windows.Forms.Button();
            this.Btn_cerrar_ventana = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_total = new System.Windows.Forms.ToolStripStatusLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoGastoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar_egreso = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_borrar_egreso = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_nuevos);
            this.panel1.Controls.Add(this.Btn_cerrar_ventana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(879, 46);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txt_buscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(627, 36);
            this.panel2.TabIndex = 4;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(55, 5);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(269, 22);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // Btn_nuevos
            // 
            this.Btn_nuevos.AutoSize = true;
            this.Btn_nuevos.BackColor = System.Drawing.Color.White;
            this.Btn_nuevos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_nuevos.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.Btn_nuevos.Location = new System.Drawing.Point(631, 5);
            this.Btn_nuevos.Name = "Btn_nuevos";
            this.Btn_nuevos.Size = new System.Drawing.Size(149, 36);
            this.Btn_nuevos.TabIndex = 3;
            this.Btn_nuevos.Text = "&Agregar Nuevo";
            this.Btn_nuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_nuevos.UseVisualStyleBackColor = false;
            this.Btn_nuevos.Click += new System.EventHandler(this.Btn_nuevos_Click);
            // 
            // Btn_cerrar_ventana
            // 
            this.Btn_cerrar_ventana.AutoSize = true;
            this.Btn_cerrar_ventana.BackColor = System.Drawing.Color.White;
            this.Btn_cerrar_ventana.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_cerrar_ventana.Image = global::CapaPresentacion.Properties.Resources.salir24;
            this.Btn_cerrar_ventana.Location = new System.Drawing.Point(780, 5);
            this.Btn_cerrar_ventana.Name = "Btn_cerrar_ventana";
            this.Btn_cerrar_ventana.Size = new System.Drawing.Size(95, 36);
            this.Btn_cerrar_ventana.TabIndex = 3;
            this.Btn_cerrar_ventana.Text = "&Cerrar";
            this.Btn_cerrar_ventana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_cerrar_ventana.UseVisualStyleBackColor = false;
            this.Btn_cerrar_ventana.Visible = false;
            this.Btn_cerrar_ventana.Click += new System.EventHandler(this.Btn_cerrar_ventana_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.BackgroundColor = System.Drawing.Color.White;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TipoGastoId,
            this.UsuarioId,
            this.Codigo,
            this.TipoGasto,
            this.Referencia,
            this.Descripcion,
            this.Valor,
            this.Fecha,
            this.btn_editar_egreso,
            this.btn_borrar_egreso,
            this.btn_imprimir});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 46);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowTemplate.Height = 30;
            this.Dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(879, 347);
            this.Dgv.TabIndex = 1;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Borrar";
            this.dataGridViewImageColumn2.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_total});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Total Egresos";
            // 
            // Lbl_total
            // 
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(13, 17);
            this.Lbl_total.Text = "0";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 29;
            // 
            // TipoGastoId
            // 
            this.TipoGastoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoGastoId.DataPropertyName = "TipoGastoId";
            this.TipoGastoId.HeaderText = "TipoGastoId";
            this.TipoGastoId.Name = "TipoGastoId";
            this.TipoGastoId.ReadOnly = true;
            this.TipoGastoId.Visible = false;
            this.TipoGastoId.Width = 103;
            // 
            // UsuarioId
            // 
            this.UsuarioId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UsuarioId.DataPropertyName = "UsuarioId";
            this.UsuarioId.HeaderText = "UsuarioId";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
            this.UsuarioId.Visible = false;
            this.UsuarioId.Width = 84;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 84;
            // 
            // TipoGasto
            // 
            this.TipoGasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoGasto.DataPropertyName = "TipoGasto";
            this.TipoGasto.HeaderText = "Tipo Gasto";
            this.TipoGasto.Name = "TipoGasto";
            this.TipoGasto.ReadOnly = true;
            this.TipoGasto.Width = 112;
            // 
            // Referencia
            // 
            this.Referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 112;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 71;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 79;
            // 
            // btn_editar_egreso
            // 
            this.btn_editar_egreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_editar_egreso.HeaderText = "Editar";
            this.btn_editar_egreso.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.btn_editar_egreso.Name = "btn_editar_egreso";
            this.btn_editar_egreso.ReadOnly = true;
            this.btn_editar_egreso.Width = 57;
            // 
            // btn_borrar_egreso
            // 
            this.btn_borrar_egreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_borrar_egreso.HeaderText = "Borrar";
            this.btn_borrar_egreso.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.btn_borrar_egreso.Name = "btn_borrar_egreso";
            this.btn_borrar_egreso.ReadOnly = true;
            this.btn_borrar_egreso.Width = 59;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.HeaderText = "Imprimir";
            this.btn_imprimir.Image = global::CapaPresentacion.Properties.Resources.imprimir;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.ReadOnly = true;
            // 
            // Frm_gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 415);
            this.ControlBox = false;
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        internal System.Windows.Forms.DataGridView Dgv;
        internal System.Windows.Forms.Button Btn_cerrar_ventana;
        internal System.Windows.Forms.Button Btn_nuevos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoGastoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar_egreso;
        private System.Windows.Forms.DataGridViewImageColumn btn_borrar_egreso;
        private System.Windows.Forms.DataGridViewImageColumn btn_imprimir;
    }
}