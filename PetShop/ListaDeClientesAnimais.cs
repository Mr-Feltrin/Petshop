using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.Properties;
using System;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ListaDeClientesAnimais : Form
    {
        public AdicionarEditarAgendamento _adicionarEditarAgendamento { get; private set; }
        private AdicionarEditarAnimais _adicionarEditarAnimais { get; set; }
        private TipoPesquisa _tipoPesquisa { get; set; }
        private ListaDeClientesAnimais()
        {
            InitializeComponent();
        }

        public ListaDeClientesAnimais(AdicionarEditarAgendamento adicionarEditarAgendamento, TipoPesquisa tipoPesquisa) : this()
        {
            _adicionarEditarAgendamento = adicionarEditarAgendamento;
            _tipoPesquisa = tipoPesquisa;
        }

        public ListaDeClientesAnimais(AdicionarEditarAnimais adicionarEditarAnimais) : this()
        {
            _adicionarEditarAnimais = adicionarEditarAnimais;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Selecionar()
        {
            if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                if (_adicionarEditarAgendamento != null)
                {
                    _adicionarEditarAgendamento.cliente = new Cliente((int)dataListaClientesAnimais.SelectedRows[0].Cells[0].Value);
                    _adicionarEditarAgendamento.txtCliente.Text = _adicionarEditarAgendamento.cliente.NomeCliente;
                }
                else if (_adicionarEditarAnimais != null)
                {
                    _adicionarEditarAnimais.cliente = new Cliente((int)dataListaClientesAnimais.SelectedRows[0].Cells[0].Value);
                    _adicionarEditarAnimais.txtNomeDonoAnimal.Text = _adicionarEditarAnimais.cliente.NomeCliente;
                }
            }
            else if (_tipoPesquisa == TipoPesquisa.Animal)
            {
                if (_adicionarEditarAgendamento != null)
                {
                    _adicionarEditarAgendamento.animal = new Animal((int)dataListaClientesAnimais.SelectedRows[0].Cells[0].Value);
                    _adicionarEditarAgendamento.txtNomeAnimal.Text = _adicionarEditarAgendamento.animal.Nome;
                }
            }
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        public void AtualizarLista()
        {
            if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                dataListaClientesAnimais.DataSource = Cliente.ListarClientes();
            }
            else if (_tipoPesquisa == TipoPesquisa.Animal)
            {
                if (_adicionarEditarAgendamento != null)
                {
                    dataListaClientesAnimais.DataSource = Animal.ListarAnimais(_adicionarEditarAgendamento.cliente.ClienteId);
                }
                else if (_adicionarEditarAnimais != null)
                {
                    dataListaClientesAnimais.DataSource = Animal.ListarAnimais();
                }
            }
            dataListaClientesAnimais.ClearSelection();
        }

        private void ListaDeClientesAnimais_Load(object sender, EventArgs e)
        {
            if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Lista de Clientes";
            }
            else if (_tipoPesquisa == TipoPesquisa.Animal)
            {
                Text = "Lista de Animais";
                Icon = Resources.animal_icon;
            }
            AtualizarLista();
        }

        private void dataListaClientesAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar();
        }

        private void dataListaClientesAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.Enabled = true;
        }

        private void btnNovoClienteAnimal_Click(object sender, EventArgs e)
        {
            if (_tipoPesquisa == TipoPesquisa.Animal)
            {
                AdicionarEditarAnimais adicionarAnimal = new AdicionarEditarAnimais(this, TipoOperacao.Adicionar);
                adicionarAnimal.Show();
            }
            else if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                AdicionarEditarCliente adicionarCliente = new AdicionarEditarCliente(TipoOperacao.Adicionar, listaDeClientes: this);
                adicionarCliente.ShowDialog();
            }
        }
    }
}
