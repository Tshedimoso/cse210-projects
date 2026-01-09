using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        string letter = "";

        if (number >= 90)
        {
             letter = "A";
        }

        else if (number >= 80)
        {
             letter = "B";
        }

        else if (number >= 70)
        {
             letter = "C";
        }

        else if (number >= 60)
        {
             letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        

        if (number >= 70)
        {
            Console.Write("Congradulations, you passed the course!");
        }

        else
        {
            Console.Write("Sorry, you failed the course. Try again next block.");
        }

    }
}