using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarFornecedor : Form
    {
        private readonly TipoOperacao Operacao;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;
        private Fornecedor _Fornecedor;

        public AdicionarEditarFornecedor(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }
        public AdicionarEditarFornecedor(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, int idFornecedor) : this(operacao, pesquisaClientesFornecedores)
        {
            _Fornecedor = new Fornecedor(idFornecedor);
        }
        private void AdicionarEditarFornecedor_Load(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Adicionar";
            }
            else
            {
                Text = "Editar Fornecedor";
                BtnAdicionarEditarFornecedor.Text = "Atualizar";
                txtNomeFornecedor.Text = _Fornecedor.Nome;
                txtTipoFornecimento.Text = _Fornecedor.Tipo_Fornecimento;
                txtApelido.Text = _Fornecedor.Apelido;
                txtEndereco.Text = _Fornecedor.Endereco;
                txtBairro.Text = _Fornecedor.Bairro;
                txtCidade.Text = _Fornecedor.Cidade;
                CombBoxUf.SelectedItem = _Fornecedor.Estado;
                txtCep.Text = _Fornecedor.Cep;
                txtTelefone.Text = _Fornecedor.Telefone;
                txtCelular.Text = _Fornecedor.Celular;
                txtCnpj.Text = _Fornecedor.Cnpj;
                txtCpf.Text = _Fornecedor.Cpf;
                txtEmail.Text = _Fornecedor.Email;
                txtObservacoes.Text = _Fornecedor.Observacoes;            
            }          
        }

        public static void EmptyMaskedTextBox(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (string.IsNullOrWhiteSpace(maskedTextBox.Text))
            {
                maskedTextBox.SelectionStart = 0;
            }
            maskedTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        private void VerificaCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNomeFornecedor.Text))
            {
                MessageBox.Show("Preencha o campo de Nome do Fornecedor", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtTipoFornecimento.Text))
            {
                MessageBox.Show("Preencha o campo de Tipo de Fornecimento", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Preencha o campo de Nome da Rua / AV.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Preencha o campo de Bairro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Preencha o campo de Cidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(CombBoxUf.Text))
            {
                MessageBox.Show("Selecione o campo de UF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de Telefone", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txtCpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o campo de CPF", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<MaskedTextBox> CamposOpcionais = new List<MaskedTextBox>() { txtCep, txtCelular, txtCnpj };
                foreach (MaskedTextBox campo in CamposOpcionais)
                {
                    if (!campo.MaskFull)
                    {
                        campo.Clear();
                        campo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    }
                }
                if (Operacao == TipoOperacao.Adicionar)
                {
                    _Fornecedor = new Fornecedor(txtNomeFornecedor.Text, txtTipoFornecimento.Text, txtApelido.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, CombBoxUf.Text, txtCep.Text, txtTelefone.Text, txtCelular.Text, txtCnpj.Text, txtCpf.Text, txtEmail.Text, txtObservacoes.Text);
                    _Fornecedor.AdicionarEditarFornecedor(Operacao);
                }
                else
                {
                    _Fornecedor.Nome = txtNomeFornecedor.Text;
                    _Fornecedor.Tipo_Fornecimento = txtTipoFornecimento.Text;
                    _Fornecedor.Apelido = txtApelido.Text;
                    _Fornecedor.Endereco = txtEndereco.Text;
                    _Fornecedor.Bairro = txtBairro.Text;
                    _Fornecedor.Cidade = txtCidade.Text;
                    _Fornecedor.Estado = CombBoxUf.Text;
                    _Fornecedor.Cep = txtCep.Text;
                    _Fornecedor.Telefone = txtTelefone.Text;
                    _Fornecedor.Celular = txtCelular.Text;
                    _Fornecedor.Cnpj = txtCnpj.Text;
                    _Fornecedor.Cpf = txtCpf.Text;
                    _Fornecedor.Email = txtEmail.Text;
                    _Fornecedor.Observacoes = txtObservacoes.Text;
                    _Fornecedor.AdicionarEditarFornecedor(Operacao);
                }
                _PesquisaClientesFornecedores.AtualizarLista();
                Close();
            }
        }     

        private void BtnAdicionarEditarFornecedor_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void CadastroFornecedorTelefone_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtTelefone);
        }

        private void CadastroFornecedorCep_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCep);
        }

        private void CadastroFornecedorCelular_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCelular);
        }

        private void CadastroFornecedorCnpj_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCnpj);
        }

        private void CadastroFornecedorCpf_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCpf);
        }
    }
}
