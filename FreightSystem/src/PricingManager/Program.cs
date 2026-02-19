using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v4.0 (Polymorphism) ---");
            Console.WriteLine("(Type 'exit' to finish for the day)");

            // --- 1. THE UNIVERSAL WAREHOUSE ---
            // Before: List<int> (Just numbers)
            // Now: List<Freight> (The actual objects!)
            List<Freight> dailyFreight = new List<Freight>();

            while (true)
            {
                Console.WriteLine(); 
                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1. Container");
                Console.WriteLine("2. Pallet"); // New Type!
                Console.Write("Choose (1/2) or 'exit': ");
                string choice = Console.ReadLine();

                if (choice == "exit") break;

                Freight newFreight = null; // Placeholder

                if (choice == "1") // Container
                {
                    Console.Write("Enter Weight (kg): ");
                    int w = int.Parse(Console.ReadLine());
                    Console.Write("Enter Type (Standard/Heavy): ");
                    string t = Console.ReadLine();
                    
                    newFreight = new Container(w, t); // Create Child 1
                }
                else if (choice == "2") // Pallet
                {
                   Console.Write("Enter Destination (EU/US): ");
                   string dest = Console.ReadLine();

                   newFreight = new Pallet(dest); // Create Child 2
                }

                if (newFreight != null)
                {
                    // POLYMORPHISM IN ACTION:
                    // We treat it as "Freight", but it behaves like a Container or Pallet.
                    int price = newFreight.CalculatePrice(); 
                    
                    Console.WriteLine($"Price: ${price}");
                    dailyFreight.Add(newFreight); // Add to list
                }
                
            } // End of Loop

            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            foreach (Freight item in dailyFreight)
            {
                // The loop doesn't know if it's a Container or Pallet.
                // It just knows it's Freight.
                // But the 'CalculatePrice' method knows what to do!
                Console.WriteLine($"ID: {item.Id} - Price: ${item.CalculatePrice()}");
            }
            // Sum only works on numbers, so we sum the CalculatePrice results
            Console.WriteLine($"Total Revenue: ${dailyFreight.Sum(f => f.CalculatePrice())}");
        }

        // --- 1. THE BASE CLASS (The Contract) ---
        class Freight
        {
            public string Id = Guid.NewGuid().ToString().Substring(0, 5); // Auto-ID

            // 'virtual' means: "My children CAN change this logic if they want."
            public virtual int CalculatePrice()
            {
                return 0; // Default price
            }
        }

        // --- 2. CHILD CLASS (Container) ---
        class Container : Freight
        {
            public int Weight;
            public string Type;

            public Container(int weight, string type)
            {
                this.Weight = weight;
                this.Type = type;
            }

            // 'override' means: "I am changing the parent's logic!"
            public override int CalculatePrice()
            {
                 if (this.Weight > 10000) return 700; 
                 else return 200; 
            }
        }

        // --- 3. NEW CHILD CLASS (Pallet) ---
        class Pallet : Freight
        {
            public string Destination;

            public Pallet(string destination)
            {
                this.Destination = destination;
            }

            // Pallets have specialized pricing (different from Container)
            public override int CalculatePrice()
            {
                if (this.Destination == "US") return 100; // More expensive
                return 50; // Standard EU Pallet
            }
        }
        
    }
}