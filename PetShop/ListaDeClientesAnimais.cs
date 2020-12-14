using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
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
                    _adicionarEditarAgendamento._Cliente = new Cliente((int)dataListaClientesAnimais.SelectedRows[0].Cells[0].Value);
                    _adicionarEditarAgendamento.txtCliente.Text = _adicionarEditarAgendamento._Cliente.NomeCliente;
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
                    _adicionarEditarAgendamento._Animal = new Animal((int)dataListaClientesAnimais.SelectedRows[0].Cells[0].Value);
                    _adicionarEditarAgendamento.txtNomeAnimal.Text = _adicionarEditarAgendamento._Animal.Nome;
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
                    dataListaClientesAnimais.DataSource = Animal.ListarAnimais(_adicionarEditarAgendamento._Cliente.ClienteId);
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
                Icon = Properties.Resources.animal_icon;
                btnNovoClienteAnimal.Image = Properties.Resources.addAnimal_32x32;
            }
            AtualizarLista();
        }

        private void dataListaClientesAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Selecionar();
            }
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

        private void dataListaClientesAnimais_Sorted(object sender, EventArgs e)
        {
            btnSelecionar.Enabled = false;
            dataListaClientesAnimais.ClearSelection();
        }

        private void txtPesquisarClienteAnimal_TextChanged(object sender, EventArgs e)
        {
            (dataListaClientesAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarClienteAnimal.Text + "%'");
        }
    }
}
