using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;

namespace PetShop
{
    public partial class PesquisarProdutos : Form
    {
        private VScrollBar DGVScrollBar;

        public PesquisarProdutos()
        {
            InitializeComponent();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            comboBoxFiltrarLista.SelectedIndex = 3;
            DGVListaProdutos.Columns["CodigoBarras"].HeaderText = "Código de Barras";
            DGVListaProdutos.Columns["TipoUnidade"].HeaderText = "Tipo de Unidade";
            DGVListaProdutos.Columns["Referencia"].HeaderText = "Referência";
            DGVListaProdutos.Columns["Localizacao"].HeaderText = "Localização";
            DGVListaProdutos.Columns["DataAtualizacao"].HeaderText = "Data de Atualização";
            DGVListaProdutos.Columns["EstoqueMinimo"].HeaderText = "Estoque Mínimo";
            DGVListaProdutos.Columns["EstoqueAtual"].HeaderText = "Estoque Atual";
            DGVListaProdutos.Columns["DataValidade"].HeaderText = "Data de Validade";
            DGVListaProdutos.Columns["ValorCusto"].HeaderText = "Valor de Custo";
            DGVListaProdutos.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            DGVListaProdutos.Columns["Observacoes"].HeaderText = "Observações";
            DGVListaProdutos.Columns["DataAtualizacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVListaProdutos.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVListaProdutos.Columns["ValorCusto"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            DGVListaProdutos.Columns["ValorCusto"].DefaultCellStyle.Format = string.Format("C2");
            DGVListaProdutos.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            DGVListaProdutos.Columns["ValorProduto"].DefaultCellStyle.Format = string.Format("C2");
            DGVListaProdutos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollBar = DGVListaProdutos.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(DGVListaProdutos, this);
            DGVListaProdutos.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVListaProdutos_ColumnWidthChanged);
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaProdutos, this);
        }

