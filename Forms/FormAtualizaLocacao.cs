using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Forms
{
    public partial class FormAtualizaLocacao : Form
    {
        public class DadosOperacaoModel
        {
            public int IdLocacao { get; set; } = 0;

            public RequestEnum LocalRequest { get; set; }
        }

        public DadosOperacaoModel DadosOperacao { get; private set; }

        public Cliente ClienteLocacao { get; private set; }

        public FormAtualizaLocacao(DadosOperacaoModel dadosOperacao)
        {
            DadosOperacao = dadosOperacao;

            InitializeComponent();


            switch (DadosOperacao.LocalRequest)
            {
                case RequestEnum.Incluir:
                    CamposPadraoIncluir();
                    break;
                case RequestEnum.Alterar:
                    BuscarLocacao(DadosOperacao.IdLocacao);
                    break;
                case RequestEnum.Excluir:
                    BuscarLocacao(DadosOperacao.IdLocacao);
                    Excluir(DadosOperacao.IdLocacao);
                    break;
            }
        }

        private void CamposPadraoIncluir()
        {
            TboxSituacao.Text = SituacaoLocacaoEnum.Aberta.GetDescription();
        }

        private void BuscarItensLocacao(int idLocacao)
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<ItemLocacao> ItensLocacao = new ItemLocacao().GetItensLocacaoById(context, idLocacao);

                    DataGridViewItensLocacao.SetDataSource(ItensLocacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarLocacao(int idLocacao)
        {
            try
            {
                TboxIdLocacao.Text = idLocacao.ToString();

                using (var context = new DataContext())
                {
                    var locacao = new Locacao().GetLocacaoById(context, idLocacao);
                    ClienteLocacao = locacao.GetClienteLocacao();

                    locacao.CalculaValores();

                    CarregaCamposLocacao(locacao);
                    CarregaCamposCliente();
                    BuscarItensLocacao(idLocacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaCamposLocacao(Locacao locacao)
        {
            TboxSituacao.Text = locacao.Situacao.GetDescription();

            DateTimePickerDataRetirada.Value = locacao.DataRetirada;
            DateTimePickerDataPrevDevolucao.Value = locacao.DataPrevisaoDevolucao;

            DateTimePickerDataDevolucao.Checked = locacao.DevolucaoEfetivada;
            DateTimePickerDataDevolucao.Value = locacao.DataEfetivaDevolucao;

            TboxQtdeDiasLocacao.Text = locacao.QtdeDias.ToString();
            TboxObservacao.Text = locacao.Observacao;

            TboxValorMultaDiaria.Text = locacao.ValorMultaDiaria.ToString();
            TboxValorDiaria.Text = locacao.ValorDiaria.ToString();
            TboxValorTotal.Text = locacao.ValorTotal.ToString();
        }

        private void CalculaValores()
        {
            using (var context = new DataContext())
            {
                Locacao locacao = new Locacao().SetLocacao(GetLocacaoModel(), context);

                locacao.CalculaDias();
                locacao.CalculaValores();
            }
        }

        private LocacaoSetModel GetLocacaoModel()
        {
            return new LocacaoSetModel
            {
                IdLocacao = Convert.ToInt32("0" + TboxIdLocacao.Text),
                IdCliente = Convert.ToInt32("0" + TboxCodigoCliente.Text),
                DataRetirada = DateTimePickerDataRetirada.Value,
                DataPrevisaoDevolucao = DateTimePickerDataPrevDevolucao.Value,
                DevolucaoEfetivada = DateTimePickerDataDevolucao.Checked,
                DataEfetivaDevolucao = DateTimePickerDataDevolucao.Value,
                Situacao = TboxSituacao.Text.ObterEnumPelaDescricao<SituacaoLocacaoEnum>(),
                Observacao = TboxObservacao.Text
            };
        }

        private bool Salvar()
        {
            try
            {
                var locacao = new Locacao();

                using (var context = new DataContext())
                {
                    var dadosLocacao = GetLocacaoModel();

                    locacao.SetLocacao(dadosLocacao, context);

                    switch (DadosOperacao.LocalRequest)
                    {
                        case RequestEnum.Incluir:
                            locacao.Incluir(context);
                            break;
                        case RequestEnum.Alterar:
                            locacao.Alterar(context);
                            break;
                    }

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Excluir(int idLocacao)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var locacao = new Locacao();

                    locacao.Excluir(context, idLocacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSelecionaCliente_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelecionaCliente())
            {
                form.ShowDialog();
                ClienteLocacao = form.ClienteSelecionado;

                CarregaCamposCliente();
            }
        }

        private void CarregaCamposCliente()
        {
            TboxCodigoCliente.Text = ClienteLocacao.IdCliente.ToString();
            TboxNomeCliente.Text = ClienteLocacao.GetNome();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar()) Close();
        }

        private void DateTimePickerDataPrevDevolucao_ValueChanged(object sender, EventArgs e)
        {
            //CalculaQtdeDias();
        }
    }
}
