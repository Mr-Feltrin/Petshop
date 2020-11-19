using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using PetShop.Entities.Enums;
using PetShop.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PetShop
{
    public partial class AdicionarEditarCliente : Form
    {
        private readonly TipoOperacao Operacao;
        private readonly PesquisaClientesFornecedores _PesquisaClientesFornecedores;
        private Cliente _Cliente;
        Control _currentToolTipControl;

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
            List<MaskedTextBox> CamposMaskedOpcionais = new List<MaskedTextBox>() { txtTelefoneSecundario, txtCelular, txtCpf, txtCnpj };
            foreach (MaskedTextBox control in CamposMaskedOpcionais)
            {
                if (!control.MaskFull)
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

        private void VerificaCamposObrigatorios()
        {
            List<object> camposObrigatorios = new List<object>() { txtNomeCompleto, combBoxTipo, txtEndereco, txtBairro, txtCidade, combBoxUf, txtCep, txtTelefonePrimario };
            foreach (object o in camposObrigatorios)
            {
                if (o.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrWhiteSpace((o as TextBox).Text))
                    {
                        btnAdicionar.Enabled = false;
                        switch ((o as TextBox).Name)
                        {
                            case "txtNomeCompleto":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o nome completo do cliente");
                                break;
                            case "txtEndereco":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o campo de endereço");
                                break;
                            case "txtBairro":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o campo de bairro");
                                break;
                            case "txtCidade":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o campo de cidade");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        btnAdicionar.Enabled = true;
                    }
                }
                if (o.GetType() == typeof(MaskedTextBox))
                {
                    if (!(o as MaskedTextBox).MaskCompleted)
                    {
                        btnAdicionar.Enabled = false;
                        switch ((o as MaskedTextBox).Name)
                        {
                            case "txtCep":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o campo de CEP");
                                break;
                            case "txtTelefonePrimario":
                                toolTip.SetToolTip(btnAdicionar, "Preencha o campo de Telefone Primário");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        btnAdicionar.Enabled = true;
                    }
                }
                if (o.GetType() == typeof(ComboBox))
                {
                    if ((o as ComboBox).SelectedIndex == -1)
                    {
                        btnAdicionar.Enabled = false;
                        switch ((o as ComboBox).Name)
                        {
                            case "combBoxTipo":
                                toolTip.SetToolTip(btnAdicionar, "Selecione o tipo de Cliente");
                                break;
                            case "combBoxUf":
                                toolTip.SetToolTip(btnAdicionar, "Selecione o estado do endereço");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        btnAdicionar.Enabled = true;
                    }                  
                }
            }
        }

        private void AdicionarEditarCliente_Load(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar Cliente";
                toolTip.SetToolTip(btnAdicionar, "Preencha todos os campos obrigatórios");
            }
            else
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
            Control control = GetChildAtPoint(e.Location);
            if (control != null)
            {
                if (!control.Enabled && _currentToolTipControl == null)
                {
                    toolTip.Active = true;
                    string toolTipString = toolTip.GetToolTip(control);
                    toolTip.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                    _currentToolTipControl = control;
                }
            }
            else
            {
                if (_currentToolTipControl != null)
                {
                    toolTip.Active = false;
                    _currentToolTipControl = null;
                }
            }
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void combBoxTipo_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void combBoxUf_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void txtTelefonePrimario_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void combBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void combBoxUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
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

