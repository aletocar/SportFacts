using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public enum Tipo { Medico, Tecnico, Deportista }
        public enum PrioridadPlan { Principal, Secundario }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNac { get; set; }
        public double IMC { get; set; }
        public string Password { get; set; }
        public Tipo tipo { get; set; }
        public List<Tuple<PlanDietareo, PrioridadPlan>> ListaPlan { get; set; }

        public Usuario() 
        { 
            ListaPlan = new List<Tuple<PlanDietareo, PrioridadPlan>>();
        }

        public override bool Equals(object obj)
        {
            try
            {
                Usuario u = (Usuario)obj;
                return this.Username.Equals(u.Username);
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
