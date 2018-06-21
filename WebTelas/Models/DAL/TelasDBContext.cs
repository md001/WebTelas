using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTelas.Models
{
    public class TelasDBContext : DbContext
    {
        public TelasDBContext() : base("TelasDBContext") // conn string ! ! !
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perfil> Perfiles { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Tela> Telas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}