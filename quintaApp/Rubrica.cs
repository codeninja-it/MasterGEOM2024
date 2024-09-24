using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quintaApp
{
    public class Rubrica
    {
        public string nome { get; set; } = "";
        public List<Contatto> contatti { get; set; } = new List<Contatto>();
    }

    public class Contatto
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string telefono { get; set; }
    }
}


