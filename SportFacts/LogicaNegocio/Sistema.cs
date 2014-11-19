using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LogicaNegocio
{
    public class Sistema
    {
        private static Sistema sistema;

        public List<Ingesta> Ingestas { get; set; }
        public List<Deportista> Deportistas { get; set; }
        public List<Alimento> Alimentos { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<PlanDietareo> PlanesDietareaos { get; set; }
        public Usuario usuarioIngresado { get; set; }

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
            Ingestas.Add(i);
        }

        public void BorrarIngesta(Ingesta i)
        {
            throw new NotImplementedException();
        }

        public void AgregarPlan(PlanDietareo p)
        {
            PlanesDietareaos.Add(p);
        }

        public void BorrarPlan(PlanDietareo p)
        {
            PlanesDietareaos.Remove(p);
        }

        public bool ExistePlanConNombre(string nombre)
        {
            foreach (PlanDietareo p in PlanesDietareaos)
            {
                if (p.NombrePlan.Equals(nombre)) return true;
            }
            return false;
        }

        public void AgregarAlimento(Alimento a)
        {
            throw new NotImplementedException();
        }


        public bool AgregarUsuario(Usuario u)
        {
            if (Usuarios.Contains(u)) 
                return false;
            else
            {
                Usuarios.Add(u);
                return true;
            }

        }

        public bool ExisteUsuario(string user)
        {
            Usuario u = new Usuario() { Username = user };
            return Usuarios.Contains(u);
        }

        public bool ContrasenaDeUsuarioCorrecta(string user, string pass)
        {
            Usuario u = new Usuario() { Username = user };
            u = Usuarios.ElementAt(Usuarios.IndexOf(u));
            return u.Password.Equals(pass);
        }

        public void Logear(string user)
        {
            Usuario u = new Usuario() { Username = user };
            usuarioIngresado = Usuarios.ElementAt(Usuarios.IndexOf(u));
        }

        public string ObtenerNombrePlan()
        {
            int max = 0;
            foreach (PlanDietareo p in PlanesDietareaos)
            {
                if (int.Parse(p.identificador.Substring(3)) > max) max = int.Parse(p.identificador.Substring(3));
            }
            max++;
            return "PD-" + max;
        }

        public List<PlanDietareo> ObtenerPlanes(string id)
        {
            List<PlanDietareo> ret = new List<PlanDietareo>();
            foreach (PlanDietareo p in PlanesDietareaos)
            {
                if (p.identificador.Equals(id)) ret.Add(p);
            }
            return ret;
        }

        public bool PlanNoSirveParaDeportista(Usuario usuario, PlanDietareo planDietareo)
        {
            return true;
        }

        public Usuario[] ObtenerDeportistas(string nombre, string apellido)
        {
            List<Usuario> ret = new List<Usuario>();
            foreach (Usuario u in Usuarios)
            {
                if (u.tipo == Usuario.Tipo.Deportista)
                {
                    if (u.Nombre == nombre || u.Apellido == apellido) ret.Add(u);
                }
            }
            return ret.ToArray();
        }
    }
}
