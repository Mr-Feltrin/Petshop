using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ClosedXML.Excel;
using PetShop.ToolBox;

namespace PetShop
{
    public partial class PesquisaProdutos : Form
    {
        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            comboBoxFiltrarLista.SelectedIndex = 3;
            DataGridListaProdutos.Columns["CodigoBarras"].HeaderText = "Código de Barras";
            DataGridListaProdutos.Columns["TipoUnidade"].HeaderText = "Tipo de Unidade";
            DataGridListaProdutos.Columns["Referencia"].HeaderText = "Referência";
            DataGridListaProdutos.Columns["Localizacao"].HeaderText = "Localização";
            DataGridListaProdutos.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            DataGridListaProdutos.Columns["EstoqueMinimo"].HeaderText = "Estoque Mínimo";
            DataGridListaProdutos.Columns["EstoqueAtual"].HeaderText = "Estoque Atual";
            DataGridListaProdutos.Columns["DataValidade"].HeaderText = "Data de Validade";
            DataGridListaProdutos.Columns["ValorCusto"].HeaderText = "Valor de Custo";
            DataGridListaProdutos.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            DataGridListaProdutos.Columns["observacoes"].HeaderText = "Observações";
            DataGridListaProdutos.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridListaProdutos.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridListaProdutos.Columns["ValorCusto"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            DataGridListaProdutos.Columns["ValorCusto"].DefaultCellStyle.Format = string.Format("C2");
            DataGridListaProdutos.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            DataGridListaProdutos.Columns["ValorProduto"].DefaultCellStyle.Format = string.Format("C2");
            DataGridListaProdutos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        public void AtualizarLista()
        {
            DataGridListaProdutos.DataSource = Produto.ListarProdutos();
            foreach (DataGridViewRow row in DataGridListaProdutos.Rows)
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
            DataGridListaProdutos.ClearSelection();
            DataGridListaProdutos.Sort(DataGridListaProdutos.Columns["EstoqueAtual"], System.ComponentModel.ListSortDirection.Descending);
            foreach (DataGridViewColumn column in DataGridListaProdutos.Columns)
            {
                column.Width = column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos adicionarProdutos = new AdicionarEditarProdutos(TipoOperacao.Adicionar);
            adicionarProdutos.ShowDialog();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos editarAgendamento = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
            editarAgendamento.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover este produto?", "Remover produto", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Produto.RemoverProduto((int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
            }
        }

        private void DataGridListaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridListaProdutos.SelectedRows.Count != 0)
            {
                AdicionarEditarProdutos editarProdutos = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
                editarProdutos.ShowDialog();
            }
        }

        private void DataGridListaProdutos_Sorted(object sender, EventArgs e)
        {
            DataGridListaProdutos.ClearSelection();
        }

        private void txtPesquisarNomeProduto_TextChanged(object sender, EventArgs e)
        {
            (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarNomeProduto.Text + "%'");
        }

        private void txtPesquisarMarcaProduto_TextChanged(object sender, EventArgs e)
        {
            (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Marca LIKE '%" + txtPesquisarMarcaProduto.Text + "%'");
        }

        private void DataGridListaProdutos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ColoracaoListaProdutos();
        }

        internal void ColoracaoListaProdutos()
        {
            foreach (DataGridViewRow row in DataGridListaProdutos.Rows)
            {
                if (float.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > float.Parse(row.Cells["EstoqueMinimo"].Value.ToString()) && float.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 234, 105);
                }
                else if (float.Parse(row.Cells["EstoqueAtual"].Value.ToString()) > 0 && float.Parse(row.Cells["EstoqueAtual"].Value.ToString()) <= float.Parse(row.Cells["EstoqueMinimo"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (float.Parse(row.Cells["EstoqueAtual"].Value.ToString()) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(249, 115, 97);
                }
            }
        }

        private void comboBoxFiltrarLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual > 0";
                DataGridListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 1)
            {
                (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual > 0 AND EstoqueAtual < EstoqueMinimo";
                DataGridListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 2)
            {
                (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = "EstoqueAtual <= 0";
                DataGridListaProdutos.ClearSelection();
            }
            else if ((sender as ComboBox).SelectedIndex == 3)
            {
                if ((DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter != null)
                {
                    (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    DataGridListaProdutos.ClearSelection();
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
                        DataTable data = (DataGridListaProdutos.DataSource as DataTable).Copy();
                        data.Columns["CodigoBarras"].ColumnName = "Codigo de Barras";
                        data.Columns["TipoUnidade"].ColumnName = "Tipo de Unidade";
                        data.Columns["Referencia"].ColumnName = "Referência";
                        data.Columns["Localizacao"].ColumnName = "Localização";
                        data.Columns["DataCadastro"].ColumnName = "Data de Cadastro";
                        data.Columns["EstoqueMinimo"].ColumnName = "Estoque Mínimo";
                        data.Columns["EstoqueAtual"].ColumnName = "Estoque Atual";
                        data.Columns["DataValidade"].ColumnName = "Data de Validade";
                        data.Columns["ValorCusto"].ColumnName = "Valor de Custo";
                        data.Columns["ValorProduto"].ColumnName = "Valor do Produto";
                        data.Columns["Observacoes"].ColumnName = "Observações";
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
                        worksheets.ColumnsUsed().AdjustToContents();
                        worksheets.RowsUsed().AdjustToContents();
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;                    
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 8, worksheets.LastRowUsed().RowNumber(), 8).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 13, worksheets.LastRowUsed().RowNumber(), 13).Style.DateFormat.Format = "dd/MM/yyyy";
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
            if (DataGridListaProdutos.Rows.Count > 0)
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
            if (DataGridListaProdutos.SelectedRows.Count > 0)
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
            PesquisarCodigoBarras pesquisarCodigoBarras = new PesquisarCodigoBarras();
            pesquisarCodigoBarras.ShowDialog();
        }

        private void PesquisaProdutos_Resize(object sender, EventArgs e)
        {
            MaximumSize = new Size(DataGridListaProdutos.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 52, 100000);
        }

        private void DataGridListaProdutos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (DataGridListaProdutos.Columns.GetColumnsWidth(DataGridViewElementStates.None) < DataGridListaProdutos.Size.Width)
            {
                Size = new Size(DataGridListaProdutos.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 52, Size.Height);
            }
        }
    }
}
