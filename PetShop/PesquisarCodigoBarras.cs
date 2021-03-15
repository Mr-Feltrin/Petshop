using System;
using System.Windows.Forms;
using PetShop.Entities;
using PetShop.Entities.Enums;

namespace PetShop
{
    public partial class PesquisarCodigoBarras : Form
    {
        public PesquisarCodigoBarras()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? id = Produto.BuscarCodigoBarras(txtCodigoBarras.Text);
            if (id != null)
            {
                AdicionarEditarProdutos produto = new AdicionarEditarProdutos(TipoOperacao.Editar, (int)id);
                produto.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("O codigo de barras inserido não corresponde a nenhum produto", "Produto não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisarCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
