using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewExtension
    {
        public static string GetCurrentRow(this DataGridView dataGridView, string column)
        {
            return (dataGridView.CurrentRow.Cells[column].Value ?? "").ToString();
        }

        public static int GetCurrentRowInt(this DataGridView dataGridView, string column, int defaultReturn = 0)
        {
            if (int.TryParse(GetCurrentRow(dataGridView, column), out int rowInt)) return rowInt;
            
            return defaultReturn;
        }

        public static bool GetCurrentRowBool(this DataGridView dataGridView, string column, bool defaultReturn = false)
        {
            if (bool.TryParse(GetCurrentRow(dataGridView, column), out bool rowBool)) return rowBool;

            return defaultReturn;
        }
    }
}
