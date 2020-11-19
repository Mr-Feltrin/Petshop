using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.Properties;
using System;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ListaDeClientesAnimais : Form
    {
        private AdicionarEditarAgendamento _adicionarEditarAgendamento;
        private AdicionarEditarAnimais _adicionarEditarAnimais;
        private TipoPesquisa _tipoPesquisa;
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
            else
            {
                // Fazer o mesmo que a operação do cliente mas com a classe de animal
            }

            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void ListaDeClientesAnimais_Load(object sender, EventArgs e)
        {
            if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                dataListaClientesAnimais.DataSource = Cliente.ListarClientes();
            }
            else
            {
                Text = "Lista de Animais";
                Icon = Resources.animal_icon;
                btnNovoClienteAnimal.Image = Resources.addAnimal_32x32;
                dataListaClientesAnimais.DataSource = Animal.ListarAnimais();              
            }
        }

        private void dataListaClientesAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar();
        }
    }
}
