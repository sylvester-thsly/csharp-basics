// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

int firstNumber;
int secondNumber;


Console.WriteLine("Welcome to my first programming language in c#");
Console.WriteLine("This is a simple calculator program.");

Console.WriteLine("Enter the first number?:");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your second number?:");
secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please chose a for addition, s for subtraction d for division and m for sumbraction");
string userChoice = Console.ReadLine();

if (userChoice == "a")
{
    int result = firstNumber + secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (userChoice == "s")
{
    int result = firstNumber - secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (userChoice == "d")
{
    int result = firstNumber / secondNumber;
    Console.WriteLine("The result is: " + result);
}
else if (userChoice == "m")
{
    int result = firstNumber * secondNumber;
    Console.WriteLine("The result is: " + result);
}





    Console.ReadLine();