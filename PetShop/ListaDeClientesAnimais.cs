using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ListaDeClientesAnimais : Form
    {
        public AdicionarEditarAgendamento FormAdicionarEditarAgendamento;
        private readonly AdicionarEditarAnimais FormAdicionarEditarAnimais;
        private readonly AdicionarEditarVacinacao FormAdicionarEditarVacinacao;
        private readonly LancarVenda FormLancarVenda;
        private TipoPesquisa _TipoPesquisa;
        private VScrollBar DGVScrollBar;

        public ListaDeClientesAnimais(AdicionarEditarAgendamento adicionarEditarAgendamento, TipoPesquisa tipoPesquisa, Cliente cliente)
        {
            InitializeComponent();
            FormAdicionarEditarAgendamento = adicionarEditarAgendamento;
            _TipoPesquisa = tipoPesquisa;
        }

        public ListaDeClientesAnimais(AdicionarEditarAnimais adicionarEditarAnimais)
        {
            InitializeComponent();
            FormAdicionarEditarAnimais = adicionarEditarAnimais;
        }

        public ListaDeClientesAnimais(LancarVenda lancarVenda, TipoPesquisa tipoPesquisa)
        {
            InitializeComponent();
            FormLancarVenda = lancarVenda;
            _TipoPesquisa = tipoPesquisa;
        }

        public ListaDeClientesAnimais(AdicionarEditarVacinacao adicionarEditarVacinacao)
        {
            InitializeComponent();
            FormAdicionarEditarVacinacao = adicionarEditarVacinacao;
            _TipoPesquisa = TipoPesquisa.Animal;
        }

        private void ListaDeClientesAnimais_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                Text = "Lista de Clientes";
                DGVClientesAnimais.Columns["Endereco"].HeaderText = "Endereço";
                DGVClientesAnimais.Columns["Cep"].HeaderText = "CEP";
                DGVClientesAnimais.Columns["Telefone_Principal"].HeaderText = "Telefone Principal";
                DGVClientesAnimais.Columns["Telefone_Secundario"].HeaderText = "Telefone Secundário";
                DGVClientesAnimais.Columns["Cpf"].HeaderText = "CPF";
                DGVClientesAnimais.Columns["Cnpj"].HeaderText = "CNPJ";
                DGVClientesAnimais.Columns["Observacoes"].HeaderText = "Observações";
                DGVClientesAnimais.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
                DGVClientesAnimais.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";

                label2.Visible = false;
                txtPesquisarAnimal.Visible = false;
                tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Absolute;
                tableLayoutPanel2.ColumnStyles[1].Width = 0;
                tableLayoutPanel2.ColumnStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel2.ColumnStyles[2].Width = 0;

            }
            else if (_TipoPesquisa == TipoPesquisa.Animal)
            {
                Text = "Lista de Animais";
                Icon = Properties.Resources.animal_icon;
                btnNovoClienteAnimal.Image = Properties.Resources.addAnimal_32x32;
                DGVClientesAnimais.Columns["Especie"].HeaderText = "Espécie";
                DGVClientesAnimais.Columns["Raca"].HeaderText = "Raça";
                DGVClientesAnimais.Columns["Identificacao"].HeaderText = "Identificação";
                DGVClientesAnimais.Columns["Observacao_rotina"].HeaderText = "Observação de Rotina";
                DGVClientesAnimais.Columns["Data_registro"].HeaderText = "Data de Registro";
                DGVClientesAnimais.Columns["DataNascimento"].HeaderText = "Data de Nascimento";
                DGVClientesAnimais.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            DGVClientesAnimais.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollBar = DGVClientesAnimais.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DGVClientesAnimais.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVClientesAnimais_ColumnWidthChanged);
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVClientesAnimais, this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Selecionar()
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                if (FormAdicionarEditarAgendamento != null)
                {
                    try
                    {
                        FormAdicionarEditarAgendamento._Cliente = new Cliente((int)DGVClientesAnimais.SelectedRows[0].Cells[0].Value);
                        FormAdicionarEditarAgendamento.txtCliente.Text = FormAdicionarEditarAgendamento._Cliente.NomeCliente;
                    }
                    catch
                    {
                        FormAdicionarEditarAgendamento._Cliente = null;
                        FormAdicionarEditarAgendamento.txtCliente.Text = null;
                    }
                }
                else if (FormAdicionarEditarAnimais != null)
                {
                    try
                    {
                        FormAdicionarEditarAnimais.ClienteId = new Cliente((int)DGVClientesAnimais.SelectedRows[0].Cells[0].Value);
                        FormAdicionarEditarAnimais.txtNomeDonoAnimal.Text = FormAdicionarEditarAnimais.ClienteId.NomeCliente;
                    }
                    catch (Exception)
                    {
                        FormAdicionarEditarAnimais.ClienteId = null;
                        FormAdicionarEditarAnimais.txtNomeDonoAnimal.Text = null;
                    }
                }
                else if (FormLancarVenda != null)
                {
                    try
                    {
                        FormLancarVenda.InserirCliente(new Cliente((int)DGVClientesAnimais.SelectedRows[0].Cells[0].Value));
                    }
                    catch
                    {
                        FormLancarVenda.InserirCliente(null);
                    }
                }
            }
            else if (_TipoPesquisa == TipoPesquisa.Animal)
            {
                if (FormAdicionarEditarAgendamento != null)
                {
                    try
                    {
                        FormAdicionarEditarAgendamento._Animal = new Animal((int)DGVClientesAnimais.SelectedRows[0].Cells[0].Value);
                        FormAdicionarEditarAgendamento.txtNomeAnimal.Text = FormAdicionarEditarAgendamento._Animal.Nome;
                    }
                    catch
                    {
                        FormAdicionarEditarAgendamento._Animal = null;
                        FormAdicionarEditarAgendamento.txtNomeAnimal.Text = null;
                    }
                }
                else if (FormAdicionarEditarVacinacao != null)
                {
                    try
                    {
                        FormAdicionarEditarVacinacao.AddAnimal(new Animal((int)DGVClientesAnimais.SelectedRows[0].Cells[0].Value));
                    }
                    catch
                    {
                        FormAdicionarEditarVacinacao.AddAnimal(null);
                    }
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
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                DGVClientesAnimais.DataSource = Cliente.ListarClientes();
                foreach (DataGridViewRow row in DGVClientesAnimais.Rows)
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
            else if (_TipoPesquisa == TipoPesquisa.Animal)
            {
                if (FormAdicionarEditarAgendamento != null)
                {
                    DGVClientesAnimais.DataSource = Animal.ListarAnimais(FormAdicionarEditarAgendamento._Cliente.Id);
                }
                else
                {
                    DGVClientesAnimais.DataSource = Animal.ListarAnimais();
                }
                foreach (DataGridViewRow row in DGVClientesAnimais.Rows)
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
            if (DGVClientesAnimais.Rows.Count > 0)
            {
                DGVClientesAnimais.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
            DGVClientesAnimais.ClearSelection();
        }

        private void dataListaClientesAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Selecionar();
            }
        }

        private void btnNovoClienteAnimal_Click(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Animal)
            {
                if (FormAdicionarEditarAgendamento != null)
                {
                    using (AdicionarEditarAnimais adicionarAnimal = new AdicionarEditarAnimais(this, TipoOperacao.Adicionar, FormAdicionarEditarAgendamento._Cliente))
                    {
                        adicionarAnimal.ShowDialog();
                    }
                }
                else
                {
                    using (AdicionarEditarAnimais adicionarAnimal = new AdicionarEditarAnimais(this, TipoOperacao.Adicionar))
                    {
                        adicionarAnimal.ShowDialog();
                    }
                }
            }
            else if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                using (AdicionarEditarCliente adicionarCliente = new AdicionarEditarCliente(TipoOperacao.Adicionar, this))
                {
                    adicionarCliente.ShowDialog();
                }
            }
        }

        private void dataListaClientesAnimais_Sorted(object sender, EventArgs e)
        {
            btnSelecionar.Enabled = false;
            DGVClientesAnimais.ClearSelection();
        }

        private void ListaDeClientesAnimais_Resize(object sender, EventArgs e)
        {
            MaximumSize = new Size(DGVClientesAnimais.Columns.GetColumnsWidth(DataGridViewElementStates.None) + 52, 100000);
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Cliente)
            {
                (DGVClientesAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarCliente.Text + "%'");

            }
            else
            {
                (DGVClientesAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeCliente LIKE '%" + txtPesquisarCliente.Text + "%'");
            }
        }

        private void txtPesquisarAnimal_TextChanged(object sender, EventArgs e)
        {
            (DGVClientesAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarAnimal.Text + "%'");
        }

        private void DGVClientesAnimais_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                btnSelecionar.Enabled = true;
            }
            else
            {
                btnSelecionar.Enabled = false;
            }
        }

        private void DGVClientesAnimais_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVClientesAnimais, this);
        }

        private void DGVClientesAnimais_Enter(object sender, EventArgs e)
        {
            DGVClientesAnimais.CurrentCell = null;
            DGVClientesAnimais.FirstDisplayedCell = null;
        }
    }
}
