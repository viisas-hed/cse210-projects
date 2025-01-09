using System;

class Program
{
    static void Main(string[] args)
    {
        char letterGrade ;
        int numGrade ;
        string sign = String.Empty;
        string article ;

        Console.Write("What's your grade percentage? ");
        numGrade = int.Parse(Console.ReadLine());

        if (numGrade >= 90) 
        {
            letterGrade = 'A' ;
        }
        else if (90 > numGrade && numGrade >= 80)
        {
            letterGrade = 'B' ;
        }
        else if (80 > numGrade && numGrade >= 70)
        {
            letterGrade = 'C' ;
        }
        else if (70 > numGrade  && numGrade >= 60)
        {
            letterGrade = 'D' ;
        }
        else 
        {
            letterGrade = 'F' ;
        }
        if (numGrade < 97 && numGrade >= 60 )
        {
            if (numGrade % 10 >= 7 )
            {
                sign = "+" ;
            }
            else if (numGrade % 10 <= 3)
            {
                sign = "-" ;
            }
        }
        
        if (letterGrade == 'A' || letterGrade == 'B')
        {
            article = "an" ;
        }
        else
        {
            article = "a" ;
        }

        Console.WriteLine($"\nYou got {article} {letterGrade}{sign}");
        
        if (numGrade >= 70) 
        {
            Console.WriteLine("Congratulations! You have passed the course!\n");
        }
        else 
        {
            Console.WriteLine("You have not passed the course at this time, but we encourage you to keep studying and try again next semester!\n");
        }
    }
}