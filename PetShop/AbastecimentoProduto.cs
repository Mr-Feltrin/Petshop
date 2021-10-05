using System;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AbastecimentoProduto : Form
    {
        private readonly AdicionarEditarProdutos FormAdicionarEditarProdutos;

        public AbastecimentoProduto(AdicionarEditarProdutos adicionarEditarProdutos)
        {
            InitializeComponent();
            FormAdicionarEditarProdutos = adicionarEditarProdutos;
        }

        private void AbastecimentoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            FormAdicionarEditarProdutos.AbastecerEstoque(int.TryParse(txtQuantidade.Text, out int result) ? result : default);
            Close();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                btnConcluir.Enabled = true;
            }
            else
            {
                btnConcluir.Enabled = false;
            }
        }
    }
}
