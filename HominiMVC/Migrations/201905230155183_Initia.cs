namespace HominiMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initia : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departamento");
        }
    }
}
