using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Forms;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormMostraEquipamentos : Form
    {
        public FormMostraEquipamentos()
        {
            InitializeComponent();

            GetDataEquipamentos();
            DataGridViewEquipamentos.ConfiguraBrowseEquipamentos();
        }

        private void GetDataEquipamentos()
        {
            using (var context = new DataContext())
            {
                DataGridViewEquipamentos.DataSource = null;

                List<Equipamento> equipamentos = new Equipamento().GetEquipamentos(context);

                DataGridViewEquipamentos.DataSource = equipamentos
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
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var dadosOperacao = new FormAtualizaEquipamentos.DadosOperacaoModel()
            {
                LocalRequest = RequestEnum.Incluir,
            };
            using (var form = new FormAtualizaEquipamentos(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataEquipamentos();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (DataGridViewEquipamentos.CurrentRow is null) return;

            var dadosOperacao = new FormAtualizaEquipamentos.DadosOperacaoModel()
            {
                IdEquipamento = DataGridViewEquipamentos.GetCurrentRowInt("IdEquipamento"),
                LocalRequest = RequestEnum.Alterar,
            };
            using (var form = new FormAtualizaEquipamentos(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataEquipamentos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DataGridViewEquipamentos.CurrentRow is null) return;

            var dadosOperacao = new FormAtualizaEquipamentos.DadosOperacaoModel()
            {
                IdEquipamento = DataGridViewEquipamentos.GetCurrentRowInt("IdEquipamento"),
                LocalRequest = RequestEnum.Excluir,
            };
            using (var form = new FormAtualizaEquipamentos(dadosOperacao))
            {
                form.Close();
            }

            GetDataEquipamentos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            TboxVoltagem.Text = (DataGridViewEquipamentos.CurrentRow.Cells["Voltagem"].Value).ToString();

            TboxNumeroSerie.Text = (DataGridViewEquipamentos.CurrentRow.Cells["NumeroSerie"].Value).ToString();

            TboxFabricante.Text = (DataGridViewEquipamentos.CurrentRow.Cells["Fabricante"].Value ?? "").ToString();

            TboxPeso.Text = (DataGridViewEquipamentos.CurrentRow.Cells["Peso"].Value).ToString();

            checkedListBoxOperadorEspecializado.SetItemChecked(0, (bool)DataGridViewEquipamentos.CurrentRow.Cells["OperadorEspecializado"].Value);

            tabPageTipoFerramenta.Parent = null;
            tabPageTipoInformatica.Parent = null;
            tabPageTipoMaquinaPesada.Parent = null;

            switch (DataGridViewEquipamentos.GetCurrentRow("TipoEquipamento").ObterEnumPelaDescricao<TipoEquipamentoEnum>())
            {
                case TipoEquipamentoEnum.Ferramenta:
                    tabPageTipoFerramenta.Parent = tabControlTiposEquipamentos;
                    break;
                case TipoEquipamentoEnum.Informatica:
                    tabPageTipoInformatica.Parent = tabControlTiposEquipamentos;
                    break;
                case TipoEquipamentoEnum.MaquinaPesada:
                    tabPageTipoMaquinaPesada.Parent = tabControlTiposEquipamentos;
                    break;
            }
        }
    }
}
