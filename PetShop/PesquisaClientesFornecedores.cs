using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;


namespace PetShop
{

    public partial class PesquisaClientesFornecedores : Form
    {

        private readonly int TipoPesquisa; // Valor 0 = Clientes, Valor 1 = Fornecedores

        public PesquisaClientesFornecedores(int tipoPesquisa)
        {
            InitializeComponent();
            TipoPesquisa = tipoPesquisa;
        }

        private void ExibirDadosLista(string comandoSql)
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
                    dataGridViewListaClientesFornecedores.Sort(dataGridViewListaClientesFornecedores.Columns[0], ListSortDirection.Descending);
                    CoresListaClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void CoresListaClientes()
        {
            if (TipoPesquisa == 0)
            {
                foreach (DataGridViewRow dataRow in dataGridViewListaClientesFornecedores.Rows)
                {
                    if (dataRow.Cells[2].Value.ToString() == "Não Atender")
                    {
                        dataRow.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (dataRow.Cells[2].Value.ToString() == "Cliente Especial")
                    {
                        dataRow.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarCliente AdicionarCliente = new AdicionarEditarCliente(true);
            AdicionarCliente.ShowDialog();
        }

        private void btnExcluirClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                string row_dados = row.Cells[0].Value.ToString();
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
                MessageBox.Show("Selecione um item para ser removido.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnEditarClienteFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaClientesFornecedores.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewListaClientesFornecedores.SelectedRows[0];
                AdicionarEditarCliente EditarCliente = new AdicionarEditarCliente(false, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(), row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString());
                EditarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item para ser editado.", "Item não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_lista_usuarios_Sorted(object sender, EventArgs e)
        {
            CoresListaClientes();
        }

        private void btn_imprimir_cliente_Click(object sender, EventArgs e)
        {
            // Classe de impressão da tabela datagridview
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Clientes Cadastrados";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "CãoPanheiro";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewListaClientesFornecedores);
        }

        private void PesquisaClientesFornecedores_Activated(object sender, EventArgs e)
        {

            ExibirDadosLista("SELECT * FROM cliente");


        }

        private void PesquisaClientesFornecedores_Load(object sender, EventArgs e)
        {
            dataGridViewListaClientesFornecedores.ClearSelection();
            if (TipoPesquisa == 0)
            {
                Text = "Pesquisa de Clientes";
                Icon = Properties.Resources.usuarios_icon;
                CoresListaClientes();
            }
            else if (TipoPesquisa == 1)
            {
                Text = "Pesquisa de Fornecedores";
                Icon = Properties.Resources.fornecedor_icon;
            }
        }

        private void BtnPesquisarNomeClienteFornecedor_Click(object sender, EventArgs e)
        {
            ExibirDadosLista($"SELECT * FROM cliente WHERE nome_completo LIKE '%{textBoxPesquisarPeloNome.Text}%'");
        }

        private void TextBoxPesquisarPeloNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExibirDadosLista($"SELECT * FROM cliente WHERE nome_completo LIKE '%{textBoxPesquisarPeloNome.Text}%'");
            }
        }

    }
}
