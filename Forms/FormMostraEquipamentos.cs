using LocacaoEquipamentos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormMostraEquipamentos : Form
    {
        public FormMostraEquipamentos()
        {
            InitializeComponent();

            ConfiguraBrowse();
        }

        private void ConfiguraBrowse()
        {
            using (var context = new DataContext())
            {
                dataGridView1.Rows.Clear();

                dataGridView1.DataSource = (from equipamentos in context.Equipamentos select equipamentos).ToList();

            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
