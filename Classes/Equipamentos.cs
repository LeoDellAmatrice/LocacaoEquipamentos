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

        // Especificos

        public decimal Voltagem { get; private set; }

        public int NumeroSerie { get; private set; }

        public string Fabricante { get; private set; }

        public decimal Peso { get; private set; }

        public bool OperadorEspecializado { get; private set; }

        public decimal GetMultaDiaria()
        {
            return TiposEquipamentos.GetMultaDiaria(TipoEquipamento);
        }

        internal void Excluir(DataContext context, int idEquipamento)
        {
            IdEquipamento = idEquipamento;

            var entry = context.Entry(this);

            if (entry.State == System.Data.Entity.EntityState.Detached) context.Equipamentos.Attach(this);

            context.Equipamentos.Remove(this);
            context.SaveChanges();
        }

        internal Equipamentos GetEquipamentoById(int idEquipamento, DataContext context)
        {
            return context.Equipamentos.Find(idEquipamento);
        }
    }
}
