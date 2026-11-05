using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocacaoEquipamentos.Classes
{
    public class LocacaoSetModel
    {
        public int IdLocacao { get; set; }
        public int IdCliente { get; set; }

        public DateTime DataRetirada { get; set; }

        public DateTime DataPrevisaoDevolucao { get; set; }

        public bool DevolucaoEfetivada { get; set; }

        public DateTime DataEfetivaDevolucao { get; set; }

        public SituacaoLocacaoEnum Situacao { get; set; }

        public string Observacao { get; set; }

    }

    public class Locacao
    {
        public int IdLocacao { get; private set; }

        public int IdCliente { get; private set; }

        public Cliente ClienteLocacao { get; private set; }

        public DateTime DataRetirada { get; private set; }

        public DateTime DataPrevisaoDevolucao { get; private set; }

        public bool DevolucaoEfetivada { get; set; }

        public DateTime DataEfetivaDevolucao { get; private set; }

        public int QtdeDias { get; private set; }

        public SituacaoLocacaoEnum Situacao { get; private set; }

        public decimal ValorDiaria { get; set; }

        public decimal ValorMultaDiaria { get; set; }

        public decimal ValorTotal { get; private set; }

        public string Observacao { get; private set; }

        public List<ItemLocacao> ItensLocacao { get; private set; }

        public Locacao()
        {
            using (var context = new DataContext())
            {
                ItensLocacao = new ItemLocacao().GetItensLocacaoById(context, IdLocacao);
            }
        }

        public Locacao SetLocacao(LocacaoSetModel dados, DataContext context)
        {
            IdLocacao = dados.IdLocacao;
            IdCliente = dados.IdCliente;
            DataRetirada = dados.DataRetirada;
            DataPrevisaoDevolucao = dados.DataPrevisaoDevolucao;
            DataEfetivaDevolucao = dados.DataEfetivaDevolucao;
            CalculaDias();
            Situacao = dados.Situacao;
            Observacao = dados.Observacao;

            ClienteLocacao = new Cliente().GetClienteById(IdCliente, context);

            CalculaValores();

            return this;
        }

        public void CalculaDias()
        {
            QtdeDias = (DataPrevisaoDevolucao - DataRetirada).Days + 1;
        }

        public void CalculaValores()
        {
            ValorDiaria = ItensLocacao.Sum(item => item.ValorEquipamento);

            ValorTotal = ValorDiaria * QtdeDias;

            ValorMultaDiaria = ItensLocacao.Sum(item => item.ValorMulta);
        }

        public List<Locacao> GetLocacoes(DataContext context)
        {
            return context.Locacao.ToList();
        }

        public Locacao GetLocacaoById(DataContext context, int idLocacao)
        {
            return context.Locacao.Find(idLocacao) ?? throw new Exception($"Erro ao buscar a Locação com o Id: {idLocacao}");
        }

        public Cliente GetClienteLocacao()
        {
            return ClienteLocacao;
        }

        public void Incluir(DataContext context)
        {
            context.Locacao.Add(this);
        }

        public void Alterar(DataContext context)
        {
            context.Entry(this).State = System.Data.Entity.EntityState.Modified;
        }

        public void Excluir(DataContext context, int idLocacao)
        {
            if (idLocacao == 0) return;

            if (ItensLocacao.Count == 0) throw new Exception($"Locação Possui Itens. Exclua-os antes.");

            IdLocacao = idLocacao;

            var entry = context.Entry(this);

            if (entry.State == System.Data.Entity.EntityState.Detached) context.Locacao.Attach(this);

            context.Locacao.Remove(this);
            context.SaveChanges();
        }
    }
}
