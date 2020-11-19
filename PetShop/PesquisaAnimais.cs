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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaAnimais.SelectedRows.Count != 0)
            {
                DialogResult confirmar_delete = MessageBox.Show("Tem certeza que deseja remover este animal?", "Remover animal", MessageBoxButtons.YesNo);
                if (confirmar_delete == DialogResult.Yes)
                {
                    Animal.ExcluirAnimal((int)listaAnimais.SelectedRows[0].Cells[0].Value);
                    AtualizarLista();
                }
            }
        }

        private void pesquisaNomeDono_TextChanged(object sender, EventArgs e)
        {
            (listaAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Dono LIKE '%" + pesquisaNomeDono.Text + "%'");
        }

        private void pesquisaNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            (listaAnimais.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + pesquisaNomeAnimal.Text + "%'");
        }
    }
}