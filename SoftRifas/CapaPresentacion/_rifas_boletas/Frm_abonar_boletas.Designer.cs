
namespace CapaPresentacion._rifas_boletas
{
    partial class Frm_abonar_boletas
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
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_deuda = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_total_abonos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_total_comision = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dgv_abonos = new System.Windows.Forms.DataGridView();
            this.b_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_boletaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_NroBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_VendedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_ValorPorPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_ValorComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_FechaAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_HoraAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_FormasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendedorCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar_forma_pago = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_cambiar_cliente = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_borrar_abono = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cbx_formas_pago = new System.Windows.Forms.ComboBox();
            this.Btn_usuario = new FontAwesome.Sharp.IconButton();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Txt_comision = new System.Windows.Forms.TextBox();
            this.txt_deuda = new System.Windows.Forms.TextBox();
            this.txt_saldado = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.Txt_cc_cl = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.Txt_cc_ve = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.txt_porc_comision = new System.Windows.Forms.TextBox();
            this.txt_cliente_id = new System.Windows.Forms.TextBox();
            this.txt_vendedor_id = new System.Windows.Forms.TextBox();
            this.txt_id_boleta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_boleta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_abonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(690, 40);
            this.panel1.TabIndex = 0;
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
            this.Btn_cerrar.Location = new System.Drawing.Point(655, 5);
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
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abonos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(690, 611);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.Dgv_abonos);
            this.panel3.Controls.Add(this.Cbx_formas_pago);
            this.panel3.Controls.Add(this.Btn_usuario);
            this.panel3.Controls.Add(this.Btn_registrar);
            this.panel3.Controls.Add(this.Btn_cancel);
            this.panel3.Controls.Add(this.Txt_comision);
            this.panel3.Controls.Add(this.txt_deuda);
            this.panel3.Controls.Add(this.txt_saldado);
            this.panel3.Controls.Add(this.txt_valor);
            this.panel3.Controls.Add(this.Txt_cc_cl);
            this.panel3.Controls.Add(this.txt_cliente);
            this.panel3.Controls.Add(this.Txt_cc_ve);
            this.panel3.Controls.Add(this.txt_vendedor);
            this.panel3.Controls.Add(this.txt_porc_comision);
            this.panel3.Controls.Add(this.txt_cliente_id);
            this.panel3.Controls.Add(this.txt_vendedor_id);
            this.panel3.Controls.Add(this.txt_id_boleta);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Txt_boleta);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 607);
            this.panel3.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbl_deuda,
            this.toolStripStatusLabel2,
            this.Lbl_total_abonos,
            this.toolStripStatusLabel4,
            this.Lbl_total_comision});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 24);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 19);
            this.toolStripStatusLabel1.Text = "Deuda";
            // 
            // Lbl_deuda
            // 
            this.Lbl_deuda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_deuda.Name = "Lbl_deuda";
            this.Lbl_deuda.Size = new System.Drawing.Size(77, 19);
            this.Lbl_deuda.Text = "Lbl_deuda";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 19);
            this.toolStripStatusLabel2.Text = "Total abonos";
            // 
            // Lbl_total_abonos
            // 
            this.Lbl_total_abonos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_total_abonos.Name = "Lbl_total_abonos";
            this.Lbl_total_abonos.Size = new System.Drawing.Size(121, 19);
            this.Lbl_total_abonos.Text = "Lbl_total_abonos";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(99, 19);
            this.toolStripStatusLabel4.Text = "Total Comision";
            // 
            // Lbl_total_comision
            // 
            this.Lbl_total_comision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_total_comision.Name = "Lbl_total_comision";
            this.Lbl_total_comision.Size = new System.Drawing.Size(132, 19);
            this.Lbl_total_comision.Text = "Lbl_total_comision";
            // 
            // Dgv_abonos
            // 
            this.Dgv_abonos.AllowUserToAddRows = false;
            this.Dgv_abonos.AllowUserToDeleteRows = false;
            this.Dgv_abonos.AllowUserToResizeColumns = false;
            this.Dgv_abonos.AllowUserToResizeRows = false;
            this.Dgv_abonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_abonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_abonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_abonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_Id,
            this.b_boletaId,
            this.b_NroBoleta,
            this.b_VendedorId,
            this.b_Vendedor,
            this.b_ClienteId,
            this.b_Cliente,
            this.b_ValorPorPagar,
            this.b_abonos,
            this.b_ValorComision,
            this.b_FechaAbono,
            this.b_HoraAbono,
            this.b_FormasPago,
            this.VendedorCC,
            this.ClienteCC,
            this.btn_editar_forma_pago,
            this.btn_cambiar_cliente,
            this.btn_borrar_abono});
            this.Dgv_abonos.Location = new System.Drawing.Point(10, 307);
            this.Dgv_abonos.Name = "Dgv_abonos";
            this.Dgv_abonos.ReadOnly = true;
            this.Dgv_abonos.RowHeadersVisible = false;
            this.Dgv_abonos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_abonos.RowTemplate.Height = 30;
            this.Dgv_abonos.RowTemplate.ReadOnly = true;
            this.Dgv_abonos.Size = new System.Drawing.Size(666, 264);
            this.Dgv_abonos.TabIndex = 14;
            this.Dgv_abonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_abonos_CellClick);
            // 
            // b_Id
            // 
            this.b_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_Id.DataPropertyName = "Id";
            this.b_Id.HeaderText = "Id";
            this.b_Id.Name = "b_Id";
            this.b_Id.ReadOnly = true;
            this.b_Id.Visible = false;
            // 
            // b_boletaId
            // 
            this.b_boletaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_boletaId.DataPropertyName = "BoletaId";
            this.b_boletaId.HeaderText = "BoletaId";
            this.b_boletaId.Name = "b_boletaId";
            this.b_boletaId.ReadOnly = true;
            this.b_boletaId.Visible = false;
            // 
            // b_NroBoleta
            // 
            this.b_NroBoleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_NroBoleta.DataPropertyName = "NroBoleta";
            this.b_NroBoleta.HeaderText = "Nro Boleta";
            this.b_NroBoleta.Name = "b_NroBoleta";
            this.b_NroBoleta.ReadOnly = true;
            this.b_NroBoleta.Visible = false;
            // 
            // b_VendedorId
            // 
            this.b_VendedorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_VendedorId.DataPropertyName = "VendedorId";
            this.b_VendedorId.HeaderText = "VendedorId";
            this.b_VendedorId.Name = "b_VendedorId";
            this.b_VendedorId.ReadOnly = true;
            this.b_VendedorId.Visible = false;
            // 
            // b_Vendedor
            // 
            this.b_Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_Vendedor.DataPropertyName = "Vendedor";
            this.b_Vendedor.HeaderText = "Vendedor";
            this.b_Vendedor.Name = "b_Vendedor";
            this.b_Vendedor.ReadOnly = true;
            this.b_Vendedor.Visible = false;
            // 
            // b_ClienteId
            // 
            this.b_ClienteId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_ClienteId.DataPropertyName = "ClienteId";
            this.b_ClienteId.HeaderText = "ClienteId";
            this.b_ClienteId.Name = "b_ClienteId";
            this.b_ClienteId.ReadOnly = true;
            this.b_ClienteId.Visible = false;
            // 
            // b_Cliente
            // 
            this.b_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_Cliente.DataPropertyName = "Cliente";
            this.b_Cliente.HeaderText = "Cliente";
            this.b_Cliente.Name = "b_Cliente";
            this.b_Cliente.ReadOnly = true;
            this.b_Cliente.Visible = false;
            // 
            // b_ValorPorPagar
            // 
            this.b_ValorPorPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_ValorPorPagar.DataPropertyName = "ValorPorPagar";
            this.b_ValorPorPagar.HeaderText = "Deuda";
            this.b_ValorPorPagar.Name = "b_ValorPorPagar";
            this.b_ValorPorPagar.ReadOnly = true;
            this.b_ValorPorPagar.Visible = false;
            // 
            // b_abonos
            // 
            this.b_abonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_abonos.DataPropertyName = "Abonos";
            this.b_abonos.HeaderText = "Abonos";
            this.b_abonos.Name = "b_abonos";
            this.b_abonos.ReadOnly = true;
            this.b_abonos.Width = 89;
            // 
            // b_ValorComision
            // 
            this.b_ValorComision.DataPropertyName = "Comision";
            this.b_ValorComision.HeaderText = "Comision";
            this.b_ValorComision.Name = "b_ValorComision";
            this.b_ValorComision.ReadOnly = true;
            // 
            // b_FechaAbono
            // 
            this.b_FechaAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_FechaAbono.DataPropertyName = "FechaAbono";
            this.b_FechaAbono.HeaderText = "Fecha Abono";
            this.b_FechaAbono.Name = "b_FechaAbono";
            this.b_FechaAbono.ReadOnly = true;
            this.b_FechaAbono.Width = 130;
            // 
            // b_HoraAbono
            // 
            this.b_HoraAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_HoraAbono.DataPropertyName = "HoraAbono";
            this.b_HoraAbono.HeaderText = "Hora Abono";
            this.b_HoraAbono.Name = "b_HoraAbono";
            this.b_HoraAbono.ReadOnly = true;
            this.b_HoraAbono.Visible = false;
            // 
            // b_FormasPago
            // 
            this.b_FormasPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.b_FormasPago.DataPropertyName = "FormasPago";
            this.b_FormasPago.HeaderText = "Forma de Pago";
            this.b_FormasPago.Name = "b_FormasPago";
            this.b_FormasPago.ReadOnly = true;
            this.b_FormasPago.Width = 143;
            // 
            // VendedorCC
            // 
            this.VendedorCC.DataPropertyName = "VendedorCC";
            this.VendedorCC.HeaderText = "VendedorCC";
            this.VendedorCC.Name = "VendedorCC";
            this.VendedorCC.ReadOnly = true;
            this.VendedorCC.Visible = false;
            // 
            // ClienteCC
            // 
            this.ClienteCC.DataPropertyName = "ClienteCC";
            this.ClienteCC.HeaderText = "ClienteCC";
            this.ClienteCC.Name = "ClienteCC";
            this.ClienteCC.ReadOnly = true;
            this.ClienteCC.Visible = false;
            // 
            // btn_editar_forma_pago
            // 
            this.btn_editar_forma_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_editar_forma_pago.HeaderText = "FP";
            this.btn_editar_forma_pago.Image = global::CapaPresentacion.Properties.Resources.editar24_gris;
            this.btn_editar_forma_pago.Name = "btn_editar_forma_pago";
            this.btn_editar_forma_pago.ReadOnly = true;
            this.btn_editar_forma_pago.Width = 35;
            // 
            // btn_cambiar_cliente
            // 
            this.btn_cambiar_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_cambiar_cliente.HeaderText = "Cliente";
            this.btn_cambiar_cliente.Image = global::CapaPresentacion.Properties.Resources.cliente;
            this.btn_cambiar_cliente.Name = "btn_cambiar_cliente";
            this.btn_cambiar_cliente.ReadOnly = true;
            this.btn_cambiar_cliente.Width = 64;
            // 
            // btn_borrar_abono
            // 
            this.btn_borrar_abono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_borrar_abono.HeaderText = "Borrar";
            this.btn_borrar_abono.Name = "btn_borrar_abono";
            this.btn_borrar_abono.ReadOnly = true;
            this.btn_borrar_abono.Text = "Borrar";
            this.btn_borrar_abono.ToolTipText = "Borrar";
            this.btn_borrar_abono.UseColumnTextForButtonValue = true;
            this.btn_borrar_abono.Width = 59;
            // 
            // Cbx_formas_pago
            // 
            this.Cbx_formas_pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cbx_formas_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_formas_pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbx_formas_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_formas_pago.FormattingEnabled = true;
            this.Cbx_formas_pago.Items.AddRange(new object[] {
            "Efectivo en Caja",
            "Consignacion Bancaria",
            "Transferencia Virtual",
            "Nequi",
            "Daviplata",
            "TransfiYa ",
            "Bono",
            "Bancolombia",
            "Banco Caja Social",
            "Banco Davivienda",
            "Banco de Bogota",
            "Banco Pichincha",
            "BBVA"});
            this.Cbx_formas_pago.Location = new System.Drawing.Point(14, 219);
            this.Cbx_formas_pago.Name = "Cbx_formas_pago";
            this.Cbx_formas_pago.Size = new System.Drawing.Size(278, 24);
            this.Cbx_formas_pago.TabIndex = 13;
            // 
            // Btn_usuario
            // 
            this.Btn_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_usuario.FlatAppearance.BorderSize = 0;
            this.Btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_usuario.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.Btn_usuario.IconColor = System.Drawing.Color.Black;
            this.Btn_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_usuario.IconSize = 32;
            this.Btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_usuario.Location = new System.Drawing.Point(263, 252);
            this.Btn_usuario.Name = "Btn_usuario";
            this.Btn_usuario.Size = new System.Drawing.Size(98, 39);
            this.Btn_usuario.TabIndex = 12;
            this.Btn_usuario.Text = "Reporte";
            this.Btn_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_usuario.UseVisualStyleBackColor = true;
            this.Btn_usuario.Visible = false;
            this.Btn_usuario.Click += new System.EventHandler(this.Btn_usuario_Click);
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_registrar.FlatAppearance.BorderSize = 0;
            this.Btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(170, 252);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(77, 38);
            this.Btn_registrar.TabIndex = 9;
            this.Btn_registrar.Text = "Registrar";
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
            this.Btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.Location = new System.Drawing.Point(87, 252);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(77, 38);
            this.Btn_cancel.TabIndex = 10;
            this.Btn_cancel.Text = "Cancelar";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Txt_comision
            // 
            this.Txt_comision.Enabled = false;
            this.Txt_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_comision.Location = new System.Drawing.Point(299, 174);
            this.Txt_comision.MaxLength = 10;
            this.Txt_comision.Name = "Txt_comision";
            this.Txt_comision.ReadOnly = true;
            this.Txt_comision.Size = new System.Drawing.Size(143, 22);
            this.Txt_comision.TabIndex = 7;
            // 
            // txt_deuda
            // 
            this.txt_deuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deuda.Location = new System.Drawing.Point(299, 221);
            this.txt_deuda.MaxLength = 10;
            this.txt_deuda.Name = "txt_deuda";
            this.txt_deuda.Size = new System.Drawing.Size(143, 22);
            this.txt_deuda.TabIndex = 7;
            this.txt_deuda.Text = "0";
            this.txt_deuda.TextChanged += new System.EventHandler(this.txt_deuda_TextChanged);
            // 
            // txt_saldado
            // 
            this.txt_saldado.Enabled = false;
            this.txt_saldado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldado.Location = new System.Drawing.Point(145, 174);
            this.txt_saldado.MaxLength = 10;
            this.txt_saldado.Name = "txt_saldado";
            this.txt_saldado.ReadOnly = true;
            this.txt_saldado.Size = new System.Drawing.Size(149, 22);
            this.txt_saldado.TabIndex = 7;
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(14, 174);
            this.txt_valor.MaxLength = 10;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(125, 22);
            this.txt_valor.TabIndex = 4;
            // 
            // Txt_cc_cl
            // 
            this.Txt_cc_cl.Enabled = false;
            this.Txt_cc_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cc_cl.Location = new System.Drawing.Point(299, 124);
            this.Txt_cc_cl.MaxLength = 150;
            this.Txt_cc_cl.Name = "Txt_cc_cl";
            this.Txt_cc_cl.ReadOnly = true;
            this.Txt_cc_cl.Size = new System.Drawing.Size(143, 22);
            this.Txt_cc_cl.TabIndex = 2;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(14, 124);
            this.txt_cliente.MaxLength = 150;
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(279, 22);
            this.txt_cliente.TabIndex = 2;
            // 
            // Txt_cc_ve
            // 
            this.Txt_cc_ve.Enabled = false;
            this.Txt_cc_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cc_ve.Location = new System.Drawing.Point(299, 79);
            this.Txt_cc_ve.MaxLength = 150;
            this.Txt_cc_ve.Name = "Txt_cc_ve";
            this.Txt_cc_ve.ReadOnly = true;
            this.Txt_cc_ve.Size = new System.Drawing.Size(143, 22);
            this.Txt_cc_ve.TabIndex = 2;
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Enabled = false;
            this.txt_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendedor.Location = new System.Drawing.Point(14, 79);
            this.txt_vendedor.MaxLength = 150;
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.ReadOnly = true;
            this.txt_vendedor.Size = new System.Drawing.Size(279, 22);
            this.txt_vendedor.TabIndex = 2;
            // 
            // txt_porc_comision
            // 
            this.txt_porc_comision.Enabled = false;
            this.txt_porc_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_porc_comision.Location = new System.Drawing.Point(396, 35);
            this.txt_porc_comision.Name = "txt_porc_comision";
            this.txt_porc_comision.ReadOnly = true;
            this.txt_porc_comision.Size = new System.Drawing.Size(63, 22);
            this.txt_porc_comision.TabIndex = 0;
            // 
            // txt_cliente_id
            // 
            this.txt_cliente_id.Enabled = false;
            this.txt_cliente_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente_id.Location = new System.Drawing.Point(569, 219);
            this.txt_cliente_id.Name = "txt_cliente_id";
            this.txt_cliente_id.ReadOnly = true;
            this.txt_cliente_id.Size = new System.Drawing.Size(29, 22);
            this.txt_cliente_id.TabIndex = 0;
            this.txt_cliente_id.Visible = false;
            // 
            // txt_vendedor_id
            // 
            this.txt_vendedor_id.Enabled = false;
            this.txt_vendedor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendedor_id.Location = new System.Drawing.Point(535, 219);
            this.txt_vendedor_id.Name = "txt_vendedor_id";
            this.txt_vendedor_id.ReadOnly = true;
            this.txt_vendedor_id.Size = new System.Drawing.Size(29, 22);
            this.txt_vendedor_id.TabIndex = 0;
            this.txt_vendedor_id.Visible = false;
            // 
            // txt_id_boleta
            // 
            this.txt_id_boleta.Enabled = false;
            this.txt_id_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_boleta.Location = new System.Drawing.Point(476, 219);
            this.txt_id_boleta.Name = "txt_id_boleta";
            this.txt_id_boleta.ReadOnly = true;
            this.txt_id_boleta.Size = new System.Drawing.Size(54, 22);
            this.txt_id_boleta.TabIndex = 0;
            this.txt_id_boleta.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comision";
            // 
            // Txt_boleta
            // 
            this.Txt_boleta.Enabled = false;
            this.Txt_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_boleta.Location = new System.Drawing.Point(14, 33);
            this.Txt_boleta.Name = "Txt_boleta";
            this.Txt_boleta.ReadOnly = true;
            this.Txt_boleta.Size = new System.Drawing.Size(146, 22);
            this.Txt_boleta.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Forma de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor a pagar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor boleta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valora saldar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro de boleta";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Porcentaje Comision vendedor";
            // 
            // Frm_abonar_boletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(690, 651);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_abonar_boletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_abonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txt_vendedor;
        internal System.Windows.Forms.TextBox Txt_boleta;
        internal System.Windows.Forms.TextBox txt_saldado;
        internal System.Windows.Forms.TextBox txt_valor;
        internal System.Windows.Forms.TextBox txt_deuda;
        internal System.Windows.Forms.TextBox txt_cliente;
        internal System.Windows.Forms.TextBox txt_id_boleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txt_cliente_id;
        internal System.Windows.Forms.TextBox txt_vendedor_id;
        internal System.Windows.Forms.TextBox Txt_comision;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton Btn_usuario;
        internal System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox Cbx_formas_pago;
        private System.Windows.Forms.DataGridView Dgv_abonos;
        internal System.Windows.Forms.TextBox Txt_cc_cl;
        internal System.Windows.Forms.TextBox Txt_cc_ve;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_deuda;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_total_abonos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_total_comision;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        internal System.Windows.Forms.TextBox txt_porc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_boletaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_NroBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_VendedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_ValorPorPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_ValorComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_FechaAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_HoraAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_FormasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendedorCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCC;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar_forma_pago;
        private System.Windows.Forms.DataGridViewImageColumn btn_cambiar_cliente;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar_abono;
        private System.Windows.Forms.Label label5;
    }
}