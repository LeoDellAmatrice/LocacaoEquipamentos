using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocacaoEquipamentos.Classes
{
    public class Locacao
    {
        public int IdLocacao { get; private set; }

        public int IdCliente { get; private set; }

        public DateTime DataRetirada { get; private set; }

        public DateTime DataPrevisaoDevolucao { get; private set; }

        public DateTime DataEfetivaDevolucao { get; private set; }

        public int QtdeDias { get; private set; }

        public SituacaoLocacaoEnum Situacao { get; private set; }

        public decimal ValorDiaria { get; set; }

        public decimal ValorTotal { get; private set; }

        public List<ItemLocacao> ItensLocacao { get; private set; }

        public List<Locacao> GetLocacoes(DataContext context)
        {
            return context.Locacao.ToList();
        }

        public Locacao GetLocacaoById(DataContext context, int idLocacao)
        {
            return context.Locacao.Find(idLocacao) ?? throw new Exception("Erro ao buscar o Locação com o Id: " + idLocacao.ToString());
        }

        public void Excluir(DataContext context, int idLocacao)
        {
            IdLocacao = idLocacao;

            var entry = context.Entry(this);

            if (entry.State == System.Data.Entity.EntityState.Detached) context.Locacao.Attach(this);

            context.Locacao.Remove(this);
            context.SaveChanges();
        }
    }
}
