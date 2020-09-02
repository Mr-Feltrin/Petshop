using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarAgendamento : Form
    {
        ToolTip _toolTip = new ToolTip();
        Control _currentToolTipControl = null;

        public AdicionarEditarAgendamento()
        {
            InitializeComponent();
            _toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
        }

        private void AdicionarEditarAgendamento_Load(object sender, EventArgs e)
        {
            // Criação de botão na textbox txtCliente
            Button btnPesquisarCliente = new Button();
            btnPesquisarCliente.Size = new Size(25, txtCliente.ClientSize.Height);
            btnPesquisarCliente.Dock = DockStyle.Right;
            btnPesquisarCliente.Cursor = Cursors.Default;
            btnPesquisarCliente.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            btnPesquisarCliente.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            btnPesquisarCliente.ForeColor = Color.White;
            btnPesquisarCliente.BackColor = Color.Transparent;
            btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            txtCliente.Controls.Add(btnPesquisarCliente);
            btnPesquisarCliente.Click += new EventHandler(btnPesquisarCliente_Click);
            //
            // Criação de botão na textbox txtNomeAnimal
            Button btnPesquisarAnimal = new Button();
            btnPesquisarAnimal.Size = new Size(25, txtCliente.ClientSize.Height);
            btnPesquisarAnimal.Dock = DockStyle.Right;
            btnPesquisarAnimal.Cursor = Cursors.Default;
            btnPesquisarAnimal.Image = Properties.Resources.search;
            btnPesquisarAnimal.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarAnimal.FlatStyle = FlatStyle.Flat;
            btnPesquisarAnimal.ForeColor = Color.White;
            btnPesquisarAnimal.BackColor = Color.Transparent;
            btnPesquisarAnimal.FlatAppearance.BorderSize = 0;
            txtNomeAnimal.Controls.Add(btnPesquisarAnimal);
            btnPesquisarAnimal.Click += new EventHandler(btnPesquisarAnimal_Click);
            //
        }

        private void VerificarCamposObrigatorios()
        {
            List<Control> CamposObrigatorios = new List<Control>() { txtCliente, txtTipoProcedimento, txtNomeAnimal };
            foreach (Control c in CamposObrigatorios)
            {
                if (string.IsNullOrWhiteSpace(c.Text))
                {
                    btnSalvar.Enabled = false;
                    break;
                }
                else
                {
                    btnSalvar.Enabled = true;
                }
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "teste";
        }

        private void btnPesquisarAnimal_Click(object sender, EventArgs e)
        {
            txtNomeAnimal.Text = "teste";
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtTipoProcedimento_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObrigatorios();
        }

        void MostrarToolTipEmControleDesativado(MouseEventArgs args)
        {
            Control control = GetChildAtPoint(args.Location);
            if (control != null)
            {
                if (!control.Enabled && _currentToolTipControl == null)
                {
                    _toolTip.Active = true;
                    string toolTipString = _toolTip.GetToolTip(control);
                    _toolTip.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                    _currentToolTipControl = control;
                }
            }
            else
            {
                if (_currentToolTipControl != null)
                {
                    _toolTip.Active = false;
                    _currentToolTipControl = null;
                }
            }
        }

        private void AdicionarEditarAgendamento_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarToolTipEmControleDesativado(e);
        }

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled) _toolTip.SetToolTip(btnSalvar, null);
        }

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            _toolTip.SetToolTip(btnSalvar, "Preencha todos os campos obrigatórios");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }

}
