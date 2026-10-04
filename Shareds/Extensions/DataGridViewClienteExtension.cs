using LocacaoEquipamentos.Classes.DataBase;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Shareds.Extensions
{
    public static class DataGridViewClienteExtension
    {
        public static void SetDataSource(this DataGridView dataGridViewClientes, List<Cliente> clientes)
        {
            dataGridViewClientes.DataSource = null;

            dataGridViewClientes.DataSource = clientes
                .Select(cliente => new
                {
                    cliente.IdCliente,
                    TipoPessoa = cliente.TipoPessoa.GetDescription(),
                    cliente.Nome,
                    cliente.RazaoSocial,
                    cliente.NomeFantasia
                }).ToList();

            ConfiguraBrowseClientes(dataGridViewClientes);
        }

        public static void ConfiguraBrowseClientes(this DataGridView dataGridViewCliente)
        {
            dataGridViewCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridViewCliente.DefaultCellStyle.Font = new Font("Arial", 9);

            ConfiguraIdClienteColumn(dataGridViewCliente);

            ConfiguraTipoPessoaColumn(dataGridViewCliente);

            ConfiguraNomeColumn(dataGridViewCliente);

            ConfiguraRazaoSocialColumn(dataGridViewCliente);

            ConfiguraNomeFantasiaColumn(dataGridViewCliente);
        }

        private static void ConfiguraIdClienteColumn(DataGridView dataGridViewCliente)
        {
            dataGridViewCliente.Columns["IdCliente"].HeaderCell.Value = "Id";
            dataGridViewCliente.Columns["IdCliente"].Width = 60;
            dataGridViewCliente.Columns["IdCliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCliente.Columns["IdCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private static void ConfiguraTipoPessoaColumn(DataGridView dataGridViewCliente) 
        {
            dataGridViewCliente.Columns["TipoPessoa"].HeaderCell.Value = "Física/Jurídica";
            dataGridViewCliente.Columns["TipoPessoa"].Width = 100;
            dataGridViewCliente.Columns["TipoPessoa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCliente.Columns["TipoPessoa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraNomeColumn(DataGridView dataGridViewCliente)
        {
            dataGridViewCliente.Columns["Nome"].HeaderCell.Value = "Nome";
            dataGridViewCliente.Columns["Nome"].Width = 200;
            dataGridViewCliente.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCliente.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraRazaoSocialColumn(DataGridView dataGridViewCliente)
        {
            dataGridViewCliente.Columns["RazaoSocial"].HeaderCell.Value = "Razão Social";
            dataGridViewCliente.Columns["RazaoSocial"].Width = 200;
            dataGridViewCliente.Columns["RazaoSocial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCliente.Columns["RazaoSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private static void ConfiguraNomeFantasiaColumn(DataGridView dataGridViewCliente)
        {
            dataGridViewCliente.Columns["NomeFantasia"].HeaderCell.Value = "Nome Fantasia";
            dataGridViewCliente.Columns["NomeFantasia"].Width = 200;
            dataGridViewCliente.Columns["NomeFantasia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCliente.Columns["NomeFantasia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
    }
}
