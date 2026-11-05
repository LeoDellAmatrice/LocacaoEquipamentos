using LocacaoEquipamentos.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewItensLocacaoExtension
    {
        public static void SetDataSource(this DataGridView dataGridViewItensLocacao, List<ItemLocacao> itensLocacao)
        {
            dataGridViewItensLocacao.DataSource = null;

            dataGridViewItensLocacao.DataSource = itensLocacao
                .Select(itemLocacao => new
                {
                    itemLocacao.SequenciaItem
                }).ToList();

            ConfiguraBrowseItensLocacao(dataGridViewItensLocacao);
        }

        private static void ConfiguraBrowseItensLocacao(this DataGridView dataGridViewItensLocacao)
        {
            dataGridViewItensLocacao.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridViewItensLocacao.DefaultCellStyle.Font = new Font("Arial", 9);

            ConfiguraSequenciaItemColumn(dataGridViewItensLocacao);
        }

        private static void ConfiguraSequenciaItemColumn(DataGridView dataGridViewItensLocacao)
        {
            dataGridViewItensLocacao.Columns["SequenciaItem"].HeaderCell.Value = "Seq.";
            dataGridViewItensLocacao.Columns["SequenciaItem"].Width = 60;
            dataGridViewItensLocacao.Columns["SequenciaItem"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewItensLocacao.Columns["SequenciaItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
