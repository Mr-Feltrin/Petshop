using System;
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
using System.Timers;

namespace PetShop
{
    public partial class LancarVenda : Form
    {
        public Button btnPesquisarCliente { get; set; }
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        private Cliente _Cliente { get; set; }
        private DataTable TableProdutos { get; set; }
        private DataTable TableServicos { get; set; }
        private DataTable TableVacinas { get; set; }
        private System.Timers.Timer TimerHorario;


        public LancarVenda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            TimerHorario = new System.Timers.Timer(10000);
            TimerHorario.Elapsed += new ElapsedEventHandler(TimerHorario_Elapsed);
            listaProdutos.AutoGenerateColumns = false;
            listaProdutos.Rows.Add(1);
            listaServicos.Rows.Add(1);
            listaVacinas.Rows.Add(1);
            TableProdutos = Produto.ListarProdutos();
            TableServicos = Servico.ListarServicos();
            TableVacinas = Vacina.ListarVacinas();
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).DataSource = TableProdutos;
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).DisplayMember = "Nome";
            ((DataGridViewComboBoxColumn)listaProdutos.Columns["NomeProduto"]).ValueMember = "Id";
            (listaProdutos.Columns["RemoverProduto"] as DataGridViewButtonColumn).DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.Transparent);
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).DataSource = TableServicos;
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).DisplayMember = "NomeServico";
            ((DataGridViewComboBoxColumn)listaServicos.Columns["NomeServico"]).ValueMember = "Id";
            (listaServicos.Columns["RemoverServico"] as DataGridViewButtonColumn).DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.Transparent);
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).DataSource = TableVacinas;
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).DisplayMember = "Imunologia";
            ((DataGridViewComboBoxColumn)listaVacinas.Columns["VacinaImunologia"]).ValueMember = "Id";
            (listaVacinas.Columns["VacinaRemover"] as DataGridViewButtonColumn).DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.Transparent);
            listaProdutos.Columns["ValorUnidade"].ValueType = typeof(double);
            listaProdutos.Columns["ValorUnidade"].DefaultCellStyle.Format = "C2";
            listaProdutos.Columns["ValorUnidade"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
            listaProdutos.Columns["ValorTotal"].ValueType = typeof(double);
            listaProdutos.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            listaProdutos.Columns["ValorTotal"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
            listaProdutos.Columns["Quantidade"].ValueType = typeof(int);
            listaProdutos.Columns["EstoqueAtualProduto"].ValueType = typeof(int);
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
            listaProdutos.ClearSelection();
            listaVacinas.ClearSelection();
            listaServicos.ClearSelection();
            listaProdutos.CellValueChanged += new DataGridViewCellEventHandler(listaProdutos_CellValueChanged);
        }

        private void TimerHorario_Elapsed(object sender, ElapsedEventArgs e)
        {
            txtHorario.Text = DateTime.Now.ToString("HH:mm");
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

        private void DataGridEnter(object sender, EventArgs e)
        {
            (sender as DataGridView).CurrentCell = null;
            (sender as DataGridView).ClearSelection();
        }

        private void listaProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ProdutosColumnQuantidade_KeyPress);
                    tb.TextChanged += new EventHandler(ProdutosColumnQuantidade_TextChanged);
                    tb.Leave += new EventHandler(ProdutosColumnQuantidade_Leave);
                }
            }
            else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                ComboBox combo = e.Control as ComboBox;
                if (combo == null)
                {
                    return;
                }
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                e.CellStyle.BackColor = listaProdutos.DefaultCellStyle.BackColor;
                combo.Enter += new EventHandler(ProdutosColumnNomeProduto_Enter);
                combo.KeyDown += new KeyEventHandler(ProdutosColumnNomeProduto_KeyDown);
                combo.Leave += new EventHandler(ProdutosColumnNomeProduto_Leave);
            }           
            else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
            {
                if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                {
                    if (listaProdutos.EditingControl.Text == "N.D")
                    {
                        listaProdutos.EditingControl.Text = string.Empty;
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

        private void ProdutosColumnQuantidade_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).KeyPress -= ProdutosColumnQuantidade_KeyPress;
            (sender as TextBox).TextChanged -= ProdutosColumnQuantidade_TextChanged;
            (sender as TextBox).Leave -= ProdutosColumnQuantidade_Leave;
        }

        private void ProdutosColumnQuantidade_TextChanged(object sender, EventArgs e)
        {          
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > (int)listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["EstoqueAtualProduto"].Value)
                {
                    (sender as TextBox).Text = listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["EstoqueAtualProduto"].Value.ToString();
                    MessageBox.Show($"Quantidade máxima em estoque ultrapassada ({listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["EstoqueAtualProduto"].Value})");
                }
                listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorTotal"].Value = int.Parse((sender as TextBox).Text) * decimal.Parse(listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorUnidade"].Value.ToString(), NumberStyles.Currency, new CultureInfo("pt-BR"));
            }
            else
            {
                listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorTotal"].Value = 0;
            }
        }

        private void ProdutosColumnNomeProduto_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).Enter -= ProdutosColumnNomeProduto_Enter;
            (sender as ComboBox).KeyDown -= ProdutosColumnNomeProduto_KeyDown;
            (sender as ComboBox).Leave -= ProdutosColumnNomeProduto_Leave;
        }

        private void ProdutosColumnNomeProduto_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(listaProdutos.CurrentCell.EditedFormattedValue.ToString()) && (int?)(sender as ComboBox).SelectedValue != -1)
            {
                listaProdutos.CurrentCell.Value = null;
            }
        }
        

        private void ProdutosColumnNomeProduto_Enter(object sender, EventArgs e)
        {
            if (listaProdutos.CurrentCell.FormattedValue.ToString() == listaProdutos.CurrentCell.EditedFormattedValue.ToString())
            {
                (sender as ComboBox).TextUpdate += new EventHandler(ProdutosColumnNomeProduto_TextUpdate);
            }
        }

        void ProdutosColumnNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void DataGridLeave(object sender, EventArgs e)
        {
            (sender as DataGridView).EndEdit();
            (sender as DataGridView).CurrentCell = null;
            (sender as DataGridView).ClearSelection();
        }

        private void RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if ((sender as RadioButton).Name == radioBtnProdutos.Name)
                {
                    listaProdutos.Visible = true;
                    listaProdutos.ClearSelection();
                    listaServicos.Visible = false;
                    listaVacinas.Visible = false;
                    labelLista.Text = "Lista de Produtos";
                }
                else if ((sender as RadioButton).Name == radioBtnServicos.Name)
                {
                    listaServicos.Visible = true;
                    listaServicos.ClearSelection();
                    listaProdutos.Visible = false;
                    listaVacinas.Visible = false;
                    labelLista.Text = "Lista de Serviços";
                }
                else if ((sender as RadioButton).Name == radioBtnVacinas.Name)
                {
                    listaVacinas.Visible = true;
                    listaVacinas.ClearSelection();
                    listaProdutos.Visible = false;
                    listaServicos.Visible = false;
                    labelLista.Text = "Lista de Vacinas";
                }
            }
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

        private void listaProdutos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (listaProdutos.IsCurrentCellDirty && listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                try
                {
                    listaProdutos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    listaProdutos.Refresh();
                }
                catch
                {
                    (listaProdutos.EditingControl as ComboBox).SelectedValue = -1;
                }
            }
        }

        private void listaProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                int? cellValue = (int?)listaProdutos.CurrentCell.Value;
                listaProdutos.BeginEdit(true);
                if (cellValue == null)
                {
                    (listaProdutos.EditingControl as ComboBox).SelectedIndex = -1;
                }
                (listaProdutos.EditingControl as ComboBox).DroppedDown = true;
            }
        }

        private void listaProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
                {
                    if (listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        DataRow Row = TableProdutos.Rows.Cast<DataRow>().Where(c => c.Field<int>("Id") == (int)listaProdutos.Rows[e.RowIndex].Cells[listaProdutos.Columns["NomeProduto"].Index].Value).First();
                        listaProdutos.CellValueChanged -= listaProdutos_CellValueChanged;
                        listaProdutos.Rows[e.RowIndex].Cells["CodigoBarras"].Value = !string.IsNullOrEmpty(Row["CodigoBarras"].ToString()) ? Row["CodigoBarras"].ToString() : "N.D";
                        listaProdutos.Rows[e.RowIndex].Cells["Marca"].Value = !string.IsNullOrEmpty(Row["Marca"].ToString()) ? Row["Marca"].ToString() : "N.D";
                        listaProdutos.Rows[e.RowIndex].Cells["Volume"].Value = $"{Row["Quantidade"]} {Row["TipoUnidade"]}";
                        listaProdutos.Rows[e.RowIndex].Cells["ValorUnidade"].Value = (decimal)Row["ValorProduto"];
                        listaProdutos.Rows[e.RowIndex].Cells["EstoqueAtualProduto"].Value = Row["EstoqueAtual"];
                        listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value = 1;
                        listaProdutos.Rows[e.RowIndex].Cells["ValorTotal"].Value = int.Parse(listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) * decimal.Parse(listaProdutos.Rows[e.RowIndex].Cells["ValorUnidade"].Value.ToString(), NumberStyles.Currency, new CultureInfo("pt-BR"));
                        listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = false;
                        listaProdutos.CurrentCell = listaProdutos.Rows[e.RowIndex].Cells["Quantidade"];
                        listaProdutos.CellValueChanged += listaProdutos_CellValueChanged;
                        ChecarCompra();
                    }
                    else
                    {
                        foreach (DataGridViewCell cell in listaProdutos.Rows[e.RowIndex].Cells)
                        {
                            listaProdutos.CellValueChanged -= listaProdutos_CellValueChanged;
                            cell.Value = null;
                            listaProdutos.CellValueChanged += listaProdutos_CellValueChanged;
                        }
                        listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = true;
                        ChecarCompra();
                    }
                    if (listaProdutos.Rows.Count > 0)
                    {
                        if (listaProdutos.Rows[listaProdutos.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[e.ColumnIndex].Value != null)
                        {
                            listaProdutos.Rows.Add(1);
                        }           
                    }
                }
                else if (e.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                {
                    if (listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "N.D")
                    {
                        if (TableProdutos.Rows.Cast<DataRow>().Any(c => (string)listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == (string)c["CodigoBarras"]))
                        {
                            listaProdutos.Rows[listaProdutos.CurrentRow.Index].Cells["NomeProduto"].Value = TableProdutos.Rows.Cast<DataRow>().Where(c => (string)listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == (string)c["CodigoBarras"]).Select(v => (int)v["Id"]).First();
                        }
                        else
                        {
                            listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        }
                    }
                }
                else if (e.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
                {
                    if (listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || string.IsNullOrWhiteSpace(listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        listaProdutos.Rows[e.RowIndex].Cells["ValorTotal"].Value = 0;
                    }
                }
            }
        }

        private void ChecarCompra()
        {
            if (listaProdutos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeProduto"].Value != null) || listaServicos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeServico"].Value != null) || listaVacinas.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["VacinaImunologia"].Value != null))
            {
                btnConcluir.Enabled = true;
            }
            else
            {
                btnConcluir.Enabled = false;
            }
        }

        private void Listas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChecarCompra();
        }

        private void listaServicos_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (listaProdutos.CurrentRow.Index == listaProdutos.Rows.Count - 1 && listaProdutos.CurrentRow.Cells[listaProdutos.Columns["NomeProduto"].Index].Value != null)
            //    {
            //        listaProdutos.Rows.Add(1);
            //    }              
            //}
        }

        private void listaVacinas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void listaProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (listaProdutos.CurrentCell != null)
                {
                    if (listaProdutos.CurrentRow.Index == listaProdutos.Rows.GetLastRow(DataGridViewElementStates.None) && listaProdutos.CurrentRow.Cells["NomeProduto"].Value != null)
                    {
                        listaProdutos.Rows.Add(1);
                    }
                    if (listaProdutos.EditingControl != null)
                    {
                        if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace(listaProdutos.EditingControl.Text))
                            {
                                listaProdutos.CurrentCell = listaProdutos.Rows[listaProdutos.CurrentRow.Index].Cells["NomeProduto"];
                            }
                        }
                        else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace(listaProdutos.EditingControl.Text))
                            {
                                if (listaProdutos.CurrentRow.Index < listaProdutos.Rows.GetLastRow(DataGridViewElementStates.None))
                                {
                                    listaProdutos.CurrentCell = listaProdutos.Rows[listaProdutos.CurrentRow.Index + 1].Cells["CodigoBarras"];
                                }
                            }
                        }
                    }
                }
                else if (listaServicos.CurrentCell != null)
                {
                    // Fazer o mesmo esquema do listaProdutos para este do listaServicos
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void listaProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = true;
        }
    }
}
