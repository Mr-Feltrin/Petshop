using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using PetShop.Entities.Enums;
using PetShop.Entities;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private TipoOperacao Operacao;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, string idCliente) : this(operacao, pesquisaClientesFornecedores)
        {
            
        }

        // ======================== Inicio de eventos de click em campos do tipo maskedtextbox ========================

        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtCep.MaskCompleted)
            {
                txtCep.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtTelefonePrimario.MaskCompleted)
            {
                txtTelefonePrimario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtTelefoneSecundario.MaskCompleted)
            {
                txtTelefoneSecundario.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtCelular.MaskCompleted)
            {
                txtCelular.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtCpf.MaskCompleted)
            {
                txtCpf.SelectionStart = 0;
            }
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar && !txtCnpj.MaskCompleted)
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
                Cliente cliente = new Cliente(txtNomeCompleto.Text, combBoxTipo.Text, txtApelido.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, combBoxUf.Text, txtCep.Text, txtTelefonePrimario.Text, txtTelefoneSecundario.Text, txtCelular.Text, txtComplemento.Text, txtEmail.Text, txtCpf.Text, txtCnpj.Text, observacoes.Text);
                cliente.AdicionarCliente();
                Close();
                _PesquisaClientesFornecedores.AtualizarLista();
            }
        }
    
        private void AdicionarEditarCliente_Load(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar)
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
