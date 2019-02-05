using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetShop
{
    public partial class Pesquisa_clientes : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rasou\Downloads\PetShop\PetShop\Database.mdf;Integrated Security=True");
        public Pesquisa_clientes()
        {
            InitializeComponent();
        }

        public void exibir_dados_lista()
        {
            try
            {
                connection.Open();
                SqlCommand comando = connection.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from [clientes]";
                comando.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(comando);
                dataadp.Fill(dta);
                dataGridView_lista_usuarios.DataSource = dta;
                connection.Close();
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
                //this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);
                dataGridView_lista_usuarios.Sort(this.dataGridView_lista_usuarios.Columns[0], ListSortDirection.Descending);

            }
            catch
            {
                MessageBox.Show("Erro ao carregar os dados da tabela, por favor verifique a base de dados e tente novamente", "Erro de exibição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_adicionar_cliente_Click(object sender, EventArgs e)
        {
            Adicionar_cliente show_Adicionar_cliente = new Adicionar_cliente();
            show_Adicionar_cliente.ShowDialog();
        }

        private void Pesquisa_clientes_Load(object sender, EventArgs e)
        {
            exibir_dados_lista();
        }

        private void Pesquisa_clientes_Activated(object sender, EventArgs e)
        {
            exibir_dados_lista();
        }

        private void btn_excluir_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}
