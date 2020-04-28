using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private readonly bool Operacao; // Valor true == Adicionar , False == Editar
        private readonly Entities.Cliente IdCliente;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;

        public AdicionarEditarCliente(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }

        public AdicionarEditarCliente(bool operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, string idCliente) : this(operacao, pesquisaClientesFornecedores)
        {
            
        }

        // ======================== Inicio de eventos de click em campos do tipo maskedtextbox ========================
        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtCep.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtTelefonePrimario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtTelefoneSecundario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtCelular.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtCpf.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                txtCnpj.SelectionStart = 0;
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
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Preencha o campo de Nome / Razão Social", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(combBoxTipo.Text))
            {
                MessageBox.Show("Selecione o tipo de cliente", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Preencha o campo de Bairro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Preencha o campo de Cidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(combBoxUf.Text))
            {
                MessageBox.Show("Selecione o campo UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtCep.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CEP", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtTelefonePrimario.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de 1° Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtCpf.MaskCompleted)
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
            using (SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Clientes (Nome, Tipo, Apelido, Endereco, Bairro, Cidade, Estado, Cep, Telefone_Principal, Telefone_Secundario, Celular, Complemento, Email, Cpf, Cnpj, Observacoes) VALUES (@Nome, @Tipo, @Apelido, @Endereco, @Bairro, @Cidade, @Estado, @Cep, @Telefone_Principal, @Telefone_Secundario, @Celular, @Complemento, @Email, @Cpf, @Cnpj, @Observacoes)";
                    cmd.Parameters.AddWithValue("@Nome", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@Tipo", combBoxTipo.Text);
                    cmd.Parameters.AddWithValue("@Apelido", txtApelido.Text);
                    cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@Estado", combBoxUf.Text);
                    cmd.Parameters.AddWithValue("@Cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@Telefone_Principal", txtTelefonePrimario.Text);
                    cmd.Parameters.AddWithValue("@Telefone_Secundario", txtTelefoneSecundario.Text);
                    cmd.Parameters.AddWithValue("@Celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@Cnpj", txtCnpj.Text);
                    cmd.Parameters.AddWithValue("@Observacoes", observacoes.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados do Cliente foram salvos.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("Erro ao salvar as informações do Cliente: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
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
            }
        }
    }
}
