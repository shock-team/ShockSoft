namespace ShockSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reparaciones", "fechaEntrega", c => c.DateTime(precision: 0));
            AddColumn("dbo.Productos", "comentarios", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "comentarios");
            DropColumn("dbo.Reparaciones", "fechaEntrega");
        }
    }
}
