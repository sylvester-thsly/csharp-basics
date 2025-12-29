using System;

namespace Practice
{
    class Day1_4_Refresher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ✨ QUICK REVISION: DAYS 1-4 ✨ ---\n");

            // ==========================================
            // DAY 2: VARIABLES (Types)
            // ==========================================
            Console.WriteLine("--- TEST 1: Variables ---");
            // ❌ TODO 1: Fix the Line Below (Type Mismatch)
            // int playerName = "Sylvester"; 
            
            // ✅ Corrected:
            string playerName = "Sylvester";
            
            // ==========================================
            // DAY 3: OPERATORS (Math)
            // ==========================================
            Console.WriteLine("--- TEST 2: Operators ---");
             int score = 10;
             // ❌ TODO 2: We want to ADD 5 to score. Fix the operator.
             // score =+ 5; // This sets it to positive 5! We want to ADD.

             score += 5; // ✅ Correct! += adds 5 to the existing score
             Console.WriteLine("Score should be 15. It is: " + score);
             

            // ==========================================
            // DAY 4: LOGIC (If/Else)
            // ==========================================
            Console.WriteLine("--- TEST 3: Logic ---");
            bool isSunny = false;

            // ❌ TODO 3: Why does this run even if isSunny is false? Fix the operator!
            // if (isSunny = true) 
            
            // ✅ Correct: Use == for comparison, and NO semicolon!
            if (isSunny == true)
            {
                Console.WriteLine("Wear sunglasses!");
            }
            else
            {
                Console.WriteLine("No sunglasses needed.");
            }
        
            Console.WriteLine("\nIf you fixed the 3 bugs, you are ready for Loops!");
        }
    }
}
