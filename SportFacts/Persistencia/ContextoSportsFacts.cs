using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ContextoSportsFacts:DbContext, IDisposable
    {
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Deportista> Deportistas { get; set; }
        public DbSet<Ingesta> Ingestas { get; set; }
        public DbSet<PlanDietareo> PlanesDietareos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
