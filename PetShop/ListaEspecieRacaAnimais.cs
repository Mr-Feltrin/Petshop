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
    public partial class ListaEspecieRacaAnimais : Form
    {
        private AdicionarEditarAnimais _AdicionarEditarAnimais { get; set; }
        private TipoPesquisa _TipoPesquisa { get; set; }

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
                groupBoxPesquisa.Text = "Pesquisar Raça";
                dataListaEspecieRaca.DataSource = Animal.ListarRacas();
            }
            else
            {
                Text = "Lista de Espécies";
                groupBoxPesquisa.Text = "Pesquisar Espécie";
                dataListaEspecieRaca.DataSource = Animal.ListarEspecies();
            }
            dataListaEspecieRaca.ClearSelection();
        }

        private void PesquisarEspecieRaca()
        {
            if (_TipoPesquisa == TipoPesquisa.Especie)
            {
                (dataListaEspecieRaca.DataSource as DataTable).DefaultView.RowFilter = string.Format("Espécie LIKE '%" + txtPesquisar.Text + "%'");

            }
            else if (_TipoPesquisa == TipoPesquisa.Raca)
            {
                (dataListaEspecieRaca.DataSource as DataTable).DefaultView.RowFilter = string.Format("Raça LIKE '%" + txtPesquisar.Text + "%'");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataListaEspecieRaca_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.Enabled = true;
        }

        private void EspecieRacaSelecionado()
        {
            if (_TipoPesquisa == TipoPesquisa.Raca)
            {
                _AdicionarEditarAnimais.txtRaca.Text = dataListaEspecieRaca.SelectedRows[0].Cells[0].Value.ToString();
            }
            else if (_TipoPesquisa == TipoPesquisa.Especie)
            {
                _AdicionarEditarAnimais.txtEspecie.Text = dataListaEspecieRaca.SelectedRows[0].Cells[0].Value.ToString();
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
            EspecieRacaSelecionado();
        }
    }
}
