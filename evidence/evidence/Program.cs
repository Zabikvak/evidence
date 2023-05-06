
using Evidence;

internal class Program
{
    private static void Main(string[] args)
    {
        Evidence.Evidence evidence = new Evidence.Evidence();
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Podpora českých znaků v konzoli
        char volba = '0';
        // hlavní cyklus
        while (volba != '4')
        {
            evidence.VypisUvodniObrazovku();
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat záznam");
            Console.WriteLine("2 - Vyhledat záznam");
            Console.WriteLine("3 - Zobrazit všechny záznamy");
            Console.WriteLine("4 - Konec");
            volba = Console.ReadKey().KeyChar;
            Console.WriteLine();
            // reakce na volbu
            switch (volba)
            {
                case '1':
                    evidence.PridejZaznam();
                    break;
                case '2':
                    evidence.VyhledejZaznam();
                    break;
                case '3':
                    evidence.VypisZaznamy();
                    break;
                case '4':
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                    break;
            }
            Console.ReadKey();
        }
    }
}