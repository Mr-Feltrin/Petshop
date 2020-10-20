using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarAnimais : Form
    {
        public Cliente cliente;
        readonly PesquisaAnimais _PesquisaAnimais;
        readonly TipoOperacao _Operacao;
        Animal animal;
        ToolTip _ToolTip = new ToolTip();
        Control _currentToolTipControl;

        public AdicionarEditarAnimais(TipoOperacao operacao, PesquisaAnimais pesquisaAnimais)
        {
            InitializeComponent();
            _Operacao = operacao;
            _PesquisaAnimais = pesquisaAnimais;
        }

        public AdicionarEditarAnimais(TipoOperacao operacao, PesquisaAnimais pesquisaAnimais, int IdAnimal) : this(operacao, pesquisaAnimais)
        {
            animal = new Animal(IdAnimal);
            cliente = new Cliente(animal.ClienteId);
        }

        private void AdicionarEditarAnimais_Load(object sender, EventArgs e)
        {          
            _ToolTip.SetToolTip(btnSalvarCadastro, "Preencha os dados de Cadastro");
            if (_Operacao == TipoOperacao.Adicionar)
            {
                txtDataRegistroAnimal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                txtDataRegistroAnimal.Text = animal.DataRegistro.ToString();
                txtNomeDonoAnimal.Text = cliente.NomeCliente;
                txtNomeAnimal.Text = animal.Nome;
                if (animal.Sexo == "Macho")
                {
                    checkSexoMacho.Checked = true;
                }
                else if (animal.Sexo == "Fêmea")
                {
                    checkSexoFemea.Checked = true;
                }
                txtEspecie.Text = animal.Especie;
                txtRaca.Text = animal.Raca;
                txtIdentificacao.Text = animal.Identificacao;
                txtFobias.Text = animal.Fobias;
                txtObservacaoComportamental.Text = animal.ObservacaoComportamental;
                txtObservacaoRotina.Text = animal.ObservacaoRotina;
                if (animal.DisponivelTosa == "Sim")
                {
                    checkDisponivelTosa.Checked = true;
                }
                if (animal.PossuiPedigree == "Sim")
                {
                    checkPossuiPedigree.Checked = true;
                }
                if (animal.Agressivo == "Sim")
                {
                    checkAgressivo.Checked = true;
                }
                if (animal.Hiperativo == "Sim")
                {
                    checkHiperativo.Checked = true;
                }
                if (animal.AntiSocial == "Sim")
                {
                    checkAntissocial.Checked = true;
                }
                if (animal.Obsessivo == "Sim")
                {
                    checkObcessivo.Checked = true;
                }
            }

            // Criação de botão de pesquisa no campo txtEspecie

            Button btnPesquisarEspecie = new Button();
            btnPesquisarEspecie.Size = new Size(25, txtEspecie.ClientSize.Height);
            btnPesquisarEspecie.Dock = DockStyle.Right;
            btnPesquisarEspecie.Cursor = Cursors.Default;
            btnPesquisarEspecie.Image = Properties.Resources.search;
            btnPesquisarEspecie.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarEspecie.FlatStyle = FlatStyle.Flat;
            btnPesquisarEspecie.ForeColor = Color.White;
            btnPesquisarEspecie.BackColor = Color.Transparent;
            btnPesquisarEspecie.FlatAppearance.BorderSize = 0;
            txtEspecie.Controls.Add(btnPesquisarEspecie);
            btnPesquisarEspecie.Click += new EventHandler(btnPesquisarEspecie_Click);
            // Criação de botão de pesquisa no campo txtRaça
            Button btnPesquisarRaca = new Button();
            btnPesquisarRaca.Size = new Size(25, txtEspecie.ClientSize.Height);
            btnPesquisarRaca.Dock = DockStyle.Right;
            btnPesquisarRaca.Cursor = Cursors.Default;
            btnPesquisarRaca.Image = Properties.Resources.search;
            btnPesquisarRaca.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarRaca.FlatStyle = FlatStyle.Flat;
            btnPesquisarRaca.ForeColor = Color.White;
            btnPesquisarRaca.BackColor = Color.Transparent;
            btnPesquisarRaca.FlatAppearance.BorderSize = 0;
            txtRaca.Controls.Add(btnPesquisarRaca);
            btnPesquisarRaca.Click += new EventHandler(btnPesquisarRaca_Click);
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisarDono_Click(object sender, EventArgs e)
        {
            ListaDeClientesAnimais listaDeClientes = new ListaDeClientesAnimais(this);
            listaDeClientes.ShowDialog();
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {                     
            if (_Operacao == TipoOperacao.Adicionar)
            {
                animal = new Animal(txtNomeAnimal.Text, checkSexoFemea.Checked ? checkSexoFemea.Text : checkSexoMacho.Text, cliente.ClienteId, txtEspecie.Text, txtRaca.Text, txtIdentificacao.Text, txtEnderecoFoto.Text, txtFobias.Text, checkDisponivelTosa.Checked ? "Sim" : "Não", checkPossuiPedigree.Checked ? "Sim" : "Não", checkAgressivo.Checked ? "Sim" : "Não", checkHiperativo.Checked ? "Sim" : "Não", checkAntissocial.Checked ? "Sim" : "Não", checkObcessivo.Checked ? "Sim" : "Não", txtObservacaoComportamental.Text, txtObservacaoRotina.Text, DateTime.Parse(txtDataRegistroAnimal.Text));
                animal.AdicionarEditarAnimal(_Operacao);
            }
            else
            {
                Text = "Editar Animal";
                animal.Nome = txtNomeAnimal.Text;
                animal.Sexo = checkSexoFemea.Checked ? checkSexoFemea.Text : checkSexoMacho.Text;
                animal.ClienteId = cliente.ClienteId;
                animal.Especie = txtEspecie.Text;
                animal.Raca = txtRaca.Text;
                animal.Identificacao = txtIdentificacao.Text;
                animal.Fotografia = txtEnderecoFoto.Text;
                animal.Fobias = txtFobias.Text;
                animal.DisponivelTosa = checkDisponivelTosa.Checked ? "Sim" : "Não";
                animal.PossuiPedigree = checkPossuiPedigree.Checked ? "Sim" : "Não";
                animal.Agressivo = checkAgressivo.Checked ? "Sim" : "Não";
                animal.Hiperativo = checkHiperativo.Checked ? "Sim" : "Não";
                animal.AntiSocial = checkAntissocial.Checked ? "Sim" : "Não";
                animal.Obsessivo = checkObcessivo.Checked ? "Sim" : "Não";
                animal.ObservacaoComportamental = txtObservacaoComportamental.Text;
                animal.ObservacaoRotina = txtObservacaoRotina.Text;
                animal.AdicionarEditarAnimal(_Operacao);
            }
            _PesquisaAnimais.AtualizarLista();
            Close();

        }

        private void btnPesquisarRaca_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarEspecie_Click(object sender, EventArgs e)
        {

        }

        private void VerificarCamposObrigatorios()
        {
            List<object> camposObrigatorios = new List<object>() { txtNomeDonoAnimal, txtNomeAnimal, txtEspecie, txtRaca };
            foreach (var t in camposObrigatorios.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    btnSalvarCadastro.Enabled = false;
                    switch (t.Name)
                    {
                        case "txtNomeDonoAnimal":
                            _ToolTip.SetToolTip(btnSalvarCadastro, "Selecione o dono do animal");
                            break;
                        case "txtNomeAnimal":
                            _ToolTip.SetToolTip(btnSalvarCadastro, "Preencha o Nome do animal");
                            break;
                        case "txtEspecie":
                            _ToolTip.SetToolTip(btnSalvarCadastro, "Preencha o campo de Espécie");
                            break;
                        case "txtRaca":
                            _ToolTip.SetToolTip(btnSalvarCadastro, "Preencha o campo de Raça");
                            break;
                    }
                    break;
                }
                else if (!checkSexoMacho.Checked && !checkSexoFemea.Checked)
                {
                    _ToolTip.SetToolTip(btnSalvarCadastro, "Selecione o Sexo do Animal");
                }
                else
                {
                    btnSalvarCadastro.Enabled = true;
                }
            }
        }

        private void checkSexoMacho_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            checkSexoFemea.Checked = false;
        }

        private void checkSexoFemea_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            checkSexoMacho.Checked = false;
        }

        private void AdicionarEditarAnimais_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = GetChildAtPoint(e.Location);
            if (control != null)
            {
                if (!control.Enabled && _currentToolTipControl == null)
                {
                    _ToolTip.Active = true;
                    string toolTipString = _ToolTip.GetToolTip(control);
                    _ToolTip.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                    _currentToolTipControl = control;
                }
            }
            else
            {
                if (_currentToolTipControl != null)
                {
                    _ToolTip.Active = false;
                    _currentToolTipControl = null;
                }
            }
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled) _ToolTip.SetToolTip((sender as Button), null);
        }

        private void btnPesquisarDono_Validated(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtNomeDonoAnimal_Enter(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void checkSexoMacho_CheckStateChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void checkSexoFemea_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtRaca_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtNomeDonoAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }
    }
}
