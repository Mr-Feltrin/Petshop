using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class Adicionar_cliente : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rasou\Downloads\PetShop\PetShop\Database.mdf;Integrated Security=True");

        public Adicionar_cliente()
        {
            InitializeComponent();  
        }

        private void Adicionar_cliente_Load(object sender, EventArgs e)
        {     
            cadastro_cliente_tipo.SelectedIndex = 0;

        }

        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cep.SelectionStart = 0;
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            cadastro_cliente_telefone_primario.SelectionStart = 0;
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            cadastro_cliente_telefone_secundario.SelectionStart = 0;
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            cadastro_cliente_celular.SelectionStart = 0;
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cpf.SelectionStart = 0;
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cnpj.SelectionStart = 0;
        }
        private void cadastro_cliente_adicionar_Click(object sender, EventArgs e)
        {        
            // Verifica se campos de cadastro obrigatórios estao preenchidos
            if (string.IsNullOrWhiteSpace(cadastro_cliente_nome_completo.Text))
            {
                MessageBox.Show("Preencha o campo de Nome / Razão Social", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(cadastro_cliente_tipo.Text))
            {
                MessageBox.Show("Selecione o tipo de cliente", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(cadastro_cliente_nome_apelido.Text))
            {
                MessageBox.Show("Preencha o campo de Nome Fantasia / Apelido", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(cadastro_cliente_endereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(cadastro_cliente_bairro.Text))
            {
                MessageBox.Show("Preencha o campo de Bairro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(cadastro_cliente_cidade.Text))
            {
                MessageBox.Show("Preencha o campo de Cidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(cadastro_cliente_uf.Text))
            {
                MessageBox.Show("Selecione o campo UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cadastro_cliente_cep.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CEP", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cadastro_cliente_telefone_primario.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de 1° Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cadastro_cliente_cpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CPF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Conexão com banco de dados e inserção de registros
                try
                {
                    connection.Open();
                    ConnectionState status_connection = connection.State;
                    if (status_connection != ConnectionState.Open)
                    {
                        MessageBox.Show("A conexão com a base de dados não foi estabelecida, tentando reconectar", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Open();
                        if (status_connection != ConnectionState.Open)
                        {
                            MessageBox.Show("Falha ao reconectar com a base de dados, por favor reinicie a aplicação e tente novamente.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else if (status_connection == ConnectionState.Open)
                    {
                        SqlCommand comando = connection.CreateCommand();
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "insert into [clientes] (nome_completo,tipo,nome_apelido,endereco,bairro,cidade,uf,cep,telefone_primario,telefone_secundario,celular,complemento,email,cpf,cnpj,observacoes) values ('" + cadastro_cliente_nome_completo.Text + "','" + cadastro_cliente_tipo.Text + "','" + cadastro_cliente_nome_apelido.Text + "','" + cadastro_cliente_endereco.Text + "','" + cadastro_cliente_bairro.Text + "','" + cadastro_cliente_cidade.Text + "','" + cadastro_cliente_uf.Text + "','" + cadastro_cliente_cep.Text + "','" + cadastro_cliente_telefone_primario.Text + "','" + cadastro_cliente_telefone_secundario.Text + "','" + cadastro_cliente_celular.Text + "','" + cadastro_cliente_complemento.Text + "','" + cadastro_cliente_email.Text + "','" + cadastro_cliente_cpf.Text + "','" + cadastro_cliente_cnpj.Text + "','" + cadastro_cliente_observacoes.Text + "')";
                        int query_check = comando.ExecuteNonQuery();
                        connection.Close();
                        if (query_check == 0)
                        {
                            MessageBox.Show("Falha ao cadastrar cliente, por favor reinicie a aplicação e tente novamente.","Erro ao cadastrar Cliente",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Cadastro de cliente realizado com sucesso.", "Cadastro concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            this.Close();

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Falha ao cadastrar cliente, por favor reinicie a aplicação e tente novamente.", "Erro ao cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }
    }
}
