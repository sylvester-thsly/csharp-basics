using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CLUB SECURITY CHECK ---");
        
        // Changing these variables will test your "if" logic!
        int age = 21; 
        bool hasID = true;

        // 1. Simple IF (Age Only)
        // If age is greater than or equal to 18...
        if (age >= 18)
        {
            Console.WriteLine("You are old enough.");
        }
        else
        {
            Console.WriteLine("You are too young! Go home.");
        }

        // 2. Complex IF (Age AND ID)
        // We use && for AND. Both sides must be true.
        if (age >= 18 && hasID == true) 
        {
            Console.WriteLine("ACCESS GRANTED: Welcome to the club! 🎉");
        }
        else
        {
            Console.WriteLine("ACCESS DENIED: You need to be 18+ AND have an ID.");
        }

        Console.WriteLine("\n--- GRADE CALCULATOR ---");
        
        // --- CHALLENGE: Grade Calculator ---
        // Change this score to test (e.g., 95, 85, 50)
        int score = 95; 

        if (score >= 90)
        {
            Console.WriteLine("Grade: A (Excellent!)");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B (Good job)");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C (Okay)");
        }
        else
        {
            Console.WriteLine("Grade: F (Study more!)");
        }
    }
}
