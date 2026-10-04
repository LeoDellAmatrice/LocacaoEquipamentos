using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static LocacaoEquipamentos.FormAtualizaCliente;

namespace LocacaoEquipamentos
{
    public partial class FormMostraClientes : Form
    {
        public FormMostraClientes()
        {
            InitializeComponent();

            GetDataClientes();
            dataGridViewClientes.ConfiguraBrowseClientes();
        }

        private void GetDataClientes()
        {
            using (var context = new DataContext())
            {
                dataGridViewClientes.DataSource = null;

                List<Cliente> clientes = new Cliente().GetClientes(context);

                dataGridViewClientes.DataSource = clientes
                    .Select(cliente => new
                    {
                        cliente.IdCliente,
                        TipoPessoa = cliente.TipoPessoa.GetDescription(),
                        cliente.Nome,
                        cliente.RazaoSocial,
                        cliente.NomeFantasia
                    }).ToList();
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var dadosOperacao = new DadosOperacaoModel
            {
                LocalRequest = RequestEnum.Incluir
            };

            using (var form = new FormAtualizaCliente(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataClientes();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow is null) return;

            var dadosOperacao = new DadosOperacaoModel
            {
                IdCliente = dataGridViewClientes.GetCurrentRowInt("IdCliente"),
                LocalRequest = RequestEnum.Alterar
            };

            using (var form = new FormAtualizaCliente(dadosOperacao))
            {
                form.ShowDialog();
            }

            GetDataClientes();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow is null) return;

            var dadosOperacao = new DadosOperacaoModel
            {
                IdCliente = dataGridViewClientes.GetCurrentRowInt("IdCliente"),
                LocalRequest = RequestEnum.Excluir
            };

            using (var form = new FormAtualizaCliente(dadosOperacao))
            {
                form.Close();
            }

            GetDataClientes();
        }
    }
}
