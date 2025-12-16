Console.WriteLine("Welcome to the Ultimate Battle: Sylvester vs Computer!");
Console.WriteLine("We are looking for a secret number between 1 and 100.");
Console.WriteLine("Whoever guesses it first wins!");

Random random = new Random();
int secretNumber = random.Next(1, 101);

// 1. Setup Lives
int sylvesterLives = 3;
int computerLives = 3;

while (sylvesterLives > 0 || computerLives > 0)
{
    // --- SYLVESTER'S TURN ---
    if (sylvesterLives > 0)
    {
        Console.WriteLine($"\nSylvester's Turn (Lives: {sylvesterLives}) > Enter your guess: ");
        string input = Console.ReadLine();
        int playerGuess = Convert.ToInt32(input);

        if (playerGuess == secretNumber)
        {
            Console.WriteLine("🎉 Sylvester WINS! The number was " + secretNumber);
            break;
        }
        else 
        {
            Console.WriteLine("WRONG!");
            if (playerGuess < secretNumber) Console.WriteLine("Too Low.");
            else Console.WriteLine("Too High.");
            
            sylvesterLives--; // Lose a life
        }
    }
    else
    {
        Console.WriteLine("\nSylvester is out of lives!");
    }

    // --- COMPUTER'S TURN ---
    if (computerLives > 0)
    {
        Console.WriteLine($"\nComputer's Turn (Lives: {computerLives})");
        int computerGuess = random.Next(1, 101); 
        Console.WriteLine("Computer guessed: " + computerGuess);

        if (computerGuess == secretNumber)
        {
            Console.WriteLine("🤖 Computer WINS! The number was " + secretNumber);
            break;
        }
        else 
        {
            Console.WriteLine("WRONG!");
            if (computerGuess < secretNumber) Console.WriteLine("Too Low.");
            else Console.WriteLine("Too High.");
            
            computerLives--; // Lose a life
        }
    }

    // Check if both lost
    if (sylvesterLives == 0 && computerLives == 0)
    {
        Console.WriteLine("\nGAME OVER! No one guessed it.");
        Console.WriteLine("The secret number was: " + secretNumber);
        break;
    }
}

Console.WriteLine("Press Enter to exit.");
Console.ReadLine();


