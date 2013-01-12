using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public partial class OperacionesBanco : Form
    {
        public OperacionesBanco()
        {
            InitializeComponent();
        }

      
        private void OperacionesBanco_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            dateTimePicker2.Value = DateTime.Today.AddMonths(-1);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Bancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue),dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
        }

    
        private void bancoCuentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
        }

        private void OperacionesBanco_Resize(object sender, EventArgs e)
        {
            operacionesBancoGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Height = this.Height - operacionesBancoGridControl.Height - 120;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  operacionesBancoTableAdapter.Insert(VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, null, null, null, Convert.ToString(gridView2.GetFocusedRowCellValue("DesProveedor")) +" Factura: "+ Convert.ToString(gridView2.GetFocusedRowCellValue("Factura")), Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCuenta")), Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Importe")), true);
            if (Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdOpeBanco")) != 0)
            {
                operacionesBancoBindingSource.AddNew();
                DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
                opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                opebanco["fecha"] = dateTimePicker1.Value;
                opebanco["DesOperacion"] = Convert.ToString(gridView2.GetFocusedRowCellValue("DesProveedor")) + " Fra: " + Convert.ToString(gridView2.GetFocusedRowCellValue("Factura"));
                opebanco["IdCuenta"] = gridView2.GetFocusedRowCellValue("IdCuenta");
                opebanco["IdCompra"] = gridView2.GetFocusedRowCellValue("IdCompra");
                opebanco["IdCobro"] = gridView2.GetFocusedRowCellValue("IdCobro");
                opebanco["IdFormaPago"] = gridView2.GetFocusedRowCellValue("IdFormaPago");
                opebanco["Importe"] = gridView2.GetFocusedRowCellValue("Importe");
                opebanco["EnCuenta"] = true;
            }
            else
            {
                gridView1.SetFocusedRowCellValue("IdCobro",true);
            }
            this.Validate();
            operacionesBancoBindingSource.EndEdit();
            operacionesBancoTableAdapter.Update(promowork_dataDataSet.OperacionesBanco);

            DataRowView opebanco1 = (DataRowView)operacionesBancoBindingSource.Current;
            queriesTableAdapter1.ActualizaSaldoAnterior(Convert.ToInt32(opebanco1["IdOpeBanco"]));

            if (Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCompra"))!=0)
            {
                pagosTableAdapter.Insert(Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCompra")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdFormaPago")), dateTimePicker1.Value, "BANCO", Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Importe")), "", Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCuenta")), dateTimePicker1.Value);
                queriesTableAdapter1.UpdateCompraPagada(Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCompra")));
            }

            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("Fecha"));
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
        }

       
    }
}
