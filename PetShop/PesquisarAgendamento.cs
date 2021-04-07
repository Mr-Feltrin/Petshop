using PetShop.Entities;
using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using PetShop.ToolBox;

namespace PetShop
{
    public partial class PesquisarAgendamento : Form
    {
        public PesquisarAgendamento()
        {
            InitializeComponent();
            Icon = Properties.Resources.agenda_icon;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            dataInicial.Value = DateTime.Now;
            dataFinal.Value = DateTime.Now.AddMonths(1);
            AtualizarLista();
            listaAgendamento.Columns["NomeAnimal"].HeaderText = "Nome do Animal";
            listaAgendamento.Columns["Horario"].HeaderText = "Horário";
            listaAgendamento.Columns["NomeServico"].HeaderText = "Procedimento";
            listaAgendamento.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            listaAgendamento.Columns[5].DefaultCellStyle.Format = "hh\\:mm";
            listaAgendamento.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaAgendamento.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaAgendamento.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaAgendamento.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            timer.Interval = 60 * 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LegendaColoracaoLista();
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {
            AdicionarEditarAgendamento AdicionarAgendamento = new AdicionarEditarAgendamento(TipoOperacao.Adicionar, this);
            AdicionarAgendamento.ShowDialog();
        }

        public void AtualizarLista()
        {
            listaAgendamento.DataSource = Agenda.ListarAgendamentos(dataInicial.Value, dataFinal.Value);
            listaAgendamento.ClearSelection();
            listaAgendamento.Sort(listaAgendamento.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void listaAgendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AdicionarEditarAgendamento editarAgendamento = new AdicionarEditarAgendamento(TipoOperacao.Editar, this, (int)listaAgendamento.SelectedRows[0].Cells[0].Value);
                editarAgendamento.ShowDialog();
            }
        }

        private void LegendaColoracaoLista()
        {
            foreach (DataGridViewRow row in listaAgendamento.Rows)
            {
                if ((DateTime)row.Cells[1].Value <= DateTime.Now && ((DateTime)row.Cells[1].Value).AddMinutes(15) > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if ((DateTime)row.Cells[1].Value > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
                else if ((DateTime)row.Cells[1].Value < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(250, 77, 77);
                }
            }
        }

        private void listaAgendamento_Sorted(object sender, EventArgs e)
        {
            listaAgendamento.ClearSelection();
        }

        private void btnExcluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover este agendamento?", "Remover agendamento", MessageBoxButtons.YesNo);
            if (confirmarDelete == DialogResult.Yes)
            {
                Agenda.RemoverAgendamento((int)listaAgendamento.SelectedRows[0].Cells[0].Value);
                AtualizarLista();
                if (Application.OpenForms.OfType<TelaPrincipal>().Count() == 1)
                {
                    Application.OpenForms.OfType<TelaPrincipal>().First().AtualizarAgendamentos();
                }
            }
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            if (listaAgendamento.SelectedRows.Count > 0)
            {
                AdicionarEditarAgendamento editarAgendamento = new AdicionarEditarAgendamento(TipoOperacao.Editar, this, (int)listaAgendamento.SelectedRows[0].Cells[0].Value);
                editarAgendamento.ShowDialog();
            }
        }

        private void dataInicial_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void dataFinal_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void pesquisaNomeDono_TextChanged(object sender, EventArgs e)
        {
            (listaAgendamento.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cliente LIKE '%" + pesquisaNomeDono.Text + "%'");

        }

        private void pesquisaNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            (listaAgendamento.DataSource as DataTable).DefaultView.RowFilter = string.Format("NomeAnimal LIKE '%" + pesquisaNomeAnimal.Text + "%'");
        }

        private void listaAgendamento_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            LegendaColoracaoLista();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Planilha do Excel (*xlsx)|*xlsx";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;
                dialog.AddExtension = true;
                dialog.DefaultExt = "xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable data = (listaAgendamento.DataSource as DataTable).Copy();
                        data.Columns["NomeAnimal"].ColumnName = "Nome do Animal";
                        data.Columns["Horario"].ColumnName = "Horário";
                        IXLWorksheet worksheet = workbook.Worksheets.Add(data, "Agendamentos");
                        worksheet.ColumnsUsed().AdjustToContents();
                        worksheet.RowsUsed().AdjustToContents();
                        worksheet.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet.Range(worksheet.FirstRowUsed().RowBelow().RowNumber(), 2, worksheet.LastRowUsed().RowNumber(), 2).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Range(worksheet.FirstRowUsed().RowBelow().RowNumber(), 6, worksheet.LastRowUsed().RowNumber(), 6).Style.DateFormat.Format = "HH:mm";
                        try
                        {
                            workbook.SaveAs(dialog.FileName);
                            FormNotificacao notificacao = new FormNotificacao();
                            notificacao.ShowAlert("A lista foi exportada", TipoNotificacao.Confirmar);
                        }
                        catch (System.IO.IOException)
                        {
                            MessageBox.Show("Não foi possível salvar o arquivo pois ele está em uso, feche o arquivo aberto e tente novamente", "Não Foi possível salvar o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void listaAgendamento_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (listaAgendamento.Rows.Count > 0)
            {
                btnRelatorio.Enabled = true;
            }
            else
            {
                btnRelatorio.Enabled = false;
            }
        }

        private void listaAgendamento_SelectionChanged(object sender, EventArgs e)
        {
            if (listaAgendamento.SelectedRows.Count > 0)
            {
                btnEditarHorario.Enabled = true;
                btnExcluirHorario.Enabled = true;
            }
            else
            {
                btnEditarHorario.Enabled = false;
                btnExcluirHorario.Enabled = false;
            }
        }

        private void PesquisarAgendamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
