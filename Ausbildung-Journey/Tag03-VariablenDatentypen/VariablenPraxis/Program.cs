
using System;

namespace VariablenPraxis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tag 3: Variablen und Datentypen ===");

            // 1. Deklaration und Initialisierung
            // Typ int (Ganzzahl)
            int iGanzzahl;
            iGanzzahl = 42;
            Console.WriteLine($"iGanzzahl: {iGanzzahl}");

            // 2. Typensicherheit und Fehler
            // Der Text erwähnt: "Implizite Konvertierung des Typs 'double' zu 'int' nicht möglich."
            
            // int iFehler = 3.14; // Fehler: CS0266
            Console.WriteLine("\n[Test] int iFehler = 3.14; -> Würde Compiler-Fehler verursachen (double zu int)");

            // Auch 314.0 ist ein double für den Compiler
            // int iFehler2 = 314.0; // Fehler
             Console.WriteLine("[Test] int iFehler2 = 314.0; -> Würde ebenfalls Fehler verursachen");

            // 3. Namenskonventionen (Ungarische Notation laut Tabelle 3.1)
            Console.WriteLine("\n=== Namenskonventionen ===");
            
            bool bStatus = true;        // boolean -> bln oder b
            double dPreis = 99.90;      // double -> dbl oder d
            string sText = "Hallo";     // string -> s oder str (oft üblich, auch wenn nicht in Tabelle explizit)
            
            // Tabelle Beispiele:
            // byte -> byt
            byte btMonat = 12;

            Console.WriteLine($"bStatus: {bStatus}");
            Console.WriteLine($"dPreis: {dPreis}");
            Console.WriteLine($"sText: {sText}");
            Console.WriteLine($"btMonat: {btMonat}");

            // Warten auf User Input damit Konsole offen bleibt (falls nötig)
            // Console.ReadLine();
        }
    }
}
