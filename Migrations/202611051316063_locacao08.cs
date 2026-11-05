namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao08 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "DevolucaoEfetivada", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "DevolucaoEfetivada");
        }
    }
}
