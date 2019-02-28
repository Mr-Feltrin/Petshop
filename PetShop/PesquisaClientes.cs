using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;


namespace PetShop
{
    
    public partial class PesquisaClientes : Form
    {

        public PesquisaClientes()
        {
            InitializeComponent();          
        }

        private void ExibirDadosLista()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    comando.CommandText = "SELECT * FROM cliente";
                    comando.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    MySqlDataAdapter dataadp = new MySqlDataAdapter(comando);
                    dataadp.Fill(dta);
                    dataGridView_lista_usuarios.DataSource = dta;
                    dataGridView_lista_usuarios.Columns[0].HeaderText = "Número";
                    dataGridView_lista_usuarios.Columns[1].HeaderText = "Nome completo";
                    dataGridView_lista_usuarios.Columns[2].HeaderText = "Tipo de cliente";
                    dataGridView_lista_usuarios.Columns[3].HeaderText = "Apelido";
                    dataGridView_lista_usuarios.Columns[4].HeaderText = "Endereço";
                    dataGridView_lista_usuarios.Columns[5].HeaderText = "Bairro";
                    dataGridView_lista_usuarios.Columns[6].HeaderText = "Cidade";
                    dataGridView_lista_usuarios.Columns[7].HeaderText = "UF";
                    dataGridView_lista_usuarios.Columns[8].HeaderText = "CEP";
                    dataGridView_lista_usuarios.Columns[9].HeaderText = "1° Telefone";
                    dataGridView_lista_usuarios.Columns[10].HeaderText = "2° Telefone";
                    dataGridView_lista_usuarios.Columns[11].HeaderText = "Celular";
                    dataGridView_lista_usuarios.Columns[12].HeaderText = "Complemento";
                    dataGridView_lista_usuarios.Columns[13].HeaderText = "E-Mail";
                    dataGridView_lista_usuarios.Columns[14].HeaderText = "CPF";
                    dataGridView_lista_usuarios.Columns[15].HeaderText = "CNPJ";
                    dataGridView_lista_usuarios.Columns[16].HeaderText = "Observações";
                    dataGridView_lista_usuarios.Sort(this.dataGridView_lista_usuarios.Columns[0], ListSortDirection.Descending);
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
            foreach (DataGridViewRow dataRow in dataGridView_lista_usuarios.Rows)
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

        private void btn_adicionar_cliente_Click(object sender, EventArgs e)
        {

            AdicionarEditarCliente AdicionarCliente = new AdicionarEditarCliente(true);
            AdicionarCliente.ShowDialog();
        }

        private void btn_excluir_cliente_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista_usuarios.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_lista_usuarios.SelectedRows[0];
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
                            MessageBox.Show("Erro ao remover Cliente: " +ex.Message, "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Pesquisa_clientes_Activated(object sender, EventArgs e)
        {
            ExibirDadosLista();
            dataGridView_lista_usuarios.ClearSelection();
        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista_usuarios.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_lista_usuarios.SelectedRows[0];
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
            // Classe 
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Clientes Cadastrados";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "CãoPanheiro";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView_lista_usuarios);
        }
    }
}
