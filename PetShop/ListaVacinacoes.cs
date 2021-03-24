using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;

namespace PetShop
{
    public partial class ListaVacinacoes : Form
    {
        public ListaVacinacoes()
        {
            InitializeComponent();
        }

        private void ListaVacinacoes_Load(object sender, EventArgs e)
        {
            dateDataInicial.Value = new DateTime(DateTime.Now.Year, 01, 01);
            ListarVacinacoes();
            listaVacinacao.Columns["DataVacina"].HeaderText = "Data da Vacinação";
            listaVacinacao.Columns["NomeAnimal"].HeaderText = "Nome do Animal";
            listaVacinacao.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            listaVacinacao.Columns["Especie"].HeaderText = "Espécie";
            listaVacinacao.Columns["Raca"].HeaderText = "Raça";
            listaVacinacao.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        private void ListarVacinacoes()
        {
            listaVacinacao.DataSource = Vacinacao.ListarVacinacoes();
            if (listaVacinacao.Rows.Count > 0)
            {
                listaVacinacao.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
            listaVacinacao.ClearSelection();
        }

        private void listaVacinacao_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            MaximumSize = new System.Drawing.Size(listaVacinacao.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 3 + (Size.Width - listaVacinacao.Size.Width), 100000);
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
                        data.Columns["DataValidade"].ColumnName = "Data de Validade";
                        data.Columns["DataCadastro"].ColumnName = "Data de Cadastro";
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
    }
}
