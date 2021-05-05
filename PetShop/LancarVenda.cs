using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PetShop.Entities;
using System.Linq;
using PetShop.Entities.Enums;
using System.Data;
using System.ComponentModel;

namespace PetShop
{
    public partial class LancarVenda : Form
    {
        public Button btnPesquisarCliente { get; set; }
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        private List<Produto> Produtos { get; set; }
        private List<Vacina> Vacinas { get; set; }
        private List<Servico> Servicos { get; set; }
        private Cliente _Cliente { get; set; }

        public LancarVenda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            Produtos = new List<Produto>();
            Vacinas = new List<Vacina>();
            Servicos = new List<Servico>();
            listaProdutos.Rows.Add(1);
            listaServicos.Rows.Add(1);
            listaVacinas.Rows.Add(1); 
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).DataSource = Produto.ListarProdutos();
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).DisplayMember = "Nome";
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).ValueMember = "Id";
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).DataSource = Servico.ListarServicos();
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).DisplayMember = "NomeServico";
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).ValueMember = "Id";
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).DataSource = Vacina.ListarVacinas();
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).DisplayMember = "Imunologia";
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).ValueMember = "Id";           
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
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
        }

        private void combBoxTipoCartao_EnabledChanged(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = SystemColors.Window;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (ListaDeClientesAnimais listaDeClientes = new ListaDeClientesAnimais(this, TipoPesquisa.Cliente))
            {
                listaDeClientes.ShowDialog(this);
            }
        }

        public void InserirCliente(Cliente cliente)
        {
            _Cliente = cliente;
            txtNomeCliente.Text = _Cliente.NomeCliente;
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if ((sender as DataGridView).Visible)
            {
                MaximumSize = new Size((sender as DataGridView).Columns.GetColumnsWidth(DataGridViewElementStates.None) + 49, 100000);
            }
        }

        private void GridVisibleChange(object sender, EventArgs e)
        {
            if ((sender as DataGridView).Visible)
            {
                MaximumSize = new Size((sender as DataGridView).Columns.GetColumnsWidth(DataGridViewElementStates.None) + 49, 100000);
            }
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

        private void CellPaintingButton(object sender, DataGridViewCellPaintingEventArgs e)
        {
            void CellDraw()
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.remove16x16.Width;
                var h = Properties.Resources.remove16x16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.remove16x16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if ((sender as DataGridView).Name == listaProdutos.Name)
            {
                if (e.ColumnIndex == (sender as DataGridView).Columns["RemoverProduto"].Index)
                {
                    CellDraw();
                }
            }
            else if ((sender as DataGridView).Name == listaServicos.Name)
            {
                if (e.ColumnIndex == (sender as DataGridView).Columns["RemoverServico"].Index)
                {
                    CellDraw();
                }
            }
            else if ((sender as DataGridView).Name == listaVacinas.Name)
            {
                if (e.ColumnIndex == (sender as DataGridView).Columns["VacinaRemover"].Index)
                {
                    CellDraw();
                }
            }
        }

        private void listaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == listaProdutos.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == listaProdutos.Columns["RemoverProduto"].Index)
            {
                if (listaProdutos.Rows.Count == 1) 
                {
                    foreach (DataGridViewCell cell in listaProdutos.Rows[0].Cells)
                    {
                        cell.Value = null;
                    }
                }
                else
                {
                    listaProdutos.Rows.RemoveAt(e.RowIndex);
                }
            }
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

        private void txtValorPago_Validating(object sender, CancelEventArgs e)
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

        private void txtDesconto_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", new CultureInfo("pt-BR"));
                }
            }
        }

        private void listaProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ProdutosColumnQuantidade_KeyPress);
            if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ProdutosColumnQuantidade_KeyPress);
                }
            }
            if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                ComboBox combo = e.Control as ComboBox;
                if (combo == null)
                {
                    return;
                }
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                listaProdutos.KeyDown += new KeyEventHandler(ComboBoxKeyDown);
                //listaProdutos.CellValueChanged += new DataGridViewCellEventHandler();
                combo.SelectionChangeCommitted += new EventHandler(ValueChanged);
                //combo.SelectedValueChanged += new EventHandler(ValueChanged);
                void ComboBoxKeyDown(object obj, KeyEventArgs args)
                {
                    if (args.KeyCode == Keys.Down || args.KeyCode == Keys.Up)
                    {
                        args.Handled = true;
                    }
                }
                void ValueChanged(object obj, EventArgs args)
                {
                    if (listaProdutos.CurrentCell.Value == null || listaProdutos.CurrentCell.Value != combo.SelectedValue)
                    {
                        listaProdutos.CurrentCell.Value = combo.SelectedValue;
                        combo.DropDownStyle = ComboBoxStyle.DropDownList;
                        DataGridViewCell currentCell = listaProdutos.CurrentCell;
                        try
                        {
                            listaProdutos.EndEdit();
                            listaProdutos.CurrentCell = null;
                            listaProdutos.CurrentCell = currentCell;
                            listaProdutos.ClearSelection();
                        }
                        catch
                        {
                            listaProdutos.CurrentCell = currentCell;
                            listaProdutos.CurrentCell.Selected = true;
                        }
                    }
                }
            }
        }

        private void ProdutosColumnQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;              
            }
        }

        private void RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if ((sender as RadioButton).Name == radioBtnProdutos.Name)
                {
                    listaProdutos.Visible = true;
                    listaServicos.Visible = false;
                    listaVacinas.Visible = false;
                    labelLista.Text = "Lista de Produtos";
                }
                else if ((sender as RadioButton).Name == radioBtnServicos.Name)
                {
                    listaServicos.Visible = true;
                    listaProdutos.Visible = false;
                    listaVacinas.Visible = false;
                    labelLista.Text = "Lista de Serviços";
                }
                else if ((sender as RadioButton).Name == radioBtnVacinas.Name)
                {
                    listaVacinas.Visible = true;
                    listaProdutos.Visible = false;
                    listaServicos.Visible = false;
                    labelLista.Text = "Lista de Vacinas";
                }
            }
        }

        private void listaProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                
                if (!(((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).DataSource as DataTable).Rows.Cast<DataRow>().Any(row => row["Id"].ToString() == ((DataGridViewComboBoxCell)listaProdutos.Rows[e.RowIndex].Cells[1]).Value.ToString()))
                {
                    MessageBox.Show("Não");
                }     
                
                //MessageBox.Show(((DataGridViewComboBoxCell)listaProdutos.Rows[e.RowIndex].Cells[1]).Value.ToString());
            }
            */

        }

        private void listaServicos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listaServicos.CurrentCell.ColumnIndex == listaServicos.Columns["NomeServico"].Index)
            {
                ComboBox combo = e.Control as ComboBox;
                if (combo == null)
                {
                    return;
                }
                combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void listaVacinas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index)
            {
                ComboBox combo = e.Control as ComboBox;
                if (combo == null)
                {
                    return;
                }
                combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void listaServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == listaServicos.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == listaServicos.Columns["RemoverServico"].Index)
            {
                if (listaServicos.Rows.Count == 1)
                {
                    foreach (DataGridViewCell cell in listaServicos.Rows[0].Cells)
                    {
                        cell.Value = null;
                    }
                }
                else
                {
                    listaServicos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void listaVacinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == listaVacinas.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == listaVacinas.Columns["VacinaRemover"].Index)
            {
                if (listaVacinas.Rows.Count == 1)
                {
                    foreach (DataGridViewCell cell in listaVacinas.Rows[0].Cells)
                    {
                        cell.Value = null;
                    }
                }
                else
                {
                    listaVacinas.Rows.RemoveAt(e.RowIndex);
                }
            }       
        }

        private void listaProdutos_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((DataGridViewComboBoxCell)listaProdutos.Rows[0].Cells[1]).ParseFormattedValue);
            //MessageBox.Show(((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"])..ToString());
        }

        private void listaProdutos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"])
            //((DataGridViewComboBoxCell)listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex]).EditedFormattedValue.ToString()
            /*
            if (e.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                if (listaProdutos.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    if (!((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).Items.Cast<DataRowView>().Any(row => (string)row[1] == ((DataGridViewComboBoxCell)listaProdutos.Rows[e.RowIndex].Cells[1]).EditedFormattedValue.ToString()))
                    {
                        foreach (DataGridViewCell cell in listaProdutos.Rows[e.RowIndex].Cells)
                        {
                            cell.Value = null;
                        }
                    }
                    e.Cancel = true;
                }

            }
            */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void listaProdutos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                listaProdutos.CurrentCell.Value = null;
            }
        }
    }
}
