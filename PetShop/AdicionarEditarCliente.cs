using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PetShop.Entities.Exceptions;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private readonly TipoOperacao Operacao;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;
        private Cliente _Cliente { get; set; }
        private ListaDeClientesAnimais _listaDeCliente { get; set; }
        private Dictionary<object, string> CamposObrigatorios { get; set; }
        List<MaskedTextBox> CamposMaskedOpcionais { get; set; }

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaClientesFornecedores = pesquisaClientesFornecedores;
        }

        public AdicionarEditarCliente(TipoOperacao operacao, PesquisaClientesFornecedores pesquisaClientesFornecedores, int idCliente) : this(operacao, pesquisaClientesFornecedores)
        {
            try
            {
                _Cliente = new Cliente(idCliente);
            }
            catch (Exception ex)
            {
                ErrorLogger.CreateErrorLog(ex);
                Load += (s, e) => Close();
                return;
            }
        }

        public AdicionarEditarCliente(TipoOperacao operacao, ListaDeClientesAnimais listaDeClientes)
        {
            InitializeComponent();
            Operacao = operacao;
            _listaDeCliente = listaDeClientes;
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

        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCep);
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtTelefonePrimario);
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtTelefoneSecundario);
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCelular);
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCpf);
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            EmptyMaskedTextBox(txtCnpj);
        }

        private void cadastro_cliente_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdicionarEditarCliente_Click(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.LimparCamposOpcionais(CamposMaskedOpcionais);

            if (Operacao == TipoOperacao.Adicionar)
            {
                _Cliente = new Cliente(txtNomeCompleto.Text, combBoxTipo.Text, txtApelido.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, combBoxUf.Text, txtCep.Text, txtTelefonePrimario.Text, txtTelefoneSecundario.Text, txtCelular.Text, txtComplemento.Text, txtEmail.Text, txtCpf.Text, txtCnpj.Text, observacoes.Text);
                _Cliente.AdicionarEditarCliente(Operacao);
            }
            else if (Operacao == TipoOperacao.Editar && _PesquisaClientesFornecedores != null)
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
            if (_PesquisaClientesFornecedores != null)
            {
                _PesquisaClientesFornecedores.AtualizarLista();
            }
            if (_listaDeCliente != null)
            {
                _listaDeCliente.AtualizarLista();
            }
            Close();

        }

        private void AdicionarEditarCliente_Load(object sender, EventArgs e)
        {
            CamposObrigatorios = new Dictionary<object, string>
            {
                { txtNomeCompleto, "Preencha o nome do cliente" },
                { combBoxTipo, "Selecione o tipo de cliente" },
                { txtEndereco, "Preencha o campo de endereço" },
                { txtBairro, "Preencha o campo de bairro" },
                { txtCidade, "Preencha o campo de cidade" },
                { combBoxUf, "Selecione o estado" },
                { txtCep, "Preencha o campo de CEP" },
                { txtTelefonePrimario, "Preencha o campo de telefone" }
            };
            CamposMaskedOpcionais = new List<MaskedTextBox>() { txtTelefoneSecundario, txtCelular, txtCpf, txtCnpj };
            toolTip.SetToolTip(btnAdicionar, "Preencha todos os campos obrigatórios");
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar Cliente";
            }
            else if (Operacao == TipoOperacao.Editar)
            {
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

        private void AdicionarEditarCliente_MouseMove(object sender, MouseEventArgs e)
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

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void combBoxTipo_Click(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void combBoxUf_Click(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void txtTelefonePrimario_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void combBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void combBoxUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnAdicionar, CamposObrigatorios, toolTip);
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {
                toolTip.Active = false;
            }
        }
    }
}

