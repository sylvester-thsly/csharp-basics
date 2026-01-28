using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- GRADE CALCULATOR (WIP) ---");

        int score = 85; 

        // TODO: Finish logic after school
        if (score >= 90)
        {
            Console.WriteLine("Grade: A (Excellent!) 🌟");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B (Good Job) 👍");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C (You Passed) ✅");
        }
        else
        {
            Console.WriteLine("Grade: F (Try Again) ❌");
        }
    }
}
