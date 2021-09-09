using System;
using System.Windows.Forms;
using PetShop.Entities;
using System.Globalization;
using PetShop.ToolBox;
using System.Linq;
using System.Data;

namespace PetShop
{
    public partial class ListaVacinas : Form
    {
        private AdicionarEditarVacinacao FormAdicionarVacinacao;
        private VScrollBar ListaVacinasScrollBar;
        public ListaVacinas()
        {
            InitializeComponent();
        }

        public ListaVacinas(AdicionarEditarVacinacao adicionarEditarVacinacao) : this()
        {
            FormAdicionarVacinacao = adicionarEditarVacinacao;
        }

        private void ListaVacinas_Load(object sender, EventArgs e)
        {
            AtualizarListaVacinas();
            DGVVacinas.Columns["ConteudoML"].HeaderText = "Conteúdo (ML)";
            DGVVacinas.Columns["DataValidade"].HeaderText = "Data de Validade";
            DGVVacinas.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            DGVVacinas.Columns["ValorMercado"].HeaderText = "Valor de Mercado";
            DGVVacinas.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            DGVVacinas.Columns["DataValidade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVVacinas.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVVacinas.Columns["ValorMercado"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVVacinas.Columns["ValorMercado"].DefaultCellStyle.Format = string.Format("C2");
            DGVVacinas.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVVacinas.Columns["ValorProduto"].DefaultCellStyle.Format = string.Format("C2");
            DGVVacinas.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            ListaVacinasScrollBar = DGVVacinas.Controls.OfType<VScrollBar>().First();
            ListaVacinasScrollBar.VisibleChanged += new EventHandler(ListaVacinasScrollBar_VisibleChanged);
            DGVVacinas.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVVacinas_ColumnWidthChanged);
        }

        private void AtualizarListaVacinas()
        {
            DGVVacinas.DataSource = Vacina.ListarVacinas();
            foreach (DataGridViewRow row in DGVVacinas.Rows)
            {
                if (row.Cells["Quantidade"].Value == null)
                {
                    row.Cells["Quantidade"].Value = 0;
                }
                if (string.IsNullOrWhiteSpace(row.Cells["Lote"].Value.ToString()))
                {
                    row.Cells["Lote"].Value = "N.D";
                }
            }
            DGVVacinas.ClearSelection();
        }
        private void ListaVacinasScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVVacinas, this);
        }

        private void DGVVacinas_Enter(object sender, EventArgs e)
        {
            (sender as DataGridView).CurrentCell = null;
            (sender as DataGridView).FirstDisplayedCell = null;
        }

        private void DGVVacinas_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVVacinas, this);
        }

        private void DGVVacinas_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                btnSelecionar.Enabled = true;
            }
            else
            {
                btnSelecionar.Enabled = false;
            }
        }

        private void DGVVacinas_Sorted(object sender, EventArgs e)
        {
            DGVVacinas.ClearSelection();
        }

        private void SelecionarVacina()
        {
            try
            {
                FormAdicionarVacinacao.AddVacina(new Vacina((int)DGVVacinas.SelectedRows[0].Cells[0].Value));
            }
            catch 
            {
                FormAdicionarVacinacao.AddVacina(null);
            }
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarVacina();
        }

        private void DGVVacinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarVacina();
        }

        private void txtPesquisarImunologia_TextChanged(object sender, EventArgs e)
        {
            (DGVVacinas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Imunologia LIKE '%" + (sender as TextBox).Text + "%'");
        }
    }
}
