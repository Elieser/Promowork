namespace Promowork
{
    partial class RptParametrosOperacionesBanco
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.TipoOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoOpe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.promowork_dataDataSet = new Promowork.Promowork_dataDataSet();
            this.marcaTipoOpeBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTipoOpeBancoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaTipoOpeBancoTableAdapter();
            this.tableAdapterManager = new Promowork.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.marcaTipoOpeBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MarcaTipoOpe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.marcaConceptosBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaConceptosBancoTableAdapter = new Promowork.Promowork_dataDataSetTableAdapters.MarcaConceptosBancoTableAdapter();
            this.marcaConceptosBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MarcaConceptoBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescipcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTipoOpeBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTipoOpeBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaConceptosBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaConceptosBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoOpe
            // 
            this.TipoOpe.Caption = "Tipo Operación";
            this.TipoOpe.FieldName = "TipoOpe";
            this.TipoOpe.Name = "TipoOpe";
            this.TipoOpe.Visible = true;
            this.TipoOpe.VisibleIndex = 1;
            this.TipoOpe.Width = 238;
            // 
            // colTipoOpe1
            // 
            this.colTipoOpe1.Caption = "Tipo";
            this.colTipoOpe1.FieldName = "TipoOpe";
            this.colTipoOpe1.Name = "colTipoOpe1";
            this.colTipoOpe1.Width = 175;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTipoOpeBancoBindingSource
            // 
            this.marcaTipoOpeBancoBindingSource.DataMember = "MarcaTipoOpeBanco";
            this.marcaTipoOpeBancoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // marcaTipoOpeBancoTableAdapter
            // 
            this.marcaTipoOpeBancoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.OperacionesBancoTableAdapter = null;
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
            // marcaTipoOpeBancoGridControl
            // 
            this.marcaTipoOpeBancoGridControl.DataSource = this.marcaTipoOpeBancoBindingSource;
            this.marcaTipoOpeBancoGridControl.Location = new System.Drawing.Point(12, 52);
            this.marcaTipoOpeBancoGridControl.MainView = this.gridView1;
            this.marcaTipoOpeBancoGridControl.Name = "marcaTipoOpeBancoGridControl";
            this.marcaTipoOpeBancoGridControl.Size = new System.Drawing.Size(308, 328);
            this.marcaTipoOpeBancoGridControl.TabIndex = 2;
            this.marcaTipoOpeBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MarcaTipoOpe,
            this.TipoOpe});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Azure;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.TipoOpe;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "Proveedores";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.TipoOpe;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "Clientes";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.TipoOpe;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "Otras Operaciones";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gridView1.GridControl = this.marcaTipoOpeBancoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // MarcaTipoOpe
            // 
            this.MarcaTipoOpe.Caption = " ";
            this.MarcaTipoOpe.FieldName = "Marca";
            this.MarcaTipoOpe.Name = "MarcaTipoOpe";
            this.MarcaTipoOpe.Visible = true;
            this.MarcaTipoOpe.VisibleIndex = 0;
            this.MarcaTipoOpe.Width = 26;
            // 
            // marcaConceptosBancoBindingSource
            // 
            this.marcaConceptosBancoBindingSource.DataMember = "MarcaConceptosBanco";
            this.marcaConceptosBancoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // marcaConceptosBancoTableAdapter
            // 
            this.marcaConceptosBancoTableAdapter.ClearBeforeFill = true;
            // 
            // marcaConceptosBancoGridControl
            // 
            this.marcaConceptosBancoGridControl.DataSource = this.marcaConceptosBancoBindingSource;
            this.marcaConceptosBancoGridControl.Location = new System.Drawing.Point(338, 52);
            this.marcaConceptosBancoGridControl.MainView = this.gridView2;
            this.marcaConceptosBancoGridControl.Name = "marcaConceptosBancoGridControl";
            this.marcaConceptosBancoGridControl.Size = new System.Drawing.Size(461, 328);
            this.marcaConceptosBancoGridControl.TabIndex = 4;
            this.marcaConceptosBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MarcaConceptoBanco,
            this.colTipoOpe1,
            this.colDescipcion});
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Azure;
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colTipoOpe1;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "Proveedores";
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Column = this.colTipoOpe1;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition5.Value1 = "Clientes";
            styleFormatCondition6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            styleFormatCondition6.Appearance.Options.UseBackColor = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Column = this.colTipoOpe1;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition6.Value1 = "Otras Operaciones";
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6});
            this.gridView2.GridControl = this.marcaConceptosBancoGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // MarcaConceptoBanco
            // 
            this.MarcaConceptoBanco.Caption = " ";
            this.MarcaConceptoBanco.FieldName = "Marca";
            this.MarcaConceptoBanco.Name = "MarcaConceptoBanco";
            this.MarcaConceptoBanco.Visible = true;
            this.MarcaConceptoBanco.VisibleIndex = 0;
            this.MarcaConceptoBanco.Width = 33;
            // 
            // colDescipcion
            // 
            this.colDescipcion.Caption = "Descripción";
            this.colDescipcion.FieldName = "Descipcion";
            this.colDescipcion.Name = "colDescipcion";
            this.colDescipcion.OptionsColumn.ReadOnly = true;
            this.colDescipcion.Visible = true;
            this.colDescipcion.VisibleIndex = 1;
            this.colDescipcion.Width = 416;
            // 
            // colMarca
            // 
            this.colMarca.Caption = " Tipo Operación";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 0;
            this.colMarca.Width = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // RptParametrosOperacionesBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcaConceptosBancoGridControl);
            this.Controls.Add(this.marcaTipoOpeBancoGridControl);
            this.Name = "RptParametrosOperacionesBanco";
            this.Text = "RptParametrosOperacionesBanco";
            this.Load += new System.EventHandler(this.RptParametrosOperacionesBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTipoOpeBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTipoOpeBancoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaConceptosBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaConceptosBancoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource marcaTipoOpeBancoBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaTipoOpeBancoTableAdapter marcaTipoOpeBancoTableAdapter;
        private Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl marcaTipoOpeBancoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TipoOpe;
        private System.Windows.Forms.BindingSource marcaConceptosBancoBindingSource;
        private Promowork_dataDataSetTableAdapters.MarcaConceptosBancoTableAdapter marcaConceptosBancoTableAdapter;
        private DevExpress.XtraGrid.GridControl marcaConceptosBancoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaConceptoBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoOpe1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescipcion;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaTipoOpe;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}