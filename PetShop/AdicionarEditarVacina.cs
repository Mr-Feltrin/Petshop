using System;
using System.Windows.Forms;
using PetShop.Entities.Enums;
using PetShop.Entities;
using System.Collections.Generic;
using PetShop.ToolBox;
using System.Linq;

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
                {txtQuantidadeEstoque, "Insira a quantidade atual no estoque"}
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
                _Vacina = new Vacina(CombBoxImunologia.Text, int.Parse(txtDoses.Text), int.Parse(txtConteudoML.Text), txtLote.Text, txtFabricante.Text, DateDataValidade.Value, dateDataCadastro.Value);
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
                _Vacina.AdicionarEditarVacina(Operacao);
            }
            if (Application.OpenForms.OfType<PesquisarVacinas>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisarVacinas>().First().AtualizarLista();
            }
            Close();
        }
    }
}
