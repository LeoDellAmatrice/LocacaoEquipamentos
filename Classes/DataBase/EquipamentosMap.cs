using System.Data.Entity.ModelConfiguration;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class EquipamentosMap : EntityTypeConfiguration<Equipamentos>
    {
        public EquipamentosMap()
        {
            ToTable("Equipamentos");
            HasKey(x => x.IdEquipamento);

            Property(x => x.Descricao).IsRequired().HasColumnType("varchar").HasMaxLength(255);

            Property(x => x.ValorDiaria).IsRequired().HasColumnType("decimal").HasPrecision(10, 2);

            Property(x => x.DataAquisicao);

            Property(x => x.SituacaoEquipamento).IsRequired().HasColumnType("int");

            Property(x => x.TipoEquipamento).IsRequired().HasColumnType("int");
        }
    }
}
