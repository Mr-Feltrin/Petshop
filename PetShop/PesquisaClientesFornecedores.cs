using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{

    public partial class PesquisaClientesFornecedores : Form
    {
        private readonly bool TipoPesquisa; // Valor true = Clientes, Valor false = Fornecedores
        public PesquisaClientesFornecedores(bool tipoPesquisa)
        {
            InitializeComponent();
            TipoPesquisa = tipoPesquisa;
        }


        public virtual void ExibirDadosLista(string comandoSql)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    comando.CommandText = comandoSql;
                    comando.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    MySqlDataAdapter dataadp = new MySqlDataAdapter(comando);
                    dataadp.Fill(dta);
                    dataGridViewListaClientesFornecedores.DataSource = dta;
                    if (TipoPesquisa == true)
                    {
                        dataGridViewListaClientesFornecedores.Columns[0].HeaderText = "Número";
                        dataGridViewListaClientesFornecedores.Columns[1].HeaderText = "Nome completo";
                        dataGridViewListaClientesFornecedores.Columns[2].HeaderText = "Tipo de cliente";
                        dataGridViewListaClientesFornecedores.Columns[3].HeaderText = "Apelido";
                        dataGridViewListaClientesFornecedores.Columns[4].HeaderText = "Endereço";
                        dataGridViewListaClientesFornecedores.Columns[5].HeaderText = "Bairro";
                        dataGridViewListaClientesFornecedores.Columns[6].HeaderText = "Cidade";
                        dataGridViewListaClientesFornecedores.Columns[7].HeaderText = "UF";
                        dataGridViewListaClientesFornecedores.Columns[8].HeaderText = "CEP";
                        dataGridViewListaClientesFornecedores.Columns[9].HeaderText = "1° Telefone";
                        dataGridViewListaClientesFornecedores.Columns[10].HeaderText = "2° Telefone";
                        dataGridViewListaClientesFornecedores.Columns[11].HeaderText = "Celular";
                        dataGridViewListaClientesFornecedores.Columns[12].HeaderText = "Complemento";
                        dataGridViewListaClientesFornecedores.Columns[13].HeaderText = "E-Mail";
                        dataGridViewListaClientesFornecedores.Columns[14].HeaderText = "CPF";
                        dataGridViewListaClientesFornecedores.Columns[15].HeaderText = "CNPJ";
                        dataGridViewListaClientesFornecedores.Columns[16].HeaderText = "Observações";
                    }
                    else
                    {
                        dataGridViewListaClientesFornecedores.Columns[0].HeaderText = "Número";
                        dataGridViewListaClientesFornecedores.Columns[1].HeaderText = "Nome do Fornecedor";
                        dataGridViewListaClientesFornecedores.Columns[2].HeaderText = "Tipo de Fornecimento";
                        dataGridViewListaClientesFornecedores.Columns[3].HeaderText = "Apelido Fornecedor";
                        dataGridViewListaClientesFornecedores.Columns[4].HeaderText = "Endereço";
                        dataGridViewListaClientesFornecedores.Columns[5].HeaderText = "Bairro";
                        dataGridViewListaClientesFornecedores.Columns[6].HeaderText = "Cidade";
                        dataGridViewListaClientesFornecedores.Columns[7].HeaderText = "UF";
                        dataGridViewListaClientesFornecedores.Columns[8].HeaderText = "CEP";
                        dataGridViewListaClientesFornecedores.Columns[9].HeaderText = "Telefone";
                        dataGridViewListaClientesFornecedores.Columns[10].HeaderText = "Celular";
                        dataGridViewListaClientesFornecedores.Columns[11].HeaderText = "Email";
                        dataGridViewListaClientesFornecedores.Columns[12].HeaderText = "CPF";
                        dataGridViewListaClientesFornecedores.Columns[13].HeaderText = "CNPJ";
                        dataGridViewListaClientesFornecedores.Columns[14].HeaderText = "Observações";
                    }
                    dataGridViewListaClientesFornecedores.Sort(dataGridViewListaClientesFornecedores.Columns[0], ListSortDirection.Descending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        
        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (TipoPesquisa == true)
            {
                AdicionarEditarCliente AdicionarCliente = new AdicionarEditarCliente(true, this);
                AdicionarCliente.ShowDialog();
            }
            else
            {
                AdicionarEditarFornecedor AdicionarFornecedor = new AdicionarEditarFornecedor(true, this);
                AdicionarFornecedor.ShowDialog();
            }
        }
        private void btnExcluirClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                string row_dados = row.Cells[0].Value.ToString();
                if (TipoPesquisa == true)
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este cliente?", "Remover Cliente", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                        {
                            try
                            {
                                conn.Open();
                                MySqlCommand comando = conn.CreateCommand();
                                comando.CommandText = "DELETE FROM cliente WHERE id = @id";
                                comando.Parameters.AddWithValue("@id", row_dados);
                                int query_check = comando.ExecuteNonQuery();
                                if (query_check != 0)
                                {
                                    MessageBox.Show("Cliente removido", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ExibirDadosLista("SELECT * FROM cliente");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao remover Cliente: " + ex.Message, "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
                else
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este Fornecedor?", "Remover Fornecedor", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                        {
                            try
                            {
                                conn.Open();
                                MySqlCommand comando = conn.CreateCommand();
                                comando.CommandText = "DELETE FROM fornecedor WHERE id = @id";
                                comando.Parameters.AddWithValue("@id", row_dados);
                                int query_check = comando.ExecuteNonQuery();
                                if (query_check != 0)
                                {
                                    MessageBox.Show("Fornecedor removido", "Remover Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ExibirDadosLista("SELECT * FROM fornecedor");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao remover Fornecedor: " + ex.Message, "Remover Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
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
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                if (TipoPesquisa == true)
                {
                    AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(false, this, row.Cells[0].Value.ToString());
                    EditarCliente.ShowDialog();
                }
                else
                {
                    AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(false, this, row.Cells[0].Value.ToString());
                    EditarFornecedor.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Selecione um item para ser editado.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisaClientesFornecedores_Load(object sender, EventArgs e)
        {
            if (TipoPesquisa == true)
            {
                Text = "Pesquisa de Clientes";
                Icon = Properties.Resources.usuarios_icon;
                ExibirDadosLista("SELECT * FROM cliente");
            }
            else
            {
                Text = "Pesquisa de Fornecedores";
                Icon = Properties.Resources.fornecedor_icon;
                ExibirDadosLista("SELECT * FROM fornecedor");
            }
        }

        private void BtnPesquisarNomeClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (TipoPesquisa == true)
            {
                ExibirDadosLista($"SELECT * FROM cliente WHERE nome_completo LIKE '%{textBoxPesquisarPeloNome.Text}%'");
            }
            else
            {
                ExibirDadosLista($"SELECT * FROM fornecedor WHERE nome_fornecedor LIKE '%{textBoxPesquisarPeloNome.Text}%'");
            }

        }

        private void TextBoxPesquisarPeloNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TipoPesquisa == true)
                {
                    ExibirDadosLista($"SELECT * FROM cliente WHERE nome_completo LIKE '%{textBoxPesquisarPeloNome.Text}%'");
                }
                else
                {
                    ExibirDadosLista($"SELECT * FROM fornecedor WHERE nome_fornecedor LIKE '%{textBoxPesquisarPeloNome.Text}%'");
                }
            }
            else
            {
                if (TipoPesquisa == true)
                {
                    ExibirDadosLista($"SELECT * FROM cliente WHERE nome_completo LIKE '%{textBoxPesquisarPeloNome.Text}%'");
                }
                else
                {
                    ExibirDadosLista($"SELECT * FROM fornecedor WHERE nome_fornecedor LIKE '%{textBoxPesquisarPeloNome.Text}%'");
                }
            }
        }

        private void DataGridViewListaClientesFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                if (TipoPesquisa == true)
                {
                    AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(false, this, row.Cells[0].Value.ToString());
                    EditarCliente.ShowDialog();
                }
                else
                {
                    AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(false, this, row.Cells[0].Value.ToString());
                    EditarFornecedor.ShowDialog();
                }
            }
        }
    }
}
