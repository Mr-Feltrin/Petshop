using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;

namespace PetShop
{
    public partial class PesquisarServicos : Form
    {
        private VScrollBar DGVScrollBar;

        public PesquisarServicos()
        {
            InitializeComponent();
        }

        private void PesquisarServicos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            listaServicos.Columns["NomeServico"].HeaderText = "Nome do Serviço";
            listaServicos.Columns["Valor"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaServicos.Columns["Valor"].DefaultCellStyle.Format = string.Format("C2");
            listaServicos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVScrollBar = listaServicos.Controls.OfType<VScrollBar>().First();
            DGVScrollBar.VisibleChanged += new EventHandler(DGVScrollBar_VisibleChanged);
            DataGridViewTools.MaximumFormSize(listaServicos, this);
            listaServicos.ColumnWidthChanged += new DataGridViewColumnEventHandler(listaServicos_ColumnWidthChanged);
        }

        private void listaServicos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaServicos, this);
        }

        private void DGVScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            DataGridViewTools.MaximumFormSize(listaServicos, this);
        }

        public void AtualizarLista()
        {
            listaServicos.DataSource = Servico.ListarServicos();
            listaServicos.ClearSelection();
            if (listaServicos.Rows.Count > 0)
            {
                listaServicos.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void listaServicos_Sorted(object sender, EventArgs e)
        {
            (sender as DataGridView).ClearSelection();
        }

        private void listaServicos_SelectionChanged(object sender, EventArgs e)
        {
            if (listaServicos.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void txtPesquisarServico_TextChanged(object sender, EventArgs e)
        {
            (listaServicos.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeServico LIKE '%" + txtPesquisarServico.Text + "%'");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarServicos adicionarServico = new AdicionarEditarServicos(TipoOperacao.Adicionar))
            {
                adicionarServico.ShowDialog(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarServicos editarServico = new AdicionarEditarServicos(TipoOperacao.Editar, (int)listaServicos.SelectedRows[0].Cells[0].Value))
            {
                editarServico.ShowDialog(this);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover esse serviço?", "Remover Serviço", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Servico.ExcluirServico((int)listaServicos.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
            }
        }

        private void listaServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                using (AdicionarEditarServicos editarServico = new AdicionarEditarServicos(TipoOperacao.Editar, (int)listaServicos.SelectedRows[0].Cells[0].Value))
                {
                    editarServico.ShowDialog(this);
                }
            }
        }

        private void PesquisarServicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void listaServicos_Enter(object sender, EventArgs e)
        {
            listaServicos.CurrentCell = null;
            listaServicos.FirstDisplayedCell = null;
        }
    }
}
