using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Windows.Forms;

namespace PetShop
{
    public partial class PesquisaProdutos : Form
    {
        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            comboBoxFiltrarLista.SelectedIndex = 4;
            AtualizarLista();
            DataGridListaProdutos.Columns["CodigoBarras"].HeaderText = "Código de Barras";
            DataGridListaProdutos.Columns["TipoUnidade"].HeaderText = "Tipo de Unidade";
            DataGridListaProdutos.Columns["Referencia"].HeaderText = "Referência";
            DataGridListaProdutos.Columns["Localizacao"].HeaderText = "Localização";
            DataGridListaProdutos.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            DataGridListaProdutos.Columns["EstoqueMinimo"].HeaderText = "Estoque Mínimo";
            DataGridListaProdutos.Columns["EstoqueAtual"].HeaderText = "Estoque Atual";
            DataGridListaProdutos.Columns["DataValidade"].HeaderText = "Data de Validade";
            DataGridListaProdutos.Columns["ValorCusto"].HeaderText = "Valor de Custo";
            DataGridListaProdutos.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            DataGridListaProdutos.Columns["observacoes"].HeaderText = "Observações";
        }

        public void AtualizarLista()
        {
            DataGridListaProdutos.DataSource = Produto.ListarProdutos();
            DataGridListaProdutos.ClearSelection();
        }

        private void DataGridListaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarProduto.Enabled = true;
            btnExcluirProduto.Enabled = true;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos adicionarProdutos = new AdicionarEditarProdutos(TipoOperacao.Adicionar);
            adicionarProdutos.ShowDialog();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos editarAgendamento = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
            editarAgendamento.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover este produto?", "Remover produto", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Produto.RemoverProduto((int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
            }
        }

        private void DataGridListaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridListaProdutos.SelectedRows.Count != 0)
            {
                AdicionarEditarProdutos editarProdutos = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)DataGridListaProdutos.SelectedRows[0].Cells[0].Value);
                editarProdutos.ShowDialog();
            }
        }

        private void DataGridListaProdutos_Sorted(object sender, EventArgs e)
        {
            DataGridListaProdutos.ClearSelection();
            btnEditarProduto.Enabled = false;
            btnExcluirProduto.Enabled = false;
        }

        private void txtPesquisarNomeProduto_TextChanged(object sender, EventArgs e)
        {
            (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE '%" + txtPesquisarNomeProduto.Text + "%'");
        }

        private void txtPesquisarMarcaProduto_TextChanged(object sender, EventArgs e)
        {
            (DataGridListaProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Marca LIKE '%" + txtPesquisarMarcaProduto.Text + "%'");
        }
    }
}
