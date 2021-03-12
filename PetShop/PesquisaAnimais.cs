using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using PetShop.ToolBox;

namespace PetShop
{
    public partial class PesquisaAnimais : Form
    {

        public PesquisaAnimais()
        {
            InitializeComponent();
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarAnimais adicionarEditarAnimais = new AdicionarEditarAnimais(TipoOperacao.Adicionar, this);
            adicionarEditarAnimais.ShowDialog();
        }

        private void PesquisaAnimais_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            listaAnimais.Columns["Especie"].HeaderText = "Espécie";
            listaAnimais.Columns["Raca"].HeaderText = "Raça";
            listaAnimais.Columns["Identificacao"].HeaderText = "Identificação";
            listaAnimais.Columns["Observacao_rotina"].HeaderText = "Observação de Rotina";
            listaAnimais.Columns["Data_registro"].HeaderText = "Data de Registro";
            listaAnimais.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            listaAnimais.Columns["Situacao"].HeaderText = "Situação";
            listaAnimais.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            listaAnimais.Columns["Peso"].DefaultCellStyle.Format = "F2";
            listaAnimais.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        public void AtualizarLista()
        {
            listaAnimais.DataSource = Animal.ListarAnimais();
            listaAnimais.Sort(listaAnimais.Columns[0], ListSortDirection.Descending);
            foreach (DataGridViewRow row in listaAnimais.Rows)
            {
                if (string.IsNullOrWhiteSpace((string)row.Cells["Identificacao"].Value))
                {
                    row.Cells["Identificacao"].Value = "Nenhuma";
                }
                if (string.IsNullOrWhiteSpace((string)row.Cells["Fobias"].Value))
                {
                    row.Cells["Fobias"].Value = "Nenhuma";
                }
                if (string.IsNullOrWhiteSpace((string)row.Cells["Observacao_rotina"].Value))
                {
                    row.Cells["Observacao_rotina"].Value = "Nenhuma";
                }
            }
            listaAnimais.ClearSelection();
            listaAnimais.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listaAnimais.SelectedRows.Count != 0)
            {
                AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value);
                editarAnimais.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaAnimais.SelectedRows.Count != 0)
            {
                DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este animal?", "Remover animal", MessageBoxButtons.YesNo);
                if (confirmar_delete == DialogResult.Yes)
                {
                    Animal.ExcluirAnimal((int)listaAnimais.SelectedRows[0].Cells[0].Value);
                    AtualizarLista();
                }
            }
        }

        private void pesquisaNomeDono_TextChanged(object sender, EventArgs e)
        {
            (listaAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Dono LIKE '%" + pesquisaNomeDono.Text + "%'");
        }

        private void pesquisaNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            (listaAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + pesquisaNomeAnimal.Text + "%'");
        }

        private void listaAnimais_Sorted(object sender, EventArgs e)
        {
            listaAnimais.ClearSelection();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void listaAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value);
                editarAnimais.ShowDialog();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
                        DataTable data = (listaAnimais.DataSource as DataTable).Copy();
                        data.Columns["Especie"].ColumnName = "Espécie";
                        data.Columns["Raca"].ColumnName = "Raça";
                        data.Columns["Identificacao"].ColumnName = "Identificação";
                        data.Columns["Observacao_rotina"].ColumnName = "Observação de Rotina";
                        data.Columns["Data_registro"].ColumnName = "Data de Registro";
                        data.Columns["DataNascimento"].ColumnName = "Data de Nascimento";
                        data.Columns["Situacao"].ColumnName = "Situação";
                        IXLWorksheet worksheet = workbook.Worksheets.Add(data, "Lista de animais");
                        worksheet.ColumnsUsed().AdjustToContents();
                        worksheet.RowsUsed().AdjustToContents();
                        worksheet.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
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

        private void listaAnimais_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (listaAnimais.Rows.Count > 0)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }

        private void listaAnimais_SelectionChanged(object sender, EventArgs e)
        {
            if (listaAnimais.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void listaAnimais_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            MaximumSize = new System.Drawing.Size(listaAnimais.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 3 + 50, 100000);
        }
    }
}