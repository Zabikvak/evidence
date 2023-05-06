using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Databaze
    {
        private List<Zaznam> zaznamy = new List<Zaznam>();
        public void PridejZaznam(Zaznam zaznam)
        {
            zaznamy.Add(zaznam);
        }

        public List<Zaznam> NajdiZaznamy(string? jmeno = null, string? prijmeni = null)
        {
            if (jmeno == null && prijmeni == null)
                return zaznamy;
            else
            {
                List<Zaznam> nalezene = new List<Zaznam>();
                foreach (Zaznam z in zaznamy)
                {
                    if ((z.Jmeno == jmeno) && (z.Prijmeni == prijmeni))
                        nalezene.Add(z);
                }
                return nalezene;
            }
        }

    }
}
