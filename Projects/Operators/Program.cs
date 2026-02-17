using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Age Calculator ---");
        
        int currentYear = 2026;
        int birthYear = 2000; // Change this to your birth year
        
        int age = currentYear - birthYear;
        
        Console.WriteLine("You are approx " + age + " years old.");
    }
}
