using LocacaoEquipamentos.Classes;
using LocacaoEquipamentos.Enums;
using LocacaoEquipamentos.Forms;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LocacaoEquipamentos
{
    public partial class FormMostraEquipamentos : Form
    {
        public FormMostraEquipamentos()
        {
            InitializeComponent();

            ConfiguraBrowse();
            GetDataEquipamentos();
        }

        private void ConfiguraBrowse()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns.Add("IdEquipamento", "Id");
            dataGridView1.Columns["IdEquipamento"].Width = 60;
            dataGridView1.Columns["IdEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["IdEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("Descricao", "Descrição");
            dataGridView1.Columns["Descricao"].Width = 120;
            dataGridView1.Columns["Descricao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("DataAquisicao", "Data Aquisição");
            dataGridView1.Columns["DataAquisicao"].Width = 120;
            dataGridView1.Columns["DataAquisicao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataAquisicao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DataAquisicao"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dataGridView1.Columns.Add("SituacaoEquipamento", "Situação");
            dataGridView1.Columns["SituacaoEquipamento"].Width = 90;
            dataGridView1.Columns["SituacaoEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SituacaoEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("TipoEquipamento", "Tipo");
            dataGridView1.Columns["TipoEquipamento"].Width = 90;
            dataGridView1.Columns["TipoEquipamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TipoEquipamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns.Add("MultaDiaria", "Multa Diária");
            dataGridView1.Columns["MultaDiaria"].Width = 110;
            dataGridView1.Columns["MultaDiaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["MultaDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["MultaDiaria"].DefaultCellStyle.Format = "P0";

            dataGridView1.Columns.Add("ValorDiaria", "Valor Diária");
            dataGridView1.Columns["ValorDiaria"].Width = 110;
            dataGridView1.Columns["ValorDiaria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ValorDiaria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ValorDiaria"].DefaultCellStyle.Format = "C2";

            dataGridView1.Columns.Add("Voltagem", "Voltagem");
            dataGridView1.Columns["Voltagem"].Visible = false;

            dataGridView1.Columns.Add("NumeroSerie", "Número Série");
            dataGridView1.Columns["NumeroSerie"].Visible = false;

            dataGridView1.Columns.Add("Fabricante", "Fabricante");
            dataGridView1.Columns["Fabricante"].Visible = false;

            dataGridView1.Columns.Add("Peso", "Peso");
            dataGridView1.Columns["Peso"].Visible = false;

            dataGridView1.Columns.Add("OperadorEspecializado", "Operado Especializado");
            dataGridView1.Columns["OperadorEspecializado"].Visible = false;
        }

        private void GetDataEquipamentos()
        {
            using (var context = new DataContext())
            {
                dataGridView1.Rows.Clear();

                var lista = (from equipamentos in context.Equipamentos select equipamentos).ToList();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.IdEquipamento, item.Descricao, item.DataAquisicao, item.SituacaoEquipamento, 
                        item.TipoEquipamento, item.GetMultaDiaria(), item.ValorDiaria, item.Voltagem, item.NumeroSerie, item.Fabricante,
                        item.Peso, item.OperadorEspecializado);
                }

            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var idEquipamento = 0;
            using (var form = new FormAtualizaEquipamentos(idEquipamento, RequestEnum.Incluir))
            {
                form.ShowDialog();
            }

            GetDataEquipamentos();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            TboxVoltagem.Text = (dataGridView1.CurrentRow.Cells["Voltagem"].Value).ToString();

            TboxNumeroSerie.Text = (dataGridView1.CurrentRow.Cells["NumeroSerie"].Value).ToString();

            TboxFabricante.Text = (dataGridView1.CurrentRow.Cells["Fabricante"].Value ?? "").ToString();

            TboxPeso.Text = (dataGridView1.CurrentRow.Cells["Peso"].Value).ToString();

            checkedListBoxOperadorEspecializado.SetItemChecked(0, (bool)dataGridView1.CurrentRow.Cells["OperadorEspecializado"].Value);

            tabPageTipoFerramenta.Parent = null;
            tabPageTipoInformatica.Parent = null;
            tabPageTipoMaquinaPesada.Parent = null;

            switch (dataGridView1.CurrentRow.Cells["TipoEquipamento"].Value)
            {
                case TipoEquipamentoEnum.Ferramenta:
                    tabPageTipoFerramenta.Parent = tabControlTiposEquipamentos;
                    break;
                case TipoEquipamentoEnum.Informatica:
                    tabPageTipoInformatica.Parent = tabControlTiposEquipamentos;
                    break;
                case TipoEquipamentoEnum.MaquinaPesada:
                    tabPageTipoMaquinaPesada.Parent = tabControlTiposEquipamentos;
                    break;
            }
        }
    }
}
