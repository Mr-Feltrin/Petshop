using Microsoft.SqlServer.Server;
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
    public partial class AdicionarEditarAgendamento : Form
    {
        public AdicionarEditarAgendamento()
        {
            InitializeComponent();
        }

        private void AdicionarEditarAgendamento_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(25, txtCliente.ClientSize.Height);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            //btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
           // btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            txtCliente.Controls.Add(btn);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
