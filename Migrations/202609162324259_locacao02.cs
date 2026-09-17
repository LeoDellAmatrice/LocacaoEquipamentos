namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipamentos",
                c => new
                    {
                        IdEquipamento = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        ValorDiaria = c.Decimal(nullable: false, precision: 10, scale: 2),
                        DataAquisicao = c.DateTime(nullable: false),
                        SituacaoEquipamento = c.Int(nullable: false),
                        TipoEquipamento_TipoEquipamento = c.Int(nullable: false),
                        TipoEquipamento_MultaDiaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdEquipamento);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Equipamentos");
        }
    }
}
