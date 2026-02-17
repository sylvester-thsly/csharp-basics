using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- 1. WHILE LOOP (The Standard) ---");
        int counter = 0;
        
        // Checks condition BEFORE running
        while (counter < 5)
        {
            Console.WriteLine($"While: Count is {counter}");
            counter++; // Very Important! Otherwise infinite loop.
        }

        Console.WriteLine("\n--- 2. DO-WHILE LOOP (The Bouncer) ---");
        int number = 10;
        
        // Runs AT LEAST ONCE, even if condition is false
        do
        {
            Console.WriteLine($"Do-While: Number is {number} (Condition was < 5!)");
            number++;
        } while (number < 5);


        Console.WriteLine("\n--- 3. FOR LOOP (The Counter) ---");
        // Best for counting: (Start; Condition; Step)
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"For: i is {i}");
        }
    }
}
