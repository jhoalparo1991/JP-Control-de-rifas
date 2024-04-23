
namespace ReportsModule._rdls
{
    partial class RptMostrarComisionesVendedores2
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptMostrarComisionesVendedores2));
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.table2 = new Telerik.Reporting.Table();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.txtVendedor = new Telerik.Reporting.TextBox();
            this.txtFormaDePago = new Telerik.Reporting.TextBox();
            this.txtValorPagado = new Telerik.Reporting.TextBox();
            this.txtFechaDePago = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.txtTotalValorAcumulado = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.6D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBox1,
            this.textBox1,
            this.textBox20,
            this.textBox21,
            this.textBox22,
            this.textBox23,
            this.txtVendedor,
            this.txtFormaDePago,
            this.txtValorPagado,
            this.txtFechaDePago});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.4D), Telerik.Reporting.Drawing.Unit.Cm(1.3D));
            this.pictureBox1.MimeType = "image/jpeg";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3D), Telerik.Reporting.Drawing.Unit.Cm(1.9D));
            this.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBox1.Value = ((object)(resources.GetObject("pictureBox1.Value")));
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Pago de comisiones";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.9D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table2,
            this.textBox2,
            this.txtTotalValorAcumulado});
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox12});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.4D), Telerik.Reporting.Drawing.Unit.Cm(0.2D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.1D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox12.Value = "=\"Fecha procesado : \" + Now()";
            // 
            // table2
            // 
            this.table2.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.677D)));
            this.table2.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.584D)));
            this.table2.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.839D)));
            this.table2.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609D)));
            this.table2.Body.SetCellContent(0, 0, this.textBox4);
            this.table2.Body.SetCellContent(0, 2, this.textBox5);
            this.table2.Body.SetCellContent(0, 1, this.textBox9);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.textBox11;
            tableGroup2.Name = "group2";
            tableGroup2.ReportItem = this.textBox17;
            tableGroup3.Name = "tableGroup2";
            tableGroup3.ReportItem = this.textBox18;
            this.table2.ColumnGroups.Add(tableGroup1);
            this.table2.ColumnGroups.Add(tableGroup2);
            this.table2.ColumnGroups.Add(tableGroup3);
            this.table2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox9,
            this.textBox5,
            this.textBox11,
            this.textBox17,
            this.textBox18});
            this.table2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.399D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.table2.Name = "table2";
            tableGroup4.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup4.Name = "detailTableGroup";
            this.table2.RowGroups.Add(tableGroup4);
            this.table2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.101D), Telerik.Reporting.Drawing.Unit.Cm(1.218D));
            this.table2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.table2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // textBox4
            // 
            this.textBox4.Format = "{0:d}";
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.677D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "=Fields.nro_boleta";
            // 
            // textBox5
            // 
            this.textBox5.Format = "{0:C2}";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.839D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "=Fields.valor_comision";
            // 
            // textBox9
            // 
            this.textBox9.Format = "{0:d}";
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.584D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.StyleName = "";
            this.textBox9.Value = "=Fields.fecha";
            // 
            // textBox11
            // 
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.677D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.Value = "Nro Boleta";
            // 
            // textBox17
            // 
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.584D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox17.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox17.Style.Font.Bold = true;
            this.textBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox17.StyleName = "";
            this.textBox17.Value = "Fecha";
            // 
            // textBox18
            // 
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.839D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox18.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox18.Style.Font.Bold = true;
            this.textBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox18.Value = "Valor Pago";
            // 
            // textBox20
            // 
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1D), Telerik.Reporting.Drawing.Unit.Cm(1.1D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox20.Style.Font.Bold = true;
            this.textBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox20.Value = "Vendedor :";
            // 
            // textBox21
            // 
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox21.Style.Font.Bold = true;
            this.textBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox21.Value = "Forma de pago :";
            // 
            // textBox22
            // 
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1D), Telerik.Reporting.Drawing.Unit.Cm(2.3D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox22.Style.Font.Bold = true;
            this.textBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox22.Value = "Valor pagado :";
            // 
            // textBox23
            // 
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1D), Telerik.Reporting.Drawing.Unit.Cm(2.9D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox23.Style.Font.Bold = true;
            this.textBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox23.Value = "Fecha de pago :";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7D), Telerik.Reporting.Drawing.Unit.Cm(1.1D));
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.2D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtVendedor.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtVendedor.Value = "textBox24";
            // 
            // txtFormaDePago
            // 
            this.txtFormaDePago.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7D), Telerik.Reporting.Drawing.Unit.Cm(1.7D));
            this.txtFormaDePago.Name = "txtFormaDePago";
            this.txtFormaDePago.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.2D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtFormaDePago.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtFormaDePago.Value = "textBox24";
            // 
            // txtValorPagado
            // 
            this.txtValorPagado.Format = "{0:C2}";
            this.txtValorPagado.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7D), Telerik.Reporting.Drawing.Unit.Cm(2.3D));
            this.txtValorPagado.Name = "txtValorPagado";
            this.txtValorPagado.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.2D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtValorPagado.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtValorPagado.Value = "textBox24";
            // 
            // txtFechaDePago
            // 
            this.txtFechaDePago.Format = "{0:d}";
            this.txtFechaDePago.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7D), Telerik.Reporting.Drawing.Unit.Cm(2.9D));
            this.txtFechaDePago.Name = "txtFechaDePago";
            this.txtFechaDePago.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.2D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtFechaDePago.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtFechaDePago.Value = "textBox24";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.761D), Telerik.Reporting.Drawing.Unit.Cm(1.518D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Total ";
            // 
            // txtTotalValorAcumulado
            // 
            this.txtTotalValorAcumulado.Format = "{0:C2}";
            this.txtTotalValorAcumulado.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.7D), Telerik.Reporting.Drawing.Unit.Cm(1.518D));
            this.txtTotalValorAcumulado.Name = "txtTotalValorAcumulado";
            this.txtTotalValorAcumulado.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtTotalValorAcumulado.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalValorAcumulado.Style.Font.Bold = true;
            this.txtTotalValorAcumulado.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtTotalValorAcumulado.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTotalValorAcumulado.Value = "textBox24";
            // 
            // RptMostrarComisionesVendedores2
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.Name = "RptMostrarComisionesVendedores22";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.Font.Name = "Consolas";
            this.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox1;
        public Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        internal Telerik.Reporting.TextBox txtVendedor;
        internal Telerik.Reporting.TextBox txtFormaDePago;
        internal Telerik.Reporting.TextBox txtValorPagado;
        internal Telerik.Reporting.TextBox txtFechaDePago;
        internal Telerik.Reporting.Table table2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox2;
        internal Telerik.Reporting.TextBox txtTotalValorAcumulado;
    }
}