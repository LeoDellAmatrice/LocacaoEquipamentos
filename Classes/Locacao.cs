
using LocacaoEquipamentos.Enums;
using System;

namespace LocacaoEquipamentos.Classes
{
    internal class Locacao
    {
        public int IdLocacao { get; private set; }

        public int IdCliente { get; private set; }

        public DateTime DataRetirada { get; private set; }

        public DateTime DataPrevisaoDevolucao { get; private set; }

        public DateTime DataEfetivaDevolucao { get; private set; }

        public EnumSituacaoLocacao Situacao { get; private set; }

        public decimal ValorDiaria { get; set; }

        public decimal ValorTotal { get; private set; }


    }
}
