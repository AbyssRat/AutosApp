using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosGUI
{
    internal class Kolcsonzes
    {
        public int KolcsonzesSzama { get; set; }
        public string Ugyfel { get; set; }
        public string Rendszam { get; set; }
        public string AutoMarka { get; set; }
        public string AutoModell { get; set; }
        public double NapiDij { get; set; }
        public DateTime Mettol { get; set; }
        public DateTime Meddig { get; set; }

        public int IdotartamNapok()
        {
            return (Meddig - Mettol).Days + 1;
        }

        public double TeljesDij()
        {
            return IdotartamNapok() * NapiDij;
        }
    }
}
