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
                    dta.Columns[0].ColumnName = "Número";
                    dta.Columns[1].ColumnName = "Nome do Produto";
                    dta.Columns[2].ColumnName = "Código de Barras";
                    dta.Columns[3].ColumnName = "Unidade";
                    dta.Columns[4].ColumnName = "Quantidade";
                    dta.Columns[5].ColumnName = "Referência";
                    dta.Columns[6].ColumnName = "Local Físico";
                    dta.Columns[7].ColumnName = "Data de Modificação";
                    dta.Columns[8].ColumnName = "Marca";
                    dta.Columns[9].ColumnName = "Categoria";
                    dta.Columns[10].ColumnName = "Estoque Mínimo";
                    dta.Columns[11].ColumnName = "Estoque Atual";
                    dta.Columns[12].ColumnName = "Data de Validade";
                    dta.Columns[13].ColumnName = "Valor de Custo";
                    dta.Columns[14].ColumnName = "Margem A Vista";
                    dta.Columns[15].ColumnName = "Valor do Produto";
                    dta.Columns[16].ColumnName = "Observações";
                    listaProduto.DataSource = dta;
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
