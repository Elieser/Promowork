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
    public partial class RptParametrosOperacionesBanco : Form
    {
        public RptParametrosOperacionesBanco()
        {
            InitializeComponent();
        }

        private void RptParametrosOperacionesBanco_Load(object sender, EventArgs e)
        {
            this.marcaTipoOpeBancoTableAdapter.FillByMarca(promowork_dataDataSet.MarcaTipoOpeBanco, VariablesGlobales.nIdEmpresaActual);
            this.marcaConceptosBancoTableAdapter.FillByMarca(promowork_dataDataSet.MarcaConceptosBanco, VariablesGlobales.nIdEmpresaActual);
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "MarcaTipoOpe")
            {
                if (marcaConceptosBancoBindingSource.Filter == null || marcaConceptosBancoBindingSource.Filter ==string.Empty )
                {
                    
                    marcaConceptosBancoBindingSource.Filter = (Boolean)e.Value == false ? "TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'" : "";
                }
                else
                {
                    marcaConceptosBancoBindingSource.Filter = marcaConceptosBancoBindingSource.Filter.Replace(" and TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'", "");
                    marcaConceptosBancoBindingSource.Filter = marcaConceptosBancoBindingSource.Filter.Replace("TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'", "");
                    
                    marcaConceptosBancoBindingSource.Filter += (Boolean)e.Value == false ? " and TipoOpe<>'" + gridView1.GetFocusedRowCellValue("TipoOpe") + "'":"";
                }
                MessageBox.Show(marcaConceptosBancoBindingSource.Filter);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

      
    }
}
