namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipamentos", "TipoEquipamento", c => c.Int(nullable: false));
            DropColumn("dbo.Equipamentos", "TipoEquipamento_TipoEquipamento");
            DropColumn("dbo.Equipamentos", "TipoEquipamento_MultaDiaria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipamentos", "TipoEquipamento_MultaDiaria", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Equipamentos", "TipoEquipamento_TipoEquipamento", c => c.Int(nullable: false));
            DropColumn("dbo.Equipamentos", "TipoEquipamento");
        }
    }
}
