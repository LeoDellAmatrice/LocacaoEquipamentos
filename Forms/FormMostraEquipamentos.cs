using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Forms;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormMostraEquipamentos : Form
    {
        public FormMostraEquipamentos()
        {
            InitializeComponent();

            GetDataEquipamentos();
        }

        private void GetDataEquipamentos()
        {
            using (var context = new DataContext())
            {
                List<Equipamento> equipamentos = new Equipamento().GetEquipamentos(context);

                DataGridViewEquipamentos.SetDataSource(equipamentos);
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

        private void DataGridViewEquipamentos_SelectionChanged(object sender, EventArgs e)
        {

            TboxVoltagem.Text = DataGridViewEquipamentos.GetCurrentRow("Voltagem");

            TboxNumeroSerie.Text = DataGridViewEquipamentos.GetCurrentRow("NumeroSerie");

            TboxFabricante.Text = DataGridViewEquipamentos.GetCurrentRow("Fabricante");

            TboxPeso.Text = DataGridViewEquipamentos.GetCurrentRow("Peso");

            checkedListBoxOperadorEspecializado.SetItemChecked(0, DataGridViewEquipamentos.GetCurrentRowBool("OperadorEspecializado"));

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
