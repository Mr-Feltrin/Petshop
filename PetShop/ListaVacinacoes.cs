using PetShop.Entities;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ListaVacinacoes : Form
    {
        private int AnimalId;
        private VScrollBar DGVVerticalScrollBar;

        public ListaVacinacoes(int animalId)
        {
            InitializeComponent();
            AnimalId = animalId;
        }
        private void ListaVacinacoes_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            DGVVacinacoes.Columns["DataVacina"].HeaderText = "Data de Vacinação";
            DGVVacinacoes.Columns["NomeAnimal"].HeaderText = "Nome do Animal";
            DGVVacinacoes.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            DGVVacinacoes.Columns["Especie"].HeaderText = "Espécie";
            DGVVacinacoes.Columns["Raca"].HeaderText = "Raça";
            DGVVacinacoes.Columns["DataVacina"].DefaultCellStyle.Format = string.Format("dd/MM/yyyy");
            DGVVacinacoes.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVVerticalScrollBar = DGVVacinacoes.Controls.OfType<VScrollBar>().First();
            DGVVerticalScrollBar.VisibleChanged += new EventHandler(DGVVerticalScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(DGVVacinacoes, this);
            DGVVacinacoes.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVVacinacoes_ColumnWidthChanged);
        }

        private void DGVVacinacoes_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVVacinacoes, this);
        }

        private void DGVVerticalScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVVacinacoes, this);
        }

        private void AtualizarLista()
        {
            DGVVacinacoes.DataSource = Vacinacao.ListarVacinacoes(AnimalId);
            if (DGVVacinacoes.Rows.Count > 0)
            {
                DGVVacinacoes.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
            DGVVacinacoes.ClearSelection();
        }

        private void DGVVacinacoes_Sorted(object sender, EventArgs e)
        {
            DGVVacinacoes.ClearSelection();
        }

        private void txtPesquisarImunologia_TextChanged(object sender, EventArgs e)
        {
            (DGVVacinacoes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Imunologia LIKE '%" + txtPesquisarImunologia.Text + "%'");
        }
    }
}
