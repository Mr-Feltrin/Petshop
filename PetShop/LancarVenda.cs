using PetShop.ToolBox;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop
{
    public partial class LancarVenda : Form
    {
        public Button btnPesquisarCliente { get; set; }
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        public LancarVenda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            txtNomeCliente.GotFocus += TextBoxGotFocus;
            txtNumeroVenda.GotFocus += TextBoxGotFocus;
            txtDataVenda.GotFocus += TextBoxGotFocus;
            txtHorario.GotFocus += TextBoxGotFocus;
            txtTotalVenda.GotFocus += TextBoxGotFocus;
            txtTotalVenda.GotFocus += TextBoxGotFocus;
            txtTroco.GotFocus += TextBoxGotFocus;
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHorario.Text = DateTime.Now.ToString("HH:mm");
            btnPesquisarCliente = new Button();
            btnPesquisarCliente.Size = new Size(25, txtNomeCliente.ClientSize.Height);
            btnPesquisarCliente.Dock = DockStyle.Right;
            btnPesquisarCliente.Cursor = Cursors.Default;
            btnPesquisarCliente.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            btnPesquisarCliente.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            btnPesquisarCliente.ForeColor = Color.White;
            btnPesquisarCliente.BackColor = Color.Transparent;
            btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            txtNomeCliente.Controls.Add(btnPesquisarCliente);
            listaProdutos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
        }

        private void combBoxTipoCartao_EnabledChanged(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = SystemColors.Window;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void combBoxFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((sender as ComboBox).SelectedIndex == 1))
            {
                combBoxTipoCartao.Enabled = true;
            }
            else
            {
                combBoxTipoCartao.Enabled = false;
                combBoxTipoCartao.SelectedIndex = -1;
            }
        }

        private void listaProdutos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == listaProdutos.Columns["RemoverProduto"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.remove16x16.Width;
                var h = Properties.Resources.remove16x16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.remove16x16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void listaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.IndexOf('.') < (sender as TextBox).SelectionStart && (sender as TextBox).Text.Split('.').Length > 1 && (sender as TextBox).Text.Split('.')[1].Length == 2)

            {
                e.Handled = true;
            }
        }

        private void txtValorPago_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", new CultureInfo("pt-BR"));
                }
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.IndexOf('.') < (sender as TextBox).SelectionStart && (sender as TextBox).Text.Split('.').Length > 1 && (sender as TextBox).Text.Split('.')[1].Length == 2)

            {
                e.Handled = true;
            }
        }

        private void txtValorPago_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
        }

        private void txtDesconto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", new CultureInfo("pt-BR"));
                }
            }
        }
    }
}
