using LocacaoEquipamentos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class Cliente
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

        public void SetPessoa(int idCliente, string nome, string telefone, string email, string cpf)
        {
            if (TipoPessoa != TipoPessoaEnum.Fisica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        public void SetPessoa(int idCliente, string razaoSocial, string nomeFantasia, string telefone, string email, string cnpj)
        {
            if (TipoPessoa != TipoPessoaEnum.Juridica) throw new Exception("Tipo pessoa inválido");

            IdCliente = idCliente;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj;
        }

        public decimal GetDesconto()
        {
            if (TipoPessoa == TipoPessoaEnum.Juridica) return 0.05m;

            return 0m;
        }

        public Cliente GetClienteById(int idCliente, DataContext context)
        {
            return context.Clientes.Find(idCliente) ?? throw new Exception("Erro ao buscar o cliente com o Id: " + IdCliente.ToString());
        }

        public List<Cliente> GetClientes(DataContext context)
        {
            return (from clientes in context.Clientes select clientes).ToList();
        }

        public void ValidarCampos()
        {
            if (TipoPessoa == TipoPessoaEnum.Fisica)
            {
                if (Cpf.Length != 11) throw new Exception("CPF Inválido");

                if (Nome.Length == 0) throw new Exception("Campo Nome vazio");

                return;
            }
            if (Cnpj.Length != 14) throw new Exception("CNPJ Inválido");
        }

        public void Incluir(DataContext context)
        {
            VerificaCpfCnpj(context);
            context.Clientes.Add(this);
        }

        private void VerificaCpfCnpj(DataContext context)
        {
            if (TipoPessoa == TipoPessoaEnum.Fisica)
            {
                if (context.Clientes.Where(u => (u.TipoPessoa == TipoPessoaEnum.Fisica) && (u.Cpf == Cpf) && (u.IdCliente != IdCliente)).Count() > 0)
                {
                    throw new Exception("Não é possivel incluir clientes com CPF ou CNPJ já cadastrados.");
                }
            }

            if (TipoPessoa == TipoPessoaEnum.Juridica)
            {
                if (context.Clientes.Where(u => u.TipoPessoa == TipoPessoaEnum.Juridica && (u.Cnpj == Cnpj) && (u.IdCliente != IdCliente)).Count() > 0)
                {
                    throw new Exception("Não é possivel incluir clientes com CPF ou CNPJ já cadastrados.");
                }
            }
        }

        public void Alterar(DataContext context)
        {
            VerificaCpfCnpj(context);
            context.Entry(this).State = System.Data.Entity.EntityState.Modified;
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
