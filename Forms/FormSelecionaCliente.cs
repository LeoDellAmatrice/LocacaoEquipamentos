using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Shareds.Extensions;
using System;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Forms
{
    public partial class FormSelecionaCliente : Form
    {
        public Cliente ClienteSelecionado {  get; private set; } = new Cliente();

        public FormSelecionaCliente()
        {
            InitializeComponent();

            GetDataClientes();
        }

        private void GetDataClientes()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var clientes = new Cliente().GetClientes(context);

                    DataGridViewClientes.SetDataSource(clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionaCliente()
        {
            using (var context = new DataContext())
            {
                ClienteSelecionado = new Cliente().GetClienteById(DataGridViewClientes.GetCurrentRowInt("IdCliente"), context);
            }

            Close();
        }

        private void DataGridViewClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelecionaCliente();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaCliente();
        }
    }
}
