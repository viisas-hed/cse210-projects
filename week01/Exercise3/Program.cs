using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random() ;
        string playAgain = "no";

        do {
            int guess = 0;
            int guessCounter = 1;
            int magicNumber = randomGenerator.Next(1, 100);
            Console.WriteLine("\nThere is a 'Magic Number' you need to guess.");
            Console.WriteLine("Let's see how many guesses it takes you to get it.");
            Console.WriteLine("Pick a number in between 1 and 100.");
            guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber) 
            {
                if (guess > magicNumber) 
                {
                    Console.WriteLine("Incorrect, try to guess lower.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Incorrect, try to guess higher.");
                }
                guessCounter = guessCounter + 1 ;
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"You're Right! Congratulations! The magic number was {magicNumber}.");
            Console.WriteLine($"Number of guesses: {guessCounter}");

            Console.WriteLine("Do you want to play again? (Enter 'yes' or 'no')");
            playAgain = Console.ReadLine() ;

        }while (playAgain == "yes") ;
        Console.WriteLine("Thank you for playing! See you soon!");
    }
}