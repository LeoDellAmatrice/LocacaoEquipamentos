using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormMostraClientes : Form
    {
        public FormMostraClientes()
        {
            InitializeComponent();

            ConfiguraBrowse();
            GetDataClientes();
        }

        private void GetDataClientes()
        {
            using (var context = new DataContex())
            {
                // dataGridView1.DataSource = (from clientes in context.Clientes select clientes).ToList();

                var lista = (from clientes in context.Clientes select clientes).ToList();

                foreach (var item in lista) 
                {
                    dataGridView1.Rows.Add(item.IdCliente, item.TipoPessoa, item.Nome, item.RazaoSocial, item.NomeFantasia);
                }

            }
        }
        private void AtualizaBrowse()
        {

        }
        private void ConfiguraBrowse()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns.Add("IdCliente", "Id");
            dataGridView1.Columns["IdCliente"].Width = 60;
            dataGridView1.Columns["IdCliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["IdCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("TipoPessoa", "Física/Jurídica");
            dataGridView1.Columns["TipoPessoa"].Width = 100;
            dataGridView1.Columns["TipoPessoa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TipoPessoa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns["Nome"].Width = 200;
            dataGridView1.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("RazaoSocial", "Razão Social");
            dataGridView1.Columns["RazaoSocial"].Width = 200;
            dataGridView1.Columns["RazaoSocial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["RazaoSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("NomeFantasia", "Nome Fantasia");
            dataGridView1.Columns["NomeFantasia"].Width = 200;
            dataGridView1.Columns["NomeFantasia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NomeFantasia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var idCliente = 0;
            using (var form = new FormAtualizaCliente(idCliente, EnumRequest.Incluir))
            {
                form.ShowDialog();
            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow is null) return;

            var idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCliente"].Value);
            using (var form = new FormAtualizaCliente(idCliente, EnumRequest.Alterar))
            {
                form.ShowDialog();
            }

            
        }
    }
}
