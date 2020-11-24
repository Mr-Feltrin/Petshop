using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PetShop.ToolBox;

namespace PetShop
{
    public partial class AdicionarEditarAnimais : Form
    {
        public Cliente cliente;
        readonly PesquisaAnimais _PesquisaAnimais;
        readonly TipoOperacao _Operacao;
        Animal animal;
        ToolTip _ToolTip = new ToolTip();
        List<Image> Fotografias = new List<Image>();
        Dictionary<object, string> CamposObrigatorios;
        CheckBox SexoSelecionado = new CheckBox();

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
            tabPage1.MouseMove += AdicionarEditarAnimais_MouseMove;
            tabControl1.MouseMove += AdicionarEditarAnimais_MouseMove;
            CamposObrigatorios = new Dictionary<object, string>()
            {
                { txtNomeDonoAnimal, "Selecione o dono do animal" },
                { txtNomeAnimal, "Digite o nome do animal" },
                { txtEspecie, "Preencha o campo de espécie" },
                { txtRaca, "Preencha o campo de Raça" },
                { SexoSelecionado, "Selecione o sexo do animal" }
            };
            _ToolTip.SetToolTip(btnSalvarCadastro, "Preencha os dados de Cadastro");
            _ToolTip.SetToolTip(btnAdicionarFoto, "Numero máximo de fotos atingido (3)");
            if (_Operacao == TipoOperacao.Adicionar)
            {
                txtDataRegistroAnimal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                Text = "Editar Animal";
                txtDataRegistroAnimal.Text = animal.DataRegistro.ToString("dd/MM/yyyy");
                txtNomeDonoAnimal.Text = cliente.NomeCliente;
                txtNomeAnimal.Text = animal.Nome;
                if (string.Equals(animal.Sexo.Trim(), checkSexoMacho.Text))
                {
                    checkSexoMacho.Checked = true;
                }
                else if (string.Equals(animal.Sexo.Trim(), checkSexoFemea.Text))
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
            NoFocusButton btnPesquisarEspecie = new NoFocusButton();
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
            NoFocusButton btnPesquisarRaca = new NoFocusButton();
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
                animal = new Animal(txtNomeAnimal.Text, checkSexoFemea.Checked ? checkSexoFemea.Text : checkSexoMacho.Text, cliente.ClienteId, txtEspecie.Text, txtRaca.Text, txtIdentificacao.Text, txtFobias.Text, checkDisponivelTosa.Checked ? "Sim" : "Não", checkPossuiPedigree.Checked ? "Sim" : "Não", checkAgressivo.Checked ? "Sim" : "Não", checkHiperativo.Checked ? "Sim" : "Não", checkAntissocial.Checked ? "Sim" : "Não", checkObcessivo.Checked ? "Sim" : "Não", txtObservacaoComportamental.Text, txtObservacaoRotina.Text, DateTime.Parse(txtDataRegistroAnimal.Text), Fotografias[0], Fotografias[1], Fotografias[2]);
                animal.AdicionarEditarAnimal(_Operacao);
            }
            else
            {
                animal.Nome = txtNomeAnimal.Text;
                animal.Sexo = checkSexoFemea.Checked ? checkSexoFemea.Text : checkSexoMacho.Text;
                animal.ClienteId = cliente.ClienteId;
                animal.Especie = txtEspecie.Text;
                animal.Raca = txtRaca.Text;
                animal.Identificacao = txtIdentificacao.Text;
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
            ListaEspecieRacaAnimais listaRaca = new ListaEspecieRacaAnimais(TipoPesquisa.Raca, this);
            listaRaca.ShowDialog();

        }

        private void btnPesquisarEspecie_Click(object sender, EventArgs e)
        {
            ListaEspecieRacaAnimais listaEspecie = new ListaEspecieRacaAnimais(TipoPesquisa.Especie, this);
            listaEspecie.ShowDialog();
        }

        private void AdicionarEditarAnimais_MouseMove(object sender, MouseEventArgs e)
        {
            Control controle = PesquisaControlePosicaoMouse.EncontrarControleNoCursor(this);
            if (controle != null && !controle.Enabled)
            {
                if (!_ToolTip.Active)
                {
                    _ToolTip.Active = true;
                    _ToolTip.Show(_ToolTip.GetToolTip(controle), controle, controle.Width / 2, controle.Height / 2);
                }
            }
            else
            {
                if (_ToolTip.Active)
                {
                    _ToolTip.Active = false;
                }
            }
        }

