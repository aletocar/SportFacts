using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportista:Usuario
    {
        public enum PrioridadPlan{

        }
        public IEnumerable<Tuple<PlanDietareo, PrioridadPlan>> ListaPlan { get; set; }

        public Deportista() { }
    }
}
