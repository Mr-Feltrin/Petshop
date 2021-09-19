using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Entities;
using PetShop.ToolBox;
using System.Globalization;

namespace PetShop
{
    public partial class RelatorioVendas : Form
    {
        private VScrollBar DGVScrollbar;

        public RelatorioVendas()
        {
            InitializeComponent();
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            dateDataInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            dateDataFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            AtualizarLista();
            DGVListaVendas.Columns["DataVenda"].HeaderText = "Data da Venda";
            DGVListaVendas.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            DGVListaVendas.Columns["NumeroItens"].HeaderText = "N° de Itens na Compra";
            DGVListaVendas.Columns["TipoCartao"].HeaderText = "Tipo de Cartão";
            DGVListaVendas.Columns["TotalVenda"].HeaderText = "Total da Venda";
            DGVListaVendas.Columns["Desconto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVListaVendas.Columns["Desconto"].DefaultCellStyle.Format = string.Format("C2", NumberStyles.Currency);
            DGVListaVendas.Columns["TotalVenda"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVListaVendas.Columns["TotalVenda"].DefaultCellStyle.Format = string.Format("C2", NumberStyles.Currency);
            DGVListaVendas.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollbar = DGVListaVendas.Controls.OfType<VScrollBar>().First();
            DGVScrollbar.VisibleChanged += new EventHandler(DGVScrollbar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(DGVListaVendas, this);
            DGVListaVendas.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVListaVendas_ColumnWidthChanged);
        }

        private void DGVListaVendas_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaVendas, this);
        }

        private void DGVScrollbar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaVendas, this);
        }

        private void AtualizarLista()
        {
            DGVListaVendas.DataSource = Venda.ListarVendas(dateDataInicial.Value.Date, dateDataFinal.Value.Date);
            foreach (DataGridViewRow row in DGVListaVendas.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells["NomeCliente"].Value.ToString()))
                {
                    row.Cells["NomeCliente"].Value = "N.D";
                }
                if (string.IsNullOrWhiteSpace(row.Cells["TipoCartao"].Value.ToString()))
                {
                    row.Cells["TipoCartao"].Value = "N.D";
                }
            }
            DGVListaVendas.ClearSelection();
            DGVListaVendas.Sort(DGVListaVendas.Columns["DataVenda"], ListSortDirection.Descending);
            if (DGVListaVendas.Rows.Count > 0)
            {
                DGVListaVendas.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void dateDataInicial_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void dateDataFinal_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            (DGVListaVendas.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeCliente LIKE '%" + txtPesquisarCliente.Text + "%'");
        }

        private void DGVListaVendas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (DGVListaVendas.Rows.Count > 0)
            {
                btnImprimirLista.Enabled = true;
            }
            else
            {
                btnImprimirLista.Enabled = false;
            }
        }

        private void DGVListaVendas_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVListaVendas.SelectedRows.Count > 0)
            {
                btnVisualizar.Enabled = true;
            }
            else
            {
                btnVisualizar.Enabled = false;
            }
        }

        private void DGVListaVendas_Sorted(object sender, EventArgs e)
        {
            DGVListaVendas.ClearSelection();
        }
    }
}
