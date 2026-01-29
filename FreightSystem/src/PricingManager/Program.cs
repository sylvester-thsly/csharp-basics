using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v2.0 (The Ledger) ---");
            Console.WriteLine("(Type 'exit' to finish for the day)");

            // 1. THE WAREHOUSE (List)
            // This 'bag' remembers every price we calculate.
            List<int> containerPrices = new List<int>();

            // 2. THE INFINITE LOOP
            while (true)
            {
                Console.WriteLine(); 
                
                // INPUT with Exit Check
                Console.Write("Enter Container Weight (kg) or 'exit': ");
                string inputWeight = Console.ReadLine();

                // EXIT COMMAND
                if (inputWeight == "exit")
                {
                    break; // Breaks the Loop. Stops the machine.
                }

                int containerWeight;
                // Safe parsing (Try/Catch is safer, but keeping it simple for now)
                try 
                {
                     containerWeight = int.Parse(inputWeight);
                }
                catch
                {
                    Console.WriteLine("Invalid Number. Try again.");
                    continue;
                }

                Console.Write("Enter Container Type (Standard/Dangerous): ");
                string containerType = Console.ReadLine();

                Console.WriteLine($"Processing Container... Weight: {containerWeight} kg");

                // BUSINESS LOGIC
                if (containerType == "Dangerous")
                {
                    Console.WriteLine("STATUS: REJECTED ❌");
                    // Rejected items make $0. We don't add to the list.
                }
                else if (containerType == "Standard")
                {
                    if (containerWeight > 30000)
                    {
                        Console.WriteLine("STATUS: REJECTED ❌");
                        Console.WriteLine("Reason: Too Heavy for Road Transport.");
                    }
                    else if (containerWeight > 10000)
                    {
                        int price = 200 + 500;
                        Console.WriteLine("STATUS: ACCEPTED (Heavy Cargo) ⚠️");
                        Console.WriteLine($"Price: ${price}");
                        
                        // ADD TO LIST
                        containerPrices.Add(price);
                    }
                    else
                    {
                        int price = 200;
                        Console.WriteLine("STATUS: ACCEPTED (Standard) ✅");
                        Console.WriteLine($"Price: ${price}");

                        // ADD TO LIST
                        containerPrices.Add(price);
                    }
                }
                else
                {
                    Console.WriteLine("STATUS: UNKNOWN TYPE ❓");
                }
            } // End of Loop

            // 3. THE SUMMARY (End of Day Report)
            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            Console.WriteLine($"Total Containers Billed: {containerPrices.Count}");
            Console.WriteLine($"Total Revenue: ${containerPrices.Sum()}");
            Console.WriteLine("Good job today! See you tomorrow. 🚛💰");
        }
    }
}
