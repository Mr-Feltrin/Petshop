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
    public partial class Adicionar_cliente : Form
    {
        public Adicionar_cliente()
        {
            InitializeComponent();
            
        }


        private void Adicionar_cliente_Load(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_cliente_cep_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cep.SelectionStart = 0;
        }

        private void Cadastro_cliente_telefone_primario_Click(object sender, EventArgs e)
        {
            cadastro_cliente_telefone_primario.SelectionStart = 0;
        }

        private void Cadastro_cliente_telefone_secundario_Click(object sender, EventArgs e)
        {
            cadastro_cliente_telefone_secundario.SelectionStart = 0;
        }

        private void Cadastro_cliente_celular_Click(object sender, EventArgs e)
        {
            cadastro_cliente_celular.SelectionStart = 0;
        }

        private void Cadastro_cliente_cpf_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cpf.SelectionStart = 0;
        }

        private void Cadastro_cliente_cnpj_Click(object sender, EventArgs e)
        {
            cadastro_cliente_cnpj.SelectionStart = 0;
        }
    }
}
