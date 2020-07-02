using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using PetShop.Entities.Enums;
using PetShop.Entities;
using System.Collections.Generic;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private TipoOperacao Operacao;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;
        private Cliente _Cliente;

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, int idCliente) : this(operacao, pesquisaClientesFornecedores)
        {
            _Cliente = new Cliente(idCliente);
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
            else
            {
                List<MaskedTextBox> CamposMaskedOpcionais = new List<MaskedTextBox>() { txtTelefoneSecundario, txtCelular, txtCpf, txtCnpj };
                foreach (MaskedTextBox control in CamposMaskedOpcionais)
                {
                    if (!control.MaskCompleted)
                    {
                        control.Clear();
                        control.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    }
                }
                if (Operacao == TipoOperacao.Adicionar)
                {
                    _Cliente = new Cliente(txtNomeCompleto.Text, combBoxTipo.Text, txtApelido.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, combBoxUf.Text, txtCep.Text, txtTelefonePrimario.Text, txtTelefoneSecundario.Text, txtCelular.Text, txtComplemento.Text, txtEmail.Text, txtCpf.Text, txtCnpj.Text, observacoes.Text);
                    _Cliente.AdicionarEditarCliente(Operacao);
                }
                else
                {
                    _Cliente.NomeCliente = txtNomeCompleto.Text;
                    _Cliente.Tipo = combBoxTipo.Text;
                    _Cliente.Apelido = txtApelido.Text;
                    _Cliente.Endereco = txtEndereco.Text;
                    _Cliente.Bairro = txtBairro.Text;
                    _Cliente.Cidade = txtCidade.Text;
                    _Cliente.Uf = combBoxUf.Text;
                    _Cliente.Cep = txtCep.Text;
                    _Cliente.TelefonePrimario = txtTelefonePrimario.Text;
                    _Cliente.TelefoneSecundario = txtTelefoneSecundario.Text;
                    _Cliente.Celular = txtCelular.Text;
                    _Cliente.Complemento = txtComplemento.Text;
                    _Cliente.Email = txtEmail.Text;
                    _Cliente.Cpf = txtCpf.Text;
                    _Cliente.Cnpj = txtCnpj.Text;
                    _Cliente.Observacoes = observacoes.Text;
                    _Cliente.AdicionarEditarCliente(Operacao);
                }              
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
                txtNomeCompleto.Text = _Cliente.NomeCliente;
                combBoxTipo.SelectedItem = _Cliente.Tipo;
                txtApelido.Text = _Cliente.Apelido;
                txtEndereco.Text = _Cliente.Endereco;
                txtBairro.Text = _Cliente.Bairro;
                txtCidade.Text = _Cliente.Cidade;
                combBoxUf.SelectedItem = _Cliente.Uf;
                txtCep.Text = _Cliente.Cep;
                txtTelefonePrimario.Text = _Cliente.TelefonePrimario;
                txtTelefoneSecundario.Text = _Cliente.TelefoneSecundario;
                txtCelular.Text = _Cliente.Celular;
                txtComplemento.Text = _Cliente.Complemento;
                txtEmail.Text = _Cliente.Email;
                txtCpf.Text = _Cliente.Cpf;
                txtCnpj.Text = _Cliente.Cnpj;
                observacoes.Text = _Cliente.Observacoes;
            }
        }
    }
}
