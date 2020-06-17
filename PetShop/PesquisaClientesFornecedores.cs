using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;
using PetShop.Entities;
using PetShop.Entities.Enums;

namespace PetShop
{

    public partial class PesquisaClientesFornecedores : Form
    {
        private readonly TipoPesquisa _TipoPesquisa; // Valor true = Clientes, Valor false = Fornecedores
        public PesquisaClientesFornecedores(TipoPesquisa tipoPesquisa)
        {
            InitializeComponent();
            _TipoPesquisa = tipoPesquisa;
        }

        public void AtualizarLista()
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                dataGridViewListaClientesFornecedores.DataSource = Cliente.ListarClientes();
            }       
        }

        
        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                AdicionarEditarCliente AdicionarCliente = new AdicionarEditarCliente(TipoOperacao.Adicionar, this);
                AdicionarCliente.ShowDialog();
            }
            else
            {
                // Refazer essa merda com o padrão correto

                /*
                AdicionarEditarFornecedor AdicionarFornecedor = new AdicionarEditarFornecedor(true, this);
                AdicionarFornecedor.ShowDialog();
                */
            }
        }
        private void btnExcluirClienteFornecedor_Click(object sender, EventArgs e)
        {
            // Fazer as alterações na parte de excluir, seja la como for feita....

            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                string row_dados = row.Cells[0].Value.ToString();
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este cliente?", "Remover Cliente", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        /*
                        using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.PetShopConnectionString))
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
                        */
                    }
                }
                else
                {
                    DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este Fornecedor?", "Remover Fornecedor", MessageBoxButtons.YesNo);
                    if (confirmar_delete == DialogResult.Yes)
                    {
                        /*using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.PetShopConnectionString))
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
                        }*/

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
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    // Corrigir essa coisa horrorosa logo depois de montar o metodo de editar na classe cliente

                    /*
                    AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(false, this, row.Cells[0].Value.ToString());
                    EditarCliente.ShowDialog();
                    */
                }
                else
                { 
                    // Corrigir isso logo depois de ter montado a classe de fornecedor

                    /*
                    AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(false, this, row.Cells[0].Value.ToString());
                    EditarFornecedor.ShowDialog();
                    */
                }
                
            }
            else
            {
                MessageBox.Show("Selecione um item para ser editado.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisaClientesFornecedores_Load(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Pesquisa de Clientes";
                Icon = Properties.Resources.usuarios_icon;
                dataGridViewListaClientesFornecedores.DataSource = Cliente.ListarClientes();
            }
            else
            {
                Text = "Pesquisa de Fornecedores";
                Icon = Properties.Resources.fornecedor_icon;
                
            }
        }

        private void BtnPesquisarNomeClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                
            }
            else
            {
                
            }

        }

        private void TextBoxPesquisarPeloNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    
                }
                else
                {
                    
                }
            }
        }

        private void DataGridViewListaClientesFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                if (_TipoPesquisa == TipoPesquisa.Cliente)
                {
                    // Refazer essa aberração logo depois de montar o metodo de editar na classe cliente

                    /*
                    AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(false, this, row.Cells[0].Value.ToString());
                    EditarCliente.ShowDialog();
                    */
                }
                else
                {
                    // Refazer isso logo depois de ter terminado de fazer pelo menos o básico da classe fornecedor

                    /*
                    AdicionarEditarFornecedor EditarFornecedor = new AdicionarEditarFornecedor(false, this, row.Cells[0].Value.ToString());
                    EditarFornecedor.ShowDialog();
                    */
                }
            }
        }
    }
}
