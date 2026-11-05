namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao06 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemLocacao", "ValorMulta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Locacao", "ValorMultaDiaria", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Locacao", "Observacao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "Observacao");
            DropColumn("dbo.Locacao", "ValorMultaDiaria");
            DropColumn("dbo.ItemLocacao", "ValorMulta");
        }
    }
}
