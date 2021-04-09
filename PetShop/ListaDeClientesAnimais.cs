using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Drawing;
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
                foreach (DataGridViewRow row in dataListaClientesAnimais.Rows)
                {
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Apelido"].Value))
                    {
                        row.Cells["Apelido"].Value = "Nenhum";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Telefone_Secundario"].Value))
                    {
                        row.Cells["Telefone_Secundario"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Celular"].Value))
                    {
                        row.Cells["Celular"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Complemento"].Value))
                    {
                        row.Cells["Complemento"].Value = "Nenhum";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Email"].Value))
                    {
                        row.Cells["Email"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cpf"].Value))
                    {
                        row.Cells["Cpf"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Cnpj"].Value))
                    {
                        row.Cells["Cnpj"].Value = "Não Definido";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Observacoes"].Value))
                    {
                        row.Cells["Observacoes"].Value = "Nenhuma";
                    }
                }
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
                foreach (DataGridViewRow row in dataListaClientesAnimais.Rows)
                {
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Identificacao"].Value))
                    {
                        row.Cells["Identificacao"].Value = "Nenhuma";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Fobias"].Value))
                    {
                        row.Cells["Fobias"].Value = "Nenhuma";
                    }
                    if (string.IsNullOrWhiteSpace((string)row.Cells["Observacao_rotina"].Value))
                    {
                        row.Cells["Observacao_rotina"].Value = "Nenhuma";
                    }
                }
            }
            dataListaClientesAnimais.ClearSelection();
            foreach (DataGridViewColumn column in dataListaClientesAnimais.Columns)
            {
                column.Width = column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
        }

        private void ListaDeClientesAnimais_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Lista de Clientes";
                dataListaClientesAnimais.Columns["Endereco"].HeaderText = "Endereço";
                dataListaClientesAnimais.Columns["Cep"].HeaderText = "CEP";
                dataListaClientesAnimais.Columns["Telefone_Principal"].HeaderText = "Telefone Principal";
                dataListaClientesAnimais.Columns["Telefone_Secundario"].HeaderText = "Telefone Secundário";
                dataListaClientesAnimais.Columns["Cpf"].HeaderText = "CPF";
                dataListaClientesAnimais.Columns["Cnpj"].HeaderText = "CNPJ";
                dataListaClientesAnimais.Columns["Observacoes"].HeaderText = "Observações";
            }
            else if (_tipoPesquisa == TipoPesquisa.Animal)
            {
                Text = "Lista de Animais";
                Icon = Properties.Resources.animal_icon;
                btnNovoClienteAnimal.Image = Properties.Resources.addAnimal_32x32;
                labelPesquisarClienteAnimal.Text = "Pesquisar nome do Animal";
                dataListaClientesAnimais.Columns["Especie"].HeaderText = "Espécie";
                dataListaClientesAnimais.Columns["Raca"].HeaderText = "Raça";
                dataListaClientesAnimais.Columns["Identificacao"].HeaderText = "Identificação";
                dataListaClientesAnimais.Columns["Observacao_rotina"].HeaderText = "Observação de Rotina";
                dataListaClientesAnimais.Columns["Data_registro"].HeaderText = "Data de Registro";
            }
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
                using (AdicionarEditarAnimais adicionarAnimal = new AdicionarEditarAnimais(this, TipoOperacao.Adicionar))
                {
                    adicionarAnimal.ShowDialog(this);
                }

            }
            else if (_tipoPesquisa == TipoPesquisa.Cliente)
            {
                using (AdicionarEditarCliente adicionarCliente = new AdicionarEditarCliente(TipoOperacao.Adicionar, listaDeClientes: this))
                {
                    adicionarCliente.ShowDialog();
                }
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

        private void ListaDeClientesAnimais_Resize(object sender, EventArgs e)
        {
            MaximumSize = new Size(dataListaClientesAnimais.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 52, 100000);
        }

        private void dataListaClientesAnimais_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (dataListaClientesAnimais.Columns.GetColumnsWidth(DataGridViewElementStates.None) < dataListaClientesAnimais.Size.Width)
            {
                Size = new Size(dataListaClientesAnimais.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 52, Size.Height);
            }
        }
    }
}
