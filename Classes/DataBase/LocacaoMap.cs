using System.Data.Entity.ModelConfiguration;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class LocacaoMap : EntityTypeConfiguration<Locacao>
    {
        public LocacaoMap() 
        { 
            ToTable("Locacao");
            HasKey(x => x.IdLocacao);
        }
    }
}