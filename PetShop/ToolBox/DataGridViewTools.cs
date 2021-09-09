using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System;

namespace PetShop.ToolBox
{
    public static class DataGridViewTools
    {
        /// <summary>
        /// Atrubui um tamanho mínimo para cada coluna do DataGridView com Base no AutoSizeColumnMode
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="dataGridViewAutoSizeColumnMode"></param>
        public static void ColumnMinimumWidthSize(this DataGridView dataGridView, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = column.GetPreferredWidth(dataGridViewAutoSizeColumnMode, true);
            }
        }

        /// <summary>
        /// Redimensiona as colunas do DataGridView com o tipo de preenchimento desejado
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="dataGridViewAutoSizeColumnMode">Modelo para redimensionar as colunas</param>
        public static void SetColumnsWidth(this DataGridView dataGridView, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = column.GetPreferredWidth(dataGridViewAutoSizeColumnMode, true);
            }
        }

        /// <summary>
        /// Define o tamanho máximo do Form com base no tamanho visível de todas as colunas do DataGridView
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="form"></param>
        public static void MaximumFormSize(DataGridView dataGridView, Form form, DataGridViewColumnEventHandler eventHandler = null )
        {
            Size MaxSize = new Size(dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3 + (form.Size.Width - dataGridView.Size.Width), 100000);
            if (form.MinimumSize.Width < MaxSize.Width)
            {
                if (dataGridView.Controls.OfType<VScrollBar>().Any(s => s.Visible))
                {
                    MaxSize.Width += dataGridView.Controls.OfType<VScrollBar>().First().Width;                      
                }
                form.MaximumSize = new Size(MaxSize.Width, MaxSize.Height);
            }
            else
            {
                if (eventHandler != null)
                {
                    dataGridView.ColumnWidthChanged -= eventHandler;
                }
                while (dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3 < dataGridView.Width)
                {
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.Width += 2;
                    }
                }
                MaxSize = new Size(dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3 + (form.Size.Width - dataGridView.Size.Width), 100000);
                form.MaximumSize = new Size(MaxSize.Width, MaxSize.Height);
                if (eventHandler != null)
                {
                    dataGridView.ColumnWidthChanged += eventHandler;
                }
            }
        }
    }
}
