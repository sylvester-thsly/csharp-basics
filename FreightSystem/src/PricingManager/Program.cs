using System;
using System.Collections.Generic; // Needed for Lists
using System.Linq; // Needed for Sum()

namespace FreightSystem.PricingManager
{
    // --- 1. THE MODELS (Data Structures) ---
    // In professional APIs, these are often in a separate folder called "Models"
    
    class Freight
    {
        public string Id = Guid.NewGuid().ToString().Substring(0, 5);
        public virtual int CalculatePrice() { return 0; }
    }

    class Container : Freight
    {
        public int Weight;
        public string Type;
        public Container(int weight, string type) { this.Weight = weight; this.Type = type; }
        public override int CalculatePrice()
        {
             if (this.Weight > 10000) return 700; 
             else return 200; 
        }
    }

    class Pallet : Freight
    {
        public string Destination;
        public Pallet(string destination) { this.Destination = destination; }
        public override int CalculatePrice()
        {
            if (this.Destination == "US") return 100;
            return 50;
        }
    }

    // --- 2. THE CONTRACT (Interface) ---
    interface IPricingService
    {
        int GetPrice(Freight item);
    }

    // --- 3. THE IMPLEMENTATION (Service) ---
    class StandardPricingService : IPricingService
    {
        public int GetPrice(Freight item)
        {
            return item.CalculatePrice();
        }
    }

    // --- 4. THE ENTRY POINT ---
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v5.0 (Service Oriented) ---");
            Console.WriteLine("(Type 'exit' to finish for the day)");

            // "Injecting" the service
            IPricingService pricingService = new StandardPricingService();
            List<Freight> dailyFreight = new List<Freight>();

            while (true)
            {
                Console.WriteLine(); 
                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1. Container");
                Console.WriteLine("2. Pallet");
                Console.Write("Choose (1/2) or 'exit': ");
                string choice = Console.ReadLine();

                if (choice == "exit") break;

                Freight newFreight = null;

                if (choice == "1") // Container
                {
                    try 
                    {
                        Console.Write("Enter Weight (kg): ");
                        int w = int.Parse(Console.ReadLine());
                        Console.Write("Enter Type (Standard/Heavy): ");
                        string t = Console.ReadLine();
                        newFreight = new Container(w, t);
                    }
                    catch { Console.WriteLine("Invalid input. Try again."); continue; }
                }
                else if (choice == "2") // Pallet
                {
                   Console.Write("Enter Destination (EU/US): ");
                   string dest = Console.ReadLine();
                   newFreight = new Pallet(dest);
                }

                if (newFreight != null)
                {
                    // SERVICE CALL (API Pattern)
                    int price = pricingService.GetPrice(newFreight); 
                    
                    Console.WriteLine($"Calculated Price: ${price}");
                    dailyFreight.Add(newFreight);
                }
                
            }

            Console.WriteLine("\n--- END OF SHIFT REPORT ---");
            foreach (Freight item in dailyFreight)
            {
                Console.WriteLine($"ID: {item.Id} - Price: ${pricingService.GetPrice(item)}");
            }
            Console.WriteLine($"Total Revenue: ${dailyFreight.Sum(f => pricingService.GetPrice(f))}");
        }
    }
}