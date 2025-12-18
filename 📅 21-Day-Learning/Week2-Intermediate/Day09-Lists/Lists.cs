using System;
using System.Collections.Generic;

namespace Week2
{
    class Lists
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Day 9: Lists ===\n");

            // --- PRACTICE 1: Create and Add ---
            // TODO 1: Create a List of strings called "tasks"
            List<string> tasks = new List<string>();
            

            // TODO 2: Add 3 tasks to the list
            // Example: tasks.Add("Learn C#");
            tasks.Add("Learn C#");
            tasks.Add("Learn C#");
            tasks.Add("Learn C#");
            


            // --- PRACTICE 2: Display the List ---
            Console.WriteLine("My To-Do List:");
            // TODO 3: Use a foreach loop to print each task
            // Hint: foreach (string task in tasks)
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            


            // --- PRACTICE 3: Remove an Item ---
            Console.WriteLine("\nRemoving first task...");
            // TODO 4: Remove the first task using RemoveAt(0)
            tasks.RemoveAt(0);

            // TODO 5: Print the list again to see the change
            Console.WriteLine("\nUpdated List:");
            

        }
    }
}
