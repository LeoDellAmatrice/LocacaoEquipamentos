namespace LocacaoEquipamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locacao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        TipoPessoa = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        RazaoSocial = c.String(maxLength: 100, unicode: false),
                        NomeFantasia = c.String(maxLength: 100, unicode: false),
                        Telefone = c.String(maxLength: 11, unicode: false),
                        Email = c.String(maxLength: 255, unicode: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        Cnpj = c.String(maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
