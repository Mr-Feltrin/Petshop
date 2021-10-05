using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PetShop.Entities.Exceptions;
using System.Runtime.InteropServices;

namespace PetShop
{
    public partial class AdicionarEditarProdutos : Form
    {
        private Dictionary<object, string> CamposObrigatorios;
        private readonly TipoOperacao _TipoOperacao;
        private Produto _Produto;
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        private Button BtnEstoqueAtualLock;
        private int EstoqueAnterior;
        private int EstoqueAtual;


        public AdicionarEditarProdutos(TipoOperacao operacao)
        {
            InitializeComponent();
            _TipoOperacao = operacao;
        }

        public AdicionarEditarProdutos(TipoOperacao operacao, int idProduto) : this(operacao)
        {
            try
            {
                _Produto = new Produto(idProduto);
            }
            catch (Exception ex)
            {
                ErrorLogger.CreateErrorLog(ex);
                Load += (s, e) => Close();
                return;
            }
        }

        private void AdicionarEditarProdutos_Load(object sender, EventArgs e)
        {
            CamposObrigatorios = new Dictionary<object, string>()
            {
                {combBoxTipoUnidade, "Selecione o tipo de unidade do produto"},
                {txtQuantidade, "Digite a quantidade do produto"},
                {txtNomeProduto, "Insira o nome do produto"},
                {CombBoxCategoria, "Insira a categoria do produto"},
                {txtEstoqueAtual, "Digite a quantidade atual no estoque"},
                {txtPrecoProduto, "Digite o preço do produto"}
            };
            combBoxMarcaProduto.DataSource = Produto.ListarMarcas();
            combBoxMarcaProduto.DisplayMember = "Marca";
            CombBoxCategoria.DataSource = Produto.ListarCategorias();
            CombBoxCategoria.DisplayMember = "Categoria";
            txtDataAtualizacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataAtualizacao.GotFocus += new EventHandler(txtDataAtualizacao_GotFocus);
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
                txtCodigo.Text = _Produto.Id.ToString();
                txtCodigoBarras.Text = _Produto.CodigoBarras;
                combBoxTipoUnidade.Text = _Produto.TipoUnidade;
                txtQuantidade.Text = _Produto.Quantidade.ToString();
                txtNomeProduto.Text = _Produto.NomeProduto;
                txtReferencia.Text = _Produto.Referencia;
                txtLocalizacao.Text = _Produto.Localizacao;
                combBoxMarcaProduto.Text = _Produto.Marca;
                CombBoxCategoria.Text = _Produto.Categoria;
                txtEstoqueMinimo.Text = _Produto.EstoqueMinimo.ToString();
                txtEstoqueAtual.Text = _Produto.EstoqueAtual.ToString();
                dateDataValidade.Value = _Produto.DataValidade;
                txtValorCusto.Text = _Produto.ValorCusto.ToString("C2", new CultureInfo("pt-BR"));
                txtPrecoProduto.Text = _Produto.ValorProduto.ToString("C2", CultureInfo.CurrentCulture);
                txtObservacoes.Text = _Produto.Observacoes;
                txtEstoqueAtual.ReadOnly = true;
                txtEstoqueAtual.BackColor = Color.FromKnownColor(KnownColor.Window);
                txtEstoqueAtual.GotFocus += new EventHandler(txtEstoqueAtual_GotFocus);
                btnAbastecer.Enabled = true;
                BtnEstoqueAtualLock = new Button();
                BtnEstoqueAtualLock.Size = new Size(25, txtEstoqueAtual.Height);
                BtnEstoqueAtualLock.Dock = DockStyle.Right;
                BtnEstoqueAtualLock.Cursor = Cursors.Default;
                BtnEstoqueAtualLock.Image = Properties.Resources.lock16x16;
                BtnEstoqueAtualLock.ImageAlign = ContentAlignment.MiddleCenter;
                BtnEstoqueAtualLock.FlatStyle = FlatStyle.Flat;
                BtnEstoqueAtualLock.ForeColor = Color.White;
                BtnEstoqueAtualLock.BackColor = Color.Transparent;
                BtnEstoqueAtualLock.FlatAppearance.BorderSize = 0;
                txtEstoqueAtual.Controls.Add(BtnEstoqueAtualLock);
                BtnEstoqueAtualLock.Click += new EventHandler(BtnEstoqueAtualLock_Click);
                EstoqueAnterior = _Produto.EstoqueAtual;
                EstoqueAtual = _Produto.EstoqueAtual;
            }
        }

