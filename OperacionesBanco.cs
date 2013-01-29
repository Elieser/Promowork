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
            // TODO: This line of code loads data into the 'promowork_dataDataSet.ConceptosBancos' table. You can move, or remove it, as needed.
            this.conceptosBancosTableAdapter.Fill(this.promowork_dataDataSet.ConceptosBancos);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FormasPago' table. You can move, or remove it, as needed.
            this.formasPagoTableAdapter.Fill(this.promowork_dataDataSet.FormasPago);

            this.WindowState = FormWindowState.Maximized;
            dateTimePicker2.Value = DateTime.Today.AddMonths(-1);

            // TODO: This line of code loads data into the 'promowork_dataDataSet.Bancos' table. You can move, or remove it, as needed.
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(promowork_dataDataSet.CuentasBancos, VariablesGlobales.nIdEmpresaActual);
            Actualiza();

            

        }

        private void Actualiza()
        {
            this.operacionesBancoTableAdapter.FillEmpCuenta(promowork_dataDataSet.OperacionesBanco, VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vOperacionesBancoAgrupadasTableAdapter.FillbyCuenta(promowork_dataDataSet.vOperacionesBancoAgrupadas, Convert.ToInt32(bancoCuentaComboBox.SelectedValue), dateTimePicker2.Value);
            this.vPrevisionesTableAdapter.FillByCuenta(promowork_dataDataSet.vPrevisiones, Convert.ToInt32(bancoCuentaComboBox.SelectedValue));
            DataRowView opebanco = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
            saldoAnteriorTextBox.Text = vOperacionesBancoAgrupadasBindingSource.Count != 0 ? (-(decimal)opebanco["SaldoAnterior"]).ToString() : "0,00";
            vOperacionesBancoAgrupadasBindingSource.MoveLast();
            DataRowView opebanco1 = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
            txtsaldofinal.Text = vOperacionesBancoAgrupadasBindingSource.Count != 0 ? (-(decimal)opebanco1["SaldoAnterior"] + (decimal)opebanco1["Importe"]).ToString() : "0,00";
            decimal saldoPrevisto = 0;
            
            if (vOperacionesBancoAgrupadasBindingSource.Count > 0)
            {
                saldoPrevisto = (decimal)opebanco1["Saldo"];
            }
            

            if (vPrevisionesBindingSource.Count > 0)
            {
                for (int i = 0; i < vPrevisionesBindingSource.Count; i++)
                {
                    saldoPrevisto += (decimal)promowork_dataDataSet.Tables["vPrevisiones"].Rows[i]["Importe"];
                    //    MessageBox.Show(saldoPrevisto.ToString());
                    promowork_dataDataSet.Tables["vPrevisiones"].Rows[i]["Saldo"]= saldoPrevisto;
                }
            }
        }
    
        private void bancoCuentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void OperacionesBanco_Resize(object sender, EventArgs e)
        {
            operacionesBancoGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Width = this.Width - 15;
            vPrevisionesGridControl.Height = this.Height - operacionesBancoGridControl.Height - 200;
            saldoAnteriorTextBox.Location = new Point(this.Width - 120,6);
            txtsaldofinal.Location = new Point(this.Width - 120, 250);
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
                                    factura = factura + Convert.ToString(gridView2.GetRowCellValue(i, "Factura")) + "  ";
                                }
                            }
                            
                            
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                               // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                                if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                                {
                                    if (Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdOpeBanco")))
                                      {
                                          
                                    operacionesBancoBindingSource.AddNew();
                                    DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
                                    opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
                                    opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
                                    opebanco["fecha"] = dateTimePicker1.Value;
                                    opebanco["DesOperacion"] = Convert.ToString(gridView2.GetRowCellValue(i, "DesProveedor")) + " Fra: " + factura;
                                    opebanco["IdCuenta"] = gridView2.GetRowCellValue(i, "IdCuenta");
                                    opebanco["TipoOpe"] = gridView2.GetRowCellValue(i, "Tipo");
                                    opebanco["IdCompra"] = gridView2.GetRowCellValue(i, "IdCompra");
                                    opebanco["IdCobro"] = gridView2.GetRowCellValue(i, "IdCobro");
                                    opebanco["IdFormaPago"] = Convert.ToInt32(comboBox1.SelectedValue);
                                    opebanco["Importe"] =-(decimal) gridView2.GetRowCellValue(i, "Importe");
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
                                       // pagosTableAdapter.Insert(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")), VariablesGlobales.nIdUsuarioActual, Convert.ToInt32(gridView2.GetRowCellValue(i, "IdFormaPago")), dateTimePicker1.Value, "BANCO", Convert.ToDecimal(gridView2.GetRowCellValue(i, "Importe")), "", Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCuenta")), dateTimePicker1.Value);
                                        queriesTableAdapter1.UpdateCompraPagada(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCompra")));
                                    }

                                    if (!Convert.IsDBNull(gridView2.GetRowCellValue(i, "IdCobro")))
                                    {
                                        queriesTableAdapter1.UpdateCobroBanco(Convert.ToInt32(gridView2.GetRowCellValue(i, "IdCobro")));
                                    }

                                    
                                }

                               
                        }
                            Actualiza();
                            txtimportesel.Text = string.Empty;
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
            Actualiza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.ActualizaSaldoAnteriorFecha(dateTimePicker2.Value,(int)bancoCuentaComboBox.SelectedValue);
            Actualiza();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView opebanco = (DataRowView)vOperacionesBancoAgrupadasBindingSource.Current;
                queriesTableAdapter1.EliminaOpeBanco((DateTime)opebanco["FechaOpe"], (int)bancoCuentaComboBox.SelectedValue);
                Actualiza();
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
           
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Value.ToString());

            gridView2.SetFocusedRowCellValue("marca", e.Value);
            decimal TotalSel = 0;

            if (e.Column.Name == "marca")
            {
              //  gridView2.CloseEditor();
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    // MessageBox.Show(Convert.ToString(gridView2.GetRowCellValue(i, "marca")));
                    if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "marca")) == true)
                    {
                        TotalSel += (decimal)gridView2.GetRowCellValue(i, "Importe");
                    }
                }
                txtimportesel.Text = TotalSel.ToString();
            }
        }

        private void saldoAnteriorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(this.saldoAnteriorTextBox.Text) < 0)
            {
                this.saldoAnteriorTextBox.ForeColor = Color.Red;
            }
            else
            {
                this.saldoAnteriorTextBox.ForeColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacionesBancoBindingSource.AddNew();
            DataRowView opebanco = (DataRowView)operacionesBancoBindingSource.Current;
            opebanco["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            opebanco["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            opebanco["fecha"] = fechaDateTimePicker.Value;
            opebanco["DesOperacion"] = cbxconcepto.Text;
            opebanco["IdCuenta"] = bancoCuentaComboBox.SelectedValue;
            opebanco["TipoOpe"] = "Otras Operaciones";
            opebanco["IdCompra"] = 1;// gridView2.GetRowCellValue(i, "IdCompra");
            opebanco["IdCobro"] = 1; // gridView2.GetRowCellValue(i, "IdCobro");
            opebanco["IdFormaPago"] = Convert.ToInt32(comboBox1.SelectedValue);
            opebanco["Importe"] = 1; // -(decimal)gridView2.GetRowCellValue(i, "Importe");
            opebanco["EnCuenta"] = true;
            opebanco["FechaOpe"] = DateTime.Now;
        }

       
    }
}
