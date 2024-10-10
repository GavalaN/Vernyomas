using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernyomas
{
    class Adatok
    {
        public DateTime datum { get; set; }
        public int Szisztoles { get; set; }
        public int Diaszteles { get; set; }
        public int Pulzus { get; set; }

        public Adatok(DateTime datum, int szisztoles, int diaszteles, int pulzus)
        {
            this.datum = datum;
            Szisztoles = szisztoles;
            Diaszteles = diaszteles;
            Pulzus = pulzus;
        }
    }
}
