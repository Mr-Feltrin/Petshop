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

    public partial class PesquisarClientesFornecedores : Form
    {
        private readonly TipoPesquisa _TipoPesquisa;
        private VScrollBar DGVScrollBar;

        public PesquisarClientesFornecedores(TipoPesquisa tipoPesquisa)
        {
            InitializeComponent();
            _TipoPesquisa = tipoPesquisa;
        }

        private void PesquisaClientesFornecedores_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Lista de clientes";
                Icon = Properties.Resources.usuarios_icon;
                DGVListaClientesFornecedores.Columns["Telefone_Principal"].HeaderText = "Telefone Principal";
                DGVListaClientesFornecedores.Columns["Telefone_Secundario"].HeaderText = "Telefone Secundário";
            }
            else if (_TipoPesquisa == TipoPesquisa.Fornecedor)
            {
                Text = "Lista de fornecedores";
                Icon = Properties.Resources.fornecedor_icon;
                DGVListaClientesFornecedores.Columns["Tipo_Fornecimento"].HeaderText = "Tipo de Fornecimento";
            }
            DGVListaClientesFornecedores.Columns["Observacoes"].HeaderText = "Observações";
            DGVListaClientesFornecedores.Columns["Cpf"].HeaderText = "CPF";
            DGVListaClientesFornecedores.Columns["Cnpj"].HeaderText = "CNPJ";
            DGVListaClientesFornecedores.Columns["Cep"].HeaderText = "CEP";
            DGVListaClientesFornecedores.Columns["Endereco"].HeaderText = "Endereço";
            DGVListaClientesFornecedores.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVListaClientesFornecedores.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(DGVListaClientesFornecedores, this);
            DGVListaClientesFornecedores.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVListaClientesFornecedores_ColumnWidthChanged);
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaClientesFornecedores, this);
        }

        public void AtualizarLista()
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                DGVListaClientesFornecedores.DataSource = Cliente.ListarClientes();
                DGVListaClientesFornecedores.ClearSelection();
                DGVListaClientesFornecedores.Sort(DGVListaClientesFornecedores.Columns[0], ListSortDirection.Descending);
                foreach (DataGridViewRow row in DGVListaClientesFornecedores.Rows)
                {
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Apelido"].Value))
                    {
                        row.Cells["Apelido"].Value = "Nenhum";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Telefone_Secundario"].Value))
                    {
                        row.Cells["Telefone_Secundario"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Celular"].Value))
                    {
                        row.Cells["Celular"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Complemento"].Value))
                    {
                        row.Cells["Complemento"].Value = "Nenhum";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Email"].Value))
                    {
                        row.Cells["Email"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cpf"].Value))
                    {
                        row.Cells["Cpf"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cnpj"].Value))
                    {
                        row.Cells["Cnpj"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Observacoes"].Value))
                    {
                        row.Cells["Observacoes"].Value = "Nenhuma";
                    }
                }
            }
            else
            {
                DGVListaClientesFornecedores.DataSource = Fornecedor.ListarFornecedores();
                foreach (DataGridViewRow row in DGVListaClientesFornecedores.Rows)
                {
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Apelido"].Value))
                    {
                        row.Cells["Apelido"].Value = "Nenhum";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cep"].Value))
                    {
                        row.Cells["Cep"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Celular"].Value))
                    {
                        row.Cells["Celular"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cnpj"].Value))
                    {
                        row.Cells["Cnpj"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cpf"].Value))
                    {
                        row.Cells["Cpf"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Email"].Value))
                    {
                        row.Cells["Email"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Observacoes"].Value))
                    {
                        row.Cells["Observacoes"].Value = "Nenhuma";
                    }
                }
            }
            DGVListaClientesFornecedores.ClearSelection();
            if (DGVListaClientesFornecedores.Rows.Count > 0)
            {
                DGVListaClientesFornecedores.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);

            }
        }

        public void BuscarLista()
        {
            (DGVListaClientesFornecedores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + textBoxPesquisarPeloNome.Text + "%'");
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                using (AdicionarEditarCliente AdicionarCliente = new AdicionarEditarCliente(TipoOperacao.Adicionar, this))
                {
                    AdicionarCliente.ShowDialog(this);
                }
            }
            else
            {
                using (AdicionarEditarFornecedor AdicionarFornecedor = new AdicionarEditarFornecedor(TipoOperacao.Adicionar))
                {
                    AdicionarFornecedor.ShowDialog(this);
                }
            }
        }
        private void btnExcluirClienteFornecedor_Click(object sender, EventArgs e)
        {

            if (DGVListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este cliente?", "Remover Cliente", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        Cliente.ExcluirCliente((int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value);
                        AtualizarLista();
                    }
                }
                else
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este Fornecedor?", "Remover Fornecedor", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        Fornecedor.ExcluirFornecedor((int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value);
                        AtualizarLista();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para ser removido.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (DGVListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    using (AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(TipoOperacao.Editar, this, (int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarCliente.ShowDialog(this);
                    }
                }
                else
                {
                    using (AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(TipoOperacao.Editar, (int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarFornecedor.ShowDialog(this);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione um item para ser editado.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridViewListaClientesFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    using (AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(TipoOperacao.Editar, this, (int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarCliente.ShowDialog(this);
                    }
                }
                else
                {
                    using (AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(TipoOperacao.Editar, (int)DGVListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarFornecedor.ShowDialog(this);
                    }
                }
            }
        }

        private void textBoxPesquisarPeloNome_TextChanged(object sender, EventArgs e)
        {
            BuscarLista();
        }

        private void dataGridViewListaClientesFornecedores_Sorted(object sender, EventArgs e)
        {
            DGVListaClientesFornecedores.ClearSelection();
        }

        private void dataGridViewListaClientesFornecedores_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (DGVListaClientesFornecedores.Rows.Count > 0)
            {
                btnExportarClienteFornecedor.Enabled = true;
            }
            else
            {
                btnExportarClienteFornecedor.Enabled = false;
            }
        }

        private void dataGridViewListaClientesFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVListaClientesFornecedores.SelectedRows.Count > 0)
            {
                btnEditarClienteFornecedor.Enabled = true;
                btnExcluirClienteFornecedor.Enabled = true;
            }
            else
            {
                btnExcluirClienteFornecedor.Enabled = false;
                btnEditarClienteFornecedor.Enabled = false;
            }
        }

        private void btnExportarClienteFornecedor_Click(object sender, EventArgs e)
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
                        DataTable data = (DGVListaClientesFornecedores.DataSource as DataTable).Copy();
                        if (_TipoPesquisa == TipoPesquisa.Cliente)
                        {
                            data.Columns["Telefone_Principal"].ColumnName = "Telefone";
                            data.Columns["Telefone_Secundario"].ColumnName = "Telefone Secundário";
                        }
                        else
                        {
                            data.Columns["Tipo_Fornecimento"].ColumnName = "Tipo de Fornecimento";

                        }
                        data.Columns["Observacoes"].ColumnName = "Observações";
                        data.Columns["Cpf"].ColumnName = "CPF";
                        data.Columns["Cnpj"].ColumnName = "CNPJ";
                        data.Columns["Cep"].ColumnName = "CEP";
                        data.Columns["Endereco"].ColumnName = "Endereço";
                        IXLWorksheet worksheet = workbook.Worksheets.Add(data, _TipoPesquisa == TipoPesquisa.Cliente ? "Lista de Clientes" : "Lista de Fornecedores");
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

        private void DGVListaClientesFornecedores_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaClientesFornecedores, this);
        }

        private void PesquisaClientesFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void DGVListaClientesFornecedores_Enter(object sender, EventArgs e)
        {
            DGVListaClientesFornecedores.CurrentCell = null;
            DGVListaClientesFornecedores.FirstDisplayedCell = null;
        }
    }
}
