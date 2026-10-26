using LocacaoEquipamentos.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewLocacaoExtension
    {
        public static void SetDataSource(this DataGridView dataGridViewLocacao, List<Locacao> locacoes)
        {
            dataGridViewLocacao.DataSource = null;

            dataGridViewLocacao.DataSource = locacoes
                .Select(locacao => new
                {
                    locacao.IdLocacao
                }).ToList();

            ConfiguraBrowseLocacao(dataGridViewLocacao);
        }

        public static void ConfiguraBrowseLocacao(this DataGridView dataGridViewLocacao)
        {
            dataGridViewLocacao.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridViewLocacao.DefaultCellStyle.Font = new Font("Arial", 9);

            ConfiguraIdLocacaoColumn(dataGridViewLocacao);

        }

        private static void ConfiguraIdLocacaoColumn(DataGridView dataGridViewLocacao)
        {
            dataGridViewLocacao.Columns["IdLocacao"].HeaderCell.Value = "Id";
            dataGridViewLocacao.Columns["IdLocacao"].Width = 100;
            dataGridViewLocacao.Columns["IdLocacao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLocacao.Columns["IdLocacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}