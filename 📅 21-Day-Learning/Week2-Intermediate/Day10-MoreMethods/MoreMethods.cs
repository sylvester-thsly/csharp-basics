using System;

namespace Week2
{
    class MoreMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Day 10: Advanced Methods ===\n");

            // --- PRACTICE 1: Parameters (Input) ---
            // TODO 1: Call SayHello passing your name 
            SayHello("Sylvester");
            
            // TODO 2: Call SayHello passing a friend's name
            SayHello("Friend");


            // --- PRACTICE 2: Return Values (Output) ---
            // TODO 3: Call Add and store the result in a variable
            // int sum = Add(5, 10);
            int sum = Add(5, 10); 

            
            // TODO 4: Print the sum
            Console.WriteLine("The sum is " + sum);
            


            // --- PRACTICE 3: Challenge ---
            // TODO 5: Call CalculateAge giving it your birth year
            // int age = CalculateAge(1990);
            // Console.WriteLine("You are " + age + " years old.");
            int age = CalculateAge(2008);
            Console.WriteLine("You are " + age + " years old.");
        }

        // --- METHOD 1: Parameters ---
        // This method takes a 'name' as input
        static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        // --- METHOD 2: Return Values ---
        // This method returns an integer (int)
        static int Add(int a, int b)
        {
            return a + b;
        }

        // --- METHOD 3: Challenge Method ---
        // TODO 6: Create a method called CalculateAge
        // It should take 'birthYear' (int) as input
        // It should return the age (current year - birthYear)
        static int CalculateAge(int birthYear)
        {
            int currentYear = 2025; // Or use DateTime.Now.Year if you want to be fancy
            return currentYear - birthYear;
        }
        
    }
}
