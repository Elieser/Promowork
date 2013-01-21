using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Promowork
{
    public partial class FacturasHorasMateriales : Form
    {
        public FacturasHorasMateriales()
        {
            InitializeComponent();
        }

        private void facturasCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (idCuentaComboBox.Text == "")
            {
               facturasCabDataGridView.CurrentRow.Cells["IdCuenta"].Value =  DBNull.Value;
            }

            try
            {
            this.Validate();
            this.facturasCabBindingSource.EndEdit();
            facturasCabTableAdapter.Update(promowork_dataDataSet.FacturasCab);
          //  toolStripButton1.Enabled = true;
           // toolStripButton12.Enabled = true;
            facturasCabDataGridView.Enabled = true;
            facturasCabDataGridView_CellEnter(null,null);
            }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);

              
           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
               }

           }
           // this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
            // this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

        }

        private void FacturasPresup_Load(object sender, EventArgs e)
        {
       
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Obras' table. You can move, or remove it, as needed.
            
          
            this.cuentasBancosTableAdapter.FillByCtaEmpresa(this.promowork_dataDataSet.CuentasBancos,VariablesGlobales.nIdEmpresaActual);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.PresupCab' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Clientes, VariablesGlobales.nIdEmpresaActual);
            clientesBindingSource.Sort = "DesCliente";
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasDet' table. You can move, or remove it, as needed.
           // this.facturasDetTableAdapter.Fill(this.promowork_dataDataSet.FacturasDet);
            // TODO: This line of code loads data into the 'promowork_dataDataSet.FacturasCab' table. You can move, or remove it, as needed.
            this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab,VariablesGlobales.nIdEmpresaActual);
            this.empresasActualTableAdapter.FillByEmpresa(this.promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);
            this.productosTableAdapter.Fill(promowork_dataDataSet.Productos, VariablesGlobales.nIdEmpresaActual);
            //this.obrasTableAdapter.FillByListaObras(this.promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            this.facturasCabBindingSource.MoveLast();
            toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
            toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fechaFacturaDateTimePicker.Value = DateTime.Now;
            fechaVctoFactDateTimePicker.Value = DateTime.Now;
            mostrarVctoCheckBox.Checked = true;
            DataRowView empresa = (DataRowView)empresasActualBindingSource.Current;
            numFacturaTextBox.Text = Convert.ToString(empresa["FactEmpresa"]);
            empresa["FactEmpresa"] = Convert.ToInt32(empresa["FactEmpresa"]) + 1;
            this.empresasActualBindingSource.EndEdit();
            empresasActualTableAdapter.Update(promowork_dataDataSet.EmpresasActual);

            DataRowView factura = (DataRowView)facturasCabBindingSource.Current;
            factura["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
            factura["IdUsuario"] = VariablesGlobales.nIdUsuarioActual;
            factura["Cobrada"] = false;
          //  factura["FacturaPresup"] = null;

          
          //  toolStripButton1.Enabled = false;
          //  toolStripButton12.Enabled = false;
            facturasCabDataGridView.Enabled = false;
            numFacturaTextBox.Focus();
            facturasCabDataGridView_CellEnter(null, null);
        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedValue = comboBox1.SelectedValue == null ? idClienteComboBox.SelectedValue : comboBox1.SelectedValue;
                this.obrasTableAdapter.FillByCliente(promowork_dataDataSet.Obras, Convert.ToInt32(idClienteComboBox.SelectedValue));
                
            }
            catch { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.facturasCabBindingSource.RemoveCurrent();
                facturasCabDataGridView.Enabled = true;
            }
            
        }

      
      private void facturasCabDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
         //  MessageBox.Show("cellenter");
           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
            this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
            this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
            toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
            toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
         
           try
           {
               textBox16.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox1.Text) * Convert.ToDecimal(descFacuraTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox16.Text = "0,00";
           }

           try
           {
               textBox20.Text = Convert.ToString(Math.Round((Convert.ToDecimal(importeTextBox1.Text) - Convert.ToDecimal(textBox16.Text)) * Convert.ToDecimal(descProntoTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox20.Text = "0,00";
           }

           try
           {
               textBox22.Text = Convert.ToString(Convert.ToDecimal(importeTextBox1.Text) - Convert.ToDecimal(textBox20.Text) - Convert.ToDecimal(textBox16.Text)); 
           }
           catch
           {
               textBox22.Text = "0,00";
           }

           try
           {
               textBox15.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox22.Text) * Convert.ToDecimal(iVAFacturaTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox15.Text = "0,00";
           }

           try
           {
               textBox23.Text = Convert.ToString(Convert.ToDecimal(textBox22.Text) + Convert.ToDecimal(textBox15.Text));
           }
           catch
           {
               textBox23.Text = "0,00";
           }

           try
           {
               textBox21.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox23.Text) * Convert.ToDecimal(retencionTextBox.Text) / 100, 2));
           }
           catch
           {
               textBox21.Text = "0,00";
           }

           try
           {
               textBox17.Text = Convert.ToString(Math.Round(Convert.ToDecimal(textBox23.Text)- Convert.ToDecimal(textBox21.Text), 2));
           }
           catch
           {
               textBox17.Text = "0,00";
           }
          
       }

      
       private void printToolStripButton_Click(object sender, EventArgs e)
       {
           DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

           int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


           RptFacturasHorasImpParte frm = new RptFacturasHorasImpParte();
           frm.LoadFiltro(Factura);
           frm.MdiParent = this.MdiParent;
           frm.Show();
       }


       private void importeTextBox1_TextChanged(object sender, EventArgs e)
       {
            try {importeTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDecimal(importeTextBox1.Text), 2));}
           catch { }
       }

       
       private void facturasDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Formato Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

      private void toolStripButton7_Click(object sender, EventArgs e)
       {
         try
           { 
               this.Validate();
            //   this.facturasDetHorasBindingSource.EndEdit();
            //   facturasDetHorasTableAdapter.Update(promowork_dataDataSet.FacturasDetHoras);

               this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual);
               this.facturasCabBindingSource.MoveLast();
               facturasCabDataGridView.Enabled = true;
               facturasCabDataGridView_CellEnter(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
               }

           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           openFileDialog1.ShowDialog();
           DataRowView facturaActual = (DataRowView)facturasCabBindingSource.Current;
           facturaActual["CopiaFactura"] = openFileDialog1.FileName;
           copiaFacturaTextBox.Text = openFileDialog1.FileName;
       }

       private void button4_Click(object sender, EventArgs e)
       {
           DataRowView FacturaActual = (DataRowView)facturasCabBindingSource.Current;
           try
           {
               System.Diagnostics.Process.Start(Convert.ToString(FacturaActual["CopiaFactura"]));
           }
           catch
           {
               MessageBox.Show("No se puedo abrir el fichero. Compruebe que exista en el camino indicado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           DataRowView FcaturaActual = (DataRowView)facturasCabBindingSource.Current;
           FcaturaActual["CopiaFactura"] = null;
           copiaFacturaTextBox.Text = "";
       }

       private void toolStripButton7_Click_1(object sender, EventArgs e)
       {
           try
           {
               this.Validate();
              vFacturaDetHorasBindingSource.EndEdit();
             // vFacturaDetHorasTableAdapter.  // facturasDetHorasTableAdapter.Update(promowork_dataDataSet.FacturasDetHoras);

              this.facturasCabTableAdapter.FillByFactHoras(this.promowork_dataDataSet.FacturasCab, VariablesGlobales.nIdEmpresaActual); this.facturasCabBindingSource.MoveLast();
               facturasCabDataGridView.Enabled = true;
               facturasCabDataGridView_CellEnter(null, null);
           }
           catch (DBConcurrencyException)
           {

               MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

               this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));

           }
           catch (SqlException ex)
           {
               if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
               {
                   this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
               }

           }
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
           gridView1.SetFocusedRowCellValue("IdFactCab", facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value);
           this.horasTrabajadasTableAdapter.FillByFacturado(this.promowork_dataDataSet.HorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
       }

      
      
       private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
           try
           {
               this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
           }
           catch { }
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
       }

      
       private void toolStripButton2_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
           
           //MessageBox.Show(Convert.ToString(gridView1.GetFocusedRowCellValue("IdFactDetHoras")));
           queriesTableAdapter1.BorraDetalleFactura(Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdFactDetHoras")));
           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
           this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
           this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
           this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
           facturasCabDataGridView_CellEnter(null, null);
       }
       }

       private void toolStripButton8_Click(object sender, EventArgs e)
       {
           gridView4.CloseEditor();
           gridView5.CloseEditor();
           decimal nCantAdmin = 0;
           decimal nSalarioVenta = 0;
           try
           {
               nCantAdmin=Convert.ToDecimal(gridView4.GetFocusedRowCellValue("CantAdmin"));
           }
           catch{}
           try
           {
               nSalarioVenta=Convert.ToDecimal(gridView4.GetFocusedRowCellValue("SalarioVenta"));
           }
           catch{}

           queriesTableAdapter1.ActualizaCantHorasAdmin(Convert.ToInt32(gridView4.GetFocusedRowCellValue("IdHoras")), nCantAdmin, nSalarioVenta);
           this.Validate();
           productosUtilizadosBindingSource1.EndEdit();
           productosUtilizadosTableAdapter.Update(promowork_dataDataSet1.ProductosUtilizados);
           queriesTableAdapter1.InsertaDetalleFactura(Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value), Convert.ToInt32(gridView4.GetFocusedRowCellValue("IdHoras")));

           this.vFacturaDetHorasTableAdapter.Fill(promowork_dataDataSet.vFacturaDetHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
           this.vHorasTrabajadasTableAdapter.Fill(promowork_dataDataSet.vHorasTrabajadas, Convert.ToInt32(idPresupComboBox.SelectedValue));
           this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet.ProductosUtilizados, Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdHoras")));
           toolStripButton8.Enabled = gridView4.RowCount == 0 ? false : true;
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
           this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
           facturasCabDataGridView_CellEnter(null, null);
       }

       private void toolStripButton7_Click_2(object sender, EventArgs e)
       {
           gridView1.SelectAll();

           gridView1.CloseEditor();
           gridView3.CloseEditor();
           ArrayList rows = new ArrayList();
           DataTable SelRows = new DataTable();
           SelRows.Columns.Add("IdHoras", System.Type.GetType("System.Int32"));
           SelRows.Columns.Add("CantAdmin", System.Type.GetType("System.Decimal"));
           SelRows.Columns.Add("SalarioVenta", System.Type.GetType("System.Decimal"));
           // Add the selected rows to the list.
           for (int i = 0; i < gridView1.SelectedRowsCount; i++)
           {
               if (gridView1.GetSelectedRows()[i] >= 0)
                   rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));

           }
           try
           {
               gridView1.BeginUpdate();
               for (int i = 0; i < rows.Count; i++)
               {
                   DataRow row = rows[i] as DataRow;
                   // Change the field value.
                   // row["ColorHoras"] = toolStripButton1.BackColor.ToArgb();
                   SelRows.Rows.Add(row["IdHoras"], row["CantAdmin"], row["SalarioVenta"]);
               }
           }
           finally
           {
               gridView1.EndUpdate();
           }

          queriesTableAdapter1.CantHorasAdmin(SelRows);
          this.Validate();
          productosUtilizadosBindingSource1.EndEdit();
          productosUtilizadosTableAdapter.Update(promowork_dataDataSet.ProductosUtilizados);
           gridView1.ClearSelection();

           this.importeFacturaHorasTableAdapter.FillFactura(promowork_dataDataSet.ImporteFacturaHoras, Convert.ToInt32(facturasCabDataGridView.CurrentRow.Cells["IdFactCab"].Value));
           facturasCabDataGridView_CellEnter(null, null);
           toolStripButton7.Enabled = false;
       }

       private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
           try
           {
               this.productosUtilizadosTableAdapter.FillbyHoras(promowork_dataDataSet1.ProductosUtilizados, Convert.ToInt32(gridView4.GetFocusedRowCellValue("IdHoras")));
           }
           catch { }
       }

       private void importeTextBox_TextChanged(object sender, EventArgs e)
       {
           importeTextBox1.Text = importeTextBox.Text;
           try
           {
               facturasCabDataGridView.CurrentRow.Cells["Importe"].Value = Convert.ToDecimal(importeTextBox.Text);
           }
           catch { }
       }

       private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
           toolStripButton7.Enabled = true;
       }

       private void gridView3_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
           toolStripButton7.Enabled = true;
       }

       private void gridView1_GotFocus(object sender, EventArgs e)
       {
           toolStripButton2.Enabled = gridView1.RowCount == 0 ? false : true;
       }

       private void toolStripButton1_Click_1(object sender, EventArgs e)
       {
           DataRowView FacturaAct = (DataRowView)facturasCabBindingSource.Current;

           int Factura = Convert.ToInt32(FacturaAct["IdFactCab"]);


           RptFacturasHorasImp frm = new RptFacturasHorasImp();
           frm.LoadFiltro(Factura);
           frm.MdiParent = this.MdiParent;
           frm.Show();
       }

      
    }
}
