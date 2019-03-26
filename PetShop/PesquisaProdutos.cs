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
    public partial class PesquisaProdutos : Form
    {
        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        private void BtnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarProdutos adicionarProdutos = new AdicionarEditarProdutos();
            adicionarProdutos.Show();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            comboBoxFiltrarLista.SelectedIndex = 4;
        }
    }
}
