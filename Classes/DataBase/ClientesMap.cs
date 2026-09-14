using System.Data.Entity.ModelConfiguration;

namespace LocacaoEquipamentos.Classes.DataBase
{
    internal class ClientesMap : EntityTypeConfiguration<Clientes>
    {
        public ClientesMap()
        {
            ToTable("Clientes");
            HasKey(x => x.IdCliente);

            Property(x => x.TipoPessoa).IsRequired().HasColumnType("int");

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.RazaoSocial).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.NomeFantasia).HasColumnType("varchar").HasMaxLength(100);

            Property(x => x.Telefone).HasColumnType("varchar").HasMaxLength(11);
            Property(x => x.Email).HasColumnType("varchar").HasMaxLength(255);

            Property(x => x.Cpf).HasColumnType("varchar").HasMaxLength(11);
            Property(x => x.Cnpj).HasColumnType("varchar").HasMaxLength(14);
        }
    }
}
