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
using ClosedXML.Excel;
using PetShop.Entities.Enums;

namespace PetShop
{
    public partial class RelatorioProdutos : Form
    {

        public RelatorioProdutos()
        {
            InitializeComponent();
        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {
            dateDataInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            dateDataFinal.Value = DateTime.Now;
            AtualizarLista();
            comboFiltrarEntradaSaida.SelectedItem = "Todos";
            DGVRelatorioProdutos.Columns["DataMovimentacao"].HeaderText = "Data de Movimentação";
            DGVRelatorioProdutos.Columns["TipoMovimentacao"].HeaderText = "Movimentação";
            DGVRelatorioProdutos.Columns["TipoOperacao"].HeaderText = "Tipo de Operação";
            DGVRelatorioProdutos.Columns["NomeProduto"].HeaderText = "Nome do Produto";
            DGVRelatorioProdutos.Columns["ValorProduto"].HeaderText = "Preço";
            DGVRelatorioProdutos.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVRelatorioProdutos.Columns["ValorProduto"].DefaultCellStyle.Format = "C2";
            DGVRelatorioProdutos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DataGridViewTools.MaximumFormSize(DGVRelatorioProdutos, this);
            DGVRelatorioProdutos.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVRelatorioProdutos_ColumnWidthChanged);
            DGVRelatorioProdutos.CurrentCell = null;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void DGVRelatorioProdutos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVRelatorioProdutos, this, DGVRelatorioProdutos_ColumnWidthChanged);
        }

        private void AtualizarLista()
        {
            DGVRelatorioProdutos.DataSource = Produto.RelatorioEntradaSaidaProdutos(dateDataInicial.Value.Date, dateDataFinal.Value);
            DGVRelatorioProdutos.ClearSelection();
            DGVRelatorioProdutos.Sort(DGVRelatorioProdutos.Columns["DataMovimentacao"], ListSortDirection.Descending);
            if (DGVRelatorioProdutos.Rows.Count > 0)
            {
                DGVRelatorioProdutos.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void RelatorioProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
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

        private void comboFiltrarEntradaSaida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltrarEntradaSaida.SelectedIndex == 0)
            {
                (DGVRelatorioProdutos.DataSource as DataTable).DefaultView.RowFilter = "TipoMovimentacao = 'Entrada'";
            }
            else if (comboFiltrarEntradaSaida.SelectedIndex == 1)
            {
                (DGVRelatorioProdutos.DataSource as DataTable).DefaultView.RowFilter = "TipoMovimentacao = 'Saída'";
            }
            else
            {
                (DGVRelatorioProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            DGVRelatorioProdutos.ClearSelection();
        }

        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            (DGVRelatorioProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeProduto LIKE '%" + txtPesquisarProduto.Text + "%'");
        }

        private void DGVRelatorioProdutos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in DGVRelatorioProdutos.Rows)
            {
                if ((string)row.Cells["TipoMovimentacao"].Value == "Entrada")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 234, 105);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(249, 115, 97);
                }
            }
        }

        private void DGVRelatorioProdutos_Sorted(object sender, EventArgs e)
        {
            DGVRelatorioProdutos.ClearSelection();
        }

        private void DGVRelatorioProdutos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (DGVRelatorioProdutos.Rows.Count > 0)
            {
                btnImprimirLista.Enabled = true;
            }
            else
            {
                btnImprimirLista.Enabled = false;
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
                        DataTable data = (DGVRelatorioProdutos.DataSource as DataTable).Copy();
                        data.Columns["DataMovimentacao"].ColumnName = "Data de Movimentação";
                        data.Columns["TipoMovimentacao"].ColumnName = "Movimentação";
                        data.Columns["TipoOperacao"].ColumnName = "Tipo de Operação";
                        data.Columns["NomeProduto"].ColumnName = "Nome do Produto";
                        data.Columns["ValorProduto"].ColumnName = "Preço";
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Relatório de Vendas");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 9, worksheets.LastRowUsed().RowNumber(), 9).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 2, worksheets.LastRowUsed().RowNumber(), 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm:ss";
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.CellsUsed().Style.Font.FontName = "Arial";
                        worksheets.CellsUsed().Style.Font.FontSize = 12;
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
