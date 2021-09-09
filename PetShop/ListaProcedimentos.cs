using PetShop.Entities;
using PetShop.Entities.Enums;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PetShop
{
    public partial class ListaProcedimentos : Form
    {
        private readonly AdicionarEditarAgendamento adicionarEditarAgendamento;

        public ListaProcedimentos(AdicionarEditarAgendamento agendamento)
        {
            InitializeComponent();
            adicionarEditarAgendamento = agendamento;
        }

        public void AtualizarLista()
        {
            listaProcedimento.DataSource = Servico.ListarServicos();
            listaProcedimento.Columns["NomeServico"].HeaderText = "Nome do Serviço";
            listaProcedimento.Columns["Valor"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
            listaProcedimento.Columns["Valor"].DefaultCellStyle.Format = string.Format("C2");
            listaProcedimento.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        private void ListaProcedimentos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtPesquisarProcedimento_TextChanged(object sender, EventArgs e)
        {
            (listaProcedimento.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeServico LIKE '%" + txtPesquisarProcedimento.Text + "%'");
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                adicionarEditarAgendamento._Servico = new Servico((int)listaProcedimento.SelectedRows[0].Cells[0].Value);
                adicionarEditarAgendamento.txtTipoProcedimento.Text = adicionarEditarAgendamento._Servico.NomeServico;
            }
            catch (Exception)
            {
                adicionarEditarAgendamento._Servico = null;
                adicionarEditarAgendamento.txtTipoProcedimento.Text = null;
            }
            Close();
        }

        private void listaProcedimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    adicionarEditarAgendamento._Servico = new Servico((int)listaProcedimento.SelectedRows[0].Cells[0].Value);
                    adicionarEditarAgendamento.txtTipoProcedimento.Text = adicionarEditarAgendamento._Servico.NomeServico;
                }
                catch (Exception)
                {
                    adicionarEditarAgendamento._Servico = null;
                    adicionarEditarAgendamento.txtTipoProcedimento.Text = null;
                }
                Close();
            }
        }

        private void listaProcedimento_Sorted(object sender, EventArgs e)
        {
            (sender as DataGridView).ClearSelection();
        }

        private void listaProcedimento_SelectionChanged(object sender, EventArgs e)
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

        private void btnAdicionarProcedimento_Click(object sender, EventArgs e)
        {
            using (AdicionarEditarServicos adicionarServico = new AdicionarEditarServicos(TipoOperacao.Adicionar))
            {
                adicionarServico.ShowDialog();
            }
        }
    }
}
