using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{    
    public partial class AdicionarEditarFornecedor : Form
    {
        private readonly bool Operacao; // Valor true = Adicionar, false = Editar
        private readonly string IdFornecedor;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;
        public AdicionarEditarFornecedor(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }
        public AdicionarEditarFornecedor(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, string idFornecedor, string nomeFornecedor, string tipoFornecimento, string apelidoFornecedor, string enderecoFornecedor, string bairroFornecedor, string cidadeFornecedor, string ufFornecedor, string cepFornecedor, string telefoneFornecedor, string celularfornecedor, string emailFornecedor, string cpfFornecedor, string cnpjFornecedor, string observacoesFornecedor) : this(operacao, pesquisaClientesFornecedores)
        {
            IdFornecedor = idFornecedor;
            CadastroFornecedorNome.Text = nomeFornecedor;
            CadastroFornecedorTipoFornecimento.Text = tipoFornecimento;
            CadastroFornecedorApelido.Text = apelidoFornecedor;
            CadastroFornecedorEndereco.Text = enderecoFornecedor;
            CadastroFornecedorBairro.Text = bairroFornecedor;
            CadastroFornecedorCidade.Text = cidadeFornecedor;
            CadastroFornecedorUf.Text = ufFornecedor;
            CadastroFornecedorCep.Text = cepFornecedor;
            CadastroFornecedorTelefone.Text = telefoneFornecedor;
            CadastroFornecedorCelular.Text = celularfornecedor;
            CadastroFornecedorEmail.Text = emailFornecedor;
            CadastroFornecedorCpf.Text = cpfFornecedor;
            CadastroFornecedorCnpj.Text = cnpjFornecedor;
            CadastroFornecedorObservacoes.Text = observacoesFornecedor;
        }
        private void AdicionarEditarFornecedor_Load(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                Text = "Adicionar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Adicionar";
            }
            else
            {
                Text = "Editar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Atualizar";
            }
        }
        private void VerificaCamposObrigatórios()
        {
            if (string.IsNullOrWhiteSpace(CadastroFornecedorNome.Text))
            {
                MessageBox.Show("Preencha o campo de Nome do Fornecedor", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(CadastroFornecedorTipoFornecimento.Text))
            {
                MessageBox.Show("Preencha o campo de Tipo de Fornecimento", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(CadastroFornecedorEndereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(CadastroFornecedorBairro.Text))
            {
                MessageBox.Show("Preencha o campo de Bairro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(CadastroFornecedorCidade.Text))
            {
                MessageBox.Show("Preencha o campo de Cidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(CadastroFornecedorUf.Text))
            {
                MessageBox.Show("Selecione o campo de UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CadastroFornecedorTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CadastroFornecedorCpf.MaskCompleted)
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
                    if (Operacao == true)
                    {
                        comando.CommandText = "INSERT INTO fornecedor (nome_fornecedor, tipo_fornecimento, apelido_fornecedor, endereco, bairro, cidade, uf, cep, telefone, celular, email, cpf, cnpj, observacoes) VALUES (@nome_fornecedor, @tipo_fornecimento, @apelido_fornecedor, @endereco, @bairro, @cidade, @uf, @cep, @telefone, @celular, @email, @cpf, @cnpj, @observacoes)";
                    }
                    else if (Operacao == false)
                    {
                        comando.CommandText = "UPDATE fornecedor SET nome_fornecedor = @nome_fornecedor, tipo_fornecimento = @tipo_fornecimento, apelido_fornecedor = @apelido_fornecedor, endereco = @endereco, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, telefone = @telefone, celular = @celular, email = @email, cpf = @cpf, cnpj = @cnpj, observacoes = @observacoes WHERE id = @id";
                        comando.Parameters.AddWithValue("@id", IdFornecedor);
                    }
                    comando.Parameters.AddWithValue("@nome_fornecedor", CadastroFornecedorNome.Text);
                    comando.Parameters.AddWithValue("@tipo_fornecimento", CadastroFornecedorTipoFornecimento.Text);
                    comando.Parameters.AddWithValue("@apelido_fornecedor", CadastroFornecedorApelido.Text);
                    comando.Parameters.AddWithValue("@endereco", CadastroFornecedorEndereco.Text);
                    comando.Parameters.AddWithValue("@bairro", CadastroFornecedorBairro.Text);
                    comando.Parameters.AddWithValue("@cidade", CadastroFornecedorCidade.Text);
                    comando.Parameters.AddWithValue("@uf", CadastroFornecedorUf.Text);
                    comando.Parameters.AddWithValue("@cep", CadastroFornecedorCep.Text);
                    comando.Parameters.AddWithValue("@telefone", CadastroFornecedorTelefone.Text);
                    comando.Parameters.AddWithValue("@celular", CadastroFornecedorCelular.Text);
                    comando.Parameters.AddWithValue("@email", CadastroFornecedorEmail.Text);
                    comando.Parameters.AddWithValue("@cpf", CadastroFornecedorCpf.Text);
                    comando.Parameters.AddWithValue("@cnpj", CadastroFornecedorCnpj.Text);
                    comando.Parameters.AddWithValue("@observacoes", CadastroFornecedorObservacoes.Text);
                    int query_check = comando.ExecuteNonQuery();
                    if (query_check != 0)
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
            VerificaCamposObrigatórios();
        }

        private void CadastroFornecedorTelefone_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                CadastroFornecedorTelefone.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCep_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                CadastroFornecedorCep.SelectionStart = 0;
            }
        }

        private void CadastroFornecedorCelular_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                CadastroFornecedorCelular.SelectionStart = 0;
            }          
        }

        private void CadastroFornecedorCnpj_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                CadastroFornecedorCnpj.SelectionStart = 0;
            }       
        }

        private void CadastroFornecedorCpf_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                CadastroFornecedorCpf.SelectionStart = 0;
            }          
        }
    }
}
