using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Alimento
    {
        public string Nombre { get; set; }
        public double ValorCalorico { get; set; }

        public Alimento()
        {

        }
    }
}
