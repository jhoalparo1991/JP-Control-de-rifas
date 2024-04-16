
namespace CapaPresentacion._rifas_boletas
{
    partial class Frm_rifas
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
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_nuevos = new System.Windows.Forms.Button();
            this.Chk_mostrar_activas = new System.Windows.Forms.CheckBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dgv_rifas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ValorRifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.chk_activa = new System.Windows.Forms.CheckBox();
            this.dt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dt_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nro_fin = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_nro_ini = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rifas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Btn_borrar);
            this.panel1.Controls.Add(this.Btn_editar);
            this.panel1.Controls.Add(this.Btn_nuevos);
            this.panel1.Controls.Add(this.Chk_mostrar_activas);
            this.panel1.Controls.Add(this.Txt_buscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(874, 58);
            this.panel1.TabIndex = 0;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_borrar.AutoSize = true;
            this.Btn_borrar.BackColor = System.Drawing.Color.White;
            this.Btn_borrar.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.Btn_borrar.Location = new System.Drawing.Point(769, 11);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(95, 38);
            this.Btn_borrar.TabIndex = 5;
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
            this.Btn_editar.Location = new System.Drawing.Point(661, 11);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(107, 38);
            this.Btn_editar.TabIndex = 6;
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
            this.Btn_nuevos.Location = new System.Drawing.Point(565, 11);
            this.Btn_nuevos.Name = "Btn_nuevos";
            this.Btn_nuevos.Size = new System.Drawing.Size(95, 38);
            this.Btn_nuevos.TabIndex = 7;
            this.Btn_nuevos.Text = "&Nuevo";
            this.Btn_nuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_nuevos.UseVisualStyleBackColor = false;
            this.Btn_nuevos.Click += new System.EventHandler(this.Btn_nuevos_Click);
            // 
            // Chk_mostrar_activas
            // 
            this.Chk_mostrar_activas.AutoSize = true;
            this.Chk_mostrar_activas.Checked = true;
            this.Chk_mostrar_activas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_mostrar_activas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_mostrar_activas.ForeColor = System.Drawing.Color.White;
            this.Chk_mostrar_activas.Location = new System.Drawing.Point(12, 19);
            this.Chk_mostrar_activas.Name = "Chk_mostrar_activas";
            this.Chk_mostrar_activas.Size = new System.Drawing.Size(161, 22);
            this.Chk_mostrar_activas.TabIndex = 3;
            this.Chk_mostrar_activas.Text = "Mostrar rifas activas";
            this.Chk_mostrar_activas.UseVisualStyleBackColor = true;
            this.Chk_mostrar_activas.CheckedChanged += new System.EventHandler(this.Chk_mostrar_activas_CheckedChanged);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(290, 18);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(228, 24);
            this.Txt_buscar.TabIndex = 2;
            this.Txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtrar";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Dgv_rifas
            // 
            this.Dgv_rifas.AllowUserToAddRows = false;
            this.Dgv_rifas.AllowUserToDeleteRows = false;
            this.Dgv_rifas.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_rifas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_rifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.FechaInicio,
            this.FechaFin,
            this.NroInicial,
            this.NroFinal,
            this.Activa,
            this.ValorRifa,
            this.rUsuarioId});
            this.Dgv_rifas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_rifas.Location = new System.Drawing.Point(0, 58);
            this.Dgv_rifas.Name = "Dgv_rifas";
            this.Dgv_rifas.ReadOnly = true;
            this.Dgv_rifas.RowHeadersVisible = false;
            this.Dgv_rifas.RowTemplate.Height = 30;
            this.Dgv_rifas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_rifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_rifas.Size = new System.Drawing.Size(565, 456);
            this.Dgv_rifas.TabIndex = 1;
            this.Dgv_rifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rifas_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 120;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Final";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 117;
            // 
            // NroInicial
            // 
            this.NroInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NroInicial.DataPropertyName = "NroInicial";
            this.NroInicial.HeaderText = "Nro Inicial";
            this.NroInicial.Name = "NroInicial";
            this.NroInicial.ReadOnly = true;
            this.NroInicial.Width = 103;
            // 
            // NroFinal
            // 
            this.NroFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NroFinal.DataPropertyName = "NroFinal";
            this.NroFinal.HeaderText = "Nro Final";
            this.NroFinal.Name = "NroFinal";
            this.NroFinal.ReadOnly = true;
            this.NroFinal.Width = 97;
            // 
            // Activa
            // 
            this.Activa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Activa.DataPropertyName = "Activa";
            this.Activa.HeaderText = "Activa";
            this.Activa.Name = "Activa";
            this.Activa.ReadOnly = true;
            this.Activa.Visible = false;
            // 
            // ValorRifa
            // 
            this.ValorRifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValorRifa.DataPropertyName = "ValorRifa";
            this.ValorRifa.HeaderText = "Valor";
            this.ValorRifa.Name = "ValorRifa";
            this.ValorRifa.ReadOnly = true;
            this.ValorRifa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValorRifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValorRifa.Width = 52;
            // 
            // rUsuarioId
            // 
            this.rUsuarioId.DataPropertyName = "UsuarioId";
            this.rUsuarioId.HeaderText = "UsuarioId";
            this.rUsuarioId.Name = "rUsuarioId";
            this.rUsuarioId.ReadOnly = true;
            this.rUsuarioId.Visible = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.chk_activa);
            this.panel2.Controls.Add(this.dt_fecha_fin);
            this.panel2.Controls.Add(this.dt_fecha_inicio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Btn_registrar);
            this.panel2.Controls.Add(this.Btn_cancelar);
            this.panel2.Controls.Add(this.txt_nro_fin);
            this.panel2.Controls.Add(this.txt_valor);
            this.panel2.Controls.Add(this.txt_nro_ini);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(565, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 456);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(269, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 30;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // chk_activa
            // 
            this.chk_activa.AutoSize = true;
            this.chk_activa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_activa.Location = new System.Drawing.Point(163, 272);
            this.chk_activa.Name = "chk_activa";
            this.chk_activa.Size = new System.Drawing.Size(71, 24);
            this.chk_activa.TabIndex = 8;
            this.chk_activa.Text = "Activa";
            this.chk_activa.UseVisualStyleBackColor = true;
            // 
            // dt_fecha_fin
            // 
            this.dt_fecha_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_fin.Location = new System.Drawing.Point(163, 135);
            this.dt_fecha_fin.Name = "dt_fecha_fin";
            this.dt_fecha_fin.Size = new System.Drawing.Size(127, 26);
            this.dt_fecha_fin.TabIndex = 4;
            // 
            // dt_fecha_inicio
            // 
            this.dt_fecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_inicio.Location = new System.Drawing.Point(13, 135);
            this.dt_fecha_inicio.Name = "dt_fecha_inicio";
            this.dt_fecha_inicio.Size = new System.Drawing.Size(144, 26);
            this.dt_fecha_inicio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(17, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mantenimiento de rifas";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_registrar.FlatAppearance.BorderSize = 0;
            this.Btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(154, 317);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(120, 38);
            this.Btn_registrar.TabIndex = 9;
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
            this.Btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Location = new System.Drawing.Point(15, 317);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(120, 38);
            this.Btn_cancelar.TabIndex = 10;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // txt_nro_fin
            // 
            this.txt_nro_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_fin.Location = new System.Drawing.Point(159, 207);
            this.txt_nro_fin.MaxLength = 10;
            this.txt_nro_fin.Name = "txt_nro_fin";
            this.txt_nro_fin.Size = new System.Drawing.Size(140, 26);
            this.txt_nro_fin.TabIndex = 6;
            this.txt_nro_fin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_fin_KeyPress);
            this.txt_nro_fin.Leave += new System.EventHandler(this.txt_nro_fin_Leave);
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(13, 270);
            this.txt_valor.MaxLength = 10;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(140, 26);
            this.txt_valor.TabIndex = 7;
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            this.txt_valor.Leave += new System.EventHandler(this.txt_valor_Leave);
            // 
            // txt_nro_ini
            // 
            this.txt_nro_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_ini.Location = new System.Drawing.Point(13, 207);
            this.txt_nro_ini.MaxLength = 10;
            this.txt_nro_ini.Name = "txt_nro_ini";
            this.txt_nro_ini.Size = new System.Drawing.Size(136, 26);
            this.txt_nro_ini.TabIndex = 5;
            this.txt_nro_ini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_ini_KeyPress);
            this.txt_nro_ini.Leave += new System.EventHandler(this.txt_nro_ini_Leave);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(13, 68);
            this.txt_descripcion.MaxLength = 150;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(273, 26);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(95, 374);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(114, 27);
            this.txt_id.TabIndex = 1;
            this.txt_id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nro final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor rifa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nro Inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo";
            this.label6.Visible = false;
            // 
            // Frm_rifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 514);
            this.ControlBox = false;
            this.Controls.Add(this.Dgv_rifas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_rifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rifas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridView Dgv_rifas;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.CheckBox Chk_mostrar_activas;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.CheckBox chk_activa;
        internal System.Windows.Forms.DateTimePicker dt_fecha_fin;
        internal System.Windows.Forms.DateTimePicker dt_fecha_inicio;
        internal System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_cancelar;
        internal System.Windows.Forms.TextBox txt_nro_fin;
        internal System.Windows.Forms.TextBox txt_valor;
        internal System.Windows.Forms.TextBox txt_nro_ini;
        internal System.Windows.Forms.TextBox txt_descripcion;
        internal System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        internal System.Windows.Forms.Button Btn_borrar;
        internal System.Windows.Forms.Button Btn_editar;
        internal System.Windows.Forms.Button Btn_nuevos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUsuarioId;
    }
}