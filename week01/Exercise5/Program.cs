using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!") ;
    }

    static string PromptUserName()
    {
        Console.Write("Hi, User!. What's your name? ") ;
        string name = Console.ReadLine() ;
        return name ;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's your favorite number? ") ;
        int favoriteNumber = int.Parse(Console.ReadLine()) ;
        return favoriteNumber ;
    }

    static double SquareNumber(double number )
    {
        return Math.Pow(number, 2);
    }

    static void DisplayResult(string userName, double squareNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }
    
}