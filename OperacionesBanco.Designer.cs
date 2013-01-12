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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.operacionesBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacionesBancoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.OperacionesBancoTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.operacionesBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOpeBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdConBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vPrevisionesGridControl = new DevExpress.XtraGrid.GridControl();
            this.vPrevisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHaber = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIdCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCompra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOpeBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            bancoCuentaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoCuentaLabel
            // 
            bancoCuentaLabel.AutoSize = true;
            bancoCuentaLabel.Location = new System.Drawing.Point(12, 9);
            bancoCuentaLabel.Name = "bancoCuentaLabel";
            bancoCuentaLabel.Size = new System.Drawing.Size(44, 13);
            bancoCuentaLabel.TabIndex = 5;
            bancoCuentaLabel.Text = "Cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(531, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 10;
            label1.Text = "Mostrar a partir de:";
            // 
            // colPrevision
            // 
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            this.colPrevision.Width = 176;
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
            this.operacionesBancoGridControl.DataSource = this.operacionesBancoBindingSource;
            this.operacionesBancoGridControl.Location = new System.Drawing.Point(0, 36);
            this.operacionesBancoGridControl.MainView = this.gridView1;
            this.operacionesBancoGridControl.Name = "operacionesBancoGridControl";
            this.operacionesBancoGridControl.Size = new System.Drawing.Size(1238, 210);
            this.operacionesBancoGridControl.TabIndex = 2;
            this.operacionesBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOpeBanco,
            this.colIdEmpresa,
            this.colFecha,
            this.colIdConBanco,
            this.colIdCompra,
            this.colIdCobro,
            this.colDesOperacion,
            this.colIdCuenta,
            this.colImporte,
            this.colEnCuenta,
            this.colSaldoAnterior,
            this.colIdFormaPago1});
            this.gridView1.GridControl = this.operacionesBancoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdOpeBanco
            // 
            this.colIdOpeBanco.FieldName = "IdOpeBanco";
            this.colIdOpeBanco.Name = "colIdOpeBanco";
            this.colIdOpeBanco.OptionsColumn.ReadOnly = true;
            this.colIdOpeBanco.Visible = true;
            this.colIdOpeBanco.VisibleIndex = 0;
            this.colIdOpeBanco.Width = 78;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 89;
            // 
            // colIdConBanco
            // 
            this.colIdConBanco.FieldName = "IdConBanco";
            this.colIdConBanco.Name = "colIdConBanco";
            this.colIdConBanco.Visible = true;
            this.colIdConBanco.VisibleIndex = 2;
            this.colIdConBanco.Width = 70;
            // 
            // colIdCompra
            // 
            this.colIdCompra.FieldName = "IdCompra";
            this.colIdCompra.Name = "colIdCompra";
            this.colIdCompra.Visible = true;
            this.colIdCompra.VisibleIndex = 3;
            this.colIdCompra.Width = 66;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 4;
            this.colIdCobro.Width = 54;
            // 
            // colDesOperacion
            // 
            this.colDesOperacion.FieldName = "DesOperacion";
            this.colDesOperacion.Name = "colDesOperacion";
            this.colDesOperacion.Visible = true;
            this.colDesOperacion.VisibleIndex = 5;
            this.colDesOperacion.Width = 418;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 6;
            this.colIdCuenta.Width = 94;
            // 
            // colImporte
            // 
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 7;
            this.colImporte.Width = 108;
            // 
            // colEnCuenta
            // 
            this.colEnCuenta.FieldName = "EnCuenta";
            this.colEnCuenta.Name = "colEnCuenta";
            this.colEnCuenta.Visible = true;
            this.colEnCuenta.VisibleIndex = 8;
            this.colEnCuenta.Width = 96;
            // 
            // colSaldoAnterior
            // 
            this.colSaldoAnterior.FieldName = "SaldoAnterior";
            this.colSaldoAnterior.Name = "colSaldoAnterior";
            this.colSaldoAnterior.Visible = true;
            this.colSaldoAnterior.VisibleIndex = 9;
            this.colSaldoAnterior.Width = 147;
            // 
            // vPrevisionesGridControl
            // 
            this.vPrevisionesGridControl.DataSource = this.vPrevisionesBindingSource;
            this.vPrevisionesGridControl.Location = new System.Drawing.Point(0, 278);
            this.vPrevisionesGridControl.MainView = this.gridView2;
            this.vPrevisionesGridControl.Name = "vPrevisionesGridControl";
            this.vPrevisionesGridControl.Size = new System.Drawing.Size(1238, 135);
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
            this.colmarca,
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
            this.colIdOpeBanco1});
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colPrevision;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "1";
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView2.GridControl = this.vPrevisionesGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colFecha1
            // 
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 0;
            this.colFecha1.Width = 124;
            // 
            // colDesProveedor
            // 
            this.colDesProveedor.Caption = "Descripción";
            this.colDesProveedor.FieldName = "DesProveedor";
            this.colDesProveedor.Name = "colDesProveedor";
            this.colDesProveedor.Visible = true;
            this.colDesProveedor.VisibleIndex = 2;
            this.colDesProveedor.Width = 380;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 3;
            this.colFactura.Width = 213;
            // 
            // colImporte1
            // 
            this.colImporte1.FieldName = "Importe";
            this.colImporte1.Name = "colImporte1";
            // 
            // colmarca
            // 
            this.colmarca.Caption = " ";
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 6;
            this.colmarca.Width = 69;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdCuenta1
            // 
            this.colIdCuenta1.FieldName = "IdCuenta";
            this.colIdCuenta1.Name = "colIdCuenta1";
            // 
            // colPagada
            // 
            this.colPagada.FieldName = "Pagada";
            this.colPagada.Name = "colPagada";
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 170;
            // 
            // colDebe
            // 
            this.colDebe.FieldName = "Debe";
            this.colDebe.Name = "colDebe";
            this.colDebe.Visible = true;
            this.colDebe.VisibleIndex = 4;
            this.colDebe.Width = 140;
            // 
            // colHaber
            // 
            this.colHaber.FieldName = "Haber";
            this.colHaber.Name = "colHaber";
            this.colHaber.Visible = true;
            this.colHaber.VisibleIndex = 5;
            this.colHaber.Width = 124;
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
            this.button1.Location = new System.Drawing.Point(1163, 249);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(1052, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(632, 6);
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
            // colIdCobro1
            // 
            this.colIdCobro1.FieldName = "IdCobro";
            this.colIdCobro1.Name = "colIdCobro1";
            // 
            // colIdCompra1
            // 
            this.colIdCompra1.FieldName = "IdCompra";
            this.colIdCompra1.Name = "colIdCompra1";
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colIdOpeBanco1
            // 
            this.colIdOpeBanco1.FieldName = "IdOpeBanco";
            this.colIdOpeBanco1.Name = "colIdOpeBanco1";
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            this.colIdFormaPago1.Visible = true;
            this.colIdFormaPago1.VisibleIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OperacionesBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPrevisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpeBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colDesOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colEnCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAnterior;
        private Promowork_dataDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private Promowork_dataDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOpeBanco1;
        private System.Windows.Forms.Button button2;
    }
}