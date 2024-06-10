
namespace CapaPresentacion._rifas_boletas
{
    partial class Frm_boletas
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
            this.Lbl_punto2 = new System.Windows.Forms.Label();
            this.Lbl_punto1 = new System.Windows.Forms.Label();
            this.Dgv_clientes = new System.Windows.Forms.DataGridView();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Cbx_formas_pago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_buscar_cliente = new FontAwesome.Sharp.IconButton();
            this.Btn_buscar_vendedor = new FontAwesome.Sharp.IconButton();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Txt_comision = new System.Windows.Forms.TextBox();
            this.Txt_abono = new System.Windows.Forms.TextBox();
            this.txt_valor_boleta = new System.Windows.Forms.TextBox();
            this.txt_cliente_id = new System.Windows.Forms.TextBox();
            this.Txt_vendedor_id = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Txt_id_boleta = new System.Windows.Forms.TextBox();
            this.txt_cc_cl = new System.Windows.Forms.TextBox();
            this.Txt_cliente = new System.Windows.Forms.TextBox();
            this.Txt_cc_ve = new System.Windows.Forms.TextBox();
            this.Txt_vendedor = new System.Windows.Forms.TextBox();
            this.Txt_nro_boleta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_porc_comision = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(607, 32);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(575, 4);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(28, 24);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar boletas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(607, 235);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Lbl_punto2);
            this.panel3.Controls.Add(this.Lbl_punto1);
            this.panel3.Controls.Add(this.Dgv_clientes);
            this.panel3.Controls.Add(this.dgv_vendedores);
            this.panel3.Controls.Add(this.Cbx_formas_pago);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_buscar_cliente);
            this.panel3.Controls.Add(this.Btn_buscar_vendedor);
            this.panel3.Controls.Add(this.Btn_registrar);
            this.panel3.Controls.Add(this.Btn_cancel);
            this.panel3.Controls.Add(this.Txt_comision);
            this.panel3.Controls.Add(this.Txt_abono);
            this.panel3.Controls.Add(this.txt_valor_boleta);
            this.panel3.Controls.Add(this.txt_cliente_id);
            this.panel3.Controls.Add(this.Txt_vendedor_id);
            this.panel3.Controls.Add(this.txt_porc_comision);
            this.panel3.Controls.Add(this.Txt_id);
            this.panel3.Controls.Add(this.Txt_id_boleta);
            this.panel3.Controls.Add(this.txt_cc_cl);
            this.panel3.Controls.Add(this.Txt_cliente);
            this.panel3.Controls.Add(this.Txt_cc_ve);
            this.panel3.Controls.Add(this.Txt_vendedor);
            this.panel3.Controls.Add(this.Txt_nro_boleta);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 231);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // Lbl_punto2
            // 
            this.Lbl_punto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_punto2.Location = new System.Drawing.Point(103, 90);
            this.Lbl_punto2.Name = "Lbl_punto2";
            this.Lbl_punto2.Size = new System.Drawing.Size(8, 8);
            this.Lbl_punto2.TabIndex = 17;
            this.Lbl_punto2.Text = ".";
            // 
            // Lbl_punto1
            // 
            this.Lbl_punto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_punto1.Location = new System.Drawing.Point(103, 59);
            this.Lbl_punto1.Name = "Lbl_punto1";
            this.Lbl_punto1.Size = new System.Drawing.Size(8, 8);
            this.Lbl_punto1.TabIndex = 16;
            this.Lbl_punto1.Text = ".";
            // 
            // Dgv_clientes
            // 
            this.Dgv_clientes.AllowUserToAddRows = false;
            this.Dgv_clientes.AllowUserToDeleteRows = false;
            this.Dgv_clientes.AllowUserToResizeColumns = false;
            this.Dgv_clientes.AllowUserToResizeRows = false;
            this.Dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id,
            this.clNombreCliente,
            this.clNroDoc,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.Dgv_clientes.Location = new System.Drawing.Point(16, 210);
            this.Dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_clientes.Name = "Dgv_clientes";
            this.Dgv_clientes.ReadOnly = true;
            this.Dgv_clientes.RowHeadersVisible = false;
            this.Dgv_clientes.RowTemplate.Height = 25;
            this.Dgv_clientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_clientes.Size = new System.Drawing.Size(436, 126);
            this.Dgv_clientes.TabIndex = 15;
            this.Dgv_clientes.Visible = false;
            this.Dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_clientes_CellClick);
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "Id";
            this.cl_id.HeaderText = "Id";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // clNombreCliente
            // 
            this.clNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNombreCliente.DataPropertyName = "NombreCompleto";
            this.clNombreCliente.HeaderText = "Nombre Cliente";
            this.clNombreCliente.Name = "clNombreCliente";
            this.clNombreCliente.ReadOnly = true;
            // 
            // clNroDoc
            // 
            this.clNroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNroDoc.DataPropertyName = "NroDoc";
            this.clNroDoc.HeaderText = "Nro Doc";
            this.clNroDoc.Name = "clNroDoc";
            this.clNroDoc.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
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
            this.dgv_vendedores.Location = new System.Drawing.Point(475, 200);
            this.dgv_vendedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            this.dgv_vendedores.RowHeadersVisible = false;
            this.dgv_vendedores.RowTemplate.Height = 25;
            this.dgv_vendedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(436, 126);
            this.dgv_vendedores.TabIndex = 15;
            this.dgv_vendedores.Visible = false;
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
            "Bancolombia"});
            this.Cbx_formas_pago.Location = new System.Drawing.Point(117, 139);
            this.Cbx_formas_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbx_formas_pago.Name = "Cbx_formas_pago";
            this.Cbx_formas_pago.Size = new System.Drawing.Size(160, 24);
            this.Cbx_formas_pago.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Forma de pago";
            // 
            // txt_buscar_cliente
            // 
            this.txt_buscar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_buscar_cliente.FlatAppearance.BorderSize = 0;
            this.txt_buscar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_cliente.ForeColor = System.Drawing.Color.White;
            this.txt_buscar_cliente.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.txt_buscar_cliente.IconColor = System.Drawing.Color.Green;
            this.txt_buscar_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txt_buscar_cliente.IconSize = 32;
            this.txt_buscar_cliente.Location = new System.Drawing.Point(553, 75);
            this.txt_buscar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscar_cliente.Name = "txt_buscar_cliente";
            this.txt_buscar_cliente.Size = new System.Drawing.Size(28, 21);
            this.txt_buscar_cliente.TabIndex = 8;
            this.txt_buscar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_buscar_cliente.UseVisualStyleBackColor = true;
            this.txt_buscar_cliente.Click += new System.EventHandler(this.txt_buscar_cliente_Click);
            // 
            // Btn_buscar_vendedor
            // 
            this.Btn_buscar_vendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar_vendedor.FlatAppearance.BorderSize = 0;
            this.Btn_buscar_vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar_vendedor.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar_vendedor.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.Btn_buscar_vendedor.IconColor = System.Drawing.Color.Green;
            this.Btn_buscar_vendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_buscar_vendedor.IconSize = 32;
            this.Btn_buscar_vendedor.Location = new System.Drawing.Point(552, 42);
            this.Btn_buscar_vendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_buscar_vendedor.Name = "Btn_buscar_vendedor";
            this.Btn_buscar_vendedor.Size = new System.Drawing.Size(28, 21);
            this.Btn_buscar_vendedor.TabIndex = 5;
            this.Btn_buscar_vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscar_vendedor.UseVisualStyleBackColor = true;
            this.Btn_buscar_vendedor.Click += new System.EventHandler(this.Btn_buscar_vendedor_Click);
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
            this.Btn_registrar.Location = new System.Drawing.Point(315, 176);
            this.Btn_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(97, 30);
            this.Btn_registrar.TabIndex = 13;
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
            this.Btn_cancel.Location = new System.Drawing.Point(211, 176);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(97, 30);
            this.Btn_cancel.TabIndex = 14;
            this.Btn_cancel.Text = "Cancelar";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Txt_comision
            // 
            this.Txt_comision.Enabled = false;
            this.Txt_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_comision.Location = new System.Drawing.Point(388, 106);
            this.Txt_comision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_comision.MaxLength = 50;
            this.Txt_comision.Name = "Txt_comision";
            this.Txt_comision.ReadOnly = true;
            this.Txt_comision.Size = new System.Drawing.Size(179, 22);
            this.Txt_comision.TabIndex = 10;
            this.Txt_comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_comision_KeyPress);
            this.Txt_comision.Leave += new System.EventHandler(this.Txt_comision_Leave);
            // 
            // Txt_abono
            // 
            this.Txt_abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_abono.Location = new System.Drawing.Point(388, 140);
            this.Txt_abono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_abono.MaxLength = 50;
            this.Txt_abono.Name = "Txt_abono";
            this.Txt_abono.Size = new System.Drawing.Size(179, 22);
            this.Txt_abono.TabIndex = 12;
            this.Txt_abono.TextChanged += new System.EventHandler(this.Txt_abono_TextChanged);
            this.Txt_abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_abono_KeyPress);
            this.Txt_abono.Leave += new System.EventHandler(this.Txt_abono_Leave);
            // 
            // txt_valor_boleta
            // 
            this.txt_valor_boleta.Enabled = false;
            this.txt_valor_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_boleta.Location = new System.Drawing.Point(117, 106);
            this.txt_valor_boleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor_boleta.MaxLength = 50;
            this.txt_valor_boleta.Name = "txt_valor_boleta";
            this.txt_valor_boleta.ReadOnly = true;
            this.txt_valor_boleta.Size = new System.Drawing.Size(160, 22);
            this.txt_valor_boleta.TabIndex = 9;
            this.txt_valor_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_boleta_KeyPress);
            this.txt_valor_boleta.Leave += new System.EventHandler(this.txt_valor_boleta_Leave);
            // 
            // txt_cliente_id
            // 
            this.txt_cliente_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente_id.Location = new System.Drawing.Point(139, 239);
            this.txt_cliente_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cliente_id.Name = "txt_cliente_id";
            this.txt_cliente_id.ReadOnly = true;
            this.txt_cliente_id.Size = new System.Drawing.Size(19, 22);
            this.txt_cliente_id.TabIndex = 2;
            this.txt_cliente_id.Visible = false;
            this.txt_cliente_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // Txt_vendedor_id
            // 
            this.Txt_vendedor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_vendedor_id.Location = new System.Drawing.Point(116, 239);
            this.Txt_vendedor_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_vendedor_id.Name = "Txt_vendedor_id";
            this.Txt_vendedor_id.ReadOnly = true;
            this.Txt_vendedor_id.Size = new System.Drawing.Size(19, 22);
            this.Txt_vendedor_id.TabIndex = 2;
            this.Txt_vendedor_id.Visible = false;
            this.Txt_vendedor_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // Txt_id
            // 
            this.Txt_id.Enabled = false;
            this.Txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(388, 11);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.ReadOnly = true;
            this.Txt_id.Size = new System.Drawing.Size(64, 22);
            this.Txt_id.TabIndex = 2;
            this.Txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // Txt_id_boleta
            // 
            this.Txt_id_boleta.Enabled = false;
            this.Txt_id_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_boleta.Location = new System.Drawing.Point(280, 11);
            this.Txt_id_boleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_id_boleta.Name = "Txt_id_boleta";
            this.Txt_id_boleta.ReadOnly = true;
            this.Txt_id_boleta.Size = new System.Drawing.Size(104, 22);
            this.Txt_id_boleta.TabIndex = 1;
            this.Txt_id_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // txt_cc_cl
            // 
            this.txt_cc_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cc_cl.Location = new System.Drawing.Point(412, 76);
            this.txt_cc_cl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cc_cl.Name = "txt_cc_cl";
            this.txt_cc_cl.Size = new System.Drawing.Size(136, 22);
            this.txt_cc_cl.TabIndex = 7;
            this.txt_cc_cl.TextChanged += new System.EventHandler(this.txt_cc_cl_TextChanged);
            this.txt_cc_cl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cc_cl_KeyPress);
            // 
            // Txt_cliente
            // 
            this.Txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cliente.Location = new System.Drawing.Point(117, 76);
            this.Txt_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_cliente.Name = "Txt_cliente";
            this.Txt_cliente.Size = new System.Drawing.Size(267, 22);
            this.Txt_cliente.TabIndex = 6;
            this.Txt_cliente.TextChanged += new System.EventHandler(this.Txt_cliente_TextChanged);
            // 
            // Txt_cc_ve
            // 
            this.Txt_cc_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cc_ve.Location = new System.Drawing.Point(411, 43);
            this.Txt_cc_ve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_cc_ve.Name = "Txt_cc_ve";
            this.Txt_cc_ve.Size = new System.Drawing.Size(136, 22);
            this.Txt_cc_ve.TabIndex = 4;
            this.Txt_cc_ve.TextChanged += new System.EventHandler(this.Txt_cc_ve_TextChanged);
            this.Txt_cc_ve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // Txt_vendedor
            // 
            this.Txt_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_vendedor.Location = new System.Drawing.Point(117, 43);
            this.Txt_vendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_vendedor.Name = "Txt_vendedor";
            this.Txt_vendedor.Size = new System.Drawing.Size(267, 22);
            this.Txt_vendedor.TabIndex = 3;
            this.Txt_vendedor.TextChanged += new System.EventHandler(this.Txt_vendedor_TextChanged_1);
            // 
            // Txt_nro_boleta
            // 
            this.Txt_nro_boleta.Enabled = false;
            this.Txt_nro_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nro_boleta.Location = new System.Drawing.Point(117, 11);
            this.Txt_nro_boleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_nro_boleta.Name = "Txt_nro_boleta";
            this.Txt_nro_boleta.ReadOnly = true;
            this.Txt_nro_boleta.Size = new System.Drawing.Size(160, 22);
            this.Txt_nro_boleta.TabIndex = 0;
            this.Txt_nro_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "CC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor comision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor abono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "CC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor boleta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Boleta";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txt_porc_comision
            // 
            this.txt_porc_comision.Enabled = false;
            this.txt_porc_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_porc_comision.Location = new System.Drawing.Point(458, 11);
            this.txt_porc_comision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_porc_comision.Name = "txt_porc_comision";
            this.txt_porc_comision.ReadOnly = true;
            this.txt_porc_comision.Size = new System.Drawing.Size(64, 22);
            this.txt_porc_comision.TabIndex = 2;
            this.txt_porc_comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_KeyPress);
            // 
            // Frm_boletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(607, 267);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_boletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).EndInit();
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
        internal System.Windows.Forms.TextBox txt_valor_boleta;
        internal System.Windows.Forms.TextBox Txt_nro_boleta;
        internal System.Windows.Forms.TextBox Txt_comision;
        internal System.Windows.Forms.TextBox Txt_abono;
        internal System.Windows.Forms.TextBox Txt_id_boleta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox Txt_id;
        internal System.Windows.Forms.TextBox Txt_vendedor_id;
        internal System.Windows.Forms.TextBox Txt_vendedor;
        private FontAwesome.Sharp.IconButton txt_buscar_cliente;
        internal System.Windows.Forms.TextBox txt_cliente_id;
        internal System.Windows.Forms.TextBox Txt_cliente;
        internal System.Windows.Forms.Button Btn_registrar;
        internal System.Windows.Forms.ComboBox Cbx_formas_pago;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txt_cc_cl;
        internal System.Windows.Forms.TextBox Txt_cc_ve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn usId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn usTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn usClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn usComision;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usIsAdmin;
        private System.Windows.Forms.Label Lbl_punto1;
        private System.Windows.Forms.Label Lbl_punto2;
        internal System.Windows.Forms.DataGridView dgv_vendedores;
        internal System.Windows.Forms.DataGridView Dgv_clientes;
        internal FontAwesome.Sharp.IconButton Btn_buscar_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        internal System.Windows.Forms.TextBox txt_porc_comision;

        public static int GetIdUsuario { get; internal set; }
        public static string GetUsuarioNombre { get; internal set; }
        public static int GetIdCliente { get; internal set; }
        public static string GetClienteNombre { get; internal set; }
    }
}