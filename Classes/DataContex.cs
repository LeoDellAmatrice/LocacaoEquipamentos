using LocacaoEquipamentos.Classes.DataBase;
using System.Data.Entity;

namespace LocacaoEquipamentos.Classes
{
    public class DataContex : DbContext
    {
        public DataContex() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LOCACAO;Integrated Security = True;Connect Timeout=30;Encrypt=False") { }
        
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientesMap());
        }
    }
}
