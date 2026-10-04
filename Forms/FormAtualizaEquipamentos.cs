using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using System;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Forms
{
    public partial class FormAtualizaEquipamentos : Form
    {
        public class DadosOperacaoModel
        {
            public int IdEquipamento {  get; set; }

            public RequestEnum LocalRequest {  get; set; }
        }

        private DadosOperacaoModel DadosOperacao { get; set; }

        public FormAtualizaEquipamentos(DadosOperacaoModel dadosOperacao)
        {
            DadosOperacao = dadosOperacao;

            InitializeComponent();

            InicializarCampos();

            switch (DadosOperacao.LocalRequest)
            {
                case RequestEnum.Incluir:
                    break;
                case RequestEnum.Alterar:
                    BuscarEquipamento(DadosOperacao.IdEquipamento);
                    break;
                case RequestEnum.Excluir:
                    BuscarEquipamento(DadosOperacao.IdEquipamento);
                    Excluir(DadosOperacao.IdEquipamento);
                    break;
            }
        }

        private bool Excluir(int idEquipamento)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var equipamento = new Equipamento();

                    equipamento.Excluir(context, idEquipamento);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void InicializarCampos()
        {
            CbSituacao.DataSource = Enum.GetValues(typeof(SituacaoEquipamentoEnum));
            CbTipoEquipamento.DataSource = Enum.GetValues(typeof(TipoEquipamentoEnum));

            ControlTabTipoEquipamento();
        }

        private void BuscarEquipamento(int idEquipamento)
        {
            try
            {
                TboxIdEquipamento.Text = idEquipamento.ToString();

                using (var context = new DataContext())
                {
                    var equipamento = new Equipamento();

                    CarregaCamposEquipamento(equipamento.GetEquipamentoById(idEquipamento, context));
                }

                ControlTabTipoEquipamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaCamposEquipamento(Equipamento equipamento)
        {

            TboxDescricao.Text = equipamento.Descricao;
            TboxValorDiaria.Text = equipamento.ValorDiaria.ToString();
            
            CbSituacao.SelectedItem = equipamento.SituacaoEquipamento;
            CbTipoEquipamento.SelectedItem = equipamento.TipoEquipamento;

            DateTimePickerAquisicao.Value = equipamento.DataAquisicao;

            // Especificos
            TboxVoltagem.Text = equipamento.Voltagem.ToString();

            TboxNumeroSerie.Text = equipamento.NumeroSerie.ToString();
            TboxFabricante.Text = equipamento.Fabricante;

            TboxPeso.Text = equipamento.Peso.ToString();
            checkedListBoxOperadorEspecializado.SetItemChecked(0, equipamento.OperadorEspecializado);

        }

        private bool Salvar()
        {
            try
            {
                var equipamento = new Equipamento();

                equipamento.SetEquipamentoBase(Convert.ToInt32("0" + TboxIdEquipamento.Text), TboxDescricao.Text, Convert.ToDecimal(TboxValorDiaria.Text), DateTimePickerAquisicao.Value, (SituacaoEquipamentoEnum)CbSituacao.SelectedItem);
                
                equipamento.SetTipoEquipamento((TipoEquipamentoEnum)CbTipoEquipamento.SelectedItem);

                switch (equipamento.TipoEquipamento)
                {
                    case TipoEquipamentoEnum.Ferramenta:
                        equipamento.SetEspecifico(Convert.ToDecimal(TboxVoltagem.Text));
                        break;
                    case TipoEquipamentoEnum.Informatica:
                        equipamento.SetEspecifico(Convert.ToInt32(TboxNumeroSerie.Text), TboxFabricante.Text);
                        break;
                    case TipoEquipamentoEnum.MaquinaPesada:
                        equipamento.SetEspecifico(Convert.ToDecimal(TboxPeso.Text), checkedListBoxOperadorEspecializado.GetItemChecked(0));
                        break;
                }
                

                using (var context = new DataContext())
                {
                    switch (DadosOperacao.LocalRequest)
                    {
                        case RequestEnum.Incluir:
                            equipamento.Incluir(context);
                            break;
                        case RequestEnum.Alterar:
                            equipamento.Alterar(context);
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

        private void ControlTabTipoEquipamento()
        {
            tabPageTipoFerramenta.Parent = null;
            tabPageTipoInformatica.Parent = null;
            tabPageTipoMaquinaPesada.Parent = null;

            switch ((TipoEquipamentoEnum)CbTipoEquipamento.SelectedItem)
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

        private void CbTipoEquipamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ControlTabTipoEquipamento();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar()) Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
