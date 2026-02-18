using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v3.0 (The Inheritance) ---");
            Console.WriteLine("(Type 'exit' to finish for the day)");

            List<int> containerPrices = new List<int>();

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

                // --- 2. THE MENU (Using the Array) ---
                Console.WriteLine("\nAvailable Container Types:");
                // Loop through the Array to show options
                for (int i = 0; i < Container.Menu.Length; i++)
                {
                   // i+1 so it says "1. Standard" instead of "0. Standard"
                   Console.WriteLine($"{i + 1}. {Container.Menu[i]}");
                }

                Console.Write("Choose Type (Enter text, e.g. 'Standard'): ");
                string containerType = Console.ReadLine();

                // 1. THE FACTORY (Constructor)
                // We create the box AND fill it in one step.
                Container myBox = new Container(containerWeight, containerType);
                
                // --- INHERITANCE IN ACTION ---
                // 'Id' is NOT in the Container class. It comes from Freight!
                myBox.Id = "CN-12345"; 
                Console.WriteLine($"[Scanned ID: {myBox.Id}]"); // Proving we have an ID

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

            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            Console.WriteLine($"Total Containers Billed: {containerPrices.Count}");
            Console.WriteLine($"Total Revenue: ${containerPrices.Sum()}");
        }

        // --- THE GRANDPARENT (Base Class) ---
        // This holds things that ANY freight has (Container, Pallet, Box).
        class Freight
        {
            public string Id; // Every freight has an ID
        }

        // --- THE CHILD (Derived Class) ---
        // 'Container : Freight' means "Container IS A Freight".
        // It gets everything inside Freight for free!
        /// <summary>
        /// Represents a standard shipping container with weight and type.
        /// (This is our Object-Oriented Blueprint!)
        /// </summary>
        class Container : Freight
        {
            // --- NEW: THE MENU (Array) ---
            public static readonly string[] Menu = { "Standard", "Heavy", "Dangerous" };

            // STATE (Data)
            public int Weight;
            public string Type;

            // 1. THE CONSTRUCTOR (The Factory Machine)
            public Container(int weight, string type)
            {
                this.Weight = weight;
                this.Type = type;
            }

            // BEHAVIOR (Logic)
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