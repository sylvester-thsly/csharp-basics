using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v2.2 (The Smart Box) ---");
            Console.WriteLine("(Type 'exit' to finish for the day)");

            // 1. THE WAREHOUSE (List)
            List<int> containerPrices = new List<int>();

            // 2. THE INFINITE LOOP
            while (true)
            {
                Console.WriteLine(); 
                
                // 1. CREATE A NEW CONTAINER (The Object)
                Container myBox = new Container();

                // 2. FILL THE FORM
                Console.Write("Enter Weight (kg) or 'exit': ");
                string weightInput = Console.ReadLine();
                if (weightInput == "exit") break;

                try 
                {
                     myBox.Weight = int.Parse(weightInput); // Putting data INTO the box
                }
                catch
                {
                    Console.WriteLine("Invalid Number. Try again.");
                    continue;
                }

                Console.Write("Enter Type (Standard/Dangerous): ");
                myBox.Type = Console.ReadLine(); // Putting Data INTO the box 
                
                // 3. ASK THE BOX TO CALCULATE ITS OWN PRICE
                // LOOK! No arguments! The box already knows its weight and type.
                int price = myBox.CalculatePrice();
                
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
                
            } // End of Loop

            // 3. THE SUMMARY
            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            Console.WriteLine($"Total Containers Billed: {containerPrices.Count}");
            Console.WriteLine($"Total Revenue: ${containerPrices.Sum()}");
            Console.WriteLine("Good job today! See you tomorrow. 🚛💰");
        }

        // --- THE BLUEPRINT (Construction Plan) ---
        class Container
        {
            // STATE (Data)
            public int Weight;
            public string Type;

            // BEHAVIOR (Logic)
            // Notice: No 'static'. No parameters (int w, string t).
            // It uses 'this.Weight' and 'this.Type'.
            public int CalculatePrice()
            {
                if (this.Type == "Dangerous")
                {
                    return 0; // Rejected
                }
                else if (this.Type == "Standard")
                {
                    if (this.Weight > 30000) return 0; // Rejected
                    else if (this.Weight > 10000) return 700; // Heavy
                    else return 200; // Standard
                }
                return 0; // Unknown
            }
        }
        
    }
}
