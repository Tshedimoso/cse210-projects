using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int randomNumber = int.Parse(userInput);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (guess == randomNumber)
        {
            Console.WriteLine("You guessed it!");
        }

        else if (guess >= randomNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("Higher");
        }



    }
}