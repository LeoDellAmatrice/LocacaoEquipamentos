using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Forms
{
    public partial class FormMostraLocacao : Form
    {
        public FormMostraLocacao()
        {
            InitializeComponent();

            GetDataLocacao();
        }

        private void GetDataLocacao()
        {
            using (var context = new DataContext())
            {
                List<Locacao> locacoes = new Locacao().GetLocacoes(context);

                DataGridViewLocacao.SetDataSource(locacoes);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var dadosOperacao = new FormAtualizaLocacao.DadosOperacaoModel
            {
                LocalRequest = RequestEnum.Incluir
            };

            using (var form = new FormAtualizaLocacao(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataLocacao();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var dadosOperacao = new FormAtualizaLocacao.DadosOperacaoModel
            {
                IdLocacao = DataGridViewLocacao.GetCurrentRowInt("IdLocacao"),
                LocalRequest = RequestEnum.Alterar
            };

            using (var form = new FormAtualizaLocacao(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataLocacao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var dadosOperacao = new FormAtualizaLocacao.DadosOperacaoModel
            {
                IdLocacao = DataGridViewLocacao.GetCurrentRowInt("IdLocacao"),
                LocalRequest = RequestEnum.Excluir
            };

            using (var form = new FormAtualizaLocacao(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataLocacao();
        }
    }
}
