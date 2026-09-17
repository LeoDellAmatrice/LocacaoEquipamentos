using LocacaoEquipamentos.Enums;
using System;

namespace LocacaoEquipamentos.Classes
{
    public class Equipamentos
    {
        public int IdEquipamento { get; private set; }

        public string Descricao { get; private set; }

        public decimal ValorDiaria { get; private set; }

        public DateTime DataAquisicao { get; private set; }

        public SituacaoEquipamentoEnum SituacaoEquipamento { get; private set; }

        public TipoEquipamentoEnum TipoEquipamento { get; private set; }

        public decimal GetMultaDiaria()
        {
            return TiposEquipamentos.GetMultaDiaria(TipoEquipamento);
        }



    }
}