        private void BtnEstoqueAtualLock_Click(object sender, EventArgs e)
        {
            if (txtEstoqueAtual.ReadOnly)
            {
                txtEstoqueAtual.ReadOnly = false;
                BtnEstoqueAtualLock.Image = Properties.Resources.unlock16x16;
                txtEstoqueAtual.GotFocus -= new EventHandler(txtEstoqueAtual_GotFocus);
            }
            else
            {
                txtEstoqueAtual.ReadOnly = true;
                BtnEstoqueAtualLock.Image = Properties.Resources.lock16x16;
                txtEstoqueAtual.GotFocus += new EventHandler(txtEstoqueAtual_GotFocus);
            }
        }

        private void txtEstoqueAtual_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtDataAtualizacao_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.IndexOf('.') < (sender as TextBox).SelectionStart && (sender as TextBox).Text.Split('.').Length > 1 && (sender as TextBox).Text.Split('.')[1].Length == 2)

            {
                e.Handled = true;
            }
        }

        private void txtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.IndexOf('.') < (sender as TextBox).SelectionStart && (sender as TextBox).Text.Split('.').Length > 1 && (sender as TextBox).Text.Split('.')[1].Length == 2)

            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            (sender as TextBox).Text = decimal.TryParse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out decimal result) ? result.ToString() : default;
        }

        private void txtPrecoProduto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", CultureInfo.CurrentCulture);
                }
            }
        }

        private void txtValorCusto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", CultureInfo.CurrentCulture);
                }
            }
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
                _Produto = new Produto(txtNomeProduto.Text, txtCodigoBarras.Text, combBoxTipoUnidade.Text, int.Parse(txtQuantidade.Text), txtReferencia.Text, txtLocalizacao.Text, combBoxMarcaProduto.Text, CombBoxCategoria.Text, int.TryParse(txtEstoqueMinimo.Text, out int minval) ? minval : default, int.TryParse(txtEstoqueAtual.Text, out int value) ? value : default, dateDataValidade.Value, decimal.TryParse(txtValorCusto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out decimal valorCusto) ? valorCusto : default, decimal.Parse(txtPrecoProduto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat), txtObservacoes.Text, DateTime.Now);
                _Produto.AdicionarEditarProduto(_TipoOperacao);
                _Produto.InserirAbastecimento(_Produto.EstoqueAtual);
            }
            else if (_TipoOperacao == TipoOperacao.Editar)
            {
                _Produto.NomeProduto = txtNomeProduto.Text;
                _Produto.CodigoBarras = txtCodigoBarras.Text;
                _Produto.TipoUnidade = combBoxTipoUnidade.Text;
                _Produto.Quantidade = int.Parse(txtQuantidade.Text);
                _Produto.Referencia = txtReferencia.Text;
                _Produto.Localizacao = txtLocalizacao.Text;
                _Produto.Marca = combBoxMarcaProduto.Text;
                _Produto.Categoria = CombBoxCategoria.Text;
                _Produto.EstoqueMinimo = int.TryParse(txtEstoqueMinimo.Text, out int estoquemin) ? estoquemin : default;
                _Produto.EstoqueAtual = int.Parse(txtEstoqueAtual.Text);
                _Produto.DataValidade = dateDataValidade.Value;
                _Produto.ValorCusto = decimal.TryParse(txtValorCusto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out decimal valorcusto) ? valorcusto : default;
                _Produto.ValorProduto = decimal.Parse(txtPrecoProduto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                _Produto.Observacoes = txtObservacoes.Text;
                _Produto.DataAtualizacao = DateTime.Now;
                _Produto.AdicionarEditarProduto(_TipoOperacao);
                if (EstoqueAnterior != EstoqueAtual)
                {
                    _Produto.InserirAbastecimento(EstoqueAtual - EstoqueAnterior);
                }
            }
            if (Application.OpenForms.OfType<PesquisarProdutos>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisarProdutos>().First().AtualizarLista();
            }
            Close();
        }

        private void txtPrecoProduto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            using (AbastecimentoProduto abastecimentoProduto = new AbastecimentoProduto(this))
            {
                abastecimentoProduto.ShowDialog(this);
                if (abastecimentoProduto.IsDisposed)
                {
                    txtEstoqueAtual.Text = EstoqueAtual.ToString();
                }
            }
        }

        public void AbastecerEstoque(int quantidade)
        {
            EstoqueAtual = int.TryParse(txtEstoqueAtual.Text, out int result) ? result + quantidade : default;
            txtEstoqueAtual.Text = EstoqueAtual.ToString();
        }

        private void txtEstoqueAtual_Validated(object sender, EventArgs e)
        {
            EstoqueAtual = int.TryParse((sender as TextBox).Text, out int result) ? result : default;
        }
    }
}
