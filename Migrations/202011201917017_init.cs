﻿namespace ZonaSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dni = c.String(maxLength: 10, storeType: "nvarchar"),
                        cuit = c.String(maxLength: 20, storeType: "nvarchar"),
                        apellido = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        nombre = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        telefono = c.String(maxLength: 30, storeType: "nvarchar"),
                        direccion = c.String(maxLength: 50, storeType: "nvarchar"),
                        IdLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Localidades", t => t.IdLocalidad, cascadeDelete: true)
                .Index(t => t.dni)
                .Index(t => t.cuit)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        monto = c.Single(nullable: false),
                        descripcion = c.String(unicode: false),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.Reparaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        problema = c.String(unicode: false),
                        solucion = c.String(unicode: false),
                        contraseña = c.String(unicode: false),
                        fechaIngreso = c.DateTime(precision: 0),
                        fechaReparacion = c.DateTime(precision: 0),
                        fechaEntrega = c.DateTime(precision: 0),
                        precio = c.Single(),
                        fueEntregado = c.Boolean(),
                        fueCobrado = c.Boolean(),
                        traeCargador = c.Boolean(),
                        traeCables = c.Boolean(),
                        IdCliente = c.Int(nullable: false),
                        IdRubro = c.Int(nullable: false),
                        IdMarca = c.Int(nullable: false),
                        IdMetodoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.IdMarca, cascadeDelete: true)
                .ForeignKey("dbo.metodosDePago", t => t.IdMetodoPago, cascadeDelete: true)
                .ForeignKey("dbo.rubros", t => t.IdRubro, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdRubro)
                .Index(t => t.IdMarca)
                .Index(t => t.IdMetodoPago);
            
            CreateTable(
                "dbo.LineasDeReparaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdReparacion = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precioActual = c.Single(nullable: false),
                        idProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.IdReparacion })
                .ForeignKey("dbo.Productos", t => t.idProducto, cascadeDelete: true)
                .ForeignKey("dbo.Reparaciones", t => t.IdReparacion, cascadeDelete: true)
                .Index(t => t.IdReparacion)
                .Index(t => t.idProducto);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, unicode: false),
                        cantidad = c.Int(nullable: false),
                        precioEnDolares = c.Single(nullable: false),
                        enVenta = c.Boolean(nullable: false),
                        porcentajeGanancia = c.Single(nullable: false),
                        comentarios = c.String(unicode: false),
                        IdMarca = c.Int(nullable: false),
                        IdParametro = c.Int(nullable: false),
                        IdRubro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Marcas", t => t.IdMarca, cascadeDelete: true)
                .ForeignKey("dbo.Parametros", t => t.IdParametro, cascadeDelete: true)
                .ForeignKey("dbo.rubros", t => t.IdRubro, cascadeDelete: true)
                .Index(t => t.IdMarca)
                .Index(t => t.IdParametro)
                .Index(t => t.IdRubro);
            
            CreateTable(
                "dbo.LineasDeCompras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdCompra = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precioActual = c.Single(nullable: false),
                        idProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.IdCompra })
                .ForeignKey("dbo.Compras", t => t.IdCompra, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.idProducto, cascadeDelete: true)
                .Index(t => t.IdCompra)
                .Index(t => t.idProducto);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        costoTotalPesos = c.Single(nullable: false),
                        dolarProveedor = c.Single(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Proveedores", t => t.IdProveedor, cascadeDelete: true)
                .Index(t => t.IdProveedor);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LineasDeVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdVenta = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        precioActual = c.Single(nullable: false),
                        idProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.IdVenta })
                .ForeignKey("dbo.Productos", t => t.idProducto, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.IdVenta, cascadeDelete: true)
                .Index(t => t.IdVenta)
                .Index(t => t.idProducto);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        IdCliente = c.Int(nullable: false),
                        IdMetodoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.metodosDePago", t => t.IdMetodoPago, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdMetodoPago);
            
            CreateTable(
                "dbo.metodosDePago",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        multiplicadorInteres = c.Single(nullable: false),
                        descripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Parametros",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        valor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.rubros",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reparaciones", "IdRubro", "dbo.rubros");
            DropForeignKey("dbo.Reparaciones", "IdMetodoPago", "dbo.metodosDePago");
            DropForeignKey("dbo.Reparaciones", "IdMarca", "dbo.Marcas");
            DropForeignKey("dbo.LineasDeReparaciones", "IdReparacion", "dbo.Reparaciones");
            DropForeignKey("dbo.LineasDeReparaciones", "idProducto", "dbo.Productos");
            DropForeignKey("dbo.Productos", "IdRubro", "dbo.rubros");
            DropForeignKey("dbo.Productos", "IdParametro", "dbo.Parametros");
            DropForeignKey("dbo.Productos", "IdMarca", "dbo.Marcas");
            DropForeignKey("dbo.Ventas", "IdMetodoPago", "dbo.metodosDePago");
            DropForeignKey("dbo.LineasDeVentas", "IdVenta", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.LineasDeVentas", "idProducto", "dbo.Productos");
            DropForeignKey("dbo.LineasDeCompras", "idProducto", "dbo.Productos");
            DropForeignKey("dbo.Compras", "IdProveedor", "dbo.Proveedores");
            DropForeignKey("dbo.LineasDeCompras", "IdCompra", "dbo.Compras");
            DropForeignKey("dbo.Reparaciones", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Pagos", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "IdLocalidad", "dbo.Localidades");
            DropIndex("dbo.Ventas", new[] { "IdMetodoPago" });
            DropIndex("dbo.Ventas", new[] { "IdCliente" });
            DropIndex("dbo.LineasDeVentas", new[] { "idProducto" });
            DropIndex("dbo.LineasDeVentas", new[] { "IdVenta" });
            DropIndex("dbo.Compras", new[] { "IdProveedor" });
            DropIndex("dbo.LineasDeCompras", new[] { "idProducto" });
            DropIndex("dbo.LineasDeCompras", new[] { "IdCompra" });
            DropIndex("dbo.Productos", new[] { "IdRubro" });
            DropIndex("dbo.Productos", new[] { "IdParametro" });
            DropIndex("dbo.Productos", new[] { "IdMarca" });
            DropIndex("dbo.LineasDeReparaciones", new[] { "idProducto" });
            DropIndex("dbo.LineasDeReparaciones", new[] { "IdReparacion" });
            DropIndex("dbo.Reparaciones", new[] { "IdMetodoPago" });
            DropIndex("dbo.Reparaciones", new[] { "IdMarca" });
            DropIndex("dbo.Reparaciones", new[] { "IdRubro" });
            DropIndex("dbo.Reparaciones", new[] { "IdCliente" });
            DropIndex("dbo.Pagos", new[] { "IdCliente" });
            DropIndex("dbo.Clientes", new[] { "IdLocalidad" });
            DropIndex("dbo.Clientes", new[] { "cuit" });
            DropIndex("dbo.Clientes", new[] { "dni" });
            DropTable("dbo.rubros");
            DropTable("dbo.Parametros");
            DropTable("dbo.Marcas");
            DropTable("dbo.metodosDePago");
            DropTable("dbo.Ventas");
            DropTable("dbo.LineasDeVentas");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Compras");
            DropTable("dbo.LineasDeCompras");
            DropTable("dbo.Productos");
            DropTable("dbo.LineasDeReparaciones");
            DropTable("dbo.Reparaciones");
            DropTable("dbo.Pagos");
            DropTable("dbo.Localidades");
            DropTable("dbo.Clientes");
        }
    }
}
