using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GewichtIngave.Models
{
    public class GewichtModel
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Gewicht { get; set; }
        public string Comment { get; set; }
    }
}
