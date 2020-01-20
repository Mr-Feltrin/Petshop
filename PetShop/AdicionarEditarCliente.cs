using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private readonly bool Operacao; // Valor true == Adicionar , False == Editar
        private readonly int IdCliente;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;

        public AdicionarEditarCliente(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }

        public AdicionarEditarCliente(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, string idCliente) :this(operacao, pesquisaClientesFornecedores)
        {
            IdCliente = int.Parse(idCliente);
        }

        // ======================== Inicio de eventos de click em campos do tipo maskedtextbox ========================
        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cep.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                telefonePrimario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                telefoneSecundario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                celular.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cpf.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                cnpj.SelectionStart = 0;
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
            if (string.IsNullOrWhiteSpace(nomeCompleto.Text))
            {
                MessageBox.Show("Preencha o campo de Nome / Razão Social", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(tipo.Text))
            {
                MessageBox.Show("Selecione o tipo de cliente", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(endereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Selecione o campo UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cep.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CEP", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!telefonePrimario.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de 1° Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CPF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsereAtualizaCliente();
            }
        }

        private void InsereAtualizaCliente() // Passar para controller
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
                        comando.CommandText = $"UPDATE cliente SET nome_completo = @nome_completo, tipo = @tipo, nome_apelido = @nome_apelido, endereco = @endereco, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, telefone_primario = @telefone_primario, telefone_secundario = @telefone_secundario, celular = @celular, complemento = , email = @email, cpf = @cpf, cnpj = @cnpj, observacoes = @observacoes WHERE id = @id";
                    }
                    comando.Parameters.AddWithValue("@id", IdCliente);
                    comando.Parameters.AddWithValue("@nome_completo", nomeCompleto.Text);
                    comando.Parameters.AddWithValue("@tipo", tipo.Text);
                    comando.Parameters.AddWithValue("@nome_apelido", nomeApelido.Text);
                    comando.Parameters.AddWithValue("@endereco", endereco.Text);
                    comando.Parameters.AddWithValue("@bairro", bairro.Text);
                    comando.Parameters.AddWithValue("@cidade", cidade.Text);
                    comando.Parameters.AddWithValue("@uf", uf.Text);
                    comando.Parameters.AddWithValue("@cep", cep.Text);
                    comando.Parameters.AddWithValue("@telefone_primario", telefonePrimario.Text);
                    comando.Parameters.AddWithValue("@telefone_secundario", telefoneSecundario.Text);
                    comando.Parameters.AddWithValue("@celular", celular.Text);
                    comando.Parameters.AddWithValue("@complemento", complemento.Text);
                    comando.Parameters.AddWithValue("@email", email.Text);
                    comando.Parameters.AddWithValue("@cpf", cpf.Text);
                    comando.Parameters.AddWithValue("@cnpj", cnpj.Text);
                    comando.Parameters.AddWithValue("@observacoes", observacoes.Text);
                    int query_check = comando.ExecuteNonQuery();
                    if (query_check != 0)
                    {
                        MessageBox.Show("Os dados do cliente foram salvos.", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _PesquisaClientesFornecedores.ExibirDadosLista("SELECT * FROM cliente");
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

        private void AdicionarEditarCliente_Load(object sender, EventArgs e) // Passar para controller
        {
            if (Operacao == true)
            {
                BtnAdicionar.Text = "Adicionar";
                Text = "Adicionar Cliente";
            }
            else
            {
                BtnAdicionar.Text = "Atualizar";
                Text = "Editar Cliente";
                using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand comando = conn.CreateCommand();
                        comando.CommandText = "SELECT * FROM cliente WHERE id = @id";
                        comando.Parameters.AddWithValue("@id", IdCliente);
                        MySqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            nomeCompleto.Text = reader.GetString("nome_completo");
                            tipo.SelectedItem = reader.GetString("tipo");
                            nomeApelido.Text = reader.GetString("nome_apelido");
                            endereco.Text = reader.GetString("endereco");
                            bairro.Text = reader.GetString("bairro");
                            cidade.Text = reader.GetString("cidade");
                            uf.SelectedItem = reader.GetString("uf");
                            cep.Text = reader.GetString("cep");
                            telefonePrimario.Text = reader.GetString("telefone_primario");
                            telefoneSecundario.Text = reader.GetString("telefone_secundario");
                            celular.Text = reader.GetString("celular");
                            complemento.Text = reader.GetString("complemento");
                            email.Text = reader.GetString("email");
                            cpf.Text = reader.GetString("cpf");
                            cnpj.Text = reader.GetString("cnpj");
                            observacoes.Text = reader.GetString("observacoes");
                        }
                        else
                        {
                            MessageBox.Show("O cliente a ser editado não se encontra mais na base de dados.", "Erro ao identificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Falha ao editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
