using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernyomas
{
    class Adatok
    {
        public string Datum { get; set; }
        public string Ido { get; set; }
        public int Szisztoles { get; set; }
        public int Diaszteles { get; set; }
        public int Pulzus { get; set; }
        public string Tipus { get; }

        public Adatok(string[] sor)
        {
            Datum = sor[0];
            Ido = sor[1];
            Szisztoles = Convert.ToInt32(sor[2]);
            Diaszteles = Convert.ToInt32(sor[3]);
            Pulzus = Convert.ToInt32(sor[4]);
            Tipus = VernyomasTipus();
        }

        public string VernyomasTipus()
        {
            if (Szisztoles < 120 && Diaszteles < 80)
            {
                return "Normál";
            }
            else if ((Szisztoles >= 120 && Szisztoles < 140) && (Diaszteles >= 80 && Diaszteles < 90))
            {
                return "Prehipertenzió";
            }
            else if ((Szisztoles >= 140 && Szisztoles < 160) && (Diaszteles >= 90 && Diaszteles < 100))
            {
                return "1.fokú hipertónia";
            }
            else if ((Szisztoles >= 160 && Szisztoles < 180) && (Diaszteles >= 100 && Diaszteles < 110))
            {
                return "2.fokú hipertónia";
            }
            else if (Szisztoles >= 180 && Diaszteles >= 110)
            {
                return "Magas vérnyomás krízis";
            }
            return "Nincs ilyen típus!";
        }

        public override string ToString()
        {
            return $"{Datum};{Ido};{Szisztoles};{Diaszteles};{Pulzus};{Tipus}";
        }
    }
}
