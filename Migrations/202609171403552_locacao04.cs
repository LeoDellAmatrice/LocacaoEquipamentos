namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipamentos", "Voltagem", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Equipamentos", "NumeroSerie", c => c.Int(nullable: false));
            AddColumn("dbo.Equipamentos", "Fabricante", c => c.String());
            AddColumn("dbo.Equipamentos", "Peso", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Equipamentos", "OperadorEspecializado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipamentos", "OperadorEspecializado");
            DropColumn("dbo.Equipamentos", "Peso");
            DropColumn("dbo.Equipamentos", "Fabricante");
            DropColumn("dbo.Equipamentos", "NumeroSerie");
            DropColumn("dbo.Equipamentos", "Voltagem");
        }
    }
}
