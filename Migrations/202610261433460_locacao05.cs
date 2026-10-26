namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao05 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemLocacao",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false),
                        SequenciaItem = c.Int(nullable: false),
                        IdEquipamento = c.Int(nullable: false),
                        ValorEquipamento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.IdLocacao, t.SequenciaItem })
                .ForeignKey("dbo.Locacao", t => t.IdLocacao, cascadeDelete: true)
                .Index(t => t.IdLocacao);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        DataRetirada = c.DateTime(nullable: false),
                        DataPrevisaoDevolucao = c.DateTime(nullable: false),
                        DataEfetivaDevolucao = c.DateTime(nullable: false),
                        QtdeDias = c.Int(nullable: false),
                        Situacao = c.Int(nullable: false),
                        ValorDiaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdLocacao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemLocacao", "IdLocacao", "dbo.Locacao");
            DropIndex("dbo.ItemLocacao", new[] { "IdLocacao" });
            DropTable("dbo.Locacao");
            DropTable("dbo.ItemLocacao");
        }
    }
}
