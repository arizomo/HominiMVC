namespace HominiMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreDepartamento = c.String(nullable: false, maxLength: 50),
                        CodigoDepartamento = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Municipio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreMunicipio = c.String(nullable: false, maxLength: 50),
                        CodigoMunicipio = c.String(nullable: false, maxLength: 3),
                        DepartamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId, cascadeDelete: true)
                .Index(t => t.DepartamentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipio", "DepartamentoId", "dbo.Departamento");
            DropIndex("dbo.Municipio", new[] { "DepartamentoId" });
            DropTable("dbo.Municipio");
            DropTable("dbo.Departamento");
        }
    }
}
