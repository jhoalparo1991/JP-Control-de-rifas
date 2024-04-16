
namespace CapaPresentacion._clientes
{
    partial class Frm_clientes
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
            this.Btn_cerrar_ventana = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_nuevos = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dgv_clientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Pn_mant = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_dir = new System.Windows.Forms.TextBox();
            this.Txt_cel = new System.Windows.Forms.TextBox();
            this.Txt_tel = new System.Windows.Forms.TextBox();
            this.Txt_nro_doc = new System.Windows.Forms.TextBox();
            this.Txt_nombres = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).BeginInit();
            this.Pn_mant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_cerrar_ventana);
            this.panel1.Controls.Add(this.Btn_borrar);
            this.panel1.Controls.Add(this.Btn_editar);
            this.panel1.Controls.Add(this.Btn_nuevos);
            this.panel1.Controls.Add(this.Txt_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(825, 46);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar_ventana
            // 
            this.Btn_cerrar_ventana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cerrar_ventana.AutoSize = true;
            this.Btn_cerrar_ventana.BackColor = System.Drawing.Color.White;
            this.Btn_cerrar_ventana.Image = global::CapaPresentacion.Properties.Resources.salir24;
            this.Btn_cerrar_ventana.Location = new System.Drawing.Point(725, 3);
            this.Btn_cerrar_ventana.Name = "Btn_cerrar_ventana";
            this.Btn_cerrar_ventana.Size = new System.Drawing.Size(95, 38);
            this.Btn_cerrar_ventana.TabIndex = 3;
            this.Btn_cerrar_ventana.Text = "&Cerrar";
            this.Btn_cerrar_ventana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_cerrar_ventana.UseVisualStyleBackColor = false;
            this.Btn_cerrar_ventana.Click += new System.EventHandler(this.Btn_cerrar_ventana_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_borrar.AutoSize = true;
            this.Btn_borrar.BackColor = System.Drawing.Color.White;
            this.Btn_borrar.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.Btn_borrar.Location = new System.Drawing.Point(629, 3);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(95, 38);
            this.Btn_borrar.TabIndex = 3;
            this.Btn_borrar.Text = "&Borrar";
            this.Btn_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_editar.AutoSize = true;
            this.Btn_editar.BackColor = System.Drawing.Color.White;
            this.Btn_editar.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.Btn_editar.Location = new System.Drawing.Point(521, 3);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(107, 38);
            this.Btn_editar.TabIndex = 3;
            this.Btn_editar.Text = "&Modificar";
            this.Btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_nuevos
            // 
            this.Btn_nuevos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_nuevos.AutoSize = true;
            this.Btn_nuevos.BackColor = System.Drawing.Color.White;
            this.Btn_nuevos.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.Btn_nuevos.Location = new System.Drawing.Point(425, 3);
            this.Btn_nuevos.Name = "Btn_nuevos";
            this.Btn_nuevos.Size = new System.Drawing.Size(95, 38);
            this.Btn_nuevos.TabIndex = 3;
            this.Btn_nuevos.Text = "&Nuevo";
            this.Btn_nuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_nuevos.UseVisualStyleBackColor = false;
            this.Btn_nuevos.Click += new System.EventHandler(this.Btn_nuevos_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(137, 10);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(228, 22);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de clientes";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Dgv_clientes
            // 
            this.Dgv_clientes.AllowUserToAddRows = false;
            this.Dgv_clientes.AllowUserToDeleteRows = false;
            this.Dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre_completo,
            this.nro_doc,
            this.direccion,
            this.celular,
            this.telefono,
            this.btn_sel});
            this.Dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_clientes.Location = new System.Drawing.Point(0, 46);
            this.Dgv_clientes.Name = "Dgv_clientes";
            this.Dgv_clientes.ReadOnly = true;
            this.Dgv_clientes.RowHeadersVisible = false;
            this.Dgv_clientes.RowTemplate.Height = 30;
            this.Dgv_clientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_clientes.Size = new System.Drawing.Size(422, 369);
            this.Dgv_clientes.TabIndex = 1;
            this.Dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_clientes_CellClick);
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
            this.celular.Visible = false;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            // 
            // btn_sel
            // 
            this.btn_sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_sel.HeaderText = "Seleccionar";
            this.btn_sel.Image = global::CapaPresentacion.Properties.Resources.seleccion;
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.ReadOnly = true;
            this.btn_sel.Visible = false;
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
            // Pn_mant
            // 
            this.Pn_mant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pn_mant.Controls.Add(this.iconPictureBox1);
            this.Pn_mant.Controls.Add(this.label9);
            this.Pn_mant.Controls.Add(this.Btn_registrar);
            this.Pn_mant.Controls.Add(this.Btn_cancelar);
            this.Pn_mant.Controls.Add(this.Txt_dir);
            this.Pn_mant.Controls.Add(this.Txt_cel);
            this.Pn_mant.Controls.Add(this.Txt_tel);
            this.Pn_mant.Controls.Add(this.Txt_nro_doc);
            this.Pn_mant.Controls.Add(this.Txt_nombres);
            this.Pn_mant.Controls.Add(this.Txt_id);
            this.Pn_mant.Controls.Add(this.label7);
            this.Pn_mant.Controls.Add(this.label6);
            this.Pn_mant.Controls.Add(this.label5);
            this.Pn_mant.Controls.Add(this.label4);
            this.Pn_mant.Controls.Add(this.label3);
            this.Pn_mant.Controls.Add(this.label8);
            this.Pn_mant.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pn_mant.Location = new System.Drawing.Point(422, 46);
            this.Pn_mant.Name = "Pn_mant";
            this.Pn_mant.Size = new System.Drawing.Size(403, 369);
            this.Pn_mant.TabIndex = 2;
            this.Pn_mant.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(358, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 32;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(20, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mantenimiento de rifas";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_registrar.FlatAppearance.BorderSize = 0;
            this.Btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(226, 310);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(109, 38);
            this.Btn_registrar.TabIndex = 23;
            this.Btn_registrar.Text = "Registrar";
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Location = new System.Drawing.Point(62, 310);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(109, 38);
            this.Btn_cancelar.TabIndex = 24;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_dir
            // 
            this.Txt_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dir.Location = new System.Drawing.Point(13, 216);
            this.Txt_dir.MaxLength = 100;
            this.Txt_dir.Name = "Txt_dir";
            this.Txt_dir.Size = new System.Drawing.Size(374, 26);
            this.Txt_dir.TabIndex = 20;
            // 
            // Txt_cel
            // 
            this.Txt_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cel.Location = new System.Drawing.Point(198, 274);
            this.Txt_cel.MaxLength = 10;
            this.Txt_cel.Name = "Txt_cel";
            this.Txt_cel.Size = new System.Drawing.Size(189, 26);
            this.Txt_cel.TabIndex = 22;
            this.Txt_cel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cel_KeyPress);
            // 
            // Txt_tel
            // 
            this.Txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tel.Location = new System.Drawing.Point(13, 274);
            this.Txt_tel.MaxLength = 10;
            this.Txt_tel.Name = "Txt_tel";
            this.Txt_tel.Size = new System.Drawing.Size(173, 26);
            this.Txt_tel.TabIndex = 21;
            this.Txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_tel_KeyPress);
            // 
            // Txt_nro_doc
            // 
            this.Txt_nro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nro_doc.Location = new System.Drawing.Point(13, 161);
            this.Txt_nro_doc.MaxLength = 20;
            this.Txt_nro_doc.Name = "Txt_nro_doc";
            this.Txt_nro_doc.Size = new System.Drawing.Size(173, 26);
            this.Txt_nro_doc.TabIndex = 19;
            this.Txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nro_doc_KeyPress);
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombres.Location = new System.Drawing.Point(13, 108);
            this.Txt_nombres.MaxLength = 150;
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Size = new System.Drawing.Size(377, 26);
            this.Txt_nombres.TabIndex = 18;
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(81, 49);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.ReadOnly = true;
            this.Txt_id.Size = new System.Drawing.Size(100, 26);
            this.Txt_id.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nro Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombres y Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Codigo";
            // 
            // Frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 415);
            this.ControlBox = false;
            this.Controls.Add(this.Dgv_clientes);
            this.Controls.Add(this.Pn_mant);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).EndInit();
            this.Pn_mant.ResumeLayout(false);
            this.Pn_mant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        internal System.Windows.Forms.DataGridView Dgv_clientes;
        private System.Windows.Forms.Panel Pn_mant;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_cancelar;
        internal System.Windows.Forms.TextBox Txt_dir;
        internal System.Windows.Forms.TextBox Txt_cel;
        internal System.Windows.Forms.TextBox Txt_tel;
        internal System.Windows.Forms.TextBox Txt_nro_doc;
        internal System.Windows.Forms.TextBox Txt_nombres;
        internal System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewImageColumn btn_sel;
        internal System.Windows.Forms.Button Btn_cerrar_ventana;
        internal System.Windows.Forms.Button Btn_borrar;
        internal System.Windows.Forms.Button Btn_editar;
        internal System.Windows.Forms.Button Btn_nuevos;
    }
}