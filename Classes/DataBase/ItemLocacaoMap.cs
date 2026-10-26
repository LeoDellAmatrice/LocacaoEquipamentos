using System.Data.Entity.ModelConfiguration;

namespace LocacaoEquipamentos.Classes.DataBase
{
    public class ItemLocacaoMap : EntityTypeConfiguration<ItemLocacao>
    {
        public ItemLocacaoMap() 
        {
            ToTable("ItemLocacao");
            HasKey(x => new { x.IdLocacao , x.SequenciaItem});
        }
    }
}
