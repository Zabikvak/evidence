using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek {get; set; }
        public string TelCislo { get; set; }
        public Zaznam(string jmeno, string prijmeni, int vek, string telCislo)
        {
            Prijmeni = prijmeni;
            Jmeno = jmeno;
            Vek = vek;
            TelCislo = telCislo;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelCislo;
        }
    }
}
