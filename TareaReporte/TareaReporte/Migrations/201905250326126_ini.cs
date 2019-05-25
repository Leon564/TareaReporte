namespace TareaReporte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria = c.String(),
                        Existencias = c.Int(nullable: false),
                        Venta_VentaId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Ventas", t => t.Venta_VentaId)
                .Index(t => t.Venta_VentaId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        FechaVenta = c.String(),
                        Cliente_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .Index(t => t.Cliente_ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productoes", "Venta_VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Cliente_ClienteId", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.Productoes", new[] { "Venta_VentaId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productoes");
            DropTable("dbo.Clientes");
        }
    }
}
