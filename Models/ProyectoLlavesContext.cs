using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProyectoLlaves.Models
{
    public class ProyectoLlavesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProyectoLlavesContext() : base("name=ProyectoLlavesContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<ProyectoLlaves.Models.Llaves> Llaves { get; set; }

        public System.Data.Entity.DbSet<ProyectoLlaves.Models.Empresas> Empresas { get; set; }

        public System.Data.Entity.DbSet<ProyectoLlaves.Models.Proveedor> Proveedors { get; set; }
    }
}
