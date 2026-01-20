using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TEST TIME! ===");

        // --- CHALLENGE 1: Explicit Conversion ---
        // 1. Create a double variable 'myHeight' with value 1.75
        // 2. Cast it to an int variable 'myHeightInt'
        // 3. Print both. What value is lost?
        
        // [WRITE CODE HERE]
        // creating  a double variable 'myHeight' with value 1.75
        double myHeight = 1.75; 
        int myHeightInt = (int)myHeight;
        Console.WriteLine(myHeight);
        Console.WriteLine(myHeightInt); // Prints the int version

      


        // --- CHALLENGE 2: Math Operators ---
        // 1. Create two variables: int a = 7, int b = 2;
        // 2. Calculate and print the result of: a / b
        // 3. (Tricky!) Why is the answer not 3.5? Write your answer as a comment // 
        // 4. Fix it to print 3.5 using casting or doubles.
        
        // [WRITE CODE HERE
        // creating two variables: int a = 7, int b = 2;

        int a = 7; 
        int b = 2; 
        Console.WriteLine(a/b); 
        








        // --- CHALLENGE 3: Modulo (Remainder) ---
        // 1. Calculate: 10 % 3
        // 2. Print the result.
        
        // [WRITE CODE HERE]
        // --- CHALLENGE 3: Modulo (Remainder) ---
        Console.WriteLine(10 % 3);

    }
}
