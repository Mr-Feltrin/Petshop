using System;
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
            AdicionarEditarProdutos editarProduto = new AdicionarEditarProdutos(false, this);
            editarProduto.ShowDialog();
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
    }
}
