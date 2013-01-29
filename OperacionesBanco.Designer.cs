namespace Promowork
{
    partial class OperacionesBanco
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
            System.Windows.Forms.Label bancoCuentaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idConBancoLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label idFormaPagoLabel;
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.operacionesBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacionesBancoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.OperacionesBancoTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.operacionesBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.vOperacionesBancoAgrupadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOpebanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vPrevisionesGridControl = new DevExpress.XtraGrid.GridControl();
            this.vPrevisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOpeBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentasBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.bancoCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.vPrevisionesTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vPrevisionesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.queriesTableAdapter1 = new Promowork.Promowork_dataDataSetTableAdapters.QueriesTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.PagosTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.saldoAnteriorTextBox = new System.Windows.Forms.TextBox();
            this.formasPagoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vOperacionesBancoAgrupadasTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.vOperacionesBancoAgrupadasTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtimportesel = new System.Windows.Forms.TextBox();
            this.txtsaldofinal = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxconcepto = new System.Windows.Forms.ComboBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.idFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.conceptosBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptosBancosTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.ConceptosBancosTableAdapter();
            this.formasPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            bancoCuentaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idConBancoLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOperacionesBancoAgrupadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bancoCuentaLabel
            // 
            bancoCuentaLabel.AutoSize = true;
            bancoCuentaLabel.Location = new System.Drawing.Point(12, 10);
            bancoCuentaLabel.Name = "bancoCuentaLabel";
            bancoCuentaLabel.Size = new System.Drawing.Size(44, 13);
            bancoCuentaLabel.TabIndex = 5;
            bancoCuentaLabel.Text = "Cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(465, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 10;
            label1.Text = "Mostrar a partir de:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 307);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 13;
            label2.Text = "Fecha Banco:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(206, 307);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 13);
            label3.TabIndex = 15;
            label3.Text = "Forma Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(622, 307);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 13);
            label4.TabIndex = 18;
            label4.Text = "Importe Seleccionado:";
            // 
            // colSaldo
            // 
            this.colSaldo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSaldo.AppearanceCell.Options.UseFont = true;
            this.colSaldo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 6;
            this.colSaldo.Width = 100;
            // 
            // colPrevision
            // 
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            this.colPrevision.OptionsColumn.AllowEdit = false;
            this.colPrevision.Width = 176;
            // 
            // Saldo
            // 
            this.Saldo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Saldo.AppearanceCell.Options.UseFont = true;
            this.Saldo.AppearanceHeader.Options.UseTextOptions = true;
            this.Saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Saldo.FieldName = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 7;
            this.Saldo.Width = 100;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operacionesBancoBindingSource
            // 
            this.operacionesBancoBindingSource.DataMember = "OperacionesBanco";
            this.operacionesBancoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // operacionesBancoTableAdapter
            // 
            this.operacionesBancoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager.AnticiposTableAdapter = null;
            this.tableAdapterManager.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajasMedicaTableAdapter = null;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ConceptosBancosTableAdapter = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetHorasTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.OperacionesBancoTableAdapter = this.operacionesBancoTableAdapter;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.ParticipantesTableAdapter = null;
            this.tableAdapterManager.PartObrasTableAdapter = null;
            this.tableAdapterManager.PartPresupTableAdapter = null;
            this.tableAdapterManager.Poblaciones1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvincias1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvinciasTableAdapter = null;
            this.tableAdapterManager.PoblacionesTableAdapter = null;
            this.tableAdapterManager.PresupCabTableAdapter = null;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProductosUtilizadosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // operacionesBancoGridControl
            // 
            this.operacionesBancoGridControl.DataSource = this.vOperacionesBancoAgrupadasBindingSource;
            this.operacionesBancoGridControl.Location = new System.Drawing.Point(0, 36);
            this.operacionesBancoGridControl.MainView = this.gridView1;
            this.operacionesBancoGridControl.Name = "operacionesBancoGridControl";
            this.operacionesBancoGridControl.Size = new System.Drawing.Size(1238, 259);
            this.operacionesBancoGridControl.TabIndex = 2;
            this.operacionesBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vOperacionesBancoAgrupadasBindingSource
            // 
            this.vOperacionesBancoAgrupadasBindingSource.DataMember = "vOperacionesBancoAgrupadas";
            this.vOperacionesBancoAgrupadasBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaOpe,
            this.colFecha,
            this.colIdFormaPago1,
            this.colIdCuenta,
            this.colImporte,
            this.colSaldoAnterior,
            this.colDesOperacion,
            this.colDesFormaPago,
            this.colIdEmpresa,
            this.colDebe1,
            this.colHaber1,
            this.colSaldo,
            this.colIdOpebanco,
            this.colTipoOpe});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colSaldo;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = "0";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.operacionesBancoGridControl;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", this.colImporte, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFechaOpe
            // 
            this.colFechaOpe.FieldName = "FechaOpe";
            this.colFechaOpe.Name = "colFechaOpe";
            this.colFechaOpe.Width = 60;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 100;
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Width = 279;
            // 
            // colImporte
            // 
            this.colImporte.Caption = "Importe";
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Width = 272;
            // 
            // colSaldoAnterior
            // 
            this.colSaldoAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaldoAnterior.FieldName = "SaldoAnterior";
            this.colSaldoAnterior.Name = "colSaldoAnterior";
            this.colSaldoAnterior.Width = 80;
            // 
            // colDesOperacion
            // 
            this.colDesOperacion.Caption = "Descripción";
            this.colDesOperacion.FieldName = "DesOperacion";
            this.colDesOperacion.Name = "colDesOperacion";
            this.colDesOperacion.Visible = true;
            this.colDesOperacion.VisibleIndex = 2;
            this.colDesOperacion.Width = 400;
            // 
            // colDesFormaPago
            // 
            this.colDesFormaPago.Caption = "Forma Pago";
            this.colDesFormaPago.FieldName = "DesFormaPago";
            this.colDesFormaPago.Name = "colDesFormaPago";
            this.colDesFormaPago.Visible = true;
            this.colDesFormaPago.VisibleIndex = 3;
            this.colDesFormaPago.Width = 318;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colDebe1
            // 
            this.colDebe1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebe1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDebe1.FieldName = "Debe";
            this.colDebe1.Name = "colDebe1";
            this.colDebe1.Visible = true;
            this.colDebe1.VisibleIndex = 4;
            this.colDebe1.Width = 100;
            // 
            // colHaber1
            // 
            this.colHaber1.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaber1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHaber1.FieldName = "Haber";
            this.colHaber1.Name = "colHaber1";
            this.colHaber1.Visible = true;
            this.colHaber1.VisibleIndex = 5;
            this.colHaber1.Width = 100;
            // 
            // colIdOpebanco
            // 
            this.colIdOpebanco.FieldName = "IdOpebanco";
            this.colIdOpebanco.Name = "colIdOpebanco";
            this.colIdOpebanco.Width = 54;
            // 
            // colTipoOpe
            // 
            this.colTipoOpe.Caption = "Tipo";
            this.colTipoOpe.FieldName = "TipoOpe";
            this.colTipoOpe.Name = "colTipoOpe";
            this.colTipoOpe.Visible = true;
            this.colTipoOpe.VisibleIndex = 1;
            this.colTipoOpe.Width = 100;
            // 
            // vPrevisionesGridControl
            // 
            this.vPrevisionesGridControl.DataSource = this.vPrevisionesBindingSource;
            this.vPrevisionesGridControl.Location = new System.Drawing.Point(0, 329);
            this.vPrevisionesGridControl.MainView = this.gridView2;
            this.vPrevisionesGridControl.Name = "vPrevisionesGridControl";
            this.vPrevisionesGridControl.Size = new System.Drawing.Size(1238, 107);
            this.vPrevisionesGridControl.TabIndex = 4;
            this.vPrevisionesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // vPrevisionesBindingSource
            // 
            this.vPrevisionesBindingSource.DataMember = "vPrevisiones";
            this.vPrevisionesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Red;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha1,
            this.colDesProveedor,
            this.colFactura,
            this.colImporte1,
            this.marca,
            this.colIdEmpresa1,
            this.colIdCuenta1,
            this.colPagada,
            this.colTipo,
            this.colPrevision,
            this.colDebe,
            this.colHaber,
            this.colIdCobro1,
            this.colIdCompra1,
            this.colIdFormaPago,
            this.Saldo,
            this.colIdOpeBanco1});
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colPrevision;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "1";
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.Saldo;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            styleFormatCondition5.Value1 = "0";
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2,
            styleFormatCondition5});
            this.gridView2.GridControl = this.vPrevisionesGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            // 
            // colFecha1
            // 
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.OptionsColumn.AllowEdit = false;
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 0;
            this.colFecha1.Width = 100;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Descripción";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.OptionsColumn.AllowEdit = false;
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 2;
            this.colDesProveedor.Width = 400;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.AllowEdit = false;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 3;
            this.colFactura.Width = 222;
            // 
            // colImporte1
            // 
            this.colImporte1.FieldName = "Importe";
            this.colImporte1.Name = "colImporte1";
            this.colImporte1.OptionsColumn.AllowEdit = false;
            // 
            // marca
            // 
            this.marca.Caption = " ";
            this.marca.FieldName = "marca";
            this.marca.Name = "marca";
            this.marca.Visible = true;
            this.marca.VisibleIndex = 4;
            this.marca.Width = 76;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.AllowEdit = false;
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            this.colIdCuenta1.OptionsColumn.AllowEdit = false;
            // 
            // colPagada
            // 
            this.colPagada.FieldName = "Pagada";
            this.colPagada.Name = "colPagada";
            this.colPagada.OptionsColumn.AllowEdit = false;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 100;
            // 
            // colDebe
            // 
            this.colDebe.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDebe.FieldName = "Debe";
            this.colDebe.Name = "colDebe";
            this.colDebe.OptionsColumn.AllowEdit = false;
            this.colDebe.Visible = true;
            this.colDebe.VisibleIndex = 5;
            this.colDebe.Width = 100;
            // 
            // colHaber
            // 
            this.colHaber.AppearanceHeader.Options.UseTextOptions = true;
            this.colHaber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colHaber.FieldName = "Haber";
            this.colHaber.Name = "colHaber";
            this.colHaber.OptionsColumn.AllowEdit = false;
            this.colHaber.Visible = true;
            this.colHaber.VisibleIndex = 6;
            this.colHaber.Width = 100;
            // 
            // colIdCobro1
            // 
            this.colIdCobro1.FieldName = "IdCobro";
            this.colIdCobro1.Name = "colIdCobro1";
            this.colIdCobro1.OptionsColumn.AllowEdit = false;
            this.colIdCobro1.Width = 36;
            // 
            // colIdCompra1
            // 
            this.colIdCompra1.FieldName = "IdCompra";
            this.colIdCompra1.Name = "colIdCompra1";
            this.colIdCompra1.OptionsColumn.AllowEdit = false;
            this.colIdCompra1.Width = 34;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsColumn.AllowEdit = false;
            this.colIdFormaPago.Width = 139;
            // 
            // colIdOpeBanco1
            // 
            this.colIdOpeBanco1.FieldName = "IdOpeBanco";
            this.colIdOpeBanco1.Name = "colIdOpeBanco1";
            this.colIdOpeBanco1.OptionsColumn.AllowEdit = false;
            this.colIdOpeBanco1.Width = 35;
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // bancoCuentaComboBox
            // 
            this.bancoCuentaComboBox.DataSource = this.cuentasBancosBindingSource;
            this.bancoCuentaComboBox.DisplayMember = "BancoCuenta";
            this.bancoCuentaComboBox.FormattingEnabled = true;
            this.bancoCuentaComboBox.Location = new System.Drawing.Point(62, 6);
            this.bancoCuentaComboBox.Name = "bancoCuentaComboBox";
            this.bancoCuentaComboBox.Size = new System.Drawing.Size(398, 21);
            this.bancoCuentaComboBox.TabIndex = 6;
            this.bancoCuentaComboBox.ValueMember = "IdCuenta";
            this.bancoCuentaComboBox.SelectedIndexChanged += new System.EventHandler(this.bancoCuentaComboBox_SelectedIndexChanged);
            // 
            // vPrevisionesTableAdapter
            // 
            this.vPrevisionesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(566, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2013, 1, 11, 0, 0, 0, 0);
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saldoAnteriorTextBox
            // 
            this.saldoAnteriorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoAnteriorTextBox.Location = new System.Drawing.Point(1137, 7);
            this.saldoAnteriorTextBox.Name = "saldoAnteriorTextBox";
            this.saldoAnteriorTextBox.ReadOnly = true;
            this.saldoAnteriorTextBox.Size = new System.Drawing.Size(100, 21);
            this.saldoAnteriorTextBox.TabIndex = 12;
            this.saldoAnteriorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saldoAnteriorTextBox.TextChanged += new System.EventHandler(this.saldoAnteriorTextBox_TextChanged);
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vPrevisionesBindingSource, "IdFormaPago", true));
            this.comboBox1.DataSource = this.formasPagoBindingSource;
            this.comboBox1.DisplayMember = "DesFormaPago";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "IdFormaPago";
            // 
            // vOperacionesBancoAgrupadasTableAdapter
            // 
            this.vOperacionesBancoAgrupadasTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(750, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Recalcular Saldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(898, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtimportesel
            // 
            this.txtimportesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimportesel.Location = new System.Drawing.Point(741, 303);
            this.txtimportesel.Name = "txtimportesel";
            this.txtimportesel.ReadOnly = true;
            this.txtimportesel.Size = new System.Drawing.Size(81, 21);
            this.txtimportesel.TabIndex = 19;
            this.txtimportesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsaldofinal
            // 
            this.txtsaldofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldofinal.Location = new System.Drawing.Point(1137, 301);
            this.txtsaldofinal.Name = "txtsaldofinal";
            this.txtsaldofinal.ReadOnly = true;
            this.txtsaldofinal.Size = new System.Drawing.Size(100, 21);
            this.txtsaldofinal.TabIndex = 21;
            this.txtsaldofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(6, 17);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 21;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(52, 13);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaDateTimePicker.TabIndex = 22;
            // 
            // idConBancoLabel
            // 
            idConBancoLabel.AutoSize = true;
            idConBancoLabel.Location = new System.Drawing.Point(159, 17);
            idConBancoLabel.Name = "idConBancoLabel";
            idConBancoLabel.Size = new System.Drawing.Size(56, 13);
            idConBancoLabel.TabIndex = 22;
            idConBancoLabel.Text = "Concepto:";
            // 
            // cbxconcepto
            // 
            this.cbxconcepto.DataSource = this.conceptosBancosBindingSource;
            this.cbxconcepto.DisplayMember = "DesConBanco";
            this.cbxconcepto.FormattingEnabled = true;
            this.cbxconcepto.Location = new System.Drawing.Point(221, 13);
            this.cbxconcepto.Name = "cbxconcepto";
            this.cbxconcepto.Size = new System.Drawing.Size(202, 21);
            this.cbxconcepto.TabIndex = 24;
            this.cbxconcepto.ValueMember = "IdConBanco";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(738, 18);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 24;
            importeLabel.Text = "Importe:";
            // 
            // importeTextBox
            // 
            this.importeTextBox.Location = new System.Drawing.Point(789, 14);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 25;
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(452, 17);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(67, 13);
            idFormaPagoLabel.TabIndex = 26;
            idFormaPagoLabel.Text = "Forma Pago:";
            // 
            // idFormaPagoComboBox
            // 
            this.idFormaPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operacionesBancoBindingSource, "IdFormaPago", true));
            this.idFormaPagoComboBox.DataSource = this.formasPagoBindingSource1;
            this.idFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.idFormaPagoComboBox.FormattingEnabled = true;
            this.idFormaPagoComboBox.Location = new System.Drawing.Point(525, 13);
            this.idFormaPagoComboBox.Name = "idFormaPagoComboBox";
            this.idFormaPagoComboBox.Size = new System.Drawing.Size(164, 21);
            this.idFormaPagoComboBox.TabIndex = 27;
            this.idFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // conceptosBancosBindingSource
            // 
            this.conceptosBancosBindingSource.DataMember = "ConceptosBancos";
            this.conceptosBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // conceptosBancosTableAdapter
            // 
            this.conceptosBancosTableAdapter.ClearBeforeFill = true;
            // 
            // formasPagoBindingSource1
            // 
            this.formasPagoBindingSource1.DataMember = "FormasPago";
            this.formasPagoBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.importeTextBox);
            this.groupBox1.Controls.Add(this.cbxconcepto);
            this.groupBox1.Controls.Add(idConBancoLabel);
            this.groupBox1.Controls.Add(idFormaPagoLabel);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(importeLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(this.idFormaPagoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 40);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otras Operaciones";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(939, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OperacionesBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1258, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsaldofinal);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtimportesel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.saldoAnteriorTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(bancoCuentaLabel);
            this.Controls.Add(this.bancoCuentaComboBox);
            this.Controls.Add(this.vPrevisionesGridControl);
            this.Controls.Add(this.operacionesBancoGridControl);
            this.Name = "OperacionesBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OperacionesBanco";
            this.Load += new System.EventHandler(this.OperacionesBanco_Load);
            this.Resize += new System.EventHandler(this.OperacionesBanco_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOperacionesBancoAgrupadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource operacionesBancoBindingSource;
        private Promowork_dataDataSetTableAdapters.OperacionesBancoTableAdapter operacionesBancoTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl operacionesBancoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl vPrevisionesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.ComboBox bancoCuentaComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte1;
        private DevExpress.XtraGrid.Columns.GridColumn marca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colPagada;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevision;
        private System.Windows.Forms.BindingSource vPrevisionesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDebe;
        private DevExpress.XtraGrid.Columns.GridColumn colHaber;
        private Promowork_dataDataSetTableAdapters.vPrevisionesTableAdapter vPrevisionesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private Promowork_dataDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpeBanco1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox saldoAnteriorTextBox;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource vOperacionesBancoAgrupadasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOpe;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colDesOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDesFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private Promowork_dataDataSetTableAdapters.vOperacionesBancoAgrupadasTableAdapter vOperacionesBancoAgrupadasTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDebe1;
        private DevExpress.XtraGrid.Columns.GridColumn colHaber1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpebanco;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoOpe;
        private System.Windows.Forms.TextBox txtimportesel;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private System.Windows.Forms.TextBox txtsaldofinal;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox cbxconcepto;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.ComboBox idFormaPagoComboBox;
        private System.Windows.Forms.BindingSource conceptosBancosBindingSource;
        private Promowork_dataDataSetTableAdapters.ConceptosBancosTableAdapter conceptosBancosTableAdapter;
        private System.Windows.Forms.BindingSource formasPagoBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
    }
}