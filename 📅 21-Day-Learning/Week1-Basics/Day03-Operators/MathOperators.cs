using System;

namespace Week1
{
    class MathOperators
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            // --- PRACTICE 1: Basic Math ---
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);

            // TODO: Calculate subtraction, multiplication
            int subtraction = a - b;
            Console.WriteLine("Subtraction: " + subtraction);
            // Multiplication 
            int multiplication = a * b; // Fixed: Added semicolon
            Console.WriteLine("Multiplication: " + multiplication); 
            
           
            // --- PRACTICE 2: The Tricky Division ---
            // TODO: Run this and see the result. Why is it 3?
            int division = a / b;
            Console.WriteLine("10 / 3 = " + division);

            // TODO: Fix it to show 3.333... (Hint: Use double)
            double divition = (double)a / b; // Fixed: Added (double) cast
            Console.WriteLine("10 / 3 = " + divition);

            // --- PRACTICE 3: Modulo (Remainder) ---
            int remainder = a % b;
            Console.WriteLine("Remainder of 10 / 3 is: " + remainder);
        }
    }
}
