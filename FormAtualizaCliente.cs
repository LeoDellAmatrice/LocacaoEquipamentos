using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocacaoEquipamentos
{
    public partial class FormAtualizaCliente : Form
    {
        private EnumRequest LocalRequest { get; set; }
        public FormAtualizaCliente(int idCliente, EnumRequest localRequest)
        {
            LocalRequest = localRequest;

            InitializeComponent();

            InicializaCampos();

            switch (LocalRequest)
            {
                case EnumRequest.Incluir:
                    break;
                case EnumRequest.Alterar:
                    BuscarCliente(idCliente);
                    break;
                case EnumRequest.Excluir:
                    BuscarCliente(idCliente);
                    break;
            }

            
        }

        private void InicializaCampos()
        {
            CbTipoPessoa.DataSource = Enum.GetValues(typeof(EnumTipoPessoa));

            ExibeCamposTipoPessoa();
        }

        private void ExibeCamposTipoPessoa()
        {
            switch ((EnumTipoPessoa)CbTipoPessoa.SelectedItem)
            {
                case EnumTipoPessoa.Fisica:
                    TabPagePessoaJuridica.Parent = null;
                    TabPagePessoaFisica.Parent = TabControlTipoPessoa;
                    break;
                case EnumTipoPessoa.Juridica:
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
                using (var context = new DataContex())
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

                cliente.SetTipoPessoa((EnumTipoPessoa)CbTipoPessoa.SelectedItem);

                switch (cliente.TipoPessoa)
                {
                    case EnumTipoPessoa.Fisica:
                        cliente.SetPessoaFisica(Convert.ToInt32("0"+TboxIdCliente.Text), TboxNome.Text, TboxTelefone.Text, TboxEmail.Text, TboxCPF.Text);
                        break;
                    case EnumTipoPessoa.Juridica:
                        cliente.SetPessoaJuridica(Convert.ToInt32("0" + TboxIdCliente.Text), TboxRazaoSocial.Text, TboxNomeFantasia.Text, TboxTelefone.Text, TboxEmail.Text, TboxCNPJ.Text);
                        break;
                }

                using (var context = new DataContex())
                {
                    switch (LocalRequest)
                    {
                        case EnumRequest.Incluir:
                            context.Clientes.Add(cliente);
                            break;
                        case EnumRequest.Alterar:
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar()) Close();
        }
    }
}
