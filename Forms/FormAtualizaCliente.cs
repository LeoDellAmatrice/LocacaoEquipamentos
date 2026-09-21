using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormAtualizaCliente : Form
    {
        private RequestEnum LocalRequest { get; set; }
        public FormAtualizaCliente(int idCliente, RequestEnum localRequest)
        {
            LocalRequest = localRequest;

            InitializeComponent();

            InicializaCampos();

            switch (LocalRequest)
            {
                case RequestEnum.Incluir:
                    break;
                case RequestEnum.Alterar:
                    BuscarCliente(idCliente);
                    break;
                case RequestEnum.Excluir:
                    BuscarCliente(idCliente);
                    Excluir(idCliente);
                    break;
            }
        }

        private void InicializaCampos()
        {
            CbTipoPessoa.DataSource = Enum.GetValues(typeof(TipoPessoaEnum));

            ExibeCamposTipoPessoa();
        }

        private void ExibeCamposTipoPessoa()
        {
            TabPagePessoaJuridica.Parent = null;
            TabPagePessoaFisica.Parent = null;

            switch ((TipoPessoaEnum)CbTipoPessoa.SelectedItem)
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
                    var cliente = new Clientes();

                    CarregaCamposCliente(cliente.GetClienteById(idCliente, context));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaCamposCliente(Clientes cliente)
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

        private void ValidarCampos()
        {
            ValidarCamposGeral();

            if ((TipoPessoaEnum)CbTipoPessoa.SelectedItem == TipoPessoaEnum.Fisica) ValidarCamposFisica();
            if ((TipoPessoaEnum)CbTipoPessoa.SelectedItem == TipoPessoaEnum.Juridica) ValidarCamposJuridica();

            void ValidarCamposGeral()
            {

            }

            void ValidarCamposFisica()
            {

            }

            void ValidarCamposJuridica()
            {

            }
        }

        private void CbTipoPessoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ExibeCamposTipoPessoa();
        }

        private bool Salvar()
        {
            try
            {
                ValidarCampos();

                var cliente = new Clientes();

                cliente.SetTipoPessoa((TipoPessoaEnum)CbTipoPessoa.SelectedItem);

                switch (cliente.TipoPessoa)
                {
                    case TipoPessoaEnum.Fisica:
                        cliente.SetPessoa(Convert.ToInt32("0"+TboxIdCliente.Text), TboxNome.Text, TboxTelefone.Text, TboxEmail.Text, TboxCPF.Text);
                        break;
                    case TipoPessoaEnum.Juridica:
                        cliente.SetPessoa(Convert.ToInt32("0" + TboxIdCliente.Text), TboxRazaoSocial.Text, TboxNomeFantasia.Text, TboxTelefone.Text, TboxEmail.Text, TboxCNPJ.Text);
                        break;
                }

                using (var context = new DataContext())
                {
                    switch (LocalRequest)
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
                    var cliente = new Clientes();

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
