using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarProdutos : Form
    {
        public AdicionarEditarProdutos()
        {
            InitializeComponent();
        }

        private void AdicionarEditarProdutos_Load(object sender, EventArgs e)
        {
            
        }

        private void PrecoProduto_Leave(object sender, EventArgs e)
        {
            double value;
            if (!string.IsNullOrWhiteSpace(precoProduto.Text))
            {
                if (Double.TryParse(precoProduto.Text, out value))
                {
                    precoProduto.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
                }
                else
                {
                    precoProduto.Text = string.Empty;
                    MessageBox.Show("O valor inserido para o preço é inválido, utilize apenas números", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        private void PrecoProduto_Enter(object sender, EventArgs e)
        {

        }
    }
}
