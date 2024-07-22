
namespace CapaPresentacion._pagos_comisiones
{
    partial class Frm_pago_comisiones
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
            this.cbxVendedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAbonosBoleta = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalComisionPendiente = new System.Windows.Forms.TextBox();
            this.txtTotalComisionPagada = new System.Windows.Forms.TextBox();
            this.txttotalComision = new System.Windows.Forms.TextBox();
            this.txtNroAbonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.txtTotalAbonos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boleta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_boleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonosBoleta)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxVendedores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 47);
            this.panel1.TabIndex = 0;
            // 
            // cbxVendedores
            // 
            this.cbxVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVendedores.FormattingEnabled = true;
            this.cbxVendedores.Location = new System.Drawing.Point(103, 8);
            this.cbxVendedores.Name = "cbxVendedores";
            this.cbxVendedores.Size = new System.Drawing.Size(371, 24);
            this.cbxVendedores.TabIndex = 1;
            this.cbxVendedores.SelectionChangeCommitted += new System.EventHandler(this.cbxVendedores_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedores";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAbonosBoleta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(727, 543);
            this.panel2.TabIndex = 1;
            // 
            // dgvAbonosBoleta
            // 
            this.dgvAbonosBoleta.AllowUserToAddRows = false;
            this.dgvAbonosBoleta.AllowUserToDeleteRows = false;
            this.dgvAbonosBoleta.AllowUserToOrderColumns = true;
            this.dgvAbonosBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonosBoleta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente_id,
            this.cliente,
            this.boleta_id,
            this.nro_boleta,
            this.valor_abono,
            this.valor_comision,
            this.abono_pagado});
            this.dgvAbonosBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbonosBoleta.Location = new System.Drawing.Point(10, 10);
            this.dgvAbonosBoleta.Name = "dgvAbonosBoleta";
            this.dgvAbonosBoleta.ReadOnly = true;
            this.dgvAbonosBoleta.RowHeadersVisible = false;
            this.dgvAbonosBoleta.RowTemplate.Height = 30;
            this.dgvAbonosBoleta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonosBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonosBoleta.Size = new System.Drawing.Size(707, 523);
            this.dgvAbonosBoleta.TabIndex = 0;
            this.dgvAbonosBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbonosBoleta_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalAbonos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnReportes);
            this.panel3.Controls.Add(this.txtTotalComisionPendiente);
            this.panel3.Controls.Add(this.txtTotalComisionPagada);
            this.panel3.Controls.Add(this.txttotalComision);
            this.panel3.Controls.Add(this.txtNroAbonos);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(727, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 543);
            this.panel3.TabIndex = 2;
            // 
            // txtTotalComisionPendiente
            // 
            this.txtTotalComisionPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComisionPendiente.Location = new System.Drawing.Point(39, 220);
            this.txtTotalComisionPendiente.Name = "txtTotalComisionPendiente";
            this.txtTotalComisionPendiente.ReadOnly = true;
            this.txtTotalComisionPendiente.Size = new System.Drawing.Size(225, 38);
            this.txtTotalComisionPendiente.TabIndex = 1;
            this.txtTotalComisionPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalComisionPagada
            // 
            this.txtTotalComisionPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComisionPagada.Location = new System.Drawing.Point(39, 160);
            this.txtTotalComisionPagada.Name = "txtTotalComisionPagada";
            this.txtTotalComisionPagada.ReadOnly = true;
            this.txtTotalComisionPagada.Size = new System.Drawing.Size(225, 38);
            this.txtTotalComisionPagada.TabIndex = 1;
            this.txtTotalComisionPagada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttotalComision
            // 
            this.txttotalComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalComision.Location = new System.Drawing.Point(39, 100);
            this.txttotalComision.Name = "txttotalComision";
            this.txttotalComision.ReadOnly = true;
            this.txttotalComision.Size = new System.Drawing.Size(225, 38);
            this.txttotalComision.TabIndex = 1;
            this.txttotalComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNroAbonos
            // 
            this.txtNroAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroAbonos.Location = new System.Drawing.Point(39, 40);
            this.txtNroAbonos.Name = "txtNroAbonos";
            this.txtNroAbonos.ReadOnly = true;
            this.txtNroAbonos.Size = new System.Drawing.Size(225, 38);
            this.txtNroAbonos.TabIndex = 1;
            this.txtNroAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Comision pendiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Comision pagada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro de abonos";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(30, 367);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(93, 49);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // txtTotalAbonos
            // 
            this.txtTotalAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAbonos.Location = new System.Drawing.Point(39, 285);
            this.txtTotalAbonos.Name = "txtTotalAbonos";
            this.txtTotalAbonos.ReadOnly = true;
            this.txtTotalAbonos.Size = new System.Drawing.Size(225, 38);
            this.txtTotalAbonos.TabIndex = 4;
            this.txtTotalAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Abonado";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 25;
            // 
            // cliente_id
            // 
            this.cliente_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliente_id.DataPropertyName = "cliente_id";
            this.cliente_id.HeaderText = "cliente_id";
            this.cliente_id.Name = "cliente_id";
            this.cliente_id.ReadOnly = true;
            this.cliente_id.Visible = false;
            this.cliente_id.Width = 74;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // boleta_id
            // 
            this.boleta_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.boleta_id.DataPropertyName = "boleta_id";
            this.boleta_id.HeaderText = "boleta_id";
            this.boleta_id.Name = "boleta_id";
            this.boleta_id.ReadOnly = true;
            this.boleta_id.Visible = false;
            this.boleta_id.Width = 91;
            // 
            // nro_boleta
            // 
            this.nro_boleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nro_boleta.DataPropertyName = "nro_boleta";
            this.nro_boleta.HeaderText = "Nro Boleta";
            this.nro_boleta.Name = "nro_boleta";
            this.nro_boleta.ReadOnly = true;
            // 
            // valor_abono
            // 
            this.valor_abono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_abono.DataPropertyName = "valor_abono";
            this.valor_abono.HeaderText = "Valor Abono";
            this.valor_abono.Name = "valor_abono";
            this.valor_abono.ReadOnly = true;
            this.valor_abono.Width = 111;
            // 
            // valor_comision
            // 
            this.valor_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor_comision.DataPropertyName = "valor_comision";
            this.valor_comision.HeaderText = "Valor Comision";
            this.valor_comision.Name = "valor_comision";
            this.valor_comision.ReadOnly = true;
            this.valor_comision.Width = 116;
            // 
            // abono_pagado
            // 
            this.abono_pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.abono_pagado.DataPropertyName = "abono_pagado";
            this.abono_pagado.HeaderText = "Pagado";
            this.abono_pagado.Name = "abono_pagado";
            this.abono_pagado.ReadOnly = true;
            this.abono_pagado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abono_pagado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.abono_pagado.Width = 63;
            // 
            // Frm_pago_comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_pago_comisiones";
            this.Text = "Frm_pago_comisiones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonosBoleta)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVendedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAbonosBoleta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalComisionPendiente;
        private System.Windows.Forms.TextBox txtTotalComisionPagada;
        private System.Windows.Forms.TextBox txttotalComision;
        private System.Windows.Forms.TextBox txtNroAbonos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.TextBox txtTotalAbonos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn boleta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_boleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono_pagado;
    }
}