double totalCost = 0;

while (true)
{
    Console.WriteLine("\nWelcome to the Coffee Shop!");
    Console.WriteLine("Total so far: $" + totalCost);
    Console.WriteLine("---------------------------");
    Console.WriteLine("1. Coffee ($2)");
    Console.WriteLine("2. Tea ($1)");
    Console.WriteLine("3. Water ($0.50)");
    Console.WriteLine("4. Exit and Pay");
    Console.WriteLine("---------------------------");
    Console.Write("What would you like to order? (Enter a number): ");

    string userChoice = Console.ReadLine();

    if (userChoice == "1")
    {
        totalCost += 2;
        Console.WriteLine("Added Coffee. Cost: $2.");
    }
    else if (userChoice == "2")
    {
        totalCost += 1;
        Console.WriteLine("Added Tea. Cost: $1.");
    }
    else if (userChoice == "3")
    {
        totalCost += 0.50;
        Console.WriteLine("Added Water. Cost: $0.50.");
    }
    else if (userChoice == "4")
    {
        break; // Exit the loop
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select a valid option.");
    }
}

Console.WriteLine("Thank you for shopping! Your final bill is: $" + totalCost);
Console.ReadLine();
// End of program

// ==========================================
// LEARNING MOMENT: WHAT DID WE USE HERE?
// ==========================================
// 1. DATA TYPES: 
//    - 'int' for whole numbers (1, 2, 3)
//    - 'double' for precision/money (0.50)
//    - 'string' for text ("Hello")
//
// 2. WHILE LOOP:
//    - 'while (true)' creates a loop that runs forever.
//    - It allows the user to keep ordering until they are done.
//    - 'break' is used to STOP the loop manually.
//
// 3. OPERATORS:
//    - 'totalCost += 2' is a shortcut for 'totalCost = totalCost + 2'.
//    - It adds to the existing pile instead of replacing it.
// ==========================================