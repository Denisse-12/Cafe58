namespace App.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Foto = c.String(),
                        Apellidos = c.String(),
                        NoControl = c.Int(nullable: false),
                        Email = c.String(),
                        Beca = c.Boolean(nullable: false),
                        FechaNac = c.DateTime(nullable: false),
                        Grupo = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orden",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAlumno = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        CostoTotal = c.Double(nullable: false),
                        Estatus = c.String(),
                        Alumno_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .Index(t => t.Alumno_Id);
            
            CreateTable(
                "dbo.OrdenPlatillo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrden = c.Int(nullable: false),
                        IdPlatillo = c.Int(nullable: false),
                        Orden_Id = c.Int(),
                        Platillo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orden", t => t.Orden_Id)
                .ForeignKey("dbo.Platillo", t => t.Platillo_Id)
                .Index(t => t.Orden_Id)
                .Index(t => t.Platillo_Id);
            
            CreateTable(
                "dbo.Platillo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Imagen = c.String(),
                        Numero = c.Double(nullable: false),
                        Beca = c.Boolean(nullable: false),
                        MenuPlatillo_Id = c.Int(),
                        OrdenPlatillo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuPlatillo", t => t.MenuPlatillo_Id)
                .ForeignKey("dbo.OrdenPlatillo", t => t.OrdenPlatillo_Id)
                .Index(t => t.MenuPlatillo_Id)
                .Index(t => t.OrdenPlatillo_Id);
            
            CreateTable(
                "dbo.Ingredientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdPlatillo = c.Int(nullable: false),
                        Platillo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Platillo", t => t.Platillo_Id)
                .Index(t => t.Platillo_Id);
            
            CreateTable(
                "dbo.MenuPlatillo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPlatillo = c.Int(nullable: false),
                        IdMenu = c.Int(nullable: false),
                        Menu_Id = c.Int(),
                        Platillo_Id = c.Int(),
                        Platillo_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.Menu_Id)
                .ForeignKey("dbo.Platillo", t => t.Platillo_Id)
                .ForeignKey("dbo.Platillo", t => t.Platillo_Id1)
                .Index(t => t.Menu_Id)
                .Index(t => t.Platillo_Id)
                .Index(t => t.Platillo_Id1);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaNac = c.DateTime(nullable: false),
                        TipoUsuario = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Platillo", "OrdenPlatillo_Id", "dbo.OrdenPlatillo");
            DropForeignKey("dbo.OrdenPlatillo", "Platillo_Id", "dbo.Platillo");
            DropForeignKey("dbo.MenuPlatillo", "Platillo_Id1", "dbo.Platillo");
            DropForeignKey("dbo.Platillo", "MenuPlatillo_Id", "dbo.MenuPlatillo");
            DropForeignKey("dbo.MenuPlatillo", "Platillo_Id", "dbo.Platillo");
            DropForeignKey("dbo.MenuPlatillo", "Menu_Id", "dbo.Menu");
            DropForeignKey("dbo.Ingredientes", "Platillo_Id", "dbo.Platillo");
            DropForeignKey("dbo.OrdenPlatillo", "Orden_Id", "dbo.Orden");
            DropForeignKey("dbo.Orden", "Alumno_Id", "dbo.Alumno");
            DropIndex("dbo.MenuPlatillo", new[] { "Platillo_Id1" });
            DropIndex("dbo.MenuPlatillo", new[] { "Platillo_Id" });
            DropIndex("dbo.MenuPlatillo", new[] { "Menu_Id" });
            DropIndex("dbo.Ingredientes", new[] { "Platillo_Id" });
            DropIndex("dbo.Platillo", new[] { "OrdenPlatillo_Id" });
            DropIndex("dbo.Platillo", new[] { "MenuPlatillo_Id" });
            DropIndex("dbo.OrdenPlatillo", new[] { "Platillo_Id" });
            DropIndex("dbo.OrdenPlatillo", new[] { "Orden_Id" });
            DropIndex("dbo.Orden", new[] { "Alumno_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Menu");
            DropTable("dbo.MenuPlatillo");
            DropTable("dbo.Ingredientes");
            DropTable("dbo.Platillo");
            DropTable("dbo.OrdenPlatillo");
            DropTable("dbo.Orden");
            DropTable("dbo.Alumno");
        }
    }
}
