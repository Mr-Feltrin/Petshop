using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Windows.Forms;
using PetShop.ToolBox;
using System.Linq;

namespace PetShop
{
    public partial class ListaEspecieRacaAnimais : Form
    {
        private AdicionarEditarAnimais _AdicionarEditarAnimais;
        private TipoPesquisa _TipoPesquisa;
        private VScrollBar DGVScrollBar;

        public ListaEspecieRacaAnimais(TipoPesquisa tipoPesquisa, AdicionarEditarAnimais adicionarEditarAnimais)
        {
            InitializeComponent();
            _TipoPesquisa = tipoPesquisa;
            _AdicionarEditarAnimais = adicionarEditarAnimais;
        }

        private void ListaEspecieRacaAnimais_Load(object sender, EventArgs e)
        {
            if (_TipoPesquisa == TipoPesquisa.Raca)
            {
                Text = "Lista de Raças";
                labelPesquisar.Text = "Pesquisar Raça";
                DGVListaEspecieRaca.DataSource = Animal.ListarRacas();
            }
            else
            {
                Text = "Lista de Espécies";
                labelPesquisar.Text = "Pesquisar Espécie";
                DGVListaEspecieRaca.DataSource = Animal.ListarEspecies();
            }
            DGVListaEspecieRaca.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollBar = DGVListaEspecieRaca.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(DGVListaEspecieRaca, this);
            DGVListaEspecieRaca.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVListaEspecieRaca_ColumnWidthChanged);
        }

        private void DGVListaEspecieRaca_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaEspecieRaca, this);
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVListaEspecieRaca, this);
        }

        private void PesquisarEspecieRaca()
        {
            if (_TipoPesquisa == TipoPesquisa.Especie)
            {
                (DGVListaEspecieRaca.DataSource as DataTable).DefaultView.RowFilter = string.Format("Espécie LIKE '%" + txtPesquisar.Text + "%'");

            }
            else if (_TipoPesquisa == TipoPesquisa.Raca)
            {
                (DGVListaEspecieRaca.DataSource as DataTable).DefaultView.RowFilter = string.Format("Raça LIKE '%" + txtPesquisar.Text + "%'");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EspecieRacaSelecionado()
        {
            if (_TipoPesquisa == TipoPesquisa.Raca)
            {
                _AdicionarEditarAnimais.txtRaca.Text = DGVListaEspecieRaca.SelectedRows[0].Cells[0].Value.ToString();
            }
            else if (_TipoPesquisa == TipoPesquisa.Especie)
            {
                _AdicionarEditarAnimais.txtEspecie.Text = DGVListaEspecieRaca.SelectedRows[0].Cells[0].Value.ToString();
            }
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            EspecieRacaSelecionado();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarEspecieRaca();
        }

        private void dataListaEspecieRaca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EspecieRacaSelecionado();
            }
        }

        private void dataListaEspecieRaca_Sorted(object sender, EventArgs e)
        {
            DGVListaEspecieRaca.ClearSelection();
            btnSelecionar.Enabled = false;
        }

        private void DGVListaEspecieRaca_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVListaEspecieRaca.SelectedRows.Count > 0)
            {
                btnSelecionar.Enabled = true;
            }
            else
            {
                btnSelecionar.Enabled = false;
            }
        }

        private void DGVListaEspecieRaca_Enter(object sender, EventArgs e)
        {
            DGVListaEspecieRaca.CurrentCell = null;
            DGVListaEspecieRaca.FirstDisplayedCell = null;
        }
    }
}
