using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 
    public class PlanDietareo
    {
 
        public enum CategoriaPlan { Categoria1, Categoria2, CategoriaN }
        public enum DiaDeSemana {Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo } 
        public enum MomentoDelDia {mañana, media_mañana, almuerzo, media_tarde, tarde, noche }
        public enum FrecuenciaPlan { diaria, semanal, quincenal, mensual }
        public string identificador { get; set; }
        public string NombrePlan { get; set; }
        public string Objetivo { get; set; }
        public CategoriaPlan Categoria { get; set; }
        public bool Generico { get; set; }
        public TimeSpan Duracion { get; set; }
        public int EdadMin { get; set; }
        public int EdadMax { get; set; }
        public double IMCMin { get; set; }
        public double IMCMax { get; set; }
        public List<Tuple<Ingesta, DiaDeSemana, MomentoDelDia>> Ingestas { get; set; }
        public FrecuenciaPlan Frecuencia { get; set; }
        public PlanDietareo() 
        {
            Ingestas = new List<Tuple<Ingesta, DiaDeSemana, MomentoDelDia>>();
        }

        public override bool Equals(object obj)
        {
            try
            {
                PlanDietareo pd = (PlanDietareo)obj;
                return this.identificador == pd.identificador;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
