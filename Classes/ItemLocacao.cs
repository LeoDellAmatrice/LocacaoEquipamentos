using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoEquipamentos.Classes
{
    public class ItemLocacao
    {
        public int IdLocacao { get; set; }

        public int SequenciaItem { get; set; }

        public int IdEquipamento { get; set; }

        public Equipamento Equipamento { get; set; }

        public decimal ValorEquipamento { get; set; }

        public decimal ValorMulta { get; set; }

        public List<ItemLocacao> GetItensLocacaoById(DataContext context, int idLocacao)
        {
            return context.ItensLocacao.Where(i => i.IdLocacao == idLocacao).OrderBy(i => i.SequenciaItem).ToList();
        }
    }
}
