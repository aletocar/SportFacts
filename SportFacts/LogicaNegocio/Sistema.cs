using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LogicaNegocio
{
    public class Sistema : ISistema
    {
        private static Sistema sistema;

        public List<Ingesta> Ingestas { get; set; }
        public List<Deportista> Deportistas { get; set; }
        public List<Alimento> Alimentos { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<PlanDietareo> PlanesDietareaos { get; set; }

        private Sistema()
        {
            Ingestas = new List<Ingesta>();
            Deportistas = new List<Deportista>();
            Alimentos = new List<Alimento>();
            Usuarios = new List<Usuario>();
            PlanesDietareaos = new List<PlanDietareo>();
        }

        public static Sistema GetSistema()
        {
            if (sistema == null) sistema = new Sistema();
            return sistema;
        }

        public void AgregarIngesta(Ingesta i)
        {
            throw new NotImplementedException();
        }

        public void ModificarIngesta(Ingesta i)
        {
            throw new NotImplementedException();
        }

        public void BorrarIngesta(Ingesta i)
        {
            throw new NotImplementedException();
        }

        public void AgregarPlan(PlanDietareo p)
        {
            throw new NotImplementedException();
        }

        public void ModificarPlan(PlanDietareo p)
        {
            throw new NotImplementedException();
        }

        public void BorrarPlan(PlanDietareo p)
        {
            throw new NotImplementedException();
        }

        public bool ExistePlanConNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public void AgregarAlimento(Alimento a)
        {
            throw new NotImplementedException();
        }


        public bool AgregarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}
