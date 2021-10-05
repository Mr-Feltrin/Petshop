using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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
            DataGridViewTools.MaximumFormSize(DGVListaVendas, this, DGVListaVendas_ColumnWidthChanged);
        }

        private void DGVScrollbar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaVendas, this);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (DGVListaVendas.SelectedRows.Count > 0)
            {
                using (VisualizarVenda visualizarVenda = new VisualizarVenda((int)DGVListaVendas.SelectedRows[0].Cells[0].Value))
                {
                    visualizarVenda.ShowDialog();
                }
            }
        }

        private void RelatorioVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void DGVListaVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VisualizarVenda visualizarVenda = new VisualizarVenda((int)DGVListaVendas.SelectedRows[0].Cells[0].Value))
            {
                visualizarVenda.ShowDialog();
            }
        }

        private void btnImprimirLista_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Planilha do Excel (*xlsx)|*xlsx";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable data = (DGVListaVendas.DataSource as DataTable).Copy();
                        data.Columns["DataVenda"].ColumnName = "Data da Venda";
                        data.Columns["NomeCliente"].ColumnName = "Nome do Cliente";
                        data.Columns["NumeroItens"].ColumnName = "N° de Itens na Compra";
                        data.Columns["TipoCartao"].ColumnName = "Tipo de Cartão";
                        data.Columns["TotalVenda"].ColumnName = "Total da Venda";
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Relatório de Produtos");
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.CellsUsed().Style.Font.FontName = "Arial";
                        worksheets.CellsUsed().Style.Font.FontSize = 12;
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 2, worksheets.LastRowUsed().RowNumber(), 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm:ss";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 6, worksheets.LastRowUsed().RowNumber(), 6).DataType = XLDataType.Number;
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 6, worksheets.LastRowUsed().RowNumber(), 6).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 8, worksheets.LastRowUsed().RowNumber(), 8).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.ColumnsUsed().AdjustToContents();
                        worksheets.RowsUsed().AdjustToContents();
                        try
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            FormNotificacao notificacao = new FormNotificacao();
                            notificacao.ShowAlert("A lista foi exportada", TipoNotificacao.Confirmar);
                        }
                        catch (System.IO.IOException)
                        {
                            MessageBox.Show("Não foi possível salvar o arquivo pois ele está em uso, feche o arquivo aberto e tente novamente", "Não Foi possível salvar o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
