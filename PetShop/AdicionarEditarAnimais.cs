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
    public partial class AdicionarEditarAnimais : Form
    {
        private readonly bool Operacao; // True == Adicionar, False == Editar
        private readonly int IdAnimal;
        private readonly PesquisaAnimais _PesquisaAnimais;


        public AdicionarEditarAnimais(bool operacao, PesquisaAnimais pesquisaAnimais)
        {
            InitializeComponent();
            Operacao = operacao;
            _PesquisaAnimais = pesquisaAnimais;
        }

        public AdicionarEditarAnimais (bool operacao, PesquisaAnimais pesquisaAnimais, string idAnimal): this(operacao, pesquisaAnimais)
        {
            IdAnimal = int.Parse(idAnimal);
        }

        private void AdicionarEditarAnimais_Load(object sender, EventArgs e)
        {
            if (Operacao)
            {
                Text = "Adicionar Animal";
                dataRegistroAnimal.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                Text = "Editar Animal";
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisarDono_Click(object sender, EventArgs e)
        {
            tools.SelecionarClienteLista selecionarClienteLista = new tools.SelecionarClienteLista();
            selecionarClienteLista.ShowDialog();
        }
    }
}
