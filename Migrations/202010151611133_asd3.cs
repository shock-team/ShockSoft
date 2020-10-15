namespace ShockSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.metodosDePago", "multiplicadorInteres", c => c.Single(nullable: false));
            AlterColumn("dbo.Reparaciones", "fechaIngreso", c => c.DateTime(precision: 0));
            AlterColumn("dbo.Reparaciones", "fechaReparacion", c => c.DateTime(precision: 0));
            AlterColumn("dbo.Reparaciones", "precio", c => c.Single());
            AlterColumn("dbo.Reparaciones", "fueEntregado", c => c.Boolean());
            AlterColumn("dbo.Reparaciones", "fueCobrado", c => c.Boolean());
            AlterColumn("dbo.Reparaciones", "traeCargador", c => c.Boolean());
            AlterColumn("dbo.Reparaciones", "traeCables", c => c.Boolean());
            DropColumn("dbo.metodosDePago", "valor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.metodosDePago", "valor", c => c.Single(nullable: false));
            AlterColumn("dbo.Reparaciones", "traeCables", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Reparaciones", "traeCargador", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Reparaciones", "fueCobrado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Reparaciones", "fueEntregado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Reparaciones", "precio", c => c.Single(nullable: false));
            AlterColumn("dbo.Reparaciones", "fechaReparacion", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Reparaciones", "fechaIngreso", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.metodosDePago", "multiplicadorInteres");
        }
    }
}
