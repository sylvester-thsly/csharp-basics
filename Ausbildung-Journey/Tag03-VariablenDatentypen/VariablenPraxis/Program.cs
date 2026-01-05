
using System;

namespace VariablenPraxis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tag 3: Variablen und Datentypen ===");

            // 1. Deklaration und Initialisierung
            int iGanzzahl;
            iGanzzahl = 42;
            Console.WriteLine($"iGanzzahl: {iGanzzahl}");

            // 2. Implizite & Explizite Konvertierung (Type Conversion)
            Console.WriteLine("\n=== Konvertierung ===");

            // Implizit (Klein in Groß passt immer)
            int iKlein = 100;
            double dGross = iKlein; // Automatisch: int passt in double
            Console.WriteLine($"Implizit (int -> double): {dGross}");

            // Explizit (Groß in Klein passt NICHT automatisch)
            double dPi = 3.14;
            // int iPi = dPi; // Das wäre ein Fehler!
            int iPi = (int)dPi; // "Cast": Wir erzwingen es (Kommazahlen fallen weg!)
            Console.WriteLine($"Explizit (double -> int): {dPi} wird zu {iPi}");

            // Datenverlust Warnung
            if (iPi != dPi)
            {
                Console.WriteLine("-> Achtung: Datenverlust durch Cast!");
            }

            // 3. Namenskonventionen
            Console.WriteLine("\n=== Namenskonventionen ===");
            bool bStatus = true;
            string sText = "Hallo";
            byte btMonat = 12;

            Console.WriteLine($"bStatus: {bStatus}");
            Console.WriteLine($"sText: {sText}");
            Console.WriteLine($"btMonat: {btMonat}");
        }
    }
}
