using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormAtualizaCliente : Form
    {
        public DadosOperacaoModel DadosOperacao { get; set; }

        public class DadosOperacaoModel
        {
            public int IdCliente { get; set; } = 0;

            public RequestEnum LocalRequest { get; set; }

        }
        public FormAtualizaCliente(DadosOperacaoModel dadosOperacao)
        {
           DadosOperacao = dadosOperacao;

            InitializeComponent();

            InicializaCampos();

            switch (DadosOperacao.LocalRequest)
            {
                case RequestEnum.Incluir:
                    break;
                case RequestEnum.Alterar:
                    BuscarCliente(DadosOperacao.IdCliente);
                    break;
                case RequestEnum.Excluir:
                    BuscarCliente(DadosOperacao.IdCliente);
                    Excluir(DadosOperacao.IdCliente);
                    break;
            }
        }

        private void InicializaCampos()
        {
            var descricoesTipoPessoa = new List<string>();
            foreach (TipoPessoaEnum tipo in Enum.GetValues(typeof(TipoPessoaEnum)))
            {
                descricoesTipoPessoa.Add(tipo.GetDescription());
            }

            CbTipoPessoa.DataSource = descricoesTipoPessoa;

            ExibeCamposTipoPessoa();
        }

        private void ExibeCamposTipoPessoa()
        {
            TabPagePessoaJuridica.Parent = null;
            TabPagePessoaFisica.Parent = null;

            switch (CbTipoPessoa.SelectedItem.ToString().ObterEnumPelaDescricao<TipoPessoaEnum>())
            {
                case TipoPessoaEnum.Fisica:
                    TabPagePessoaFisica.Parent = TabControlTipoPessoa;
                    break;
                case TipoPessoaEnum.Juridica:
                    TabPagePessoaJuridica.Parent = TabControlTipoPessoa;
                    break;
            }
        }

        private void BuscarCliente(int idCliente)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var cliente = new Cliente();

                    CarregaCamposCliente(cliente.GetClienteById(idCliente, context));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaCamposCliente(Cliente cliente)
        {
            TboxIdCliente.Text = cliente.IdCliente.ToString();

            CbTipoPessoa.SelectedItem = cliente.TipoPessoa;
            ExibeCamposTipoPessoa();

            TboxCNPJ.Text = cliente.Cnpj;
            TboxRazaoSocial.Text = cliente.RazaoSocial;
            TboxNomeFantasia.Text = cliente.NomeFantasia;
            TboxNome.Text = cliente.Nome;
            TboxCPF.Text = cliente.Cpf;
            TboxTelefone.Text = cliente.Telefone;
            TboxEmail.Text = cliente.Email;
        }

        private void CbTipoPessoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ExibeCamposTipoPessoa();
        }

        private bool Salvar()
        {
            try
            {
                var cliente = new Cliente();

                cliente.SetTipoPessoa(CbTipoPessoa.SelectedItem.ToString().ObterEnumPelaDescricao<TipoPessoaEnum>());

                switch (cliente.TipoPessoa)
                {
                    case TipoPessoaEnum.Fisica:
                        cliente.SetPessoa(Convert.ToInt32("0"+TboxIdCliente.Text), TboxNome.Text, TboxTelefone.Text, TboxEmail.Text, TboxCPF.Text);
                        break;
                    case TipoPessoaEnum.Juridica:
                        cliente.SetPessoa(Convert.ToInt32("0" + TboxIdCliente.Text), TboxRazaoSocial.Text, TboxNomeFantasia.Text, TboxTelefone.Text, TboxEmail.Text, TboxCNPJ.Text);
                        break;
                }

                cliente.ValidarCampos();

                using (var context = new DataContext())
                {
                    switch (DadosOperacao.LocalRequest)
                    {
                        case RequestEnum.Incluir:
                            cliente.Incluir(context);
                            break;
                        case RequestEnum.Alterar:
                            cliente.Alterar(context);
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

        private bool Excluir(int idCliente)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var cliente = new Cliente();

                    cliente.Excluir(context, idCliente);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
