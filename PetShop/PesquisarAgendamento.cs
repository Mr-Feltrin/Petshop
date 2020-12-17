using System;
using System.Windows.Forms;
using PetShop.Entities.Enums;
using PetShop.Entities;
using System.Data;
using System.Globalization;
using System.Drawing;

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
            listaAgendamento.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listaAgendamento.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listaAgendamento.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Timer timer = new Timer();
            timer.Interval = 3 * 60 * 1000;
            timer.Tick += new EventHandler(timer_Tick);
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
            listaAgendamento.DataSource = Agenda.ListarAgendamentos(dataInicial.Value.Date, dataFinal.Value.Date);
            listaAgendamento.ClearSelection();
            listaAgendamento.Sort(listaAgendamento.Columns[1], System.ComponentModel.ListSortDirection.Ascending);  
            listaAgendamento.Sort(listaAgendamento.Columns[5], System.ComponentModel.ListSortDirection.Descending);
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
                string date = $"{DateTime.Parse(row.Cells[1].Value.ToString()):dd/MM/yyyy} {row.Cells[5].Value}";
                if (DateTime.Parse(date) <= DateTime.Now && DateTime.Parse(date).AddMinutes(15) > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (DateTime.Parse(date) > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
                else if (DateTime.Parse(date) < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(250, 77, 77);
                }
                
            }                       
        }

        private void listaAgendamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarHorario.Enabled = true;
            btnExcluirHorario.Enabled = true;
        }

        private void listaAgendamento_Sorted(object sender, EventArgs e)
        {
            listaAgendamento.ClearSelection();
            btnEditarHorario.Enabled = false;
            btnExcluirHorario.Enabled = false;
        }

        private void btnExcluirHorario_Click(object sender, EventArgs e)
        {
            if (listaAgendamento.SelectedRows.Count > 0)
            {
                DialogResult confirmarDelete = MessageBox.Show("Tem certeza que quer remover este agendamento?", "Remover agendamento", MessageBoxButtons.YesNo);
                if (confirmarDelete == DialogResult.Yes)
                {
                    Agenda.RemoverAgendamento((int)listaAgendamento.SelectedRows[0].Cells[0].Value);
                    AtualizarLista();
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
    }
}
