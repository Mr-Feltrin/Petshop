using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{
    public partial class PesquisaProdutos : Form
    {
        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        private void BtnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos adicionarProdutos = new AdicionarEditarProdutos(true, this);
            adicionarProdutos.ShowDialog();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            comboBoxFiltrarLista.SelectedIndex = 4;
            ListaProdutos("SELECT * FROM produto");
        }

        private void BtnEditarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (listaProduto.SelectedRows.Count != 0)
            {
                DataGridViewRow row = listaProduto.SelectedRows[0];
                AdicionarEditarProdutos editarProdutos = new AdicionarEditarProdutos(false, this, row.Cells[0].Value.ToString());
                editarProdutos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um produto para ser editado.", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ListaProdutos(string comandoSql)
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
                    listaProduto.DataSource = dta;
                    listaProduto.Columns[0].HeaderText = "Número";
                    listaProduto.Columns[1].HeaderText = "Nome do Produto";
                    listaProduto.Columns[2].HeaderText = "Codigo de Barras";
                    listaProduto.Columns[3].HeaderText = "Unidade";
                    listaProduto.Columns[4].HeaderText = "Quantidade";
                    listaProduto.Columns[5].HeaderText = "Referência";
                    listaProduto.Columns[6].HeaderText = "Local Físico";
                    listaProduto.Columns[7].HeaderText = "Data de Modificação";
                    listaProduto.Columns[8].HeaderText = "Marca";
                    listaProduto.Columns[9].HeaderText = "Categoria";
                    listaProduto.Columns[10].HeaderText = "Estoque Mínimo";
                    listaProduto.Columns[11].HeaderText = "Estoque Atual";
                    listaProduto.Columns[12].HeaderText = "Data de Validade";
                    listaProduto.Columns[13].HeaderText = "Valor de Custo";
                    listaProduto.Columns[14].HeaderText = "Margem a Vista";
                    listaProduto.Columns[15].HeaderText = "Valor do Produto";
                    listaProduto.Columns[16].HeaderText = "Observações";
                    listaProduto.Sort(listaProduto.Columns[0], ListSortDirection.Descending);               
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

        private void BtnExcluirClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (listaProduto.SelectedRows.Count != 0)
            {
                DataGridViewRow row = listaProduto.SelectedRows[0];
                string row_dados = row.Cells[0].Value.ToString();
                DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este Produto?", "Remover Produto", MessageBoxButtons.YesNo);
                if (confirmar_delete == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand comando = conn.CreateCommand();
                            comando.CommandText = "DELETE FROM produto WHERE id = @id";
                            comando.Parameters.AddWithValue("@id", row_dados);
                            int query_check = comando.ExecuteNonQuery();
                            if (query_check != 0)
                            {
                                MessageBox.Show("Produto removido", "Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ListaProdutos("SELECT * FROM produto");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao remover Produto: " + ex.Message, "Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}
