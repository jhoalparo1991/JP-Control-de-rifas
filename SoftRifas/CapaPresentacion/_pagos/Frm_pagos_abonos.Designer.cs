
namespace CapaPresentacion._pagos
{
    partial class Frm_pagos_abonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_usuario_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_identificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Pn_pagos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_registrar_pago = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_nuevos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Pn_nuevos_pagos = new System.Windows.Forms.Panel();
            this.Pn_listado_vendedores = new System.Windows.Forms.Panel();
            this.dgv_vendedores = new System.Windows.Forms.DataGridView();
            this.usId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usIsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_cerrar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Dgv_nuevos_pagos = new System.Windows.Forms.DataGridView();
            this.pago_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_punto_1 = new System.Windows.Forms.Label();
            this.cbx_forma_pago = new System.Windows.Forms.ComboBox();
            this.txt_valor_pagar = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.btn_agregar_pago = new System.Windows.Forms.Button();
            this.Txt_nro_doc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_vendedor_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dgv_detalle_pagos_realizados = new System.Windows.Forms.DataGridView();
            this.d_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_PagoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_VendedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_ValorPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_PeriodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_Pagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_quitar_pagos = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Dgv_pagos = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_periodo_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_hora_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_valor_pagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_fecha_ini_pago = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dt_fecha_fin_pago = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pn_pagos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Pn_nuevos_pagos.SuspendLayout();
            this.Pn_listado_vendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_nuevos_pagos)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_pagos_realizados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Enabled = false;
            this.Txt_usuario.Location = new System.Drawing.Point(139, 13);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(374, 23);
            this.Txt_usuario.TabIndex = 0;
            // 
            // txt_usuario_id
            // 
            this.txt_usuario_id.Enabled = false;
            this.txt_usuario_id.Location = new System.Drawing.Point(321, 133);
            this.txt_usuario_id.Name = "txt_usuario_id";
            this.txt_usuario_id.Size = new System.Drawing.Size(49, 23);
            this.txt_usuario_id.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Pago";
            // 
            // txt_identificador
            // 
            this.txt_identificador.Enabled = false;
            this.txt_identificador.Location = new System.Drawing.Point(139, 42);
            this.txt_identificador.Name = "txt_identificador";
            this.txt_identificador.Size = new System.Drawing.Size(374, 23);
            this.txt_identificador.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Pago";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(139, 72);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(155, 23);
            this.txt_fecha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hora Pago";
            // 
            // txt_hora
            // 
            this.txt_hora.Enabled = false;
            this.txt_hora.Location = new System.Drawing.Point(382, 72);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(131, 23);
            this.txt_hora.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Periodo pagado del";
            // 
            // dt_fecha_ini
            // 
            this.dt_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_ini.Location = new System.Drawing.Point(139, 104);
            this.dt_fecha_ini.Name = "dt_fecha_ini";
            this.dt_fecha_ini.Size = new System.Drawing.Size(130, 23);
            this.dt_fecha_ini.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "al";
            // 
            // dt_fecha_fin
            // 
            this.dt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_fin.Location = new System.Drawing.Point(300, 104);
            this.dt_fecha_fin.Name = "dt_fecha_fin";
            this.dt_fecha_fin.Size = new System.Drawing.Size(130, 23);
            this.dt_fecha_fin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total pagado";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(139, 133);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(176, 23);
            this.txt_total.TabIndex = 6;
            // 
            // Txt_id
            // 
            this.Txt_id.Enabled = false;
            this.Txt_id.Location = new System.Drawing.Point(376, 133);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(49, 23);
            this.Txt_id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(535, 41);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(328, 118);
            this.txt_descripcion.TabIndex = 9;
            // 
            // Pn_pagos
            // 
            this.Pn_pagos.Controls.Add(this.Txt_usuario);
            this.Pn_pagos.Controls.Add(this.txt_descripcion);
            this.Pn_pagos.Controls.Add(this.label1);
            this.Pn_pagos.Controls.Add(this.label8);
            this.Pn_pagos.Controls.Add(this.label2);
            this.Pn_pagos.Controls.Add(this.dt_fecha_fin);
            this.Pn_pagos.Controls.Add(this.label3);
            this.Pn_pagos.Controls.Add(this.dt_fecha_ini);
            this.Pn_pagos.Controls.Add(this.label5);
            this.Pn_pagos.Controls.Add(this.txt_total);
            this.Pn_pagos.Controls.Add(this.label6);
            this.Pn_pagos.Controls.Add(this.txt_hora);
            this.Pn_pagos.Controls.Add(this.label4);
            this.Pn_pagos.Controls.Add(this.txt_fecha);
            this.Pn_pagos.Controls.Add(this.txt_identificador);
            this.Pn_pagos.Controls.Add(this.Txt_id);
            this.Pn_pagos.Controls.Add(this.label7);
            this.Pn_pagos.Controls.Add(this.txt_usuario_id);
            this.Pn_pagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pn_pagos.Location = new System.Drawing.Point(0, 50);
            this.Pn_pagos.Name = "Pn_pagos";
            this.Pn_pagos.Size = new System.Drawing.Size(909, 175);
            this.Pn_pagos.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_registrar_pago);
            this.panel2.Controls.Add(this.Btn_borrar);
            this.panel2.Controls.Add(this.Btn_editar);
            this.panel2.Controls.Add(this.Btn_cancelar);
            this.panel2.Controls.Add(this.Btn_nuevos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(909, 50);
            this.panel2.TabIndex = 0;
            // 
            // Btn_registrar_pago
            // 
            this.Btn_registrar_pago.AutoSize = true;
            this.Btn_registrar_pago.BackColor = System.Drawing.Color.White;
            this.Btn_registrar_pago.BackgroundImage = global::CapaPresentacion.Properties.Resources.verde;
            this.Btn_registrar_pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_registrar_pago.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_registrar_pago.FlatAppearance.BorderSize = 0;
            this.Btn_registrar_pago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_registrar_pago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_registrar_pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar_pago.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar_pago.Location = new System.Drawing.Point(739, 5);
            this.Btn_registrar_pago.Name = "Btn_registrar_pago";
            this.Btn_registrar_pago.Size = new System.Drawing.Size(165, 40);
            this.Btn_registrar_pago.TabIndex = 3;
            this.Btn_registrar_pago.Text = "&Registrar los pagos";
            this.Btn_registrar_pago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_registrar_pago.UseVisualStyleBackColor = false;
            this.Btn_registrar_pago.Click += new System.EventHandler(this.Btn_registrar_pago_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.AutoSize = true;
            this.Btn_borrar.BackColor = System.Drawing.Color.White;
            this.Btn_borrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_borrar.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.Btn_borrar.Location = new System.Drawing.Point(305, 5);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(95, 40);
            this.Btn_borrar.TabIndex = 2;
            this.Btn_borrar.Text = "&Borrar";
            this.Btn_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Visible = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.AutoSize = true;
            this.Btn_editar.BackColor = System.Drawing.Color.White;
            this.Btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_editar.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.Btn_editar.Location = new System.Drawing.Point(198, 5);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(107, 40);
            this.Btn_editar.TabIndex = 1;
            this.Btn_editar.Text = "&Modificar";
            this.Btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Visible = false;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.AutoSize = true;
            this.Btn_cancelar.BackColor = System.Drawing.Color.White;
            this.Btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_cancelar.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.Btn_cancelar.Location = new System.Drawing.Point(100, 5);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(98, 40);
            this.Btn_cancelar.TabIndex = 0;
            this.Btn_cancelar.Text = "&Cancelar";
            this.Btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_nuevos
            // 
            this.Btn_nuevos.AutoSize = true;
            this.Btn_nuevos.BackColor = System.Drawing.Color.White;
            this.Btn_nuevos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_nuevos.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.Btn_nuevos.Location = new System.Drawing.Point(5, 5);
            this.Btn_nuevos.Name = "Btn_nuevos";
            this.Btn_nuevos.Size = new System.Drawing.Size(95, 40);
            this.Btn_nuevos.TabIndex = 0;
            this.Btn_nuevos.Text = "&Nuevo";
            this.Btn_nuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_nuevos.UseVisualStyleBackColor = false;
            this.Btn_nuevos.Click += new System.EventHandler(this.Btn_nuevos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 390);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.Pn_nuevos_pagos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Pago";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Pn_nuevos_pagos
            // 
            this.Pn_nuevos_pagos.AutoScroll = true;
            this.Pn_nuevos_pagos.Controls.Add(this.Pn_listado_vendedores);
            this.Pn_nuevos_pagos.Controls.Add(this.Dgv_nuevos_pagos);
            this.Pn_nuevos_pagos.Controls.Add(this.panel3);
            this.Pn_nuevos_pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_nuevos_pagos.Location = new System.Drawing.Point(3, 3);
            this.Pn_nuevos_pagos.Name = "Pn_nuevos_pagos";
            this.Pn_nuevos_pagos.Size = new System.Drawing.Size(895, 355);
            this.Pn_nuevos_pagos.TabIndex = 0;
            // 
            // Pn_listado_vendedores
            // 
            this.Pn_listado_vendedores.Controls.Add(this.dgv_vendedores);
            this.Pn_listado_vendedores.Controls.Add(this.panel4);
            this.Pn_listado_vendedores.Location = new System.Drawing.Point(656, 421);
            this.Pn_listado_vendedores.Name = "Pn_listado_vendedores";
            this.Pn_listado_vendedores.Size = new System.Drawing.Size(531, 235);
            this.Pn_listado_vendedores.TabIndex = 10;
            this.Pn_listado_vendedores.Visible = false;
            // 
            // dgv_vendedores
            // 
            this.dgv_vendedores.AllowUserToAddRows = false;
            this.dgv_vendedores.AllowUserToDeleteRows = false;
            this.dgv_vendedores.AllowUserToResizeColumns = false;
            this.dgv_vendedores.AllowUserToResizeRows = false;
            this.dgv_vendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usId,
            this.usNombreCompleto,
            this.usNroDoc,
            this.usDireccion,
            this.usCelular,
            this.usTelefono,
            this.usClave,
            this.usComision,
            this.usIsAdmin});
            this.dgv_vendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vendedores.Location = new System.Drawing.Point(0, 39);
            this.dgv_vendedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            this.dgv_vendedores.RowHeadersVisible = false;
            this.dgv_vendedores.RowTemplate.Height = 25;
            this.dgv_vendedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(531, 196);
            this.dgv_vendedores.TabIndex = 16;
            this.dgv_vendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vendedores_CellClick);
            // 
            // usId
            // 
            this.usId.DataPropertyName = "Id";
            this.usId.HeaderText = "Id";
            this.usId.Name = "usId";
            this.usId.ReadOnly = true;
            this.usId.Visible = false;
            // 
            // usNombreCompleto
            // 
            this.usNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usNombreCompleto.DataPropertyName = "NombreCompleto";
            this.usNombreCompleto.HeaderText = "Nombre Vendedor";
            this.usNombreCompleto.Name = "usNombreCompleto";
            this.usNombreCompleto.ReadOnly = true;
            // 
            // usNroDoc
            // 
            this.usNroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usNroDoc.DataPropertyName = "NroDoc";
            this.usNroDoc.HeaderText = "Nro Doc";
            this.usNroDoc.Name = "usNroDoc";
            this.usNroDoc.ReadOnly = true;
            // 
            // usDireccion
            // 
            this.usDireccion.DataPropertyName = "Direccion";
            this.usDireccion.HeaderText = "direccion";
            this.usDireccion.Name = "usDireccion";
            this.usDireccion.ReadOnly = true;
            this.usDireccion.Visible = false;
            // 
            // usCelular
            // 
            this.usCelular.DataPropertyName = "Celular";
            this.usCelular.HeaderText = "Celular";
            this.usCelular.Name = "usCelular";
            this.usCelular.ReadOnly = true;
            this.usCelular.Visible = false;
            // 
            // usTelefono
            // 
            this.usTelefono.DataPropertyName = "Telefono";
            this.usTelefono.HeaderText = "Telefono";
            this.usTelefono.Name = "usTelefono";
            this.usTelefono.ReadOnly = true;
            this.usTelefono.Visible = false;
            // 
            // usClave
            // 
            this.usClave.DataPropertyName = "Clave";
            this.usClave.HeaderText = "Clave";
            this.usClave.Name = "usClave";
            this.usClave.ReadOnly = true;
            this.usClave.Visible = false;
            // 
            // usComision
            // 
            this.usComision.DataPropertyName = "Comision";
            this.usComision.HeaderText = "Comision";
            this.usComision.Name = "usComision";
            this.usComision.ReadOnly = true;
            this.usComision.Visible = false;
            // 
            // usIsAdmin
            // 
            this.usIsAdmin.DataPropertyName = "IsAdmin";
            this.usIsAdmin.HeaderText = "Admin";
            this.usIsAdmin.Name = "usIsAdmin";
            this.usIsAdmin.ReadOnly = true;
            this.usIsAdmin.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Lbl_cerrar);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 39);
            this.panel4.TabIndex = 0;
            // 
            // Lbl_cerrar
            // 
            this.Lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_cerrar.AutoSize = true;
            this.Lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cerrar.Location = new System.Drawing.Point(504, 11);
            this.Lbl_cerrar.Name = "Lbl_cerrar";
            this.Lbl_cerrar.Size = new System.Drawing.Size(18, 17);
            this.Lbl_cerrar.TabIndex = 1;
            this.Lbl_cerrar.Text = "X";
            this.Lbl_cerrar.Click += new System.EventHandler(this.Lbl_cerrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Listado de vendedores";
            // 
            // Dgv_nuevos_pagos
            // 
            this.Dgv_nuevos_pagos.AllowUserToAddRows = false;
            this.Dgv_nuevos_pagos.AllowUserToDeleteRows = false;
            this.Dgv_nuevos_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_nuevos_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pago_id,
            this.vendedor_id,
            this.nombre_vendedor,
            this.valor_pagado,
            this.forma_pago,
            this.periodo_pagado,
            this.btn_quitar});
            this.Dgv_nuevos_pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_nuevos_pagos.Location = new System.Drawing.Point(0, 99);
            this.Dgv_nuevos_pagos.Name = "Dgv_nuevos_pagos";
            this.Dgv_nuevos_pagos.ReadOnly = true;
            this.Dgv_nuevos_pagos.RowHeadersVisible = false;
            this.Dgv_nuevos_pagos.RowTemplate.Height = 25;
            this.Dgv_nuevos_pagos.Size = new System.Drawing.Size(1187, 557);
            this.Dgv_nuevos_pagos.TabIndex = 1;
            this.Dgv_nuevos_pagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_nuevos_pagos_CellClick);
            // 
            // pago_id
            // 
            this.pago_id.DataPropertyName = "pago_id";
            this.pago_id.HeaderText = "pago_id";
            this.pago_id.Name = "pago_id";
            this.pago_id.ReadOnly = true;
            this.pago_id.Visible = false;
            // 
            // vendedor_id
            // 
            this.vendedor_id.DataPropertyName = "vendedor_id";
            this.vendedor_id.HeaderText = "vendedor_id";
            this.vendedor_id.Name = "vendedor_id";
            this.vendedor_id.ReadOnly = true;
            this.vendedor_id.Visible = false;
            // 
            // nombre_vendedor
            // 
            this.nombre_vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_vendedor.DataPropertyName = "nombre_vendedor";
            this.nombre_vendedor.HeaderText = "Vendedores";
            this.nombre_vendedor.Name = "nombre_vendedor";
            this.nombre_vendedor.ReadOnly = true;
            // 
            // valor_pagado
            // 
            this.valor_pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_pagado.DataPropertyName = "valor_pagado";
            this.valor_pagado.HeaderText = "Valor Pago";
            this.valor_pagado.Name = "valor_pagado";
            this.valor_pagado.ReadOnly = true;
            this.valor_pagado.Width = 95;
            // 
            // forma_pago
            // 
            this.forma_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.forma_pago.DataPropertyName = "forma_pago";
            this.forma_pago.HeaderText = "Forma de pago";
            this.forma_pago.Name = "forma_pago";
            this.forma_pago.ReadOnly = true;
            this.forma_pago.Width = 89;
            // 
            // periodo_pagado
            // 
            this.periodo_pagado.DataPropertyName = "periodo_pagado";
            this.periodo_pagado.HeaderText = "periodo_pagado";
            this.periodo_pagado.Name = "periodo_pagado";
            this.periodo_pagado.ReadOnly = true;
            this.periodo_pagado.Visible = false;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1187, 99);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_punto_1);
            this.groupBox1.Controls.Add(this.cbx_forma_pago);
            this.groupBox1.Controls.Add(this.txt_valor_pagar);
            this.groupBox1.Controls.Add(this.txt_vendedor);
            this.groupBox1.Controls.Add(this.btn_agregar_pago);
            this.groupBox1.Controls.Add(this.Txt_nro_doc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_vendedor_id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar vendedores";
            // 
            // Lbl_punto_1
            // 
            this.Lbl_punto_1.AutoSize = true;
            this.Lbl_punto_1.Location = new System.Drawing.Point(107, 53);
            this.Lbl_punto_1.Name = "Lbl_punto_1";
            this.Lbl_punto_1.Size = new System.Drawing.Size(0, 17);
            this.Lbl_punto_1.TabIndex = 9;
            // 
            // cbx_forma_pago
            // 
            this.cbx_forma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_forma_pago.FormattingEnabled = true;
            this.cbx_forma_pago.Location = new System.Drawing.Point(403, 55);
            this.cbx_forma_pago.Name = "cbx_forma_pago";
            this.cbx_forma_pago.Size = new System.Drawing.Size(238, 24);
            this.cbx_forma_pago.TabIndex = 2;
            // 
            // txt_valor_pagar
            // 
            this.txt_valor_pagar.Enabled = false;
            this.txt_valor_pagar.Location = new System.Drawing.Point(112, 56);
            this.txt_valor_pagar.Name = "txt_valor_pagar";
            this.txt_valor_pagar.Size = new System.Drawing.Size(171, 23);
            this.txt_valor_pagar.TabIndex = 1;
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Enabled = false;
            this.txt_vendedor.Location = new System.Drawing.Point(289, 26);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(352, 23);
            this.txt_vendedor.TabIndex = 1;
            // 
            // btn_agregar_pago
            // 
            this.btn_agregar_pago.AutoSize = true;
            this.btn_agregar_pago.BackColor = System.Drawing.Color.White;
            this.btn_agregar_pago.Image = global::CapaPresentacion.Properties.Resources.agregar24_gris;
            this.btn_agregar_pago.Location = new System.Drawing.Point(656, 29);
            this.btn_agregar_pago.Name = "btn_agregar_pago";
            this.btn_agregar_pago.Size = new System.Drawing.Size(147, 38);
            this.btn_agregar_pago.TabIndex = 0;
            this.btn_agregar_pago.Text = "&Agregar Pago";
            this.btn_agregar_pago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar_pago.UseVisualStyleBackColor = false;
            this.btn_agregar_pago.Click += new System.EventHandler(this.btn_agregar_pago_Click);
            // 
            // Txt_nro_doc
            // 
            this.Txt_nro_doc.Location = new System.Drawing.Point(112, 26);
            this.Txt_nro_doc.Name = "Txt_nro_doc";
            this.Txt_nro_doc.Size = new System.Drawing.Size(171, 23);
            this.Txt_nro_doc.TabIndex = 1;
            this.Txt_nro_doc.TextChanged += new System.EventHandler(this.Txt_nro_doc_TextChanged);
            this.Txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nro_doc_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Forma de pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Valor a pagar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro Doc";
            // 
            // Txt_vendedor_id
            // 
            this.Txt_vendedor_id.Enabled = false;
            this.Txt_vendedor_id.Location = new System.Drawing.Point(809, 29);
            this.Txt_vendedor_id.Name = "Txt_vendedor_id";
            this.Txt_vendedor_id.Size = new System.Drawing.Size(49, 23);
            this.Txt_vendedor_id.TabIndex = 8;
            this.Txt_vendedor_id.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Dgv_detalle_pagos_realizados);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagos realizados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dgv_detalle_pagos_realizados
            // 
            this.Dgv_detalle_pagos_realizados.AllowUserToAddRows = false;
            this.Dgv_detalle_pagos_realizados.AllowUserToDeleteRows = false;
            this.Dgv_detalle_pagos_realizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle_pagos_realizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_Id,
            this.d_PagoId,
            this.d_VendedorId,
            this.d_Vendedor,
            this.d_ValorPagado,
            this.d_FechaPago,
            this.d_FormaPago,
            this.d_PeriodoPago,
            this.d_Pagado,
            this.btn_quitar_pagos});
            this.Dgv_detalle_pagos_realizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_detalle_pagos_realizados.Location = new System.Drawing.Point(391, 3);
            this.Dgv_detalle_pagos_realizados.Name = "Dgv_detalle_pagos_realizados";
            this.Dgv_detalle_pagos_realizados.ReadOnly = true;
            this.Dgv_detalle_pagos_realizados.RowHeadersVisible = false;
            this.Dgv_detalle_pagos_realizados.RowTemplate.Height = 25;
            this.Dgv_detalle_pagos_realizados.Size = new System.Drawing.Size(507, 355);
            this.Dgv_detalle_pagos_realizados.TabIndex = 3;
            this.Dgv_detalle_pagos_realizados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_detalle_pagos_realizados_CellClick);
            // 
            // d_Id
            // 
            this.d_Id.DataPropertyName = "Id";
            this.d_Id.HeaderText = "Id";
            this.d_Id.Name = "d_Id";
            this.d_Id.ReadOnly = true;
            this.d_Id.Visible = false;
            // 
            // d_PagoId
            // 
            this.d_PagoId.DataPropertyName = "PagoId";
            this.d_PagoId.HeaderText = "PagoId";
            this.d_PagoId.Name = "d_PagoId";
            this.d_PagoId.ReadOnly = true;
            this.d_PagoId.Visible = false;
            // 
            // d_VendedorId
            // 
            this.d_VendedorId.DataPropertyName = "VendedorId";
            this.d_VendedorId.HeaderText = "VendedorId";
            this.d_VendedorId.Name = "d_VendedorId";
            this.d_VendedorId.ReadOnly = true;
            this.d_VendedorId.Visible = false;
            // 
            // d_Vendedor
            // 
            this.d_Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.d_Vendedor.DataPropertyName = "Vendedor";
            this.d_Vendedor.HeaderText = "Vendedor";
            this.d_Vendedor.Name = "d_Vendedor";
            this.d_Vendedor.ReadOnly = true;
            this.d_Vendedor.Width = 95;
            // 
            // d_ValorPagado
            // 
            this.d_ValorPagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.d_ValorPagado.DataPropertyName = "ValorPagado";
            this.d_ValorPagado.HeaderText = "Valor Pagado";
            this.d_ValorPagado.Name = "d_ValorPagado";
            this.d_ValorPagado.ReadOnly = true;
            this.d_ValorPagado.Width = 119;
            // 
            // d_FechaPago
            // 
            this.d_FechaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.d_FechaPago.DataPropertyName = "FechaPago";
            this.d_FechaPago.HeaderText = "FechaPago";
            this.d_FechaPago.Name = "d_FechaPago";
            this.d_FechaPago.ReadOnly = true;
            this.d_FechaPago.Visible = false;
            // 
            // d_FormaPago
            // 
            this.d_FormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.d_FormaPago.DataPropertyName = "FormaPago";
            this.d_FormaPago.HeaderText = "Forma Pago";
            this.d_FormaPago.Name = "d_FormaPago";
            this.d_FormaPago.ReadOnly = true;
            this.d_FormaPago.Width = 110;
            // 
            // d_PeriodoPago
            // 
            this.d_PeriodoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.d_PeriodoPago.DataPropertyName = "PeriodoPago";
            this.d_PeriodoPago.HeaderText = "Periodo Pago";
            this.d_PeriodoPago.Name = "d_PeriodoPago";
            this.d_PeriodoPago.ReadOnly = true;
            this.d_PeriodoPago.Width = 119;
            // 
            // d_Pagado
            // 
            this.d_Pagado.DataPropertyName = "Pagado";
            this.d_Pagado.HeaderText = "Pagado";
            this.d_Pagado.Name = "d_Pagado";
            this.d_Pagado.ReadOnly = true;
            this.d_Pagado.Visible = false;
            // 
            // btn_quitar_pagos
            // 
            this.btn_quitar_pagos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_quitar_pagos.HeaderText = "Quitar";
            this.btn_quitar_pagos.Image = global::CapaPresentacion.Properties.Resources.borrar24_gris;
            this.btn_quitar_pagos.Name = "btn_quitar_pagos";
            this.btn_quitar_pagos.ReadOnly = true;
            this.btn_quitar_pagos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 355);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar Pagos";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Dgv_pagos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 65);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(382, 287);
            this.panel5.TabIndex = 1;
            // 
            // Dgv_pagos
            // 
            this.Dgv_pagos.AllowUserToAddRows = false;
            this.Dgv_pagos.AllowUserToDeleteRows = false;
            this.Dgv_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_usuario_id,
            this.p_identificador,
            this.p_fecha_pago,
            this.p_periodo_pagado,
            this.p_hora_pago,
            this.p_valor_pagos,
            this.p_descripcion});
            this.Dgv_pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_pagos.Location = new System.Drawing.Point(5, 5);
            this.Dgv_pagos.Name = "Dgv_pagos";
            this.Dgv_pagos.ReadOnly = true;
            this.Dgv_pagos.RowHeadersVisible = false;
            this.Dgv_pagos.RowTemplate.Height = 25;
            this.Dgv_pagos.Size = new System.Drawing.Size(372, 277);
            this.Dgv_pagos.TabIndex = 2;
            this.Dgv_pagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_pagos_CellClick);
            this.Dgv_pagos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_pagos_CellEnter);
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_id.DataPropertyName = "Id";
            this.p_id.HeaderText = "Id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Width = 44;
            // 
            // p_usuario_id
            // 
            this.p_usuario_id.DataPropertyName = "UsuarioId";
            this.p_usuario_id.HeaderText = "usuario_id";
            this.p_usuario_id.Name = "p_usuario_id";
            this.p_usuario_id.ReadOnly = true;
            this.p_usuario_id.Visible = false;
            // 
            // p_identificador
            // 
            this.p_identificador.DataPropertyName = "Identificador";
            this.p_identificador.HeaderText = "identificador";
            this.p_identificador.Name = "p_identificador";
            this.p_identificador.ReadOnly = true;
            this.p_identificador.Visible = false;
            // 
            // p_fecha_pago
            // 
            this.p_fecha_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_fecha_pago.DataPropertyName = "FechaPago";
            this.p_fecha_pago.HeaderText = "Fecha Pago";
            this.p_fecha_pago.Name = "p_fecha_pago";
            this.p_fecha_pago.ReadOnly = true;
            this.p_fecha_pago.Width = 109;
            // 
            // p_periodo_pagado
            // 
            this.p_periodo_pagado.DataPropertyName = "PeriodoPagado";
            this.p_periodo_pagado.HeaderText = "periodo_pagado";
            this.p_periodo_pagado.Name = "p_periodo_pagado";
            this.p_periodo_pagado.ReadOnly = true;
            this.p_periodo_pagado.Visible = false;
            // 
            // p_hora_pago
            // 
            this.p_hora_pago.DataPropertyName = "HoraPago";
            this.p_hora_pago.HeaderText = "hora_pago";
            this.p_hora_pago.Name = "p_hora_pago";
            this.p_hora_pago.ReadOnly = true;
            this.p_hora_pago.Visible = false;
            // 
            // p_valor_pagos
            // 
            this.p_valor_pagos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_valor_pagos.DataPropertyName = "ValorPagos";
            this.p_valor_pagos.HeaderText = "Valor Pagado";
            this.p_valor_pagos.Name = "p_valor_pagos";
            this.p_valor_pagos.ReadOnly = true;
            // 
            // p_descripcion
            // 
            this.p_descripcion.DataPropertyName = "Descripcion";
            this.p_descripcion.HeaderText = "descripcion";
            this.p_descripcion.Name = "p_descripcion";
            this.p_descripcion.ReadOnly = true;
            this.p_descripcion.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dt_fecha_ini_pago);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dt_fecha_fin_pago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 46);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Buscar";
            // 
            // dt_fecha_ini_pago
            // 
            this.dt_fecha_ini_pago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_ini_pago.Location = new System.Drawing.Point(72, 12);
            this.dt_fecha_ini_pago.Name = "dt_fecha_ini_pago";
            this.dt_fecha_ini_pago.Size = new System.Drawing.Size(130, 23);
            this.dt_fecha_ini_pago.TabIndex = 4;
            this.dt_fecha_ini_pago.ValueChanged += new System.EventHandler(this.dt_fecha_ini_pago_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "al";
            // 
            // dt_fecha_fin_pago
            // 
            this.dt_fecha_fin_pago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_fin_pago.Location = new System.Drawing.Point(233, 12);
            this.dt_fecha_fin_pago.Name = "dt_fecha_fin_pago";
            this.dt_fecha_fin_pago.Size = new System.Drawing.Size(130, 23);
            this.dt_fecha_fin_pago.TabIndex = 5;
            this.dt_fecha_fin_pago.ValueChanged += new System.EventHandler(this.dt_fecha_fin_pago_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_pagos_abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 615);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Pn_pagos);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_pagos_abonos";
            this.Text = "Frm_pagos_abonos";
            this.Pn_pagos.ResumeLayout(false);
            this.Pn_pagos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Pn_nuevos_pagos.ResumeLayout(false);
            this.Pn_listado_vendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_nuevos_pagos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_pagos_realizados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox txt_usuario_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_identificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_fecha_ini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_fecha_fin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Panel Pn_pagos;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button Btn_registrar_pago;
        internal System.Windows.Forms.Button Btn_borrar;
        internal System.Windows.Forms.Button Btn_editar;
        internal System.Windows.Forms.Button Btn_nuevos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel Pn_nuevos_pagos;
        private System.Windows.Forms.DataGridView Dgv_nuevos_pagos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_valor_pagar;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.TextBox Txt_nro_doc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_forma_pago;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btn_agregar_pago;
        private System.Windows.Forms.TextBox Txt_vendedor_id;
        internal System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.DataGridView dgv_vendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn usId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn usTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn usClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn usComision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usIsAdmin;
        private System.Windows.Forms.Label Lbl_punto_1;
        private System.Windows.Forms.Panel Pn_listado_vendedores;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_cerrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dt_fecha_ini_pago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dt_fecha_fin_pago;
        private System.Windows.Forms.DataGridView Dgv_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_periodo_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_hora_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_valor_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_descripcion;
        private System.Windows.Forms.DataGridView Dgv_detalle_pagos_realizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo_pagado;
        private System.Windows.Forms.DataGridViewImageColumn btn_quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_PagoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_VendedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_ValorPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_PeriodoPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn d_Pagado;
        private System.Windows.Forms.DataGridViewImageColumn btn_quitar_pagos;
    }
}