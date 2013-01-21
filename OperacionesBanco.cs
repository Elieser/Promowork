using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);

            this.WindowState = FormWindowState.Maximized;
            dateTimePicker2.Value = DateTime.Today.AddMonths(-1);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Bancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue),dateTimePicker2.Value);
            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
            vOperacionesBancoAgrupadasBindingSource.MoveLast();
        }

    
        private void bancoCuentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
            vOperacionesBancoAgrupadasBindingSource.MoveLast();
        }

        private void OperacionesBanco_Resize(object sender, EventArgs e)
        {
            operacionesBancoGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Height = this.Height - operacionesBancoGridControl.Height - 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  operacionesBancoTableAdapter.Insert(VariablesGlobales.nIdEmpresaActual, dateTimePicker1.Value, null, null, null, Convert.ToString(gridView2.GetFocusedRowCellValue("DesProveedor")) +" Factura: "+ Convert.ToString(gridView2.GetFocusedRowCellValue("Factura")), Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdCuenta")), Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Importe")), true);
          //  MessageBox.Show(Convert.ToString(gridView2.GetFocusedRowCellValue("IdOpeBanco")));

            DateTime FechaActual = DateTime.Now;
            if (Convert.ToString(comboBox1.SelectedValue).Trim()=="" )
            {
                MessageBox.Show("Debe definir la Forma de Pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              //  MessageBox.Show(Convert.ToString(comboBox1.SelectedValue));
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    MessageBox.Show("La fecha de la operación tiene que estar contenida en el rango mostrado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   

                        if (gridView2.RowCount > 0)
                        {
                            string factura = "";
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                               // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                                if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                                {
                                     if (Convert.IsDBNull(gridView2.GetFocusedRowCellValue("IdOpeBanco")))
                                      {
                                          factura = factura + Convert.ToString(gridView2.GetRowCellValue(i, "Factura"))+"  ";
                                    operacionesBancoBindingSource.AddNew();
                                    DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
                                    opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                                    opebanco["fecha"] = dateTimePicker1.Value;
                                    opebanco["DesOperacion"] = Convert.ToString(gridView2.GetRowCellValue(i, "DesProveedor")) + " Fra: " + factura;
                                    opebanco["IdCuenta"] = gridView2.GetRowCellValue(i, "IdCuenta");
                                    opebanco["IdCompra"] = gridView2.GetRowCellValue(i, "IdCompra");
                                    opebanco["IdCobro"] = gridView2.GetRowCellValue(i, "IdCobro");
                                    opebanco["IdFormaPago"] = Convert.ToInt32(comboBox1.SelectedValue);
                                    opebanco["Importe"] = gridView2.GetRowCellValue(i, "Importe");
                                    opebanco["EnCuenta"] = true;
                                    opebanco["FechaOpe"] = FechaActual;
                                     }
                                    else
                                    {
                                        DataRowView opebanco1 = (DataRowView)operacionesBancoBindingSource.Current;
                                        opebanco1["EnCuenta"] = true;
                                    }

                                     this.Validate();
                                     operacionesBancoBindingSource.EndEdit();
                                     operacionesBancoTableAdapter.Update(promowork_dataDataSet.OperacionesBanco);
                               
                                    DataRowView opebanco2 = (DataRowView)operacionesBancoBindingSource.Current;
                                    // MessageBox.Show(Convert.ToString(opebanco2["IdOpeBanco"]));
                                    queriesTableAdapter1.ActualizaSaldoAnterior(Convert.ToInt32(opebanco2["IdOpeBanco"]));

                                    if (!Convert.IsDBNull(gridView2.GetFocusedRowCellValue("IdCompra")))
                                    {
                                        pagosTableAdapter.Insert(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdFormaPago")), dateTimePicker1.Value, "BANCO", Convert.ToDecimal(gridView2.GetRowCellValue(i, "Importe")), "", Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCuenta")), dateTimePicker1.Value);
                                        queriesTableAdapter1.UpdateCompraPagada(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")));
                                    }

                                    if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCobro")))
                                    {
                                        queriesTableAdapter1.UpdateCobroBanco(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCobro")));
                                    }

                                    
                                }

                               
                        }
                            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
                            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
                            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
                            operacionesBancoBindingSource.MoveLast();
                    }

                }
            }
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
            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            vOperacionesBancoAgrupadasBindingSource.MoveLast();
        }

            
    }
}
