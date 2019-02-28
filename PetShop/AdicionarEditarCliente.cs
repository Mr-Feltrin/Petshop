using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private bool Operacao { get; set; }
        private string IdCliente { get; set; }


        public AdicionarEditarCliente(bool operacao)
        {
            InitializeComponent();
            Operacao = operacao;
        }

        public AdicionarEditarCliente(bool operacao, string idCliente, string nomeCompleto, string tipoCliente, string nomeApelido, string enderecoCliente, string bairroCliente, string cidadeCliente, string ufCliente, string cepCliente, string telefonePrimarioCliente, string telefoneSecundarioCliente, string celularCliente, string complementoCliente, string emailCliente, string cpfCliente, string cnpjCliente, string observacoesClientes) : this(operacao)
        {
            IdCliente = idCliente;
            cadastro_cliente_nome_completo.Text = nomeCompleto;
            cadastro_cliente_tipo.SelectedIndex = cadastro_cliente_tipo.FindString(tipoCliente);
            cadastro_cliente_nome_apelido.Text = nomeApelido;
            cadastro_cliente_endereco.Text = enderecoCliente;
            cadastro_cliente_bairro.Text = bairroCliente;
            cadastro_cliente_cidade.Text = cidadeCliente;
            cadastro_cliente_uf.SelectedIndex = cadastro_cliente_uf.FindString(ufCliente);
            cadastro_cliente_cep.Text = cepCliente;
            cadastro_cliente_telefone_primario.Text = telefonePrimarioCliente;
            cadastro_cliente_telefone_secundario.Text = telefoneSecundarioCliente;
            cadastro_cliente_celular.Text = celularCliente;
            cadastro_cliente_complemento.Text = complementoCliente;
            cadastro_cliente_email.Text = emailCliente;
            cadastro_cliente_cpf.Text = cpfCliente;
            cadastro_cliente_cnpj.Text = cnpjCliente;
            cadastro_cliente_observacoes.Text = observacoesClientes;
        }

        // ======================== Inicio de eventos de click em campos do tipo maskedtextbox ========================

        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_cep.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_telefone_primario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_telefone_secundario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_celular.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_cpf.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cadastro_cliente_cnpj.SelectionStart = 0;
            }
        }

        // ======================== Termino de eventos de click em campos do tipo maskedtextbox ========================

        private void cadastro_cliente_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdicionarEditarCliente_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void VerificaCamposObrigatorios()
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
                InsereAtualizaCliente();
            }
        }


        private void InsereAtualizaCliente()
        {
            // Conexão com banco de dados e execução da Query
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    if (Operacao == true)
                    {
                        comando.CommandText = "INSERT INTO cliente (nome_completo,tipo,nome_apelido,endereco,bairro,cidade,uf,cep,telefone_primario,telefone_secundario,celular,complemento,email,cpf,cnpj,observacoes) VALUES (@nome_completo,@tipo,@nome_apelido,@endereco,@bairro,@cidade,@uf,@cep,@telefone_primario,@telefone_secundario,@celular,@complemento,@email,@cpf,@cnpj,@observacoes)";
                    }
                    else if (Operacao == false)
                    {
                        comando.CommandText = "UPDATE cliente SET nome_completo = @nome_completo, tipo = @tipo, nome_apelido = @nome_apelido, endereco = @endereco, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, telefone_primario = @telefone_primario, telefone_secundario = @telefone_secundario, celular = @celular, complemento = @complemento, email = @email, cpf = @cpf, cnpj = @cnpj, observacoes = @observacoes WHERE id = @id";
                    }
                    comando.Parameters.AddWithValue("@id", IdCliente);
                    comando.Parameters.AddWithValue("@nome_completo", cadastro_cliente_nome_completo.Text.ToUpper());
                    comando.Parameters.AddWithValue("@tipo", cadastro_cliente_tipo.Text);
                    comando.Parameters.AddWithValue("@nome_apelido", cadastro_cliente_nome_apelido.Text.ToUpper());
                    comando.Parameters.AddWithValue("@endereco", cadastro_cliente_endereco.Text);
                    comando.Parameters.AddWithValue("@bairro", cadastro_cliente_bairro.Text);
                    comando.Parameters.AddWithValue("@cidade", cadastro_cliente_cidade.Text);
                    comando.Parameters.AddWithValue("@uf", cadastro_cliente_uf.Text);
                    comando.Parameters.AddWithValue("@cep", cadastro_cliente_cep.Text);
                    comando.Parameters.AddWithValue("@telefone_primario", cadastro_cliente_telefone_primario.Text);
                    comando.Parameters.AddWithValue("@telefone_secundario", cadastro_cliente_telefone_secundario.Text);
                    comando.Parameters.AddWithValue("@celular", cadastro_cliente_celular.Text);
                    comando.Parameters.AddWithValue("@complemento", cadastro_cliente_complemento.Text);
                    comando.Parameters.AddWithValue("@email", cadastro_cliente_email.Text);
                    comando.Parameters.AddWithValue("@cpf", cadastro_cliente_cpf.Text);
                    comando.Parameters.AddWithValue("@cnpj", cadastro_cliente_cnpj.Text);
                    comando.Parameters.AddWithValue("@observacoes", cadastro_cliente_observacoes.Text);
                    int query_check = comando.ExecuteNonQuery();
                    if (query_check != 0)
                    {
                        MessageBox.Show("Os dados do cliente foram salvos.", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as informações do cliente: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Close();
                }
            }
        }

        private void AdicionarEditarCliente_Load(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                BtnAdicionarEditarCliente.Text = "Adicionar";
                Text = "Adicionar Cliente";
            }
            else
            {
                BtnAdicionarEditarCliente.Text = "Atualizar";
                Text = "Editar Cliente";
            }
        }
    }
}
