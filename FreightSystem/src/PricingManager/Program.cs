using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v2.1 (The Toolbox) ---");
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

                // --- MODIFIED BUSINESS LOGIC (USING THE NEW TOOL!) ---
                
                // Call our new tool to get the price
                int price = CalculatePrice(containerWeight, containerType);

                // Print the result based on the price
                if (price == 0) // 0 means Rejected in our logic
                {
                     Console.WriteLine("STATUS: REJECTED ❌");
                }
                else
                {
                    Console.WriteLine("STATUS: ACCEPTED ✅");
                    Console.WriteLine($"Price: ${price}");
                    containerPrices.Add(price);
                }
                
                // --- END OF NEW LOGIC ---

            } // End of Loop

            // 3. THE SUMMARY (End of Day Report)
            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            Console.WriteLine($"Total Containers Billed: {containerPrices.Count}");
            Console.WriteLine($"Total Revenue: ${containerPrices.Sum()}");
            Console.WriteLine("Good job today! See you tomorrow. 🚛💰");
        }

        // 4. THE TOOLBOX (Methods)
        // This is the clean, reusable logic tool.
        static int CalculatePrice(int weight, string type)
        {
            if (type == "Dangerous")
            {
                return 0; // Rejected
            }
            else if (type == "Standard")
            {
                if (weight > 30000) return 0; // Rejected
                else if (weight > 10000) return 700; // Heavy
                else return 200; // Standard
            }
            return 0; // Unknown
        }

    }
}
