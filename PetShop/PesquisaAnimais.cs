using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace PetShop
{
    public partial class PesquisaAnimais : Form
    {
        public PesquisaAnimais()
        {
            InitializeComponent();
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarAnimais adicionarEditarAnimais = new AdicionarEditarAnimais(TipoOperacao.Adicionar, this);
            adicionarEditarAnimais.ShowDialog(); 
        }

        private void PesquisaAnimais_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        public void AtualizarLista()
        {
            listaAnimais.DataSource = Animal.ListarAnimais();
        }

        private void listaAnimais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value);
            editarAnimais.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AdicionarEditarAnimais editarAnimais = new AdicionarEditarAnimais(TipoOperacao.Editar, this, (int)listaAnimais.SelectedRows[0].Cells[0].Value);
            editarAnimais.ShowDialog();
        }
    }
}
