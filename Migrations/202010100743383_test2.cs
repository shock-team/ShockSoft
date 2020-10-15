namespace ShockSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Clientes", new[] { "dni" });
            CreateIndex("dbo.Clientes", "dni");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clientes", new[] { "dni" });
            CreateIndex("dbo.Clientes", "dni", unique: true);
        }
    }
}
