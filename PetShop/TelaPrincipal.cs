using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetShop
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            Focus();
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


        private void btnMenuPesquisaClientes_Click(object sender, EventArgs e)
        {
            PesquisaClientesFornecedores pesquisaClientes = new PesquisaClientesFornecedores(true);
            pesquisaClientes.ShowDialog();
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
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

        }
        // Display de horário atual
        private void Horario_atual_Tick(object sender, EventArgs e)
        {
            toolStripStatus_horario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnMenuFornecedores_Click(object sender, EventArgs e)
        {
            PesquisaClientesFornecedores pesquisaFornecedores = new PesquisaClientesFornecedores(false);
            pesquisaFornecedores.ShowDialog();
        }
    }
}
