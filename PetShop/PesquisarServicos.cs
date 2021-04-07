using System;
using System.Windows.Forms;
using PetShop.Entities;
using System.Globalization;
using PetShop.ToolBox;
using System.Data;
using PetShop.Entities.Enums;

namespace PetShop
{
    public partial class PesquisarServicos : Form
    {
        public PesquisarServicos()
        {
            InitializeComponent();
        }

        private void PesquisarServicos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            listaServicos.Columns["NomeServico"].HeaderText = "Nome do Serviço";
            listaServicos.Columns["Valor"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
            listaServicos.Columns["Valor"].DefaultCellStyle.Format = string.Format("C2");
            listaServicos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        public void AtualizarLista()
        {
            listaServicos.DataSource = Servico.ListarServicos();
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
            AdicionarEditarServicos adicionarServico = new AdicionarEditarServicos(TipoOperacao.Adicionar);
            adicionarServico.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AdicionarEditarServicos editarServico = new AdicionarEditarServicos(TipoOperacao.Editar, (int)listaServicos.SelectedRows[0].Cells[0].Value);
            editarServico.ShowDialog();
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
                AdicionarEditarServicos editarServico = new AdicionarEditarServicos(TipoOperacao.Editar, (int)listaServicos.SelectedRows[0].Cells[0].Value);
                editarServico.ShowDialog();
            }
        }
    }
}
