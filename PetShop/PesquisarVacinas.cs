using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PetShop
{
    public partial class PesquisarVacinas : Form
    {
        private VScrollBar listaVacinasVerticalScrollBar;
        public PesquisarVacinas()
        {
            InitializeComponent();
        }

        private void btnAdicionarVacina_Click(object sender, EventArgs e)
        {
            AdicionarEditarVacina adicionarVacina = new AdicionarEditarVacina(TipoOperacao.Adicionar);
            adicionarVacina.Show(this);
        }

        private void PesquisarVacinas_Load(object sender, EventArgs e)
        {
            listaVacinas.Font = new Font("Microsoft Sans Serif", 9.75F);
            AtualizarLista();
            listaVacinas.Columns["ConteudoML"].HeaderText = "Conteúdo (ML)";
            listaVacinas.Columns["DataValidade"].HeaderText = "Data de Validade";
            listaVacinas.Columns["DataModificacao"].HeaderText = "Data de Modificação";
            listaVacinas.Columns["ValorMercado"].HeaderText = "Valor de Mercado";
            listaVacinas.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            listaVacinas.Columns["DataModificacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            listaVacinas.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            listaVacinas.Columns["ValorMercado"].DefaultCellStyle.Format = "C2";
            listaVacinas.Columns["ValorMercado"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaVacinas.Columns["ValorProduto"].DefaultCellStyle.Format = "C2";
            listaVacinas.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaVacinas.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            listaVacinasVerticalScrollBar = listaVacinas.Controls.OfType<VScrollBar>().First();
            listaVacinasVerticalScrollBar.VisibleChanged += listaVacinasVerticalScrollBar_VisibleChanged;
            DataGridViewTools.MaximumFormSize(listaVacinas, this);
            listaVacinas.ColumnWidthChanged += new DataGridViewColumnEventHandler(listaVacinas_ColumnWidthChanged);
        }

        private void listaVacinasVerticalScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaVacinas, this);
        }

        public void AtualizarLista()
        {
            listaVacinas.DataSource = Vacina.ListarVacinas();
            foreach (DataGridViewRow row in listaVacinas.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells["Lote"].Value.ToString()))
                {
                    row.Cells["Lote"].Value = "N/D";
                }
            }
            listaVacinas.ClearSelection();
            listaVacinas.Sort(listaVacinas.Columns["Quantidade"], System.ComponentModel.ListSortDirection.Descending);
            listaVacinas.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void ColoracaoListaVacinas()
        {
            foreach (DataGridViewRow row in listaVacinas.Rows)
            {
                if (Convert.ToInt32(row.Cells["Quantidade"].Value) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 234, 105);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(249, 115, 97);
                }
            }
        }

        private void listaVacinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaVacinas.SelectedRows.Count != 0)
            {
                AdicionarEditarVacina editarVacina = new AdicionarEditarVacina(TipoOperacao.Editar, (int)listaVacinas.SelectedRows[0].Cells[0].Value);
                editarVacina.Show(this);
            }
        }

        private void listaVacinas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (listaVacinas.Rows.Count > 0)
            {
                btnExportarLista.Enabled = true;
            }
            else
            {
                btnExportarLista.Enabled = false;
            }
        }

        private void listaVacinas_SelectionChanged(object sender, EventArgs e)
        {
            if (listaVacinas.SelectedRows.Count > 0)
            {
                btnEditarVacina.Enabled = true;
                btnExcluirVacina.Enabled = true;
            }
            else
            {
                btnEditarVacina.Enabled = false;
                btnExcluirVacina.Enabled = false;
            }
        }

        private void listaVacinas_Sorted(object sender, EventArgs e)
        {
            listaVacinas.ClearSelection();
        }

        private void btnEditarVacina_Click(object sender, EventArgs e)
        {
            AdicionarEditarVacina editarVacina = new AdicionarEditarVacina(TipoOperacao.Editar, (int)listaVacinas.SelectedRows[0].Cells[0].Value);
            editarVacina.Show(this);
        }

        private void btnExcluirVacina_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover a vacina?", "Remover vacina", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Vacina.ExcluirVacina((int)listaVacinas.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
            }
        }

        private void txtPesquisarImunidade_TextChanged(object sender, EventArgs e)
        {
            (listaVacinas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Imunologia LIKE '%" + txtPesquisarImunidade.Text + "%'");
        }

        private void txtPesquisarFabricante_TextChanged(object sender, EventArgs e)
        {
            (listaVacinas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Fabricante LIKE '%" + txtPesquisarImunidade.Text + "%'");
        }

        private void btnExportarLista_Click(object sender, EventArgs e)
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
                        DataTable data = (listaVacinas.DataSource as DataTable).Clone();
                        foreach (DataGridViewRow row in listaVacinas.Rows)
                        {
                            data.ImportRow(((DataRowView)row.DataBoundItem).Row);
                        }
                        data.Columns["ConteudoML"].ColumnName = "Conteúdo (ML)";
                        data.Columns["DataValidade"].ColumnName = "Data de Validade";
                        data.Columns["DataModificacao"].ColumnName = "Data de Modificação";
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Produtos");
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.CellsUsed().Style.Font.FontName = "Arial";
                        worksheets.CellsUsed().Style.Font.FontSize = 12;
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 5, worksheets.LastRowUsed().RowNumber(), 5).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 8, worksheets.LastRowUsed().RowNumber(), 8).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 10, worksheets.LastRowUsed().RowNumber(), 10).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 11, worksheets.LastRowUsed().RowNumber(), 11).Style.NumberFormat.SetFormat("R$ #,##0.00");
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

        private void listaVacinas_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaVacinas, this, listaVacinas_ColumnWidthChanged);
        }

        private void PesquisarVacinas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void listaVacinas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ColoracaoListaVacinas();
        }
    }
}
