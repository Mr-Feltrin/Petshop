using PetShop.Entities;
using PetShop.Entities.Exceptions;
using PetShop.ToolBox;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class VisualizarVenda : Form
    {
        private readonly Venda IdVenda;
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public VisualizarVenda(int idVenda)
        {
            InitializeComponent();
            try
            {
                IdVenda = new Venda(idVenda);
            }
            catch (Exception e)
            {
                ErrorLogger.CreateErrorLog(e);
                Load -= VisualizarVenda_Load;
                Load += new EventHandler((s, a) => Close());
                return;
            }

        }

        private void VisualizarVenda_Load(object sender, EventArgs e)
        {
            //------------TextBox Formating------------
            txtNumeroVenda.Text = IdVenda.Id.ToString();
            txtHorario.Text = IdVenda.DataVenda.ToString("HH:mm");
            txtDataVenda.Text = IdVenda.DataVenda.ToString("dd/MM/yyyy");
            txtFormaPagamento.Text = IdVenda.Pagamento;
            txtTipoCartao.Text = string.IsNullOrWhiteSpace(IdVenda.TipoCartao) ? "N.D" : IdVenda.TipoCartao;
            txtTotalVenda.Text = IdVenda.TotalVenda.ToString("C2", CultureInfo.CurrentCulture);
            txtNomeCliente.Text = IdVenda.ClienteId != null ? IdVenda.ClienteId.NomeCliente : "N.D";
            txtDesconto.Text = IdVenda.Desconto.ToString("C2", CultureInfo.CurrentCulture);
            //------------TextBox GotFocus Events------------
            txtNumeroVenda.GotFocus += new EventHandler(txtNumeroVenda_GotFocus);
            txtHorario.GotFocus += new EventHandler(txtHorario_GotFocus);
            txtDataVenda.GotFocus += new EventHandler(txtDataVenda_GotFocus);
            txtFormaPagamento.GotFocus += new EventHandler(txtFormaPagamento_GotFocus);
            txtTipoCartao.GotFocus += new EventHandler(txtTipoCartao_GotFocus);
            txtTotalVenda.GotFocus += new EventHandler(txtTotalVenda_GotFocus);
            txtNomeCliente.GotFocus += new EventHandler(txtNomeCliente_GotFocus);
            txtDesconto.GotFocus += new EventHandler(txtDesconto_GotFocus);
            //---------------DataGrid Datasource & Formatting---------------
            DGVProdutos.DataSource = VendaProduto.BuscarProdutosVenda(IdVenda.Id);
            DGVProdutos.Columns["CodigoBarras"].HeaderText = "Código de Barras";
            DGVProdutos.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            DGVProdutos.Columns["ValorTotal"].HeaderText = "Valor Total";
            DGVProdutos.Columns["ValorProduto"].DefaultCellStyle.Format = string.Format("C2", NumberStyles.Currency);
            DGVProdutos.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVProdutos.Columns["ValorTotal"].DefaultCellStyle.Format = string.Format("C2", NumberStyles.Currency);
            DGVProdutos.Columns["ValorTotal"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            foreach (DataGridViewRow row in DGVProdutos.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells["CodigoBarras"].Value.ToString()))
                {
                    row.Cells["CodigoBarras"].Value = "N.D";
                }
                if (string.IsNullOrWhiteSpace(row.Cells["Marca"].Value.ToString()))
                {
                    row.Cells["Marca"].Value = "N.D";
                }
            }
            DGVProdutos.ClearSelection();
            DGVProdutos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DataGridViewTools.MaximumFormSize(DGVProdutos, this);
            DGVProdutos.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVColumnWidthChanged);
            DGVProdutos.DefaultCellStyle.SelectionBackColor = DGVProdutos.DefaultCellStyle.BackColor;
            DGVProdutos.DefaultCellStyle.SelectionForeColor = DGVProdutos.DefaultCellStyle.ForeColor;
            DGVServicos.DataSource = VendaServico.BuscarServicosVenda(IdVenda.Id);
            DGVServicos.Columns["NomeServico"].HeaderText = "Nome do Serviço";
            DGVServicos.Columns["Valor"].HeaderText = "Preço";
            DGVServicos.Columns["Valor"].DefaultCellStyle.Format = string.Format("C2", NumberStyles.Currency);
            DGVServicos.Columns["Valor"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVServicos.ClearSelection();
            DGVServicos.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVServicos.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVColumnWidthChanged);
            DGVServicos.DefaultCellStyle.SelectionBackColor = DGVServicos.DefaultCellStyle.BackColor;
            DGVServicos.DefaultCellStyle.SelectionForeColor = DGVServicos.DefaultCellStyle.ForeColor;
            DGVVacinas.DataSource = VendaVacina.BuscarVacinasVenda(IdVenda.Id);
            DGVVacinas.Columns["ConteudoML"].HeaderText = "Conteúdo (ML)";
            DGVVacinas.Columns["ValorProduto"].HeaderText = "Preço";
            DGVVacinas.Columns["ValorProduto"].DefaultCellStyle.Format = string.Format("C2", CultureInfo.CurrentCulture);
            DGVVacinas.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVVacinas.ClearSelection();
            DGVVacinas.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DGVVacinas.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVColumnWidthChanged);

        }

        private void DGVColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize((sender as DataGridView), this);
        }

        private void DGVServicos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVServicos, this);
        }

        private void DGVProdutos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVProdutos, this);
        }

        private void txtDesconto_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtNomeCliente_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtTotalVenda_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtTipoCartao_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtFormaPagamento_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtDataVenda_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtHorario_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);

        }

        private void txtNumeroVenda_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void VisualizarVenda_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if ((sender as RadioButton).Name == radioBtnProdutos.Name)
                {
                    DGVProdutos.Visible = true;
                    DGVProdutos.ClearSelection();
                    DGVServicos.Visible = false;
                    DGVVacinas.Visible = false;
                    labelLista.Text = "Lista de Produtos";
                }
                else if ((sender as RadioButton).Name == radioBtnServicos.Name)
                {
                    DGVServicos.Visible = true;
                    DGVServicos.ClearSelection();
                    DGVProdutos.Visible = false;
                    DGVVacinas.Visible = false;
                    labelLista.Text = "Lista de Serviços";
                }
                else if ((sender as RadioButton).Name == radioBtnVacinas.Name)
                {
                    DGVVacinas.Visible = true;
                    DGVVacinas.ClearSelection();
                    DGVProdutos.Visible = false;
                    DGVServicos.Visible = false;
                    labelLista.Text = "Lista de Vacinas";
                }
            }
        }

        private void DGVVisibleChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).Visible)
            {
                (sender as DataGridView).CurrentCell = null;
                (sender as DataGridView).FirstDisplayedCell = null;
                DataGridViewTools.MaximumFormSize(sender as DataGridView, this, DGVColumnWidthChanged);
            }
        }
    }
}
