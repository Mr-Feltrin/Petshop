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
using System.Threading;
using PetShop.ToolBox;
using System.Collections.Generic;

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
        private decimal ValorTotalVenda { get; set; }
        private System.Timers.Timer TimerHorario;
        private VScrollBar listaProdutosScrollBar;
        private VScrollBar listaServicosScrollBar;
        private VScrollBar listaVacinasScrollBar;


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
            TableProdutos = Produto.ListarProdutos(true);
            TableServicos = Servico.ListarServicos();
            TableVacinas = Vacina.ListarVacinas(true);
            listaProdutosScrollBar = listaProdutos.Controls.OfType<VScrollBar>().First();
            listaServicosScrollBar = listaServicos.Controls.OfType<VScrollBar>().First();
            listaVacinasScrollBar = listaVacinas.Controls.OfType<VScrollBar>().First();
            listaProdutosScrollBar.VisibleChanged += new EventHandler(DataGridViewScrollBar_VisibleChanged);
            listaServicosScrollBar.VisibleChanged += new EventHandler(DataGridViewScrollBar_VisibleChanged);
            listaVacinasScrollBar.VisibleChanged += new EventHandler(DataGridViewScrollBar_VisibleChanged);
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
            listaProdutos.Columns["ValorUnidade"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaProdutos.Columns["ValorTotal"].ValueType = typeof(double);
            listaProdutos.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            listaProdutos.Columns["ValorTotal"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaProdutos.Columns["EstoqueAtualProduto"].ValueType = typeof(int);
            listaServicos.Columns["PrecoServico"].DefaultCellStyle.Format = "C2";
            listaServicos.Columns["PrecoServico"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            listaVacinas.Columns["VacinaValor"].DefaultCellStyle.Format = "C2";
            listaVacinas.Columns["VacinaValor"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
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
            listaProdutos.CellValueChanged += listaProdutos_CellValueChanged;
            listaServicos.CellValueChanged += listaServicos_CellValueChanged;
            listaVacinas.CellValueChanged += listaVacinas_CellValueChanged;          
        }

        private void DataGridViewScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            MaximumFormSize((sender as Control).Parent as DataGridView);
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
            MaximumFormSize(sender as DataGridView);
        }

        private void MaximumFormSize(DataGridView dataGridView)
        {
            if (dataGridView.Visible)
            {
                if (dataGridView.Controls.OfType<VScrollBar>().Any(s => s.Visible))
                {
                    MaximumSize = new Size(dataGridView.Controls.OfType<VScrollBar>().Where(s => s.Visible).First().Width + dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 49, 100000);
                }
                else
                {
                    MaximumSize = new Size(dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 49, 100000);
                }
            }
        }

        private void GridVisibleChange(object sender, EventArgs e)
        {
            if ((sender as DataGridView).Visible)
            {
                (sender as DataGridView).CurrentCell = null;
                (sender as DataGridView).FirstDisplayedCell = null;
                MaximumFormSize(sender as DataGridView);
            }
        }

        private void DataGridEnter(object sender, EventArgs e)
        {
            (sender as DataGridView).CurrentCell = null;
            (sender as DataGridView).FirstDisplayedCell = null;
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
                if (!(listaProdutos.Rows.Cast<DataGridViewRow>().Count(v => v.Cells["NomeProduto"].Value == null) == 1 && listaProdutos.Rows[e.RowIndex].Cells["NomeProduto"].Value == null))
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
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", CultureInfo.CurrentCulture);
                }
            }
            else
            {
                (sender as TextBox).Text = "R$ 0,00";
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
            (sender as TextBox).Text = decimal.Parse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat).ToString();
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = decimal.Parse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat).ToString();
        }

        private void txtDesconto_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (!Regex.IsMatch((sender as TextBox).Text, @"^[0-9]{,5}\.[0-9]{2}$"))
                {
                    (sender as TextBox).Text = Math.Round(double.Parse((sender as TextBox).Text), 2).ToString("C2", CultureInfo.CurrentCulture);

                }
            }
            else
            {
                (sender as TextBox).Text = "R$ 0,00";
            }
        }

        private void listaProdutos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += ProdutosColumnQuantidade_KeyPress;
                    tb.TextChanged += ProdutosColumnQuantidade_TextChanged;
                    tb.Leave += ProdutosColumnQuantidade_Leave;
                }
            }
            else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
            {
                DataGridViewComboBoxEditingControl combo = e.Control as DataGridViewComboBoxEditingControl;
                if (combo != null)
                {
                    combo.DropDownStyle = ComboBoxStyle.DropDown;
                    e.CellStyle.BackColor = listaProdutos.DefaultCellStyle.BackColor;
                    combo.Enter += ProdutosColumnNomeProduto_Enter;
                    combo.KeyDown += ProdutosColumnNomeProduto_KeyDown;
                    combo.LostFocus += ProdutosColumnNomeProduto_LostFocus;
                    combo.Leave += ProdutosColumnNomeProduto_Leave;
                }
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

        private void ProdutosColumnNomeProduto_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as DataGridViewComboBoxEditingControl).Text))
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = (sender as DataGridViewComboBoxEditingControl).FindString((sender as DataGridViewComboBoxEditingControl).Text);
            }
            else
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
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
                listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorTotal"].Value = int.Parse((sender as TextBox).Text) * decimal.Parse(listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorUnidade"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
            }
            else
            {
                listaProdutos.Rows[listaProdutos.CurrentCell.RowIndex].Cells["ValorTotal"].Value = 0;
            }
        }

        private void ProdutosColumnNomeProduto_Leave(object sender, EventArgs e)
        {
            (sender as DataGridViewComboBoxEditingControl).Enter -= ProdutosColumnNomeProduto_Enter;
            (sender as DataGridViewComboBoxEditingControl).KeyDown -= ProdutosColumnNomeProduto_KeyDown;
            (sender as DataGridViewComboBoxEditingControl).TextUpdate -= ProdutosColumnNomeProduto_TextUpdate;
            (sender as DataGridViewComboBoxEditingControl).LostFocus -= ProdutosColumnNomeProduto_LostFocus;
            (sender as DataGridViewComboBoxEditingControl).Leave -= ProdutosColumnNomeProduto_Leave;
        }

        private void ProdutosColumnNomeProduto_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(listaProdutos.CurrentCell.EditedFormattedValue.ToString()) && (int?)(sender as DataGridViewComboBoxEditingControl).SelectedValue != -1)
            {
                listaProdutos.CurrentCell.Value = null;
            }
        }

        private void ProdutosColumnNomeProduto_Enter(object sender, EventArgs e)
        {
            int? cellValue = (int?)listaProdutos.CurrentCell.Value;
            if (cellValue == null)
            {
                (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
            }
            (sender as DataGridViewComboBoxEditingControl).DroppedDown = true;
            if (listaProdutos.CurrentCell.FormattedValue.ToString() == listaProdutos.CurrentCell.EditedFormattedValue.ToString())
            {
                (sender as DataGridViewComboBoxEditingControl).TextUpdate += ProdutosColumnNomeProduto_TextUpdate;
            }
        }

        void ProdutosColumnNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void listaProdutos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (listaProdutos.IsCurrentCellDirty)
            {
                try
                {
                    listaProdutos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
                catch
                {
                    if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index && listaProdutos.EditingControl != null)
                    {
                        (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedValue = -1;
                    }
                }
            }
        }

        private void DataGridLeave(object sender, EventArgs e)
        {

            (sender as DataGridView).EndEdit();
            (sender as DataGridView).CurrentCell = null;
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
            if (listaServicos.CurrentCell.ColumnIndex == listaServicos.Columns["QuantidadeServico"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += ServicosColumnQuantidadeServico_KeyPress;
                    tb.Leave += ServicosColumnQuantidadeServico_Leave;
                }
            }
            else if (listaServicos.CurrentCell.ColumnIndex == listaServicos.Columns["NomeServico"].Index)
            {
                DataGridViewComboBoxEditingControl combo = e.Control as DataGridViewComboBoxEditingControl;
                if (combo != null)
                {
                    combo.DropDownStyle = ComboBoxStyle.DropDown;
                    e.CellStyle.BackColor = listaServicos.DefaultCellStyle.BackColor;
                    combo.Enter += ServicosColumnNomeServico_Enter;
                    combo.KeyDown += ServicosColumnNomeServico_KeyDown;
                    combo.LostFocus += ServicosColumnNomeServico_LostFocus;
                    combo.Leave += ServicosCulumnNomeServico_Leave;
                }
            }
        }

        private void ServicosColumnQuantidadeServico_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).KeyPress -= ServicosColumnQuantidadeServico_KeyPress;
            (sender as TextBox).Leave -= ServicosColumnQuantidadeServico_Leave;
        }

        private void ServicosColumnQuantidadeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ServicosCulumnNomeServico_Leave(object sender, EventArgs e)
        {
            (sender as DataGridViewComboBoxEditingControl).Enter -= ServicosColumnNomeServico_Enter;
            (sender as DataGridViewComboBoxEditingControl).KeyDown -= ServicosColumnNomeServico_KeyDown;
            (sender as DataGridViewComboBoxEditingControl).LostFocus -= ServicosColumnNomeServico_LostFocus;
            (sender as DataGridViewComboBoxEditingControl).TextUpdate -= ServicosColumnNomeServico_TextUpdate;
            (sender as DataGridViewComboBoxEditingControl).Leave -= ServicosCulumnNomeServico_Leave;
        }

        private void ServicosColumnNomeServico_Enter(object sender, EventArgs e)
        {
            int? cellValue = (int?)listaServicos.CurrentCell.Value;
            if (cellValue == null)
            {
                (listaServicos.EditingControl as ComboBox).SelectedIndex = -1;
            }
            (sender as DataGridViewComboBoxEditingControl).DroppedDown = true;
            if (listaServicos.CurrentCell.FormattedValue.ToString() == listaServicos.CurrentCell.EditedFormattedValue.ToString())
            {
                (sender as ComboBox).TextUpdate += ServicosColumnNomeServico_TextUpdate;
            }
        }

        private void ServicosColumnNomeServico_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(listaServicos.CurrentCell.EditedFormattedValue.ToString()) && (int?)(sender as DataGridViewComboBoxEditingControl).SelectedValue != -1)
            {
                listaServicos.CurrentCell.Value = null;
            }
        }

        private void ServicosColumnNomeServico_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as DataGridViewComboBoxEditingControl).Text))
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = (sender as DataGridViewComboBoxEditingControl).FindString((sender as DataGridViewComboBoxEditingControl).Text);
            }
            else
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
            }
        }

        private void ServicosColumnNomeServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void listaServicos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == listaServicos.Columns["NomeServico"].Index)
                {
                    if (listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (listaServicos.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["NomeServico"].Value != null).Count(r => (int)r.Cells["NomeServico"].Value == (int)listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 1)
                        {
                            MessageBox.Show("O Serviço selecionado ja foi adicionado a lista.", "Serviços similares inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        }
                        else
                        {
                            int rowIndex = e.RowIndex;
                            DataRow row = TableServicos.Rows.Cast<DataRow>().Where(v => v.Field<int>("Id") == (int)listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).First();
                            listaServicos.CellValueChanged -= listaServicos_CellValueChanged;
                            listaServicos.Rows[e.RowIndex].Cells["PrecoServico"].Value = (decimal)row["Valor"];
                            listaServicos.Rows[e.RowIndex].Cells["QuantidadeServico"].Value = 1;
                            listaServicos.Rows[e.RowIndex].Cells["QuantidadeServico"].ReadOnly = false;
                            listaServicos.CellValueChanged += listaServicos_CellValueChanged;
                            ChecarCompra();
                            AtualizarTotalCompra();
                            if (!listaServicos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeServico"].Value == null))
                            {
                                listaServicos.Rows.Add(1);
                            }
                            listaServicos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                            listaServicos.EndEdit(DataGridViewDataErrorContexts.LeaveControl);
                            listaServicos.CurrentCell = null;
                            Thread.Sleep(260);
                            listaServicos.CurrentCell = listaServicos.Rows[rowIndex].Cells["QuantidadeServico"];
                            listaServicos.EditMode = DataGridViewEditMode.EditOnEnter;
                        }
                    }
                    else
                    {
                        listaServicos.CellValueChanged -= listaServicos_CellValueChanged;
                        foreach (DataGridViewCell cell in listaServicos.Rows[e.RowIndex].Cells)
                        {
                            cell.Value = null;
                        }
                        listaServicos.CellValueChanged += listaServicos_CellValueChanged;
                        listaServicos.Rows[e.RowIndex].Cells["QuantidadeServico"].ReadOnly = true;
                        ChecarCompra();
                        AtualizarTotalCompra();
                    }
                }
                else if (e.ColumnIndex == listaServicos.Columns["QuantidadeServico"].Index)
                {
                    if (listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || string.IsNullOrWhiteSpace(listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        listaServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                    ChecarQuantidades();
                    AtualizarTotalCompra();
                }
            }
        }

        private void listaServicos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (listaServicos.IsCurrentCellDirty)
            {
                try
                {
                    listaServicos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    listaServicos.EndEdit();
                }
                catch
                {
                    if (listaServicos.CurrentCell.ColumnIndex == listaServicos.Columns["NomeServico"].Index && listaServicos.EditingControl != null)
                    {
                        (listaServicos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                    }
                }
            }
        }

        private void listaVacinas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaQuantidade"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += VacinasColumnVacinaQuantidade_KeyPress;
                    tb.TextChanged += VacinasColumnQuantidade_TextChanged;
                    tb.Leave += VacinasColumnVacinaQuantidade_Leave;
                }
            }
            else if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index)
            {
                ComboBox combo = e.Control as ComboBox;
                if (combo == null)
                {
                    return;
                }
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                e.CellStyle.BackColor = listaProdutos.DefaultCellStyle.BackColor;
                combo.Enter += VacinasColumnVacinaImunologia_Enter;
                combo.KeyDown += VacinasColumnVacinaImunologia_KeyDown;
                combo.LostFocus += VacinasColumnVacinaImunologia_LostFocus;
                combo.Leave += VacinaColumnVacinaImunologia_Leave;
            }
        }

        private void VacinasColumnQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (int.Parse((sender as TextBox).Text) > (int)listaVacinas.Rows[listaVacinas.CurrentCell.RowIndex].Cells["VacinaEstoqueDisponivel"].Value)
                {
                    (sender as TextBox).Text = listaVacinas.Rows[listaVacinas.CurrentCell.RowIndex].Cells["VacinaEstoqueDisponivel"].Value.ToString();
                    MessageBox.Show($"Quantidade máxima em estoque ultrapassada ({listaVacinas.Rows[listaVacinas.CurrentCell.RowIndex].Cells["VacinaEstoqueDisponivel"].Value})");
                }
            }
        }

        private void VacinasColumnVacinaQuantidade_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).KeyPress -= VacinasColumnVacinaQuantidade_KeyPress;
            (sender as TextBox).Leave -= VacinasColumnVacinaQuantidade_Leave;
        }

        private void VacinasColumnVacinaQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VacinaColumnVacinaImunologia_Leave(object sender, EventArgs e)
        {
            (sender as DataGridViewComboBoxEditingControl).Enter -= VacinasColumnVacinaImunologia_Enter;
            (sender as DataGridViewComboBoxEditingControl).KeyDown -= VacinasColumnVacinaImunologia_KeyDown;
            (sender as DataGridViewComboBoxEditingControl).LostFocus -= VacinasColumnVacinaImunologia_LostFocus;
            (sender as DataGridViewComboBoxEditingControl).TextUpdate -= VacinasColumnVacinaImunologia_TextUpdate;
            (sender as DataGridViewComboBoxEditingControl).Leave -= VacinaColumnVacinaImunologia_Leave;
        }

        private void VacinasColumnVacinaImunologia_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as DataGridViewComboBoxEditingControl).Text))
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = (sender as DataGridViewComboBoxEditingControl).FindString((sender as DataGridViewComboBoxEditingControl).Text);
            }
            else
            {
                (sender as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
            }
        }

        private void VacinasColumnVacinaImunologia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void VacinasColumnVacinaImunologia_Enter(object sender, EventArgs e)
        {
            int? cellValue = (int?)listaVacinas.CurrentCell.Value;
            if (cellValue == null)
            {
                (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
            }
            (sender as DataGridViewComboBoxEditingControl).DroppedDown = true;
            if (listaVacinas.CurrentCell.FormattedValue.ToString() == listaVacinas.CurrentCell.EditedFormattedValue.ToString())
            {
                (sender as DataGridViewComboBoxEditingControl).TextUpdate += VacinasColumnVacinaImunologia_TextUpdate;
            }
        }

        private void VacinasColumnVacinaImunologia_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(listaVacinas.CurrentCell.EditedFormattedValue.ToString()) && (int?)(sender as DataGridViewComboBoxEditingControl).SelectedValue != -1)
            {
                listaVacinas.CurrentCell.Value = null;
            }
        }

        private void listaVacinas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (listaVacinas.IsCurrentCellDirty)
            {
                try
                {
                    listaVacinas.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
                catch
                {
                    if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index && listaVacinas.EditingControl != null)
                    {
                        (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedValue = -1;
                    }
                }
            }
        }

        private void listaVacinas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index)
                {
                    if (listaVacinas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (listaVacinas.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["VacinaImunologia"].Value != null).Count(r => (int)r.Cells["VacinaImunologia"].Value == (int)listaVacinas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 1)
                        {
                            MessageBox.Show("A vacina selecionada ja foi adicionada na lista.", "Vacinas similares inseridas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaVacinas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        }
                        else
                        {
                            int rowIndex = e.RowIndex;
                            DataRow Row = TableVacinas.Rows.Cast<DataRow>().Where(c => c.Field<int>("Id") == (int)listaVacinas.Rows[e.RowIndex].Cells["VacinaImunologia"].Value).First();
                            listaVacinas.CellValueChanged -= listaVacinas_CellValueChanged;
                            listaVacinas.Rows[rowIndex].Cells["VacinaConteudoML"].Value = (int)Row["ConteudoML"];
                            listaVacinas.Rows[rowIndex].Cells["VacinaDoses"].Value = (int)Row["Doses"];
                            listaVacinas.Rows[rowIndex].Cells["VacinaFabricante"].Value = (string)Row["Fabricante"];
                            listaVacinas.Rows[rowIndex].Cells["VacinaValor"].Value = (decimal)Row["ValorProduto"];
                            listaVacinas.Rows[rowIndex].Cells["VacinaQuantidade"].Value = 1;
                            listaVacinas.Rows[rowIndex].Cells["VacinaEstoqueDisponivel"].Value = (int)Row["Quantidade"];
                            listaVacinas.Rows[rowIndex].Cells["VacinaQuantidade"].ReadOnly = false;
                            listaVacinas.CellValueChanged += listaVacinas_CellValueChanged;
                            ChecarCompra();
                            AtualizarTotalCompra();
                            if (!listaVacinas.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["VacinaImunologia"].Value == null))
                            {
                                listaVacinas.Rows.Add(1);
                            }
                            listaVacinas.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                            listaVacinas.EndEdit(DataGridViewDataErrorContexts.LeaveControl);
                            listaVacinas.CurrentCell = null;
                            Thread.Sleep(260);
                            listaVacinas.CurrentCell = listaVacinas.Rows[rowIndex].Cells["VacinaQuantidade"];
                            listaVacinas.EditMode = DataGridViewEditMode.EditOnEnter;
                        }
                    }
                    else
                    {
                        listaVacinas.CellValueChanged -= listaVacinas_CellValueChanged;
                        foreach (DataGridViewCell cell in listaVacinas.Rows[e.RowIndex].Cells)
                        {
                            cell.Value = null;
                        }
                        listaVacinas.CellValueChanged += listaVacinas_CellValueChanged;
                        listaVacinas.Rows[e.RowIndex].Cells["VacinaQuantidade"].ReadOnly = true;
                        ChecarCompra();
                        AtualizarTotalCompra();
                    }
                }
                else if (e.ColumnIndex == listaVacinas.Columns["VacinaQuantidade"].Index)
                {
                    if (listaVacinas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || string.IsNullOrWhiteSpace(listaVacinas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                    ChecarQuantidades();
                    AtualizarTotalCompra();
                }
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
                if (!(listaServicos.Rows.Cast<DataGridViewRow>().Count(v => v.Cells["NomeServico"].Value == null) == 1 && listaServicos.Rows[e.RowIndex].Cells["NomeServico"].Value == null))
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
                if (!(listaVacinas.Rows.Cast<DataGridViewRow>().Count(v => v.Cells["VacinaImunologia"].Value == null) == 1 && listaVacinas.Rows[e.RowIndex].Cells["VacinaImunologia"].Value == null))
                {
                    listaVacinas.Rows.RemoveAt(e.RowIndex);
                }
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
                        if (listaProdutos.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["NomeProduto"].Value != null).Count(r => (int)r.Cells["NomeProduto"].Value == (int)listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 1)
                        {
                            MessageBox.Show("O produto selecionado ja foi adicionado a lista.", "Produtos similares inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        }
                        else
                        {
                            int rowIndex = e.RowIndex;
                            DataRow Row = TableProdutos.Rows.Cast<DataRow>().Where(c => c.Field<int>("Id") == (int)listaProdutos.Rows[e.RowIndex].Cells[listaProdutos.Columns["NomeProduto"].Index].Value).First();
                            listaProdutos.CellValueChanged -= listaProdutos_CellValueChanged;
                            listaProdutos.Rows[e.RowIndex].Cells["CodigoBarras"].Value = !string.IsNullOrEmpty(Row["CodigoBarras"].ToString()) ? Row["CodigoBarras"].ToString() : "N.D";
                            listaProdutos.Rows[e.RowIndex].Cells["Marca"].Value = !string.IsNullOrEmpty(Row["Marca"].ToString()) ? Row["Marca"].ToString() : "N.D";
                            listaProdutos.Rows[e.RowIndex].Cells["Volume"].Value = $"{Row["Quantidade"]} {Row["TipoUnidade"]}";
                            listaProdutos.Rows[e.RowIndex].Cells["ValorUnidade"].Value = (decimal)Row["ValorProduto"];
                            listaProdutos.Rows[e.RowIndex].Cells["EstoqueAtualProduto"].Value = Row["EstoqueAtual"];
                            listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value = 1;
                            listaProdutos.Rows[e.RowIndex].Cells["ValorTotal"].Value = int.Parse(listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString()) * decimal.Parse(listaProdutos.Rows[e.RowIndex].Cells["ValorUnidade"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                            listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = false;
                            listaProdutos.CellValueChanged += listaProdutos_CellValueChanged;
                            ChecarCompra();
                            AtualizarTotalCompra();
                            if (!listaProdutos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeProduto"].Value == null))
                            {
                                listaProdutos.Rows.Add(1);
                            }
                            listaProdutos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                            listaProdutos.EndEdit(DataGridViewDataErrorContexts.LeaveControl);
                            listaProdutos.CurrentCell = null;
                            Thread.Sleep(260);
                            listaProdutos.CurrentCell = listaProdutos.Rows[rowIndex].Cells["Quantidade"];
                            listaProdutos.EditMode = DataGridViewEditMode.EditOnEnter;
                        }
                    }
                    else
                    {
                        listaProdutos.CellValueChanged -= listaProdutos_CellValueChanged;
                        foreach (DataGridViewCell cell in listaProdutos.Rows[e.RowIndex].Cells)
                        {
                            cell.Value = null;
                        }
                        listaProdutos.CellValueChanged += listaProdutos_CellValueChanged;
                        listaProdutos.Rows[e.RowIndex].Cells["Quantidade"].ReadOnly = true;
                        ChecarCompra();
                        AtualizarTotalCompra();
                    }
                }
                else if (e.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                {
                    if (listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "N.D")
                    {
                        if (TableProdutos.Rows.Cast<DataRow>().Where(c => (string)c["CodigoBarras"] != string.Empty).Any(c => (string)listaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == (string)c["CodigoBarras"]))
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
                    ChecarQuantidades();
                    AtualizarTotalCompra();
                }
            }
        }

        private void ChecarCompra()
        {
            if (listaProdutos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeProduto"].Value != null) || listaServicos.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["NomeServico"].Value != null) || listaVacinas.Rows.Cast<DataGridViewRow>().Any(v => v.Cells["VacinaImunologia"].Value != null))
            {
                btnConcluir.Enabled = true;
                toolTip.SetToolTip(btnConcluir, string.Empty);
            }
            else
            {
                btnConcluir.Enabled = false;
                toolTip.SetToolTip(btnConcluir, "Não existem produtos ou serviços adicionados na compra");
                return;
            }
            ChecarTipoPagamento();
        }

        private void ChecarQuantidades()
        {
            if (listaProdutos.Rows.Cast<DataGridViewRow>().Where(v => v.Cells["NomeProduto"].Value != null && v.Cells["Quantidade"].Value != null).Any(v => int.Parse(v.Cells["Quantidade"].Value.ToString()) > 0) || listaServicos.Rows.Cast<DataGridViewRow>().Where(v => v.Cells["NomeServico"].Value != null && v.Cells["QuantidadeServico"].Value != null).Any(v => int.Parse(v.Cells["QuantidadeServico"].Value.ToString()) > 0) || listaVacinas.Rows.Cast<DataGridViewRow>().Where(v => v.Cells["VacinaImunologia"].Value != null && v.Cells["VacinaQuantidade"].Value != null).Any(v => int.Parse(v.Cells["VacinaQuantidade"].Value.ToString()) > 0))
            {
                btnConcluir.Enabled = true;
                toolTip.SetToolTip(btnConcluir, string.Empty);
            }
            else
            {
                btnConcluir.Enabled = false;
                toolTip.SetToolTip(btnConcluir, "Os produtos inseridos não estão na quantidade mínima para se concluir a compra");
                return;
            }
            ChecarTipoPagamento();
        }

        private void ChecarTipoPagamento()
        {
            if (combBoxFormaPagamento.SelectedIndex != -1)
            {
                if (combBoxFormaPagamento.SelectedIndex == 1 && combBoxTipoCartao.SelectedIndex == -1)
                {
                    btnConcluir.Enabled = false;
                    toolTip.SetToolTip(btnConcluir, "Selecione o tipo de cartão para pagamento");
                }
                else
                {
                    btnConcluir.Enabled = true;
                    toolTip.SetToolTip(btnConcluir, string.Empty);
                }
            }
            else
            {
                btnConcluir.Enabled = false;
                toolTip.SetToolTip(btnConcluir, "Selecione a forma de pagamento");
            }
        }

        private void Listas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChecarCompra();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (listaProdutos.CurrentCell != null)
                {
                    if (listaProdutos.EditingControl != null)
                    {
                        if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace(listaProdutos.EditingControl.Text))
                            {
                                listaProdutos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                                listaProdutos.EndEdit();
                                listaProdutos.CurrentCell = listaProdutos.Rows[listaProdutos.CurrentRow.Index].Cells["NomeProduto"];
                                listaProdutos.EditMode = DataGridViewEditMode.EditOnEnter;
                            }
                        }
                        else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace((listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).Text))
                            {
                                (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).FindString((listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).Text);
                            }
                            else
                            {
                                (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                            }
                        }
                        else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace(listaProdutos.EditingControl.Text))
                            {
                                if (listaProdutos.Rows.Cast<DataGridViewRow>().Any(r => r.Cells["NomeProduto"].Value == null))
                                {
                                    listaProdutos.CurrentCell = listaProdutos.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["NomeProduto"].Value == null).Select(r => r.Cells["NomeProduto"]).FirstOrDefault();
                                }
                            }
                        }
                    }
                }
                else if (listaServicos.CurrentCell != null)
                {
                    if (listaServicos.EditingControl != null)
                    {
                        if (listaServicos.CurrentCell.ColumnIndex == listaServicos.Columns["NomeServico"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace((listaServicos.EditingControl as DataGridViewComboBoxEditingControl).Text))
                            {
                                (listaServicos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = (listaServicos.EditingControl as DataGridViewComboBoxEditingControl).FindString((listaServicos.EditingControl as DataGridViewComboBoxEditingControl).Text);
                            }
                            else
                            {
                                (listaServicos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                            }
                        }
                    }
                }
                else if (listaVacinas.CurrentCell != null)
                {
                    if (listaVacinas.EditingControl != null)
                    {
                        if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace((listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).Text))
                            {
                                (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).FindString((listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).Text);
                            }
                            else
                            {
                                (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                            }
                        }
                        else if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaQuantidade"].Index)
                        {
                            if (!string.IsNullOrWhiteSpace(listaVacinas.EditingControl.Text))
                            {
                                if (listaVacinas.Rows.Cast<DataGridViewRow>().Any(r => r.Cells["VacinaImunologia"].Value == null))
                                {
                                    listaVacinas.CurrentCell = listaVacinas.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["VacinaImunologia"].Value == null).Select(r => r.Cells["VacinaImunologia"]).FirstOrDefault();
                                }
                            }
                        }
                    }
                }
                return true;
            }
            else if (keyData == Keys.Tab)
            {
                if (listaProdutos.CurrentCell != null && listaProdutos.EditingControl != null)
                {
                    if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["NomeProduto"].Index)
                    {
                        int? currentIndex = (int?)listaProdutos.CurrentCell.Value;
                        if (!string.IsNullOrWhiteSpace((listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).Text))
                        {
                            (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).FindString((listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).Text);
                            if ((int?)listaProdutos.CurrentCell.Value == currentIndex)
                            {
                                int rowIndex = listaProdutos.CurrentCell.RowIndex;
                                listaProdutos.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                                listaProdutos.EndEdit(DataGridViewDataErrorContexts.LeaveControl);
                                listaProdutos.CurrentCell = listaProdutos.Rows[rowIndex].Cells["Quantidade"];
                                listaProdutos.EditMode = DataGridViewEditMode.EditOnEnter;
                            }
                        }
                        else
                        {
                            (listaProdutos.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                        }
                    }
                    else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["Quantidade"].Index)
                    {
                        if (listaProdutos.Rows.Cast<DataGridViewRow>().Any(r => r.Cells["NomeProduto"].Value == null))
                        {
                            listaProdutos.CurrentCell = listaProdutos.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["NomeProduto"].Value == null).Select(r => r.Cells["NomeProduto"]).FirstOrDefault();
                        }
                    }
                    else if (listaProdutos.CurrentCell.ColumnIndex == listaProdutos.Columns["CodigoBarras"].Index)
                    {
                        listaProdutos.BeginEdit(false);
                        listaProdutos.CurrentCell = listaProdutos.Rows[listaProdutos.CurrentRow.Index].Cells["NomeProduto"];
                    }
                }
                else if (listaVacinas.CurrentCell != null && listaVacinas.EditingControl != null)
                {
                    if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaImunologia"].Index)
                    {
                        int? lastValue = (int?)listaVacinas.CurrentCell.Value;
                        if (!string.IsNullOrWhiteSpace((listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).Text))
                        {
                            (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).FindString((listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).Text);
                            if ((int?)listaVacinas.CurrentCell.Value == lastValue)
                            {
                                int rowIndex = listaVacinas.CurrentRow.Index;
                                listaVacinas.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                                listaVacinas.EndEdit(DataGridViewDataErrorContexts.LeaveControl);
                                listaVacinas.CurrentCell = listaVacinas.Rows[rowIndex].Cells["VacinaQuantidade"];
                                listaVacinas.EditMode = DataGridViewEditMode.EditOnEnter;
                            }
                        }
                        else
                        {
                            (listaVacinas.EditingControl as DataGridViewComboBoxEditingControl).SelectedIndex = -1;
                        }
                    }
                    else if (listaVacinas.CurrentCell.ColumnIndex == listaVacinas.Columns["VacinaQuantidade"].Index)
                    {
                        if (listaVacinas.Rows.Cast<DataGridViewRow>().Any(r => r.Cells["VacinaImunologia"].Value == null))
                        {
                            listaVacinas.CurrentCell = listaVacinas.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["VacinaImunologia"].Value == null).Select(r => r.Cells["VacinaImunologia"]).FirstOrDefault();
                        }
                    }
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

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled)
            {
                return;
            }
            else
            {

                List<VendaProduto> vendaProdutos = new List<VendaProduto>();
                List<VendaServico> vendaServicos = new List<VendaServico>();
                List<VendaVacina> vendaVacinas = new List<VendaVacina>();
                int? idCliente = null;
                if (_Cliente != null)
                {
                    idCliente = _Cliente.ClienteId;
                }
                Venda venda = new Venda(DateTime.Now, idCliente, combBoxFormaPagamento.SelectedItem.ToString(), decimal.TryParse(txtDesconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out decimal txtDescontoResult) ? txtDescontoResult : default, combBoxTipoCartao.Text, decimal.Parse(txtTotalVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
                try
                {
                    venda.AdicionarVenda();
                }
                catch
                {
                    return;
                }
                if (listaProdutos.Rows.Cast<DataGridViewRow>().Any(row => row.Cells["NomeProduto"].Value != null))
                {
                    foreach (DataGridViewRow row in listaProdutos.Rows)
                    {
                        if (row.Cells["NomeProduto"].Value != null)
                        {
                            vendaProdutos.Add(new VendaProduto(venda.Id, (int)row.Cells["NomeProduto"].Value, Convert.ToInt32(row.Cells["Quantidade"].Value)));
                        }
                    }
                }
                if (listaServicos.Rows.Cast<DataGridViewRow>().Any(row => row.Cells["NomeServico"].Value != null))
                {
                    foreach (DataGridViewRow row in listaServicos.Rows)
                    {
                        if (row.Cells["NomeServico"].Value != null)
                        {
                            vendaServicos.Add(new VendaServico(venda.Id, (int)row.Cells["NomeServico"].Value, (int)row.Cells["QuantidadeServico"].Value));
                        }
                    }
                }
                if (listaVacinas.Rows.Cast<DataGridViewRow>().Any(row => row.Cells["VacinaImunologia"].Value != null))
                {
                    foreach (DataGridViewRow row in listaVacinas.Rows)
                    {
                        if (row.Cells["VacinaImunologia"].Value != null)
                        {
                            vendaVacinas.Add(new VendaVacina(venda.Id, (int)row.Cells["VacinaImunologia"].Value, (int)row.Cells["VacinaQuantidade"].Value));
                        }
                    }
                }
                try
                {
                    if (vendaProdutos.Any())
                    {
                        foreach (VendaProduto produto in vendaProdutos)
                        {
                            produto.SalvarVendaProduto();
                        }
                    }
                    if (vendaServicos.Any())
                    {
                        foreach (VendaServico servico in vendaServicos)
                        {
                            servico.SalvarVendaServico();
                        }
                    }
                    if (vendaVacinas.Any())
                    {
                        foreach (VendaVacina vacina in vendaVacinas)
                        {
                            vacina.SalvarVendaVacina();
                        }
                    }
                    MessageBox.Show("Venda Concluida", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();
                }
                catch
                {
                    return;
                }
            }
        }

        private void listaVacinas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            listaVacinas.Rows[e.RowIndex].Cells["VacinaQuantidade"].ReadOnly = true;
        }

        private void AtualizarTotalCompra()
        {
            ValorTotalVenda = listaProdutos.Rows.Cast<DataGridViewRow>().Where(v => v.Cells["NomeProduto"].Value != null).Select(v => decimal.Parse(v.Cells["ValorTotal"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat)).Sum() + listaServicos.Rows.Cast<DataGridViewRow>().Where(v => v.Cells["NomeServico"].Value != null).Select(v => decimal.Parse(v.Cells["PrecoServico"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat) * int.Parse(v.Cells["QuantidadeServico"].Value.ToString())).Sum() + listaVacinas.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["VacinaImunologia"].Value != null).Select(v => decimal.Parse(v.Cells["VacinaValor"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat) * int.Parse(v.Cells["VacinaQuantidade"].Value.ToString())).Sum();
            txtTotalVenda.Text = ValorTotalVenda.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void LancarVenda_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = PesquisaControlePosicaoMouse.EncontrarControleNoCursor(this);
            if (control != null && !control.Enabled)
            {
                if (!toolTip.Active)
                {
                    toolTip.Active = true;
                    toolTip.Show(toolTip.GetToolTip(control), control, control.Width / 2, control.Height / 2);
                }
            }
            else
            {
                if (toolTip.Active)
                {
                    toolTip.Active = false;
                }
            }
        }

        private void combBoxTipoCartao_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void combBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
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
            ChecarCompra();
        }

        private void combBoxTipoCartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarCompra();
        }

        private void listaServicos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            listaServicos.Rows[e.RowIndex].Cells["QuantidadeServico"].ReadOnly = true;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                txtTotalVenda.Text = (decimal.TryParse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal result) ? ValorTotalVenda - result : default).ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtTotalVenda.Text = ValorTotalVenda.ToString("C2", CultureInfo.CurrentCulture);
            }   
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if (decimal.Parse(txtValorPago.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) > decimal.Parse(txtTotalVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture))
                {
                    txtTroco.Text = (decimal.Parse(txtValorPago.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) - decimal.Parse(txtTotalVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture)).ToString("C2", CultureInfo.CurrentCulture);
                }
                else
                {
                    txtTroco.Text = "R$ 0,00";
                }
            }
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValorPago.Text) && decimal.Parse(txtValorPago.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) > 0)
            {
                txtTroco.Text = (decimal.Parse(txtValorPago.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) - decimal.Parse(txtTotalVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture)).ToString("C2", CultureInfo.CurrentCulture);
            }
        }
    }
}
