using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using PetShop.ToolBox.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarProdutos : Form
    {
        private decimal LastValorCusto;
        private decimal LastPrecoProduto;
        private float LastEstoqueMinimo;
        private float LastEstoqueAtual;
        private Dictionary<object, string> CamposObrigatorios;
        private readonly TipoOperacao _TipoOperacao;
        private Produto _Produto;

        public AdicionarEditarProdutos(TipoOperacao operacao)
        {
            InitializeComponent();
            _TipoOperacao = operacao;
        }

        public AdicionarEditarProdutos(TipoOperacao operacao, int idProduto) : this(operacao)
        {
            _Produto = new Produto(idProduto);
        }

        private void AdicionarEditarProdutos_Load(object sender, EventArgs e)
        {
            CamposObrigatorios = new Dictionary<object, string>()
            {
                {combBoxTipoUnidade, "Selecione o tipo de unidade do produto"},
                {txtQuantidade, "Digite a quantidade do produto"},
                {txtNomeProduto, "Insira o nome do produto"},
                {CombBoxCategoria, "Insira a categoria do produto"},
                {txtEstoqueAtual, "Digite a quantidade atual no estoque"}
            };
            combBoxMarcaProduto.DataSource = Produto.ListarMarcas();
            combBoxMarcaProduto.DisplayMember = "Marca";
            CombBoxCategoria.DataSource = Produto.ListarCategorias();
            CombBoxCategoria.DisplayMember = "Categoria";
            if (_TipoOperacao == TipoOperacao.Adicionar)
            {
                toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
                Text = "Adicionar produto";
                combBoxMarcaProduto.SelectedIndex = -1;
                CombBoxCategoria.SelectedIndex = -1;
            }
            else if (_TipoOperacao == TipoOperacao.Editar)
            {
                Text = "Editar produto";
                txtCodigo.Text = _Produto.ProdutoId.ToString();
                txtCodigoBarras.Text = _Produto.CodigoBarras;
                combBoxTipoUnidade.Text = _Produto.TipoUnidade;
                txtQuantidade.Text = _Produto.Quantidade.ToString();
                txtNomeProduto.Text = _Produto.NomeProduto;
                txtReferencia.Text = _Produto.Referencia;
                txtLocalizacao.Text = _Produto.Localizacao;
                dateDataCadastro.Value = _Produto.DataCadastro;
                combBoxMarcaProduto.Text = _Produto.Marca;
                CombBoxCategoria.Text = _Produto.Categoria;
                txtEstoqueMinimo.Text = _Produto.EstoqueMinimo.ToString();
                txtEstoqueAtual.Text = _Produto.EstoqueAtual.ToString();
                dateDataValidade.Value = _Produto.DataValidade;
                txtValorCusto.Text = _Produto.ValorCusto.ToString("C2", new CultureInfo("pt-BR"));
                txtPrecoProduto.Text = _Produto.ValorProduto.ToString("C2", new CultureInfo("pt-BR"));
                txtObservacoes.Text = _Produto.Observacoes;
            }
            LastValorCusto = decimal.Parse(txtValorCusto.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("pt-BR").NumberFormat);
            LastPrecoProduto = decimal.Parse(txtPrecoProduto.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("pt-BR").NumberFormat);
            try
            {
                LastEstoqueMinimo = float.Parse(txtEstoqueMinimo.Text);
            }
            catch (FormatException)
            {
                LastEstoqueMinimo = 0.0f;
            }
            try
            {
                LastEstoqueAtual = float.Parse(txtEstoqueAtual.Text);
            }
            catch (FormatException)
            {
                LastEstoqueAtual = default;
            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValorCustoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMargemVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValorCusto_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace("R$", "");
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }

        private void CurrencyDoubleValidation(object control, ref decimal LastValor)
        {
            if (double.TryParse((control as TextBox).Text.Replace(',', '.'), out double value))
            {
                (control as TextBox).Text = value.ToString("C2", new CultureInfo("pt-BR"));
                LastValor = decimal.Parse((control as TextBox).Text, NumberStyles.Currency, new CultureInfo("pt-BR").NumberFormat);
                if ((control as TextBoxBorderColored).BorderColor == Color.Red)
                {
                    (control as TextBoxBorderColored).BorderColor = SystemColors.GrayText;
                    toolTip.SetToolTip(control as TextBoxBorderColored, null);
                }
            }
            else
            {
                (control as TextBoxBorderColored).BorderColor = Color.Red;
                toolTip.SetToolTip(control as TextBoxBorderColored, "O formato anterior não é monetário");
                (control as TextBoxBorderColored).Text = LastValor.ToString("C2", new CultureInfo("pt-BR"));
            }
        }

        private void EstoqueFloatValidation(object control, ref float LastValor)
        {
            if (float.TryParse((control as TextBox).Text, out float value))
            {
                (control as TextBox).Text = value.ToString();
                LastValor = value;
                if ((control as TextBoxBorderColored).BorderColor == Color.Red)
                {
                    (control as TextBoxBorderColored).BorderColor = SystemColors.GrayText;
                    toolTipEnabledControls.SetToolTip(control as TextBoxBorderColored, null);
                }
            }
            else
            {
                (control as TextBoxBorderColored).BorderColor = Color.Red;
                toolTipEnabledControls.SetToolTip(control as TextBoxBorderColored, "O formato anterior não é válido");
                (control as TextBoxBorderColored).Text = LastValor.ToString();
            }
        }

        private void txtPrecoProduto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CurrencyDoubleValidation(sender, ref LastPrecoProduto);
        }

        private void txtValorCusto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CurrencyDoubleValidation(sender, ref LastValorCusto);
        }

        private void AdicionarEditarProdutos_MouseMove(object sender, MouseEventArgs e)
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

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtEstoqueAtual_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void combBoxTipoUnidade_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void CombBoxCategoria_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_TipoOperacao == TipoOperacao.Adicionar)
            {
                _Produto = new Produto(txtNomeProduto.Text, txtCodigoBarras.Text, combBoxTipoUnidade.Text, int.Parse(txtQuantidade.Text), txtReferencia.Text, txtLocalizacao.Text, dateDataCadastro.Value, combBoxMarcaProduto.Text, CombBoxCategoria.Text, float.TryParse(txtEstoqueMinimo.Text, out float minval) ? minval : default, float.TryParse(txtEstoqueAtual.Text, out float value) ? value : default, dateDataValidade.Value, decimal.Parse(txtValorCusto.Text.Replace("R$", "").Replace(",", ".").Trim()), decimal.Parse(txtPrecoProduto.Text.Replace("R$", "").Replace(",", ".").Trim()), txtObservacoes.Text);
                _Produto.AdicionarEditarProduto(_TipoOperacao);
            }
            else if (_TipoOperacao == TipoOperacao.Editar)
            {
                _Produto.NomeProduto = txtNomeProduto.Text;
                _Produto.CodigoBarras = txtCodigoBarras.Text;
                _Produto.TipoUnidade = combBoxTipoUnidade.Text;
                _Produto.Quantidade = int.Parse(txtQuantidade.Text);
                _Produto.Referencia = txtReferencia.Text;
                _Produto.Localizacao = txtLocalizacao.Text;
                _Produto.DataCadastro = dateDataCadastro.Value;
                _Produto.Marca = combBoxMarcaProduto.Text;
                _Produto.Categoria = CombBoxCategoria.Text;
                _Produto.EstoqueMinimo = float.Parse(txtEstoqueMinimo.Text);
                _Produto.EstoqueAtual = float.Parse(txtEstoqueAtual.Text);
                _Produto.DataValidade = dateDataValidade.Value;
                _Produto.ValorCusto = decimal.Parse(txtValorCusto.Text.Replace("R$", "").Replace(",", ".").Trim());
                _Produto.ValorProduto = decimal.Parse(txtPrecoProduto.Text.Replace("R$", "").Replace(",", ".").Trim());
                _Produto.Observacoes = txtObservacoes.Text;
                _Produto.AdicionarEditarProduto(_TipoOperacao);
            }
            if (Application.OpenForms.OfType<PesquisaProdutos>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisaProdutos>().First().AtualizarLista();
            }
            Close();
        }

        private void txtEstoqueMinimo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EstoqueFloatValidation(sender, ref LastEstoqueMinimo);
        }

        private void txtEstoqueAtual_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EstoqueFloatValidation(sender, ref LastEstoqueAtual);
        }
    }
}
