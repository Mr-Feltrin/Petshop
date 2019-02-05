using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            this.Focus();
            // Verificação de data em formato completo
            toolStripStatus_data_completa.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            // Verificação de tecla Caps Lock ativa/inativa
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                toolStripStatus_caps_lock.ForeColor = SystemColors.ActiveCaptionText;
            }
            else
            {
                toolStripStatus_caps_lock.ForeColor = SystemColors.InactiveCaption;
            }
            // Verificação de tecla Num Lock ativa/inativa
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                toolStripStatus_num_lock.ForeColor = SystemColors.ActiveCaptionText;
            }
            else
            {
                toolStripStatus_num_lock.ForeColor = SystemColors.InactiveCaption;
            }
            // Verificação de data em formato numerico
            toolStripStatus_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            // Exibição nome de usuário do sistema
            toolStripStatus_nome_administrador.Text = Environment.UserName;
        }


        private void Botao_clientes_Click(object sender, EventArgs e)
        {
            Pesquisa_clientes show_Pesquisa_clientes = new Pesquisa_clientes();
            show_Pesquisa_clientes.ShowDialog();
        }

        private void Tela_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se tecla Caps Lock está ativa
            if ((e.KeyCode & Keys.KeyCode) == Keys.CapsLock)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    toolStripStatus_caps_lock.ForeColor = SystemColors.ActiveCaptionText;
                }
                else
                {
                    toolStripStatus_caps_lock.ForeColor = SystemColors.InactiveCaption;
                }
            }
            // Verifica se tecla Num Lock está ativa
            if ((e.KeyCode & Keys.KeyCode) == Keys.NumLock)
            {
                if (Console.NumberLock)
                {
                    toolStripStatus_num_lock.ForeColor = SystemColors.ActiveCaptionText;
                }
                else
                {
                    toolStripStatus_num_lock.ForeColor = SystemColors.InactiveCaption;
                }
            }

        }
        // Display de horário atual
        private void Horario_atual_Tick(object sender, EventArgs e)
        {
            this.toolStripStatus_horario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
