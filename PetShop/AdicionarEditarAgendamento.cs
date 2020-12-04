using Microsoft.SqlServer.Server;
using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarAgendamento : Form
    {
        ToolTip _toolTip = new ToolTip();
        public Cliente cliente { get; set; }
        public Animal animal { get; set; }
        private Dictionary<object, string> CamposObrigatorios;
        private List<Image> FotosAnimal = new List<Image>();
        private Button BtnPesquisarAnimal;
        private Button BtnPesquisarCliente;
        private TipoOperacao Operacao;
        private readonly Agenda _Agenda;

        public AdicionarEditarAgendamento(TipoOperacao operacao, Agenda agenda)
        {
            InitializeComponent();
            Operacao = operacao;
        }

        private void AdicionarEditarAgendamento_Load(object sender, EventArgs e)
        {
            _toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
            CamposObrigatorios = new Dictionary<object, string>()
            {
                { txtCliente, "Selecione o cliente" },
                { txtTipoProcedimento, "Preencha o Tipo de Procedimento" },
                { txtNomeAnimal, "Selecione o animal" }
            };
            tableLayoutPanel4.MouseMove += AdicionarEditarAgendamento_MouseMove;
            tableLayoutPanel6.MouseMove += AdicionarEditarAgendamento_MouseMove;
            // Criação de botão na textbox txtCliente
            BtnPesquisarCliente = new Button();
            BtnPesquisarCliente.Size = new Size(25, txtCliente.ClientSize.Height);
            BtnPesquisarCliente.Dock = DockStyle.Right;
            BtnPesquisarCliente.Cursor = Cursors.Default;
            BtnPesquisarCliente.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            BtnPesquisarCliente.ImageAlign = ContentAlignment.MiddleCenter;
            BtnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            BtnPesquisarCliente.ForeColor = Color.White;
            BtnPesquisarCliente.BackColor = Color.Transparent;
            BtnPesquisarCliente.FlatAppearance.BorderSize = 0;
            txtCliente.Controls.Add(BtnPesquisarCliente);
            BtnPesquisarCliente.Click += new EventHandler(btnPesquisarCliente_Click);
            //
            // Criação de botão na textbox txtNomeAnimal
            BtnPesquisarAnimal = new Button();
            BtnPesquisarAnimal.Size = new Size(25, txtCliente.ClientSize.Height);
            BtnPesquisarAnimal.Dock = DockStyle.Right;
            BtnPesquisarAnimal.Cursor = Cursors.Default;
            BtnPesquisarAnimal.Image = Properties.Resources.search;
            BtnPesquisarAnimal.ImageAlign = ContentAlignment.MiddleCenter;
            BtnPesquisarAnimal.FlatStyle = FlatStyle.Flat;
            BtnPesquisarAnimal.ForeColor = Color.White;
            BtnPesquisarAnimal.BackColor = Color.Transparent;
            BtnPesquisarAnimal.FlatAppearance.BorderSize = 0;
            txtNomeAnimal.Controls.Add(BtnPesquisarAnimal);
            BtnPesquisarAnimal.Enabled = false;
            BtnPesquisarAnimal.Click += new EventHandler(btnPesquisarAnimal_Click);
            //
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar agendamento";
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                Text = "Editar agendamento";
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            ListaDeClientesAnimais listaDeClientes = new ListaDeClientesAnimais(this, TipoPesquisa.Cliente);
            listaDeClientes.ShowDialog();
        }

        private void btnPesquisarAnimal_Click(object sender, EventArgs e)
        {
            ListaDeClientesAnimais listaDeAnimais = new ListaDeClientesAnimais(this, TipoPesquisa.Animal);
            listaDeAnimais.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
            BtnPesquisarAnimal.Enabled = true;
            if (animal != null && animal.ClienteId != cliente.ClienteId)
            {
                animal = null;
                txtNomeAnimal.Clear();
                txtSexo.Clear();
                txtEspecie.Clear();
                txtRaca.Clear();
            }
        }

        private void txtTipoProcedimento_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
            if (animal != null)
            {
                txtSexo.Text = animal.Sexo;
                txtEspecie.Text = animal.Especie;
                txtRaca.Text = animal.Raca;
                if (animal.Fotografia1 != null)
                {
                    FotosAnimal.Add(animal.Fotografia1);
                }
                if (animal.Fotografia2 != null)
                {
                    FotosAnimal.Add(animal.Fotografia2);
                }
                if (animal.Fotografia3 != null)
                {
                    FotosAnimal.Add(animal.Fotografia3);
                }
                if (FotosAnimal.Count > 0)
                {
                    pictureFotoAnimal.Image = FotosAnimal.First();
                    labelIndexFoto.Text = (FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1).ToString();
                    ControleFotografia();
                }
            }
        }

        private void AdicionarEditarAgendamento_MouseMove(object sender, MouseEventArgs e)
        {
            Control controle = PesquisaControlePosicaoMouse.EncontrarControleNoCursor(this);
            if (controle != null && !controle.Enabled)
            {
                if (!_toolTip.Active)
                {
                    _toolTip.Active = true;
                    _toolTip.Show(_toolTip.GetToolTip(controle), controle, controle.Width / 2, controle.Height / 2);
                }
            }
            else
            {
                if (_toolTip.Active)
                {
                    _toolTip.Active = false;
                }
            }
        }

        private void ControleFotografia()
        {
            if (FotosAnimal.IndexOf(pictureFotoAnimal.Image) >= 3 || FotosAnimal.Count > 0 && FotosAnimal.Last() == pictureFotoAnimal.Image)
            {
                btnAvancarFoto.Enabled = false;
            }
            else
            {
                btnAvancarFoto.Enabled = true;
            }
            if (FotosAnimal.IndexOf(pictureFotoAnimal.Image) <= 0)
            {
                btnVoltarFoto.Enabled = false;
            }
            else
            {
                btnVoltarFoto.Enabled = true;
            }
            if (FotosAnimal.Count == 0)
            {
                pictureFotoAnimal.Image = null;
                labelIndexFoto.Text = null;
                btnAvancarFoto.Enabled = false;
                btnVoltarFoto.Enabled = false;
            }
            if (labelIndexFoto.Text == "")
            {
                labelIndexFoto.Text = (FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1).ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarFoto_Click(object sender, EventArgs e)
        {
            if (FotosAnimal.IndexOf(pictureFotoAnimal.Image) > 0)
            {
                pictureFotoAnimal.Image = FotosAnimal[FotosAnimal.IndexOf(pictureFotoAnimal.Image) - 1];
                labelIndexFoto.Text = (FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1).ToString();
                ControleFotografia();
            }
        }

        private void btnAvancarFoto_Click(object sender, EventArgs e)
        {
            if (FotosAnimal.Count > 0 && FotosAnimal.Last() != pictureFotoAnimal.Image)
            {
                pictureFotoAnimal.Image = FotosAnimal[FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1];
                labelIndexFoto.Text = (FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1).ToString();
                ControleFotografia();
            }
        }
    }

}
