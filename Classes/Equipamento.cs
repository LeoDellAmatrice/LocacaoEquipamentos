using LocacaoEquipamentos.Classes.DataBase;
using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocacaoEquipamentos.Classes
{
    public class Equipamento
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

        public void Alugar()
        {
            if (SituacaoEquipamento != SituacaoEquipamentoEnum.Disponivel)
            {
                throw new Exception("Não é possivel alugar materiais com situação diferente de Disponivel.");
            }

            SituacaoEquipamento = SituacaoEquipamentoEnum.Alugado;
        }

        public void SetEquipamentoBase(int idEquipamento, string descricao, decimal valorDiaria, DateTime dataAquisicao, SituacaoEquipamentoEnum situacaoEquipamento)
        {
            IdEquipamento = idEquipamento;
            Descricao = descricao;
            ValorDiaria = valorDiaria;
            DataAquisicao = dataAquisicao;
            SituacaoEquipamento = situacaoEquipamento;
        }

        public void SetTipoEquipamento(TipoEquipamentoEnum tipoEquipamento)
        {
            TipoEquipamento = tipoEquipamento;
        }

        public void Incluir(DataContext context)
        {
            context.Equipamentos.Add(this);
        }

        public void Alterar(DataContext context)
        {
            context.Entry(this).State = System.Data.Entity.EntityState.Modified;
        }

        public void Excluir(DataContext context, int idEquipamento)
        {
            IdEquipamento = idEquipamento;

            var entry = context.Entry(this);

            if (entry.State == System.Data.Entity.EntityState.Detached) context.Equipamentos.Attach(this);

            context.Equipamentos.Remove(this);
            context.SaveChanges();
        }

        public Equipamento GetEquipamentoById(int idEquipamento, DataContext context)
        {
            return context.Equipamentos.Find(idEquipamento) ?? throw new Exception("Erro ao buscar o equipamento com o Id: " + idEquipamento.ToString());
        }

        public List<Equipamento> GetEquipamentos(DataContext context)
        {
            return (from equipamentos in context.Equipamentos select equipamentos).ToList();
        }

        public void SetEspecifico(decimal voltagem)
        {
            Voltagem = voltagem;
        }

        public void SetEspecifico(int numeroSerie, string fabricante)
        {
            NumeroSerie = numeroSerie;
            Fabricante = fabricante;
        }

        public void SetEspecifico(decimal peso, bool operadorEspecializado)
        {
            Peso = peso;
            OperadorEspecializado = operadorEspecializado;
        }
    }
}
