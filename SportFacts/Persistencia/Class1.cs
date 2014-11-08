using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ContextoSportsFacts:DbContext
    {
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Deportista> Deportistas { get; set; }
        public DbSet<Ingesta> Ingestas { get; set; }
        public DbSet<PlanDietareo> PlanesDietareos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<Deportista>()
                .HasMany(e => e.ListaPlan)
                .WithMany(
            
            base.OnModelCreating(mb);
        }

    }
}
