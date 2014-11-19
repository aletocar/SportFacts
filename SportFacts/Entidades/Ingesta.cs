using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingesta
    {

        public List<Tuple<Alimento, int>> Alimentos { get; set; }
        public double ValorCalorico { get; set; }

        public Ingesta() 
        {
            Alimentos = new List<Tuple<Alimento, int>>();
        }
    }
}
