using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using PetShop.ToolBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarAgendamento : Form
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        ToolTip _toolTip = new ToolTip();
        public Cliente _Cliente { get; set; }
        public Animal _Animal { get; set; }
        public Servico _Servico { get; set; }
        private Dictionary<Control, string> CamposObrigatorios;
        private List<Image> FotosAnimal = new List<Image>();
        private Button BtnPesquisarAnimal;
        private Button BtnPesquisarCliente;
        private Button BtnPesquisarProcedimento;
        private TipoOperacao Operacao { get; set; }
        private readonly PesquisarAgendamento PesquisaAgendamento;
        private Agenda _Agenda { get; set; }

        public AdicionarEditarAgendamento(TipoOperacao operacao, PesquisarAgendamento agenda)
        {
            InitializeComponent();
            Operacao = operacao;
            PesquisaAgendamento = agenda;
        }

        public AdicionarEditarAgendamento(TipoOperacao operacao, PesquisarAgendamento agenda, int idAgendamento) : this(operacao, agenda)
        {
            try
            {
                _Agenda = new Agenda(idAgendamento);
                _Cliente = _Agenda.ClienteId;
                _Animal = _Agenda.AnimalId;
                _Servico = _Agenda.ServicoId;
            }
            catch (Exception ex)
            {
                ErrorLogger.CreateErrorLog(ex);
                Load += (s, e) => Close();
                return;
            }
        }

        private void AdicionarEditarAgendamento_Load(object sender, EventArgs e)
        {
            txtCliente.GotFocus += TextBoxGotFocus;
            txtTipoProcedimento.GotFocus += TextBoxGotFocus;
            txtNomeAnimal.GotFocus += TextBoxGotFocus;
            txtSexo.GotFocus += TextBoxGotFocus;
            txtEspecie.GotFocus += TextBoxGotFocus;
            txtRaca.GotFocus += TextBoxGotFocus;
            _toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
            CamposObrigatorios = new Dictionary<Control, string>()
            {
                { txtCliente, "Selecione o cliente" },
                { txtTipoProcedimento, "Selecione o Tipo de Procedimento" },
                { txtNomeAnimal, "Selecione o animal" }
            };
            tableLayoutPanel4.MouseMove += AdicionarEditarAgendamento_MouseMove;
            tableLayoutPanel6.MouseMove += AdicionarEditarAgendamento_MouseMove;
            // Botão de pesquisar Cliente
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
            // Botão de pesquisar Animal
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
            _toolTip.SetToolTip(BtnPesquisarAnimal, "Selecione o cliente");
            txtNomeAnimal.MouseMove += AdicionarEditarAgendamento_MouseMove;
            //
            // Botão de pesquisar procedimento
            BtnPesquisarProcedimento = new Button();
            BtnPesquisarProcedimento.Size = new Size(25, txtCliente.ClientSize.Height);
            BtnPesquisarProcedimento.Dock = DockStyle.Right;
            BtnPesquisarProcedimento.Cursor = Cursors.Default;
            BtnPesquisarProcedimento.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            BtnPesquisarProcedimento.ImageAlign = ContentAlignment.MiddleCenter;
            BtnPesquisarProcedimento.FlatStyle = FlatStyle.Flat;
            BtnPesquisarProcedimento.ForeColor = Color.White;
            BtnPesquisarProcedimento.BackColor = Color.Transparent;
            BtnPesquisarProcedimento.FlatAppearance.BorderSize = 0;
            txtTipoProcedimento.Controls.Add(BtnPesquisarProcedimento);
            BtnPesquisarProcedimento.Click += new EventHandler(BtnPesquisarProcedimento_Click);
            //
            if (Operacao == TipoOperacao.Adicionar)
            {
                Text = "Adicionar agendamento";
                dateHorario.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm"));

            }
            else if (Operacao == TipoOperacao.Editar)
            {
                Text = "Editar agendamento";
                dateDataAgendamento.Value = _Agenda.DataAgendamento;
                dateHorario.Value = DateTime.Parse(_Agenda.DataAgendamento.ToString("HH:mm"));
                txtCliente.Text = _Agenda.ClienteId.NomeCliente;
                txtTipoProcedimento.Text = _Servico.NomeServico;
                txtNomeAnimal.Text = _Agenda.AnimalId.Nome;
                txtSexo.Text = _Agenda.AnimalId.Sexo;
                txtEspecie.Text = _Agenda.AnimalId.Especie;
                txtRaca.Text = _Agenda.AnimalId.Raca;
                if (_Agenda.AnimalId.Fotografia1 != null)
                {
                    FotosAnimal.Add(_Agenda.AnimalId.Fotografia1);
                }
                if (_Agenda.AnimalId.Fotografia2 != null)
                {
                    FotosAnimal.Add(_Agenda.AnimalId.Fotografia2);
                }
                if (_Agenda.AnimalId.Fotografia3 != null)
                {
                    FotosAnimal.Add(_Agenda.AnimalId.Fotografia3);
                }
                if (FotosAnimal.Count > 0)
                {
                    pictureFotoAnimal.Image = FotosAnimal.First();
                    labelIndexFoto.Text = (FotosAnimal.IndexOf(pictureFotoAnimal.Image) + 1).ToString();
                    ControleFotografia();
                }
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            ListaDeClientesAnimais listaDeClientes = new ListaDeClientesAnimais(this, TipoPesquisa.Cliente, _Cliente);
            listaDeClientes.Show(this);
        }

        private void BtnPesquisarProcedimento_Click(object sender, EventArgs e)
        {
            ListaProcedimentos procedimentos = new ListaProcedimentos(this);
            procedimentos.Show(this);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void btnPesquisarAnimal_Click(object sender, EventArgs e)
        {
            ListaDeClientesAnimais listaDeAnimais = new ListaDeClientesAnimais(this, TipoPesquisa.Animal, _Cliente);
            listaDeAnimais.Show(this);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
            BtnPesquisarAnimal.Enabled = true;
            if (_Animal != null && _Animal.ClienteId != _Cliente.Id)
            {
                _Animal = null;
                txtNomeAnimal.Clear();
                txtSexo.Clear();
                txtEspecie.Clear();
                txtRaca.Clear();
            }
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtTipoProcedimento_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios.ChecarCampos(btnSalvar, CamposObrigatorios, _toolTip);
            if (_Animal != null)
            {
                txtSexo.Text = _Animal.Sexo;
                txtEspecie.Text = _Animal.Especie;
                txtRaca.Text = _Animal.Raca;
                if (_Animal.Fotografia1 != null)
                {
                    FotosAnimal.Add(_Animal.Fotografia1);
                }
                if (_Animal.Fotografia2 != null)
                {
                    FotosAnimal.Add(_Animal.Fotografia2);
                }
                if (_Animal.Fotografia3 != null)
                {
                    FotosAnimal.Add(_Animal.Fotografia3);
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
            if (dateDataAgendamento.Value.Date < DateTime.Now.Date)
            {
                DialogResult add = MessageBox.Show("A data do agendamento selecionada é anterior a data atual, deseja agendar mesmo assim?", "Salvar Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (add == DialogResult.No)
                {
                    return;
                }
                else
                {
                    goto Salvar;
                }
            }

        Salvar:

            if (Operacao == TipoOperacao.Adicionar)
            {
                _Agenda = new Agenda(dateDataAgendamento.Value.Date + new TimeSpan(dateHorario.Value.Hour, dateHorario.Value.Minute, dateHorario.Value.Second), _Servico, _Animal, _Cliente);
                _Agenda.AdicionarEditarAgendamento(TipoOperacao.Adicionar);
            }
            else if (Operacao == TipoOperacao.Editar)
            {
                _Agenda.DataAgendamento = dateDataAgendamento.Value.Date + new TimeSpan(dateHorario.Value.Hour, dateHorario.Value.Minute, dateHorario.Value.Second);
                _Agenda.ClienteId = _Cliente;
                _Agenda.ServicoId = _Servico;
                _Agenda.AnimalId = _Animal;
                _Agenda.AdicionarEditarAgendamento(Operacao);
            }
            PesquisaAgendamento.AtualizarLista();
            if (Application.OpenForms.OfType<TelaPrincipal>().Count() == 1)
            {
                Application.OpenForms.OfType<TelaPrincipal>().First().AtualizarAgendamentos();
            }
            Close();
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
