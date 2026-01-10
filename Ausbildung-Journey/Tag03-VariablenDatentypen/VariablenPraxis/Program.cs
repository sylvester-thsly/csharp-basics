
using System;

namespace VariablenPraxis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Tag 3: Variablen und Datentypen ===");

            // 1. Deklaration und Initialisierung
            int iGanzzahl = 42;
            Console.WriteLine($"iGanzzahl: {iGanzzahl}");

            // 2. Implizite & Explizite Konvertierung
            int iKlein = 100;
            double dGross = iKlein; 
            double dPi = 3.14;
            int iPi = (int)dPi;
            Console.WriteLine($"Konvertierung: {dGross} / {iPi}");

            // --- HIER DEIN CODE ---
            // Nächste Aufgabe: Genauigkeit (Precision)
            // Schreibe hier den Code für das float vs double vs decimal Experiment

            float num = 1.1f;
            double num2 = 1.1;
            decimal num3 = 1.1m;
            Console.WriteLine($"float: {num}");
            Console.WriteLine($"double: {num2}");
            Console.WriteLine($"decimal: {num3}");
            
        }
    }
}
