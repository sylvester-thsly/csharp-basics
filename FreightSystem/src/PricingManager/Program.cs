using System;

namespace FreightSystem.PricingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CARGONERDS PRICING ENGINE v1.0 ---");
            
            // 1. INPUT (Interactive)
            Console.Write("Enter Container Weight (kg): ");
            string inputWeight = Console.ReadLine();
            int containerWeight = int.Parse(inputWeight); 

             Console.Write("Enter Container Type (Standard/Dangerous): ");
             string containerType = Console.ReadLine();

            Console.WriteLine($"Processing Container... Weight: {containerWeight} kg");

            // 2. BUSINESS LOGIC (The Rules)
            
            if (containerType == "Dangerous")
            {
                Console.WriteLine("STATUS: REJECTED ❌");
                Console.WriteLine("Reason: Your Container is very Dangerous");
            }
            else if (containerType == "Standard")
            {
                // We only check weight for Standard containers
                if (containerWeight > 30000)
                {
                    Console.WriteLine("STATUS: REJECTED ❌");
                    Console.WriteLine("Reason: Too Heavy for Road Transport.");
                }
                else if (containerWeight > 10000)
                {
                    int price = 200 + 500;
                    Console.WriteLine("STATUS: ACCEPTED (Heavy Cargo) ⚠️");
                    Console.WriteLine($"Price: ${price} (Includes $500 Heavy Fee)");
                }
                else
                {
                    int price = 200;
                    Console.WriteLine("STATUS: ACCEPTED (Standard) ✅");
                    Console.WriteLine($"Price: ${price}");
                }
            }
            else
            {
                Console.WriteLine("STATUS: UNKNOWN TYPE ❓");
                Console.WriteLine("Please enter 'Standard' or 'Dangerous'.");
            }
        }
    }
}
