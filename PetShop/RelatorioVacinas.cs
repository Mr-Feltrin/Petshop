using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Entities;
using PetShop.ToolBox;
using System.Globalization;
using ClosedXML.Excel;
using PetShop.Entities.Enums;

namespace PetShop
{
    public partial class RelatorioVacinas : Form
    {
        public RelatorioVacinas()
        {
            InitializeComponent();
        }

        private void RelatorioVacinas_Load(object sender, EventArgs e)
        {
            dateDataInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            dateDataFinal.Value = DateTime.Now;
            AtualizarLista();
            comboFiltrarEntradaSaida.SelectedItem = "Todos";
            DGVRelatorioVacinas.Columns["DataMovimentacao"].HeaderText = "Data de Movimentação";
            DGVRelatorioVacinas.Columns["TipoMovimentacao"].HeaderText = "Movimentação";
            DGVRelatorioVacinas.Columns["TipoOperacao"].HeaderText = "Tipo de Operação";
            DGVRelatorioVacinas.Columns["ConteudoML"].HeaderText = "Conteúdo (ML)";
            DGVRelatorioVacinas.Columns["ValorProduto"].HeaderText = "Preço";
            DGVRelatorioVacinas.Columns["ValorProduto"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;
            DGVRelatorioVacinas.Columns["ValorProduto"].DefaultCellStyle.Format = "C2";
            DGVRelatorioVacinas.ColumnMinimumWidthSize(DataGridViewAutoSizeColumnMode.ColumnHeader);
            DataGridViewTools.MaximumFormSize(DGVRelatorioVacinas, this);
            DGVRelatorioVacinas.ColumnWidthChanged += new DataGridViewColumnEventHandler(DGVRelatorioVacinas_ColumnWidthChanged);
            DGVRelatorioVacinas.CurrentCell = null;
        }

        private void DGVRelatorioVacinas_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridViewTools.MaximumFormSize(DGVRelatorioVacinas, this, DGVRelatorioVacinas_ColumnWidthChanged);
        }

        private void AtualizarLista()
        {
            DGVRelatorioVacinas.DataSource = Vacina.RelatorioEntradaSaidaVacinas(dateDataInicial.Value, dateDataFinal.Value);
            DGVRelatorioVacinas.ClearSelection();
            DGVRelatorioVacinas.Sort(DGVRelatorioVacinas.Columns["DataMovimentacao"], ListSortDirection.Descending);
            if (DGVRelatorioVacinas.Rows.Count > 0)
            {
                DGVRelatorioVacinas.SetColumnsWidth(DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void RelatorioVacinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void dateDataInicial_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void dateDataFinal_ValueChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void comboFiltrarEntradaSaida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltrarEntradaSaida.SelectedIndex == 0)
            {
                (DGVRelatorioVacinas.DataSource as DataTable).DefaultView.RowFilter = "TipoMovimentacao = 'Entrada'";
            }
            else if (comboFiltrarEntradaSaida.SelectedIndex == 1)
            {
                (DGVRelatorioVacinas.DataSource as DataTable).DefaultView.RowFilter = "TipoMovimentacao = 'Saída'";
            }
            else
            {
                (DGVRelatorioVacinas.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            DGVRelatorioVacinas.ClearSelection();
        }

        private void txtPesquisarImunologia_TextChanged(object sender, EventArgs e)
        {
            (DGVRelatorioVacinas.DataSource as DataTable).DefaultView.RowFilter = string.Format("Imunologia LIKE '%" + txtPesquisarImunologia.Text + "%'");
        }

        private void DGVRelatorioVacinas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in DGVRelatorioVacinas.Rows)
            {
                if ((string)row.Cells["TipoMovimentacao"].Value == "Entrada")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 234, 105);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(249, 115, 97);
                }
            }
        }

        private void DGVRelatorioVacinas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (DGVRelatorioVacinas.Rows.Count > 0)
            {
                btnImprimirLista.Enabled = true;
            }
            else
            {
                btnImprimirLista.Enabled = false;
            }
        }

        private void DGVRelatorioVacinas_Sorted(object sender, EventArgs e)
        {
            DGVRelatorioVacinas.ClearSelection();
        }

        private void btnImprimirLista_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Planilha do Excel (*xlsx)|*xlsx";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable data = (DGVRelatorioVacinas.DataSource as DataTable).Clone();
                        foreach (DataGridViewRow row in DGVRelatorioVacinas.Rows)
                        {
                            data.ImportRow(((DataRowView)row.DataBoundItem).Row);
                        }
                        data.Columns["DataMovimentacao"].ColumnName = "Data de Movimentação";
                        data.Columns["TipoMovimentacao"].ColumnName = "Movimentação";
                        data.Columns["TipoOperacao"].ColumnName = "Tipo de Operação";
                        data.Columns["ConteudoML"].ColumnName = "Conteúdo (ML)";
                        data.Columns["ValorProduto"].ColumnName = "Preço";
                        IXLWorksheet worksheets = workbook.Worksheets.Add(data, "Relatório de Vacinas");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 9, worksheets.LastRowUsed().RowNumber(), 9).Style.NumberFormat.SetFormat("R$ #,##0.00");
                        worksheets.Range(worksheets.FirstRowUsed().RowBelow().RowNumber(), 2, worksheets.LastRowUsed().RowNumber(), 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm:ss";
                        worksheets.CellsUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheets.CellsUsed().Style.Font.FontName = "Arial";
                        worksheets.CellsUsed().Style.Font.FontSize = 12;
                        worksheets.ColumnsUsed().AdjustToContents();
                        worksheets.RowsUsed().AdjustToContents();
                        try
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            FormNotificacao notificacao = new FormNotificacao();
                            notificacao.ShowAlert("A lista foi exportada", TipoNotificacao.Confirmar);
                        }
                        catch (System.IO.IOException)
                        {
                            MessageBox.Show("Não foi possível salvar o arquivo pois ele está em uso, feche o arquivo aberto e tente novamente", "Não Foi possível salvar o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
