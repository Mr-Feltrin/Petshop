using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarFornecedor : Form
    {
        private readonly TipoOperacao Operacao;
        private Fornecedor _Fornecedor { get; set; }
        private List<MaskedTextBox> CamposOpcionais { get; set; }
        private Dictionary<object, string> CamposObrigatorios { get; set; }

        public AdicionarEditarFornecedor(TipoOperacao operacao)
        {
            InitializeComponent();
            Operacao = operacao;
        }
        public AdicionarEditarFornecedor(TipoOperacao operacao, int idFornecedor) : this(operacao)
        {
            _Fornecedor = new Fornecedor(idFornecedor);
        }
        private void AdicionarEditarFornecedor_Load(object sender, EventArgs e)
        {
            CamposOpcionais = new List<MaskedTextBox>() { txtCep, txtCelular, txtCnpj };
            CamposObrigatorios = new Dictionary<object, string>()
            {
                {txtNomeFornecedor, "Preencha o Nome do Fornecedor"},
                {txtTipoFornecimento, "Preencha o Tipo de Fornecimento"},
                {txtEndereco, "Preencha o campo de Endereço"},
                {txtBairro, "Preencha o campo de Bairro"},
                {txtCidade, "Preencha o campo de Cidade"},
                {CombBoxUf, "Selecione o Estado"},
                {txtTelefone, "Preencha o campo de Telefone"},
                {txtCpf, "Preencha o campo de CPF"}
            };
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar Fornecedor";
                toolTip.SetToolTip(btnAdicionarEditarFornecedor, "Preencha os Campos Obrigatórios");
            }
            else
            {
                Text = "Editar Fornecedor";
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

        private void BtnAdicionarEditarFornecedor_Click(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.LimparCamposOpcionais(CamposOpcionais);
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
            if (Application.OpenForms.OfType<PesquisaClientesFornecedores>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisaClientesFornecedores>().First().AtualizarLista();
            }
            Close();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarEditarFornecedor_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = PesquisaControlePosicaoMouse.EncontrarControleNoCursor(this);
            if (control != null && !control.Enabled)
            {
                if (!toolTip.Active)
                {
                    toolTip.Active = true;
                    toolTip.Show(toolTip.GetToolTip(control), control, control.Width / 2, control.Height / 2);
                }
            }
            else
            {
                if (toolTip.Active)
                {
                    toolTip.Active = false;
                }
            }
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtTipoFornecimento_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void CombBoxUf_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionarEditarFornecedor, CamposObrigatorios, toolTip);
        }
    }
}