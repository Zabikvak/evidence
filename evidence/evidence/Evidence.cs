using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Evidence
    {
        private Databaze databaze;
        public Evidence()
        {
            databaze = new Databaze(); 
        }

        public void VypisZaznamy()
        {
            List<Zaznam> zaznamy = databaze.NajdiZaznamy();
            // Výpis záznamů
            if (zaznamy.Count() > 0)
            {
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);

                Console.WriteLine("Pokračujte stisknutím libovolné klávesy...");
            }
            else
                // Nenalezeno
                Console.WriteLine("V databázi zatím nejsou žádné záznamy, pokračujte stisknutím libovolné klávesy...");

        }

        public void VyhledejZaznam()
        {
            Console.WriteLine("Zadejte jmeno:");
            string? jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Jméno je neplatné. Zadej jméno znovu:");
            }
            Console.WriteLine("Zadejte jmeno:");
            string? prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Příjmení je neplatné. Zadej příjmení znovu:");
            }

            List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno, prijmeni);
            // Výpis záznamů
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto pojištěnci: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);

                Console.WriteLine("Pokračujte stisknutím libovolné klávesy...");
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy, pokračujte stisknutím libovolné klávesy...");
        }

        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jmeno:");
            string? jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Jméno je neplatné. Zadej jméno znovu:");
            }
            Console.WriteLine("Zadejte jmeno:");
            string? prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Příjmení je neplatné. Zadej příjmení znovu:");
            }
            Console.WriteLine("Zadejte vek:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Věk je neplatný. Zadej věk znovu:");
            }
            Console.WriteLine("Zadejte tel. číslo ve tvaru XXXYYYZZZ:");
            string? telCislo;
            while ((telCislo = Console.ReadLine()) == null || System.Text.RegularExpressions.Regex.Matches(telCislo, "^[1-9][0-9]{8}$").Count != 1)
            {
                Console.WriteLine("Telefonní číslo je neplatné. Zadej tel. číslo znovu:");
            }
            databaze.PridejZaznam(new Zaznam(jmeno, prijmeni, vek, telCislo));
            Console.WriteLine("Záznam byl uložen, pokračujte stisknutím libovolné klávesy...");
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Evidence pojištěných");
        }
    }

}
