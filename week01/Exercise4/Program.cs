using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int num = 1 ;
        float sum = 0;
        float avg ;
        int max = 0 ;
        int minPos = 0;
        List<int> numbers = new List<int>() ;

        Console.WriteLine("Enter a series of numbers (enter 0 to finish)");
        while (num != 0)
        {
            num = int.Parse(Console.ReadLine()) ;
            if (num != 0)
            {
                numbers.Add(num) ;
                sum = sum + num ;
                max = num ;
            
                if (num > 0)
                {
                    minPos = num;
                }
            }
        }

        numbers.Sort() ;

        Console.Write("\nThis is the sorted list: ") ;

        foreach (int x in numbers)
        {
            if (x > 0 && x < minPos)
            {
                minPos = x ;
            }

            if (x > max)
            {
                max = x ;
            }

            if (x != numbers[(numbers.Count - 1)])
            {
                Console.Write($"{x}, ");
            }
            else 
            {
                Console.Write($"{x}.");
            }
        }
        avg = sum / numbers.Count;

        Console.WriteLine($"\nThe sum of the numbers in the list equals {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"The largest number is: {max}");

        if (minPos > 0)
        {
            Console.WriteLine($"The smallest positive number is: {minPos}");
        }
        else
        {
            Console.WriteLine("There is no positive numbers in the list");
        }                
    }
}