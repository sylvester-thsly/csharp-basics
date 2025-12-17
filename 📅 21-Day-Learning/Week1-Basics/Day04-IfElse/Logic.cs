using System;

namespace Week1
{
    class Logic
    {
        static void Main(string[] args)
        {
            // --- PRACTICE 1: Simple If/Else ---
            int age = 16;
            
            // TODO: Write an if statement checking if age is >= 18
            // If true, print "You can vote!"
            // Else, print "Too young to vote."
           if (age >= 18){
            Console.WriteLine("You can vote!");
           }
           else{
            Console.WriteLine("Too young to vote.");
           }

            // --- PRACTICE 2: User Input + Logic ---
            Console.Write("Enter the password: ");
            string input = Console.ReadLine(); 

            // TODO: Check if input equals "csharp"
            // If true, print "Access Granted"
            // Else, print "Access Denied" 
            if (input == "csharp"){
                Console.WriteLine("Access Granted");
            }
            else{
                Console.WriteLine("Access Denied");
            } 
        }
    }
}
