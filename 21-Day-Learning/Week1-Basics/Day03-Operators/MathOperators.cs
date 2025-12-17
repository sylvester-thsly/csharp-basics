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
            
            // --- PRACTICE 2: The Tricky Division ---
            // TODO: Run this and see the result. Why is it 3?
            int division = a / b;
            Console.WriteLine("10 / 3 = " + division);

            // TODO: Fix it to show 3.333... (Hint: Use double)

            // --- PRACTICE 3: Modulo (Remainder) ---
            int remainder = a % b;
            Console.WriteLine("Remainder of 10 / 3 is: " + remainder);
        }
    }
}
