using System;
using System.Collections.Generic;

namespace Examples
{
    class PracticeExamples
    {
        static void Main(string[] args)
        {
            // Example 1: FizzBuzz (Classic programming challenge)
            Console.WriteLine("=== FizzBuzz ===");
            for (int i = 1; i <= 15; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            // Example 2: Reverse a string
            Console.WriteLine("\n=== Reverse String ===");
            string original = "Hello";
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine($"{original} reversed is {reversed}");

            // Example 3: Find max in list
            Console.WriteLine("\n=== Find Maximum ===");
            List<int> numbers = new List<int> { 5, 2, 9, 1, 7 };
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            Console.WriteLine($"Maximum number is: {max}");
        }
    }
}
