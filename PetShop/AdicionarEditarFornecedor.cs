using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarFornecedor : Form
    {
        private readonly bool Operacao; // Valor true = Adicionar, false = Editar
        private readonly int IdFornecedor;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;

        public AdicionarEditarFornecedor(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }
        public AdicionarEditarFornecedor(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, string idFornecedor) : this(operacao, pesquisaClientesFornecedores)
        {
            IdFornecedor = int.Parse(idFornecedor);
        }
        private void AdicionarEditarFornecedor_Load(object sender, EventArgs e)
        {
            if (Operacao)
            {
                Text = "Adicionar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Adicionar";
            }
            else
            {
                Text = "Editar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Atualizar";
                using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand comando = conn.CreateCommand();
                        comando.CommandText = "SELECT * FROM fornecedor WHERE id = @id";
                        comando.Parameters.AddWithValue("@id", IdFornecedor);
                        MySqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            nomeCompleto.Text = reader.GetString("nome_fornecedor");
                            tipoFornecimento.Text = reader.GetString("tipo_fornecimento");
                            apelido.Text = reader.GetString("apelido_fornecedor");
                            endereco.Text = reader.GetString("endereco");
                            bairro.Text = reader.GetString("bairro");
                            cidade.Text = reader.GetString("cidade");
                            uf.SelectedItem = reader.GetString("uf");
                            cep.Text = reader.GetString("cep");
                            telefone.Text = reader.GetString("telefone");
                            celular.Text = reader.GetString("celular");
                            email.Text = reader.GetString("email");
                            cpf.Text = reader.GetString("cpf");
                            cnpj.Text = reader.GetString("cnpj");
                            observacoes.Text = reader.GetString("observacoes");
                        }
                        else
                        {
                            MessageBox.Show("O fornecedor a ser editado não se encontra mais na base de dados.", "Erro ao identificar Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Falha ao editar Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        private void VerificaCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(nomeCompleto.Text))
            {
                MessageBox.Show("Preencha o campo de Nome do Fornecedor", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(tipoFornecimento.Text))
            {
                MessageBox.Show("Preencha o campo de Tipo de Fornecimento", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(endereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(bairro.Text))
            {
                MessageBox.Show("Preencha o campo de Bairro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(cidade.Text))
            {
                MessageBox.Show("Preencha o campo de Cidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(uf.Text))
            {
                MessageBox.Show("Selecione o campo de UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!telefone.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CPF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsereAtualizaFornecedor();
            }
        }
        private void InsereAtualizaFornecedor()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    if (Operacao)
                    {
                        comando.CommandText = "INSERT INTO fornecedor (nome_fornecedor, tipo_fornecimento, apelido_fornecedor, endereco, bairro, cidade, uf, cep, telefone, celular, email, cpf, cnpj, observacoes) VALUES (@nome_fornecedor, @tipo_fornecimento, @apelido_fornecedor, @endereco, @bairro, @cidade, @uf, @cep, @telefone, @celular, @email, @cpf, @cnpj, @observacoes)";
                    }
                    else
                    {
                        comando.CommandText = "UPDATE fornecedor SET nome_fornecedor = @nome_fornecedor, tipo_fornecimento = @tipo_fornecimento, apelido_fornecedor = @apelido_fornecedor, endereco = @endereco, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, telefone = @telefone, celular = @celular, email = @email, cpf = @cpf, cnpj = @cnpj, observacoes = @observacoes WHERE id = @id";
                        comando.Parameters.AddWithValue("@id", IdFornecedor);
                    }
                    comando.Parameters.AddWithValue("@nome_fornecedor", nomeCompleto.Text);
                    comando.Parameters.AddWithValue("@tipo_fornecimento", tipoFornecimento.Text);
                    comando.Parameters.AddWithValue("@apelido_fornecedor", apelido.Text);
                    comando.Parameters.AddWithValue("@endereco", endereco.Text);
                    comando.Parameters.AddWithValue("@bairro", bairro.Text);
                    comando.Parameters.AddWithValue("@cidade", cidade.Text);
                    comando.Parameters.AddWithValue("@uf", uf.Text);
                    comando.Parameters.AddWithValue("@cep", cep.Text);
                    comando.Parameters.AddWithValue("@telefone", telefone.Text);
                    comando.Parameters.AddWithValue("@celular", celular.Text);
                    comando.Parameters.AddWithValue("@email", email.Text);
                    comando.Parameters.AddWithValue("@cpf", cpf.Text);
                    comando.Parameters.AddWithValue("@cnpj", cnpj.Text);
                    comando.Parameters.AddWithValue("@observacoes", observacoes.Text);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Os dados do fornecedor foram salvos.", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _PesquisaClientesFornecedores.ExibirDadosLista("SELECT * FROM fornecedor");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as informações do Fornecedor: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Close();
                }
            }
        }

        private void BtnAdicionarEditarFornecedor_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void CadastroFornecedorTelefone_Click(object sender, EventArgs e)
        {
            if (Operacao)
            {
                telefone.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCep_Click(object sender, EventArgs e)
        {
            if (Operacao)
            {
                cep.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCelular_Click(object sender, EventArgs e)
        {
            if (Operacao)
            {
                celular.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCnpj_Click(object sender, EventArgs e)
        {
            if (Operacao)
            {
                cnpj.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCpf_Click(object sender, EventArgs e)
        {
            if (Operacao)
            {
                cpf.SelectionStart = 0;
            }
        }
    }
}
