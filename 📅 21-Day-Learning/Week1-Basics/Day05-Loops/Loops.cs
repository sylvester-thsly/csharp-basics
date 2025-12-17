using System;

namespace Week1
{
    class Loops
    {
        static void Main(string[] args)
        {
            // --- PRACTICE 1: While Loop ---
            Console.WriteLine("--- Blastoff ---");
            int countdown = 10;

            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }
            Console.WriteLine("Blastoff! 🚀");

            // --- PRACTICE 2: For Loop ---
            Console.WriteLine("\n--- Even Numbers ---");
            
            // TODO: Create a for loop: for (int i = 0; i <= 20; i++)
            // Challenge: Only print if i is even (i % 2 == 0) OR just increase i by 2
            
            for (int i = 0; i <= 20; i += 2) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
