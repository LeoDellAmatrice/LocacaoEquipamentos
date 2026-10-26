using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public FormAtualizaLocacao(DadosOperacaoModel dadosOperacao)
        {
            DadosOperacao = dadosOperacao;

            InitializeComponent();


            switch (DadosOperacao.LocalRequest)
            {
                case RequestEnum.Incluir:
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

        private void BuscarLocacao(int IdLocacao)
        {
            try
            {
                // Definir Tbox IdLocacao

                using (var context = new DataContext())
                {
                    var locacao = new Locacao().GetLocacaoById(context, IdLocacao);

                    // carregar campos 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
