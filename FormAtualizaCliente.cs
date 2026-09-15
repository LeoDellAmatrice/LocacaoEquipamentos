using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using System;
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
            switch ((TipoPessoaEnum)CbTipoPessoa.SelectedItem)
            {
                case TipoPessoaEnum.Fisica:
                    TabPagePessoaJuridica.Parent = null;
                    TabPagePessoaFisica.Parent = TabControlTipoPessoa;
                    break;
                case TipoPessoaEnum.Juridica:
                    TabPagePessoaJuridica.Parent = TabControlTipoPessoa;
                    TabPagePessoaFisica.Parent = null;
                    break;
            }
        }

        private void BuscarCliente(int idCliente)
        {
            TboxIdCliente.Text = idCliente.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    var cliente = context.Clientes.Find(idCliente) ?? throw new Exception("Erro ao Encontrar o cliente.");

                    CarregaCamposCliente(cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaCamposCliente(Clientes cliente)
        {
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
                var cliente = new Clientes();

                cliente.SetTipoPessoa((TipoPessoaEnum)CbTipoPessoa.SelectedItem);

                switch (cliente.TipoPessoa)
                {
                    case TipoPessoaEnum.Fisica:
                        cliente.SetPessoaFisica(Convert.ToInt32("0"+TboxIdCliente.Text), TboxNome.Text, TboxTelefone.Text, TboxEmail.Text, TboxCPF.Text);
                        break;
                    case TipoPessoaEnum.Juridica:
                        cliente.SetPessoaJuridica(Convert.ToInt32("0" + TboxIdCliente.Text), TboxRazaoSocial.Text, TboxNomeFantasia.Text, TboxTelefone.Text, TboxEmail.Text, TboxCNPJ.Text);
                        break;
                }

                using (var context = new DataContext())
                {
                    switch (LocalRequest)
                    {
                        case RequestEnum.Incluir:
                            context.Clientes.Add(cliente);
                            break;
                        case RequestEnum.Alterar:
                            context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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
    }
}
