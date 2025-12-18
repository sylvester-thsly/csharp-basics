using System;

namespace Week1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Calculator!");
            
            bool keepRunning = true;
            string operation = "";
            int result = 0;

            while (keepRunning)
            {
                // TODO: 1. Ask for first number (Convert string to int/double)
                Console.Write("What is your first number?: ");
                string input1 = Console.ReadLine();
                int num1 = Convert.ToInt32(input1);
                
                
                // TODO: 2. Ask for second number
                Console.Write("What is your second number?: ");
                string input2 = Console.ReadLine();
                int num2 = Convert.ToInt32(input2);
                
                // TODO: 3. Ask for operation (+, -, *, /)
                Console.WriteLine("At the Moment we have + for addition - for subtraction * for multiplication and / for divistion");
                operation = Console.ReadLine();
              
                
                
                // TODO: 4. Use if/else or switch to do the math
                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                    result = num1 / num2;
                }
                
                // TODO: 5. Print the result
                Console.WriteLine($"The result is {result}");
                
                // TODO: 6. Ask "Do you want to calculate again? (y/n)"
                // If 'n', set keepRunning = false
                Console.WriteLine("Do you want to calculate again? (y/n)");
                string input3 = Console.ReadLine();
                if (input3 == "n")
                {
                    keepRunning = false;
                }
                if (input3 == "y")
                {
                    keepRunning = true;;
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

           
        }
    }
}