        internal void AtualizarLista()
        {
            DGVListaProdutos.DataSource = Produto.ListarProdutos();
            foreach (DataGridViewRow row in DGVListaProdutos.Rows)
            {
                if (string.IsNullOrEmpty((string)row.Cells["CodigoBarras"].Value))
                {
                    row.Cells["CodigoBarras"].Value = "Sem Código";
                }
                if (string.IsNullOrEmpty((string)row.Cells["Referencia"].Value))
                {
                    row.Cells["Referencia"].Value = "Não Definido";
                }
                if (string.IsNullOrEmpty((string)row.Cells["Localizacao"].Value))
                {
                    row.Cells["Localizacao"].Value = "Não Definido";
                }
                if (string.IsNullOrEmpty((string)row.Cells["Marca"].Value))
                {
                    row.Cells["Marca"].Value = "Não Definido";
                }
                if (string.IsNullOrEmpty((string)row.Cells["Observacoes"].Value))
                {
                    row.Cells["Observacoes"].Value = "Não Definido";
                }
            }
            DGVListaProdutos.ClearSelection();
            DGVListaProdutos.Sort(DGVListaProdutos.Columns["EstoqueAtual"], System.ComponentModel.ListSortDirection.Descending);
            if (DGVListaProdutos.Rows.Count > 0)
            {
                DGVListaProdutos.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarProdutos adicionarProdutos = new AdicionarEditarProdutos(TipoOperacao.Adicionar))
            {
                adicionarProdutos.ShowDialog();
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarProdutos editarAgendamento = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DGVListaProdutos.SelectedRows[0].Cells[0].Value))
            {
                editarAgendamento.ShowDialog();
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover este produto?", "Remover produto", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Produto.RemoverProduto((int)DGVListaProdutos.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
            }
        }

        private void DataGridListaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListaProdutos.SelectedRows.Count != 0)
            {
                using (AdicionarEditarProdutos editarProdutos = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DGVListaProdutos.SelectedRows[0].Cells[0].Value))
                {
                    editarProdutos.ShowDialog();
                }
            }
        }

        private void DataGridListaProdutos_Sorted(object sender, EventArgs e)
        {
            DGVListaProdutos.ClearSelection();
        }

        private void txtPesquisarNomeProduto_TextChanged(object sender, EventArgs e)
        {
            (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarNomeProduto.Text + "%'");
        }

        private void txtPesquisarMarcaProduto_TextChanged(object sender, EventArgs e)
        {
            (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Marca LIKE '%" + txtPesquisarMarcaProduto.Text + "%'");
        }

        private void DataGridListaProdutos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ColoracaoListaProdutos();
        }

        private void ColoracaoListaProdutos()
        {
            foreach (DataGridViewRow row in DGVListaProdutos.Rows)
            {
                if (int.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > int.Parse(row.Cells["EstoqueMinimo"].Value.ToString()) && int.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 234, 105);
                }
                else if (int.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > 0 && int.Parse(row.Cells["EstoqueAtual"].Value.ToString()) <= int.Parse(row.Cells["EstoqueMinimo"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (int.Parse(row.Cells["EstoqueAtual"].Value.ToString()) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(249, 115, 97);
                }
            }
        }

        private void comboBoxFiltrarLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual > 0";
                DGVListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 1)
            {
                (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual > 0 AND EstoqueAtual < EstoqueMinimo";
                DGVListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 2)
            {
                (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual <= 0";
                DGVListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 3)
            {
                if ((DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter != null)
                {
                    (DGVListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    DGVListaProdutos.ClearSelection();
                }
            }
        }

        private void btnImprimirLista_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Planilha do Excel (*xlsx)|*xlsx";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;
                dialog.AddExtension = true;
                dialog.DefaultExt = "xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable data = (DGVListaProdutos.DataSource as DataTable).Copy();
                        data.Columns["CodigoBarras"].ColumnName = "Codigo de Barras";
                        data.Columns["TipoUnidade"].ColumnName = "Tipo de Unidade";
                        data.Columns["Referencia"].ColumnName = "Referência";
                        data.Columns["Localizacao"].ColumnName = "Localização";
                        data.Columns["EstoqueMinimo"].ColumnName = "Estoque Mínimo";
                        data.Columns["EstoqueAtual"].ColumnName = "Estoque Atual";
                        data.Columns["DataValidade"].ColumnName = "Data de Validade";
                        data.Columns["ValorCusto"].ColumnName = "Valor de Custo";
                        data.Columns["ValorProduto"].ColumnName = "Valor do Produto";
                        data.Columns["Observacoes"].ColumnName = "Observações";
                        data.Columns["DataAtualizacao"].ColumnName = "Data de Atualização";
                        if (comboBoxFiltrarLista.SelectedIndex == 0)
                        {
                            data = data.Select("EstoqueAtual > 0").CopyToDataTable();
                        }
                        else if (comboBoxFiltrarLista.SelectedIndex == 1)
                        {
                            data = data.Select("EstoqueAtual > 0 AND EstoqueAtual < EstoqueMinimo").CopyToDataTable();
                        }
                        else if (comboBoxFiltrarLista.SelectedIndex == 2)
                        {
                            data = data.Select("EstoqueAtual <= 0").CopyToDataTable();
                        }
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Produtos");
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.CellsUsed().Style.Font.FontName = "Arial";
                        worksheets.CellsUsed().Style.Font.FontSize = 12;
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 12, worksheets.LastRowUsed().RowNumber(), 12).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 16, worksheets.LastRowUsed().RowNumber(), 16).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 13, worksheets.LastRowUsed().RowNumber(), 13).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 14, worksheets.LastRowUsed().RowNumber(), 14).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.ColumnsUsed().AdjustToContents();
                        worksheets.RowsUsed().AdjustToContents();
                        try
                        {
                            workbook.SaveAs(dialog.FileName);
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

        private void DataGridListaProdutos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (DGVListaProdutos.Rows.Count > 0)
            {
                btnImprimirLista.Enabled = true;
            }
            else
            {
                btnImprimirLista.Enabled = false;
            }
        }

        private void DataGridListaProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVListaProdutos.SelectedRows.Count > 0)
            {
                btnEditarProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;
            }
            else
            {
                btnEditarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
            }
        }

        private void btnCodigoBarras_Click(object sender, EventArgs e)
        {
            using (PesquisarCodigoBarras pesquisarCodigoBarras = new PesquisarCodigoBarras())
            {
                pesquisarCodigoBarras.ShowDialog(this);
            }
        }

        private void DGVListaProdutos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaProdutos, this, DGVListaProdutos_ColumnWidthChanged);
        }

        private void PesquisaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void DGVListaProdutos_Enter(object sender, EventArgs e)
        {
            DGVListaProdutos.CurrentCell = null;
            DGVListaProdutos.FirstDisplayedCell = null;
        }
    }
}
