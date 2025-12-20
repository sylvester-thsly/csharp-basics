using System;

namespace Week2
{
    class Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Day 8: Methods ===\n");

            // TODO 1: Call the Greet method
            Greet();

            // TODO 2: Call the PrintLine method
            PrintLine();

            // TODO 3: Call the CountToTen method
            CountToTen();
        }

        // --- METHOD 1: Simple Method (No parameters, no return) ---
        static void Greet()
        {
            Console.WriteLine("Hello from the Greet method!");
        }

        // TODO 4: Create a method called PrintLine
        // It should print "--------------------"
        static
        void PrintLine()
        {
            Console.WriteLine("--------------------");
        }

        // TODO 5: Create a method called CountToTen
        // It should use a for loop to print numbers 1 to 10
        static void CountToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
