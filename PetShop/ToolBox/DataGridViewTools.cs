using System.Windows.Forms;

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
    }
}