        private void btnPesquisarDono_Validated(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void txtRaca_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void txtNomeDonoAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }


        private void btnSalvarCadastro_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {
                if (_ToolTip.Active)
                {
                    _ToolTip.Active = false;
                }
            }
        }

        private void ControleBotoesFotografia()
        {
            if (Fotografias.Count == 3)
            {
                btnAdicionarFoto.Enabled = false;
            }
            if (Fotografias.Count < 3)
            {
                btnAdicionarFoto.Enabled = true;
            }
            if (Fotografias.IndexOf(pictureBoxFotoAnimal.Image) >= 3 || Fotografias.Count > 0 && Fotografias.Last() == pictureBoxFotoAnimal.Image)
            {
                btnAvancarFoto.Enabled = false;
            }
            else
            {
                btnAvancarFoto.Enabled = true;
            }
            if (Fotografias.IndexOf(pictureBoxFotoAnimal.Image) <= 0)
            {
                btnVoltarFoto.Enabled = false;
            }
            else
            {
                btnVoltarFoto.Enabled = true;
            }
            if (Fotografias.Count == 0)
            {
                btnRemoverFoto.Enabled = false;
                pictureBoxFotoAnimal.Image = null;
                labelIndexFoto.Text = null;
                btnAvancarFoto.Enabled = false;
                btnVoltarFoto.Enabled = false;
            }
            else
            {
                btnRemoverFoto.Enabled = true;
            }
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            if (Fotografias.Count >= 3 == false)
            {
                using (OpenFileDialog openFile = new OpenFileDialog())
                {
                    openFile.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        Fotografias.Add(Image.FromFile(openFile.FileName));
                        pictureBoxFotoAnimal.Image = Fotografias.Last();
                        labelIndexFoto.Text = (Fotografias.IndexOf(Fotografias.Last()) + 1).ToString();
                        ControleBotoesFotografia();
                    }
                }
            }
        }

        private void checkSexoMacho_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            checkSexoFemea.Checked = false;
            SexoSelecionado.Checked = true; ;
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void checkSexoFemea_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            checkSexoMacho.Checked = false;
            SexoSelecionado.Checked = true;
            VerificarCamposObrigatorios.ChecarCampos(btnSalvarCadastro, CamposObrigatorios, _ToolTip);
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmarRemover = MessageBox.Show("Tem certeza que deseja remover esta foto?", "Remover foto", MessageBoxButtons.YesNo);
            if (ConfirmarRemover == DialogResult.Yes)
            {
                Fotografias.Remove(pictureBoxFotoAnimal.Image);
                if (Fotografias.Count > 0)
                {
                    pictureBoxFotoAnimal.Image = Fotografias.Last();
                    labelIndexFoto.Text = (Fotografias.IndexOf(Fotografias.Last()) + 1).ToString();
                }
                ControleBotoesFotografia();
            }
        }

        private void btnVoltarFoto_Click(object sender, EventArgs e)
        {
            if (Fotografias.IndexOf(pictureBoxFotoAnimal.Image) > 0)
            {
                pictureBoxFotoAnimal.Image = Fotografias[Fotografias.IndexOf(pictureBoxFotoAnimal.Image) - 1];
                labelIndexFoto.Text = (Fotografias.IndexOf(pictureBoxFotoAnimal.Image) + 1).ToString();
                ControleBotoesFotografia();
            }
        }

        private void btnAvancarFoto_Click(object sender, EventArgs e)
        {
            if (Fotografias.Count > 0 && Fotografias.Last() != pictureBoxFotoAnimal.Image)
            {
                pictureBoxFotoAnimal.Image = Fotografias[Fotografias.IndexOf(pictureBoxFotoAnimal.Image) + 1];
                labelIndexFoto.Text = (Fotografias.IndexOf(pictureBoxFotoAnimal.Image) + 1).ToString();
                ControleBotoesFotografia();
            }
        }
    }
}
