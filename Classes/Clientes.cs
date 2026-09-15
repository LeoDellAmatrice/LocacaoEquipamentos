using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class Clientes
    {
        public int IdCliente { get; private set; }

        public TipoPessoaEnum TipoPessoa { get; private set; }

        public string Nome { get; private set; }

        public string RazaoSocial { get; private set; }

        public string NomeFantasia { get; private set; }

        public string Telefone { get; private set; }

        public string Email { get; private set; }

        public string Cpf { get; private set; }

        public string Cnpj { get; private set; }

        public void SetTipoPessoa(TipoPessoaEnum tipoPessoa)
        {
            TipoPessoa = tipoPessoa;
        }

        public void SetPessoaFisica(int idCliente, string nome, string telefone, string email, string cpf)
        {
            if (TipoPessoa != TipoPessoaEnum.Fisica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        public void SetPessoaJuridica(int idCliente, string razaoSocial, string nomeFantasia, string telefone, string email, string cnpj)
        {
            if (TipoPessoa != TipoPessoaEnum.Juridica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj;
        }

        public void Excluir(DataContext context, int idCliente)
        {
            IdCliente = idCliente;

            var entry = context.Entry(this);

            if (entry.State == System.Data.Entity.EntityState.Detached) context.Clientes.Attach(this);

            context.Clientes.Remove(this);
            context.SaveChanges();
        }
    }
}
