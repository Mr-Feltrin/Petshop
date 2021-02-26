using System;
using System.Windows.Forms;
using PetShop.Entities.Enums;
using PetShop.Entities;

namespace PetShop
{
    public partial class PesquisarVacinas : Form
    {
        public PesquisarVacinas()
        {
            InitializeComponent();
        }

        private void btnAdicionarVacina_Click(object sender, EventArgs e)
        {
            AdicionarEditarVacina adicionarVacina = new AdicionarEditarVacina(TipoOperacao.Adicionar);
            adicionarVacina.ShowDialog();
        }

        public void AtualizarLista()
        {
            listaVacinas.DataSource = Vacina.ListarVacinas();
            listaVacinas.ClearSelection();
        }

        private void PesquisarVacinas_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
