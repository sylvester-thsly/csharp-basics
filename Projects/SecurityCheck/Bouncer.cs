using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CLUB SECURITY CHECK ---");
        
        // 1. Define variables
        int age = 20; 
        bool hasID = true;
        Console.WriteLine($"Checking person: Age {age}, Has ID: {hasID}");

        // 2. The Simple Check (Age only)
         if (age >= 18)
        {
            Console.WriteLine("Step 1: You are old enough.");
        }
        else
        { 
            Console.WriteLine("Step 1: You are too young! Go home.");
        }

        // 3. The Complex Check (Age AND ID)
        if (age >= 18 && hasID == true)
        {
             Console.WriteLine("FINAL DECISION: ACCESS GRANTED! Welcome to the club! 🎉");
        }
        else
        {
            Console.WriteLine("FINAL DECISION: ACCESS DENIED. (You need to be 18+ AND have an ID). 🛑");
        } 
    }
}
