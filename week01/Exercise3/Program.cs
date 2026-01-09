using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1 ;

        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
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
}