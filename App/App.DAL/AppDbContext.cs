using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using App.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace App.DAL
{
  public  class AppDBContext : DbContext 
   {
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           base.OnModelCreating(modelBuilder);
       }

       public AppDBContext() : base("Cafe58Conn")
       {

       }

       public DbSet<Alumno> Alumnos { get; set; }
       public DbSet<Ingredientes> Ingredientes { get; set; }
       public DbSet<Menu> Menus { get; set;  }
       public DbSet<MenuPlatillo> MenuPlatillos { get; set; }
       public DbSet<Orden> Ordenes { get; set; }
       public DbSet<OrdenPlatillo> OrdenesPlatillos { get; set; }
       public DbSet<Platillo> Platillos { get; set; }
       public DbSet<Usuario> Usuarios { get; set;}
   }
}
