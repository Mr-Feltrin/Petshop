using System;
using System.Windows.Forms;
using System.Collections.Generic;
using PetShop.Entities.Enums;

namespace PetShop
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            Icon = Properties.Resources.agenda_icon;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            dataInicial.Value = DateTime.Now;
            dataFinal.Value = DateTime.Now.AddMonths(1);
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {
            AdicionarEditarAgendamento AdicionarAgendamento = new AdicionarEditarAgendamento(TipoOperacao.Adicionar, this);
            AdicionarAgendamento.ShowDialog();
        }
    }
}
