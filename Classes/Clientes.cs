using LocacaoEquipamentos.Enums;
using System;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class Clientes
    {
        public int IdCliente { get; private set; }

        public EnumTipoPessoa TipoPessoa { get; private set; }

        public string Nome { get; private set; }

        public string RazaoSocial { get; private set; }

        public string NomeFantasia { get; private set; }

        public string Telefone { get; private set; }

        public string Email { get; private set; }

        public string Cpf { get; private set; }

        public string Cnpj { get; private set; }

        public void SetTipoPessoa(EnumTipoPessoa tipoPessoa)
        {
            TipoPessoa = tipoPessoa;
        }

        public void SetPessoaFisica(int idCliente, string nome, string telefone, string email, string cpf)
        {
            if (TipoPessoa != EnumTipoPessoa.Fisica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        public void SetPessoaJuridica(int idCliente, string razaoSocial, string nomeFantasia, string telefone, string email, string cnpj)
        {
            if (TipoPessoa != EnumTipoPessoa.Juridica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj;
        }

    }
}
