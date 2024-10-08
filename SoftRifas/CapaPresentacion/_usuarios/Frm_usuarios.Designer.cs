
namespace CapaPresentacion._usuarios
{
    partial class Frm_usuarios
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
            this.Btn_nuevos = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_cerrar_ventana = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarBoletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_nuevos);
            this.panel1.Controls.Add(this.Btn_editar);
            this.panel1.Controls.Add(this.Txt_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_borrar);
            this.panel1.Controls.Add(this.Btn_cerrar_ventana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(1086, 49);
            this.panel1.TabIndex = 0;
            // 
            // Btn_nuevos
            // 
            this.Btn_nuevos.AutoSize = true;
            this.Btn_nuevos.BackColor = System.Drawing.Color.White;
            this.Btn_nuevos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_nuevos.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.Btn_nuevos.Location = new System.Drawing.Point(690, 5);
            this.Btn_nuevos.Name = "Btn_nuevos";
            this.Btn_nuevos.Size = new System.Drawing.Size(95, 39);
            this.Btn_nuevos.TabIndex = 7;
            this.Btn_nuevos.Text = "&Nuevo";
            this.Btn_nuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_nuevos.UseVisualStyleBackColor = false;
            this.Btn_nuevos.Click += new System.EventHandler(this.Btn_nuevos_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.AutoSize = true;
            this.Btn_editar.BackColor = System.Drawing.Color.White;
            this.Btn_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_editar.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.Btn_editar.Location = new System.Drawing.Point(785, 5);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(107, 39);
            this.Btn_editar.TabIndex = 6;
            this.Btn_editar.Text = "&Modificar";
            this.Btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(120, 8);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(183, 26);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedores";
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.AutoSize = true;
            this.Btn_borrar.BackColor = System.Drawing.Color.White;
            this.Btn_borrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_borrar.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.Btn_borrar.Location = new System.Drawing.Point(892, 5);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(95, 39);
            this.Btn_borrar.TabIndex = 5;
            this.Btn_borrar.Text = "&Borrar";
            this.Btn_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_cerrar_ventana
            // 
            this.Btn_cerrar_ventana.AutoSize = true;
            this.Btn_cerrar_ventana.BackColor = System.Drawing.Color.White;
            this.Btn_cerrar_ventana.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_cerrar_ventana.Image = global::CapaPresentacion.Properties.Resources.salir24;
            this.Btn_cerrar_ventana.Location = new System.Drawing.Point(987, 5);
            this.Btn_cerrar_ventana.Name = "Btn_cerrar_ventana";
            this.Btn_cerrar_ventana.Size = new System.Drawing.Size(95, 39);
            this.Btn_cerrar_ventana.TabIndex = 4;
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
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AllowUserToOrderColumns = true;
            this.Dgv_usuarios.AllowUserToResizeColumns = false;
            this.Dgv_usuarios.AllowUserToResizeRows = false;
            this.Dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre_completo,
            this.nro_doc,
            this.direccion,
            this.celular,
            this.telefono,
            this.clave,
            this.comision,
            this.is_admin});
            this.Dgv_usuarios.ContextMenuStrip = this.contextMenuStrip1;
            this.Dgv_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_usuarios.Location = new System.Drawing.Point(0, 49);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.RowHeadersVisible = false;
            this.Dgv_usuarios.RowTemplate.Height = 30;
            this.Dgv_usuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_usuarios.Size = new System.Drawing.Size(1086, 406);
            this.Dgv_usuarios.TabIndex = 1;
            this.Dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellClick);
            this.Dgv_usuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre_completo
            // 
            this.nombre_completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_completo.DataPropertyName = "NombreCompleto";
            this.nombre_completo.HeaderText = "Nombres y Apellidos";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            // 
            // nro_doc
            // 
            this.nro_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nro_doc.DataPropertyName = "NroDoc";
            this.nro_doc.HeaderText = "Nro Doc";
            this.nro_doc.Name = "nro_doc";
            this.nro_doc.ReadOnly = true;
            this.nro_doc.Width = 85;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.celular.DataPropertyName = "Celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 83;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 96;
            // 
            // clave
            // 
            this.clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clave.DataPropertyName = "Clave";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // comision
            // 
            this.comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comision.DataPropertyName = "Comision";
            this.comision.HeaderText = "% comision";
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            this.comision.Width = 105;
            // 
            // is_admin
            // 
            this.is_admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.is_admin.DataPropertyName = "IsAdmin";
            this.is_admin.HeaderText = "Admin";
            this.is_admin.Name = "is_admin";
            this.is_admin.ReadOnly = true;
            this.is_admin.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarBoletasToolStripMenuItem,
            this.verInformacionToolStripMenuItem,
            this.modificarVendedorToolStripMenuItem,
            this.borrarVendedorToolStripMenuItem,
            this.agregarNuevoVendedorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 114);
            // 
            // agregarBoletasToolStripMenuItem
            // 
            this.agregarBoletasToolStripMenuItem.Name = "agregarBoletasToolStripMenuItem";
            this.agregarBoletasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.agregarBoletasToolStripMenuItem.Text = "Agregar Boletas";
            this.agregarBoletasToolStripMenuItem.Click += new System.EventHandler(this.agregarBoletasToolStripMenuItem_Click);
            // 
            // verInformacionToolStripMenuItem
            // 
            this.verInformacionToolStripMenuItem.Name = "verInformacionToolStripMenuItem";
            this.verInformacionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.verInformacionToolStripMenuItem.Text = "Ver informacion";
            this.verInformacionToolStripMenuItem.Click += new System.EventHandler(this.verInformacionToolStripMenuItem_Click);
            // 
            // modificarVendedorToolStripMenuItem
            // 
            this.modificarVendedorToolStripMenuItem.Name = "modificarVendedorToolStripMenuItem";
            this.modificarVendedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.modificarVendedorToolStripMenuItem.Text = "Modificar vendedor";
            this.modificarVendedorToolStripMenuItem.Click += new System.EventHandler(this.modificarVendedorToolStripMenuItem_Click);
            // 
            // borrarVendedorToolStripMenuItem
            // 
            this.borrarVendedorToolStripMenuItem.Name = "borrarVendedorToolStripMenuItem";
            this.borrarVendedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.borrarVendedorToolStripMenuItem.Text = "Borrar Vendedor";
            this.borrarVendedorToolStripMenuItem.Click += new System.EventHandler(this.borrarVendedorToolStripMenuItem_Click);
            // 
            // agregarNuevoVendedorToolStripMenuItem
            // 
            this.agregarNuevoVendedorToolStripMenuItem.Name = "agregarNuevoVendedorToolStripMenuItem";
            this.agregarNuevoVendedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.agregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor";
            this.agregarNuevoVendedorToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoVendedorToolStripMenuItem_Click);
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
            // Frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 455);
            this.ControlBox = false;
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        internal System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarBoletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoVendedorToolStripMenuItem;
        internal System.Windows.Forms.Button Btn_cerrar_ventana;
        internal System.Windows.Forms.Button Btn_borrar;
        internal System.Windows.Forms.Button Btn_editar;
        internal System.Windows.Forms.Button Btn_nuevos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_admin;
    }
}