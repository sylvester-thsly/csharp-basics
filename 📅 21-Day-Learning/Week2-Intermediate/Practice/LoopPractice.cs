using System;

namespace Practice
{
    class LoopsBootcamp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 🏋️ Loops Bootcamp 🏋️ ===\n");

            // --- PART 1: THE WHILE LOOP (The "As Long As" Loop) ---
            Console.WriteLine("--- Challenge 1: The Annoying Kid ---");
            Console.WriteLine("I will keep asking 'Are we there yet?' until you say 'yes'.");
            
            string answer = "no";
            
            // TODO 1: Create a while loop that runs while 'answer' is NOT "yes"
            // Hint: while (answer != "yes")
            while (answer != "yes")
            {
                Console.Write("Are we there yet? ");
                // TODO 2: Read the user's input into 'answer'
                answer = Console.ReadLine();
            }
            Console.WriteLine("Yay! We are here!\n");


            // --- PART 2: THE FOR LOOP (The "Counter" Loop) ---
            Console.WriteLine("--- Challenge 2: The Countdown ---");
            
            // TODO 3: Create a for loop that counts DOWN from 5 to 1
            // Hint: for (int i = 5; i >= 1; i--)
            // Warning: Do NOT put a semicolon here! -> for (...); 
            // It breaks the loop logic. Learned this the hard way.
            for (int i = 5; i >= 1; i--)
            {
                // TODO 4: Print the number 'i'
                Console.WriteLine(i);
            }
            Console.WriteLine("Blastoff! 🚀\n");


            // --- PART 3: THE COMBO ---
            Console.WriteLine("--- Challenge 3: Multiples of 5 ---");
            
            // TODO 5: Create a for loop to print multiples of 5, up to 50
            // Hint: Start at 0, go while i <= 50, Step is i = i + 5
            for (int i = 0; i <= 50; i += 5)
            {
               Console.WriteLine(i);
            }
        }
    }
}
