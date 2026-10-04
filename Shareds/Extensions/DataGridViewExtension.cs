using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewExtension
    {
        public static int GetCurrentRowInt(this DataGridView dataGridView, string column, int defaultReturn = 0)
        {
            if (int.TryParse(dataGridView.CurrentRow.Cells[column].Value.ToString(), out int rowInt)) return rowInt;
            
            return defaultReturn;
        }

        public static string GetCurrentRow(this DataGridView dataGridView, string column)
        {
            return dataGridView.CurrentRow.Cells[column].Value.ToString();
        }
    }
}
