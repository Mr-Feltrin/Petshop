using ClosedXML.Excel;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PetShop
{

    public partial class PesquisarClientesFornecedores : Form
    {
        private readonly TipoPesquisa _TipoPesquisa;
        public PesquisarClientesFornecedores(TipoPesquisa tipoPesquisa)
        {
            InitializeComponent();
            _TipoPesquisa = tipoPesquisa;
        }

        public void AtualizarLista()
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                dataGridViewListaClientesFornecedores.DataSource = Cliente.ListarClientes();
                dataGridViewListaClientesFornecedores.ClearSelection();
                dataGridViewListaClientesFornecedores.Sort(dataGridViewListaClientesFornecedores.Columns[0], ListSortDirection.Descending);
                foreach (DataGridViewRow row in dataGridViewListaClientesFornecedores.Rows)
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
                dataGridViewListaClientesFornecedores.DataSource = Fornecedor.ListarFornecedores();
                foreach (DataGridViewRow row in dataGridViewListaClientesFornecedores.Rows)
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
            dataGridViewListaClientesFornecedores.Sort(dataGridViewListaClientesFornecedores.Columns[0], ListSortDirection.Descending);
            dataGridViewListaClientesFornecedores.ClearSelection();
            dataGridViewListaClientesFornecedores.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
        }

        public void BuscarLista()
        {
            (dataGridViewListaClientesFornecedores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + textBoxPesquisarPeloNome.Text + "%'");
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

            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este cliente?", "Remover Cliente", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        Cliente.ExcluirCliente((int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value);
                        AtualizarLista();
                    }
                }
                else
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este Fornecedor?", "Remover Fornecedor", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        Fornecedor.ExcluirFornecedor((int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value);
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
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    using (AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(TipoOperacao.Editar, this, (int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarCliente.ShowDialog(this);
                    }
                }
                else
                {
                    using (AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(TipoOperacao.Editar, (int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
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

        private void PesquisaClientesFornecedores_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Lista de clientes";
                Icon = Properties.Resources.usuarios_icon;
                dataGridViewListaClientesFornecedores.Columns["Telefone_Principal"].HeaderText = "Telefone Principal";
                dataGridViewListaClientesFornecedores.Columns["Telefone_Secundario"].HeaderText = "Telefone Secundário";
            }
            else if (_TipoPesquisa == TipoPesquisa.Fornecedor)
            {
                Text = "Lista de fornecedores";
                Icon = Properties.Resources.fornecedor_icon;
                dataGridViewListaClientesFornecedores.Columns["Tipo_Fornecimento"].HeaderText = "Tipo de Fornecimento";
            }
            dataGridViewListaClientesFornecedores.Columns["Observacoes"].HeaderText = "Observações";
            dataGridViewListaClientesFornecedores.Columns["Cpf"].HeaderText = "CPF";
            dataGridViewListaClientesFornecedores.Columns["Cnpj"].HeaderText = "CNPJ";
            dataGridViewListaClientesFornecedores.Columns["Cep"].HeaderText = "CEP";
            dataGridViewListaClientesFornecedores.Columns["Endereco"].HeaderText = "Endereço";
            dataGridViewListaClientesFornecedores.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        private void DataGridViewListaClientesFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    using (AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(TipoOperacao.Editar, this, (int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
                    {
                        EditarCliente.ShowDialog(this);
                    }
                }
                else
                {
                    using (AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(TipoOperacao.Editar, (int)dataGridViewListaClientesFornecedores.SelectedRows[0].Cells[0].Value))
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
            dataGridViewListaClientesFornecedores.ClearSelection();
        }

        private void dataGridViewListaClientesFornecedores_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.Rows.Count > 0)
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
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count > 0)
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
                        DataTable data = (dataGridViewListaClientesFornecedores.DataSource as DataTable).Copy();
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

        private void dataGridViewListaClientesFornecedores_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            MaximumSize = new System.Drawing.Size(dataGridViewListaClientesFornecedores.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 3 + 52, 100000);
        }

        private void PesquisaClientesFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
