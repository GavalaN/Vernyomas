﻿using System;
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
                return "Prehipertenzió";
            }
            else if ((Szisztoles >= 160 && Szisztoles < 180) && (Diaszteles >= 100 && Diaszteles < 110))
            {
                return "1.fokú hipertónia";
            }
            else if (Szisztoles >= 180 && Diaszteles >= 110)
            {
                return "2.fokú hipertónia";
            }
            return "";
        }
    }
}
