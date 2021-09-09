using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace PetShop
{
    public partial class PesquisarVacinacoes : Form
    {
        private VScrollBar ListaVacinacaoScrollBar;
        public PesquisarVacinacoes()
        {
            InitializeComponent();
        }

        private void ListaVacinacoes_Load(object sender, EventArgs e)
        {
            dateDataInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateDataFinal.Value = dateDataInicial.Value.AddMonths(1);
            AtualizarListaVacinacoes();
            listaVacinacao.Columns["DataVacina"].HeaderText = "Data da Vacinação";
            listaVacinacao.Columns["NomeAnimal"].HeaderText = "Nome do Animal";
            listaVacinacao.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            listaVacinacao.Columns["Especie"].HeaderText = "Espécie";
            listaVacinacao.Columns["Raca"].HeaderText = "Raça";
            listaVacinacao.Columns["DataVacina"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");
            listaVacinacao.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            ListaVacinacaoScrollBar = listaVacinacao.Controls.OfType<VScrollBar>().First();
            ListaVacinacaoScrollBar.VisibleChanged += new EventHandler(listaVacinacaoScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(listaVacinacao, this);
            listaVacinacao.ColumnWidthChanged += new DataGridViewColumnEventHandler(listaVacinacao_ColumnWidthChanged);
        }

        private void listaVacinacaoScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaVacinacao, this);
        }

        internal void AtualizarListaVacinacoes()
        {
            listaVacinacao.DataSource = Vacinacao.ListarVacinacoes(dataInicial: dateDataInicial.Value.Date, dataFinal: dateDataFinal.Value.Date);
            if (listaVacinacao.Rows.Count > 0)
            {
                listaVacinacao.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
            listaVacinacao.ClearSelection();
        }

        private void listaVacinacao_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaVacinacao, this);
        }

        private void listaVacinacao_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (listaVacinacao.Rows.Count > 0)
            {
                btnImprimirLista.Enabled = true;
            }
            else
            {
                btnImprimirLista.Enabled = false;
            }
        }

        private void listaVacinacao_SelectionChanged(object sender, EventArgs e)
        {
            if (listaVacinacao.SelectedRows.Count > 0)
            {
                btnExcluirVacinacao.Enabled = true;
            }
            else
            {
                btnExcluirVacinacao.Enabled = false;
            }
        }

        private void listaVacinacao_Sorted(object sender, EventArgs e)
        {
            listaVacinacao.ClearSelection();
        }

        private void btnExcluirVacinacao_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Você tem certeza que quer remover este registro de vacinação?", "Remover registro de Vacinação", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Vacinacao.ExcluirVacinacao((int)listaVacinacao.SelectedRows[0].Cells[0].Value);
                AtualizarListaVacinacoes();
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
                        DataTable data = (listaVacinacao.DataSource as DataTable).Copy();
                        data.Columns["DataVacina"].ColumnName = "Data da Vacinação";
                        data.Columns["NomeAnimal"].ColumnName = "Nome do Animal";
                        data.Columns["NomeCliente"].ColumnName = "Nome do Cliente";
                        data.Columns["Especie"].ColumnName = "Espécie";
                        data.Columns["Raca"].ColumnName = "Raça";
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Vacinação");
                        worksheets.ColumnsUsed().AdjustToContents();
                        worksheets.RowsUsed().AdjustToContents();
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 3, worksheets.LastRowUsed().RowNumber(), 3).Style.DateFormat.Format = "dd/MM/yyyy";
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

        private void btnAdicionarVacinacao_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarVacinacao adicionarVacinacao = new AdicionarEditarVacinacao())
            {
                adicionarVacinacao.ShowDialog();
            }
        }

        private void dateDataInicial_ValueChanged(object sender, EventArgs e)
        {
            AtualizarListaVacinacoes();
        }

        private void dateDataFinal_ValueChanged(object sender, EventArgs e)
        {
            AtualizarListaVacinacoes();
        }

        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {
            (listaVacinacao.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeAnimal LIKE '%" + txtPesquisarAnimal.Text + "%'");

        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            (listaVacinacao.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeCliente LIKE '%" + txtPesquisarCliente.Text + "%'");

        }
    }
}
