using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v2.3 (The Factory) ---");
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
                string weightInput = Console.ReadLine();
                if (weightInput == "exit") break;

                // Safe parsing (Try/Catch)
                int containerWeight;
                try 
                {
                     containerWeight = int.Parse(weightInput);
                }
                catch
                {
                    Console.WriteLine("Invalid Number. Try again.");
                    continue;
                }

                Console.Write("Enter Container Type (Standard/Dangerous): ");
                string containerType = Console.ReadLine();

                // 1. THE FACTORY (Constructor)
                // We create the box AND fill it in one step.
                // No more "empty ghost boxes".
                Container myBox = new Container(containerWeight, containerType);
                  
                // 3. ASK THE BOX TO CALCULATE ITS OWN PRICE
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

            // 3. THE SUMMARY (End of Day Report)
            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            Console.WriteLine($"Total Containers Billed: {containerPrices.Count}");
            Console.WriteLine($"Total Revenue: ${containerPrices.Sum()}");
            Console.WriteLine("Good job today! See you tomorrow. 🚛💰");
        }

        // --- THE BLUEPRINT (Construction Plan) ---
        /// <summary>
        /// Represents a standard shipping container with weight and type.
        /// (This is our Object-Oriented Blueprint!)
        /// </summary>
        class Container
        {
            // STATE (Data)
            public int Weight;
            public string Type;

            // 1. THE CONSTRUCTOR (The Factory Machine)
            // Forces you to provide weight and type when creating.
            // THIS MUST BE INSIDE THE CLASS!
            public Container(int weight, string type)
            {
                this.Weight = weight;
                this.Type = type;
            }

            // BEHAVIOR (Logic)
            /// <summary>
            /// Calculates the shipping price based on weight and type rules.
            /// </summary>
            /// <returns>Price in Dollars (USD)</returns>
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