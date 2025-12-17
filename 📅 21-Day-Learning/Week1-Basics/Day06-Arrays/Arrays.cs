using System;

namespace Week1
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // --- PRACTICE 1: Declare Array ---
            // TODO: Create a string array with 3 slots
            string[] fruits = new string[3];
            
            // TODO: Fill the slots
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Cherry";

            // --- PRACTICE 2: Loop Array ---
            Console.WriteLine("--- Fruit List ---");
            
            // TODO: Use a loop to print each fruit
            // Hint: Use fruits.Length to know how many times to loop
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }   
        }
    }
}
