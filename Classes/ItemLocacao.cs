using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoEquipamentos.Classes
{
    public class ItemLocacao
    {
        public int IdLocacao { get; set; }

        public int SequenciaItem { get; set; }

        public int IdEquipamento { get; set; }

        public decimal ValorEquipamento { get; set; }

    }
}
