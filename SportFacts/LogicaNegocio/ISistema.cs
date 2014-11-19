using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    interface ISistema
    {
        void AgregarIngesta(Ingesta i);
        void ModificarIngesta(Ingesta i);
        void BorrarIngesta(Ingesta i);
        void AgregarPlan(PlanDietareo p);
        void ModificarPlan(PlanDietareo p);
        void BorrarPlan(PlanDietareo p);
        bool ExistePlanConNombre(string nombre);
        bool AgregarUsuario(Usuario u);
    }
}
