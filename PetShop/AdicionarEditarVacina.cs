using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarVacina : Form
    {
        private readonly TipoOperacao Operacao;
        private Vacina _Vacina { get; set; }
        private Dictionary<object, string> CamposObrigatorios;

        public AdicionarEditarVacina(TipoOperacao operacao)
        {
            InitializeComponent();
            Operacao = operacao;
        }

        public AdicionarEditarVacina(TipoOperacao operacao, int idVacina) : this(operacao)
        {
            _Vacina = new Vacina(idVacina);
        }

        private void AdicionarEditarVacina_Load(object sender, EventArgs e)
        {
            CamposObrigatorios = new Dictionary<object, string>()
            {
                {CombBoxImunologia, "Selecione o tipo de Imunologia"},
                {txtConteudoML, "Digite o conteúdo da vacina"},
                {txtDoses, "Digite a quantidade de doses da vacina"},
                {txtLote, "Digite o lote da vacina"},
                {txtFabricante, "Digite o nome do fabricante"},
                {txtQuantidadeEstoque, "Insira a quantidade atual no estoque"},
                { txtValorCusto, "Insira o valor de custo da Vacina" },
                { txtValorProduto, "Insira o valor de venda da Vacina" }
            };
            CombBoxImunologia.DataSource = Vacina.ListarImunologia();
            CombBoxImunologia.DisplayMember = "Imunologia";
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar vacina";
                CombBoxImunologia.SelectedIndex = -1;
                toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
            }
            else
            {
                Text = "Editar vacina";
                dateDataCadastro.Value = _Vacina.DataCadastro;
                CombBoxImunologia.Text = _Vacina.Imunologia;
                txtConteudoML.Text = _Vacina.ConteudoML.ToString();
                txtDoses.Text = _Vacina.Doses.ToString();
                txtLote.Text = _Vacina.Lote;
                txtFabricante.Text = _Vacina.Fabricante;
                DateDataValidade.Value = _Vacina.DataValidade;
                txtQuantidadeEstoque.Text = _Vacina.Quantidade.ToString();
                txtValorCusto.Text = _Vacina.ValorMercado.ToString("C2", new CultureInfo("pt-BR"));
                txtValorProduto.Text = _Vacina.ValorProduto.ToString("C2", new CultureInfo("pt-BR"));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConteudoML_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidadeEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AdicionarEditarVacina_MouseMove(object sender, MouseEventArgs e)
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

        private void CombBoxImunologia_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtConteudoML_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtDoses_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtQuantidadeEstoque_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Operacao == TipoOperacao.Adicionar)
            {
                _Vacina = new Vacina(CombBoxImunologia.Text, int.Parse(txtDoses.Text), int.Parse(txtConteudoML.Text), txtLote.Text, txtFabricante.Text, DateDataValidade.Value, dateDataCadastro.Value, int.Parse(txtQuantidadeEstoque.Text), decimal.Parse(txtValorCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim()), decimal.Parse(txtValorProduto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim()));
                _Vacina.AdicionarEditarVacina(Operacao);
            }
            else
            {
                _Vacina.DataCadastro = dateDataCadastro.Value;
                _Vacina.Imunologia = CombBoxImunologia.Text;
                _Vacina.ConteudoML = int.Parse(txtConteudoML.Text);
                _Vacina.Doses = int.Parse(txtDoses.Text);
                _Vacina.Lote = txtLote.Text;
                _Vacina.Fabricante = txtFabricante.Text;
                _Vacina.DataValidade = DateDataValidade.Value;
                _Vacina.Quantidade = int.Parse(txtQuantidadeEstoque.Text);
                _Vacina.ValorMercado = decimal.Parse(txtValorCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim());
                _Vacina.ValorProduto = decimal.Parse(txtValorProduto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim());
                _Vacina.AdicionarEditarVacina(Operacao);
            }
            if (Application.OpenForms.OfType<PesquisarVacinas>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisarVacinas>().First().AtualizarLista();
            }
            Close();
        }

        private void txtValorCusto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorCusto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text.Replace(",", ".")), 2).ToString("C2", new CultureInfo("pt-BR"));
                }
            }
        }

        private void txtValorProduto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", new CultureInfo("pt-BR"));
                }
            }
        }

        private void txtValorProduto_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
        }

        private void txtValorCusto_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
        }

        private void txtValorCusto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }

        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, toolTip);
        }
    }
}