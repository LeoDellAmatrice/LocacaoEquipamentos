namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao07 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ItemLocacao", "IdEquipamento");
            CreateIndex("dbo.Locacao", "IdCliente");
            AddForeignKey("dbo.ItemLocacao", "IdEquipamento", "dbo.Equipamentos", "IdEquipamento", cascadeDelete: false);
            AddForeignKey("dbo.Locacao", "IdCliente", "dbo.Clientes", "IdCliente", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.ItemLocacao", "IdEquipamento", "dbo.Equipamentos");
            DropIndex("dbo.Locacao", new[] { "IdCliente" });
            DropIndex("dbo.ItemLocacao", new[] { "IdEquipamento" });
        }
    }
}
