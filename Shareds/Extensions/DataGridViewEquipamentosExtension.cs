using LocacaoEquipamentos.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewEquipamentosExtension
    {
        public static void SetDataSource(this DataGridView dataGridViewEquipamentos, List<Equipamento> equipamentos)
        {
            dataGridViewEquipamentos.DataSource = null;

            dataGridViewEquipamentos.DataSource = equipamentos
                    .Select(equipamento => new
                    {
                        equipamento.IdEquipamento,
                        equipamento.Descricao,
                        equipamento.DataAquisicao,
                        SituacaoEquipamento = equipamento.SituacaoEquipamento.GetDescription(),
                        TipoEquipamento = equipamento.TipoEquipamento.GetDescription(),
                        MultaDiaria = equipamento.GetMultaDiaria(),
                        equipamento.ValorDiaria,
                        equipamento.Voltagem,
                        equipamento.NumeroSerie,
                        equipamento.Fabricante,
                        equipamento.Peso,
                        equipamento.OperadorEspecializado
                    }).ToList();

            ConfiguraBrowseEquipamentos(dataGridViewEquipamentos);
        }

        public static void ConfiguraBrowseEquipamentos(this DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridViewEquipamentos.DefaultCellStyle.Font = new Font("Arial", 9);

            ConfiguraIdEquipamentoColumn(dataGridViewEquipamentos);

            ConfiguraDescricaoColumn(dataGridViewEquipamentos);

            ConfiguraDataAquisicaoColumn(dataGridViewEquipamentos);

            ConfiguraSituacaoEquipamentoColumn(dataGridViewEquipamentos);

            ConfiguraTipoEquipamentoColumn(dataGridViewEquipamentos);

            ConfiguraMultaDiariaColumn(dataGridViewEquipamentos);

            ConfiguraValorDiariaColumn(dataGridViewEquipamentos);

            ConfiguraVoltagemColumn(dataGridViewEquipamentos);

            ConfiguraNumeroSerieColumn(dataGridViewEquipamentos);

            ConfiguraFabricanteColumn(dataGridViewEquipamentos);

            ConfiguraPesoColumn(dataGridViewEquipamentos);

            ConfiguraOperadorEspecializadoColumn(dataGridViewEquipamentos);
        }

        private static void ConfiguraIdEquipamentoColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["IdEquipamento"].HeaderCell.Value = "Id";
            dataGridViewEquipamentos.Columns["IdEquipamento"].Width = 60;
            dataGridViewEquipamentos.Columns["IdEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["IdEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private static void ConfiguraDescricaoColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["Descricao"].HeaderCell.Value = "Descrição";
            dataGridViewEquipamentos.Columns["Descricao"].Width = 120;
            dataGridViewEquipamentos.Columns["Descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraDataAquisicaoColumn(DataGridView dataGridViewEquipamentos) 
        {
            dataGridViewEquipamentos.Columns["DataAquisicao"].HeaderCell.Value = "Data Aquisição";
            dataGridViewEquipamentos.Columns["DataAquisicao"].Width = 120;
            dataGridViewEquipamentos.Columns["DataAquisicao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["DataAquisicao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["DataAquisicao"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private static void ConfiguraSituacaoEquipamentoColumn(DataGridView dataGridViewEquipamentos) 
        {
            dataGridViewEquipamentos.Columns["SituacaoEquipamento"].HeaderCell.Value = "Situação";
            dataGridViewEquipamentos.Columns["SituacaoEquipamento"].Width = 90;
            dataGridViewEquipamentos.Columns["SituacaoEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["SituacaoEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraTipoEquipamentoColumn(DataGridView dataGridViewEquipamentos) 
        {
            dataGridViewEquipamentos.Columns["TipoEquipamento"].HeaderCell.Value = "Tipo";
            dataGridViewEquipamentos.Columns["TipoEquipamento"].Width = 90;
            dataGridViewEquipamentos.Columns["TipoEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["TipoEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraMultaDiariaColumn(DataGridView dataGridViewEquipamentos) 
        {
            dataGridViewEquipamentos.Columns["MultaDiaria"].HeaderCell.Value = "Multa Diária";
            dataGridViewEquipamentos.Columns["MultaDiaria"].Width = 110;
            dataGridViewEquipamentos.Columns["MultaDiaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["MultaDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEquipamentos.Columns["MultaDiaria"].DefaultCellStyle.Format = "P0";
        }

        private static void ConfiguraValorDiariaColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["ValorDiaria"].HeaderCell.Value = "Valor Diária";
            dataGridViewEquipamentos.Columns["ValorDiaria"].Width = 110;
            dataGridViewEquipamentos.Columns["ValorDiaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEquipamentos.Columns["ValorDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEquipamentos.Columns["ValorDiaria"].DefaultCellStyle.Format = "C2";
        }

        private static void ConfiguraVoltagemColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["Voltagem"].Visible = false;
        }

        private static void ConfiguraNumeroSerieColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["NumeroSerie"].Visible = false;
        }

        private static void ConfiguraFabricanteColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["Fabricante"].Visible = false;
        }

        private static void ConfiguraPesoColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["Peso"].Visible = false;
        }

        private static void ConfiguraOperadorEspecializadoColumn(DataGridView dataGridViewEquipamentos)
        {
            dataGridViewEquipamentos.Columns["OperadorEspecializado"].Visible = false;
        }
    }
}
