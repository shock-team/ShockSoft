namespace ShockSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Clientes", new[] { "cuit" });
            AlterColumn("dbo.Clientes", "telefono", c => c.String(maxLength: 30, storeType: "nvarchar"));
            CreateIndex("dbo.Clientes", "cuit");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clientes", new[] { "cuit" });
            AlterColumn("dbo.Clientes", "telefono", c => c.String(nullable: false, maxLength: 30, storeType: "nvarchar"));
            CreateIndex("dbo.Clientes", "cuit", unique: true);
        }
    }
}
