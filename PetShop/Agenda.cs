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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            Icon = Properties.Resources.agenda_icon;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            FiltroDisponibilidade.SelectedText = "Geral";
            dataInicial.Value = DateTime.Now;
            dataFinal.Value = DateTime.Now.AddMonths(1);

        }
    }
}
