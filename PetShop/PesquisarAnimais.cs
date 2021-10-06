using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace PetShop
{
    public partial class PesquisarAnimais : Form
    {
        private VScrollBar DGVScrollBar;

        public PesquisarAnimais()
        {
            InitializeComponent();
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarAnimais adicionarEditarAnimais = new AdicionarEditarAnimais(TipoOperacao.Adicionar, this))
            {
                adicionarEditarAnimais.ShowDialog(this);
            }
        }

        private void PesquisaAnimais_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            listaAnimais.Columns["Especie"].HeaderText = "Espécie";
            listaAnimais.Columns["Raca"].HeaderText = "Raça";
            listaAnimais.Columns["Identificacao"].HeaderText = "Identificação";
            listaAnimais.Columns["NomeCliente"].HeaderText = "Nome do Dono";
            listaAnimais.Columns["Observacao_rotina"].HeaderText = "Observação de Rotina";
            listaAnimais.Columns["Data_registro"].HeaderText = "Data de Registro";
            listaAnimais.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
            listaAnimais.Columns["Situacao"].HeaderText = "Situação";
            listaAnimais.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            listaAnimais.Columns["Peso"].DefaultCellStyle.Format = "F2";
            listaAnimais.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollBar = listaAnimais.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(listaAnimais, this);
            listaAnimais.ColumnWidthChanged += new DataGridViewColumnEventHandler(listaAnimais_ColumnWidthChanged);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaAnimais, this);
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
            if (listaAnimais.Rows.Count > 0)
            {
                listaAnimais.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listaAnimais.SelectedRows.Count != 0)
            {
                using (AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value))
                {
                    editarAnimais.ShowDialog(this);
                }
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
                using (AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value))
                {
                    editarAnimais.ShowDialog(this);
                }
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
                        DataTable data = (listaAnimais.DataSource as DataTable).Clone();
                        foreach (DataGridViewRow row in listaAnimais.Rows)
                        {
                            data.ImportRow(((DataRowView)row.DataBoundItem).Row);
                        }
                        data.Columns["Especie"].ColumnName = "Espécie";
                        data.Columns["Raca"].ColumnName = "Raça";
                        data.Columns["Identificacao"].ColumnName = "Identificação";
                        data.Columns["NomeCliente"].ColumnName = "Nome do Dono";
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
            DataGridViewTools.MaximumFormSize(listaAnimais, this, listaAnimais_ColumnWidthChanged);
        }

        private void PesquisaAnimais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void listaAnimais_Enter(object sender, EventArgs e)
        {
            listaAnimais.CurrentCell = null;
            listaAnimais.FirstDisplayedCell = null;
        }
    }
}