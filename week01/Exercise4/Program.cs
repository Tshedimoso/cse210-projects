using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");

            string response = Console.ReadLine() ;
            userInput = int.Parse(response);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum = number + sum ;
        }
       
       Console.WriteLine($"The sum is: {sum}");

       float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        
        int maxValue = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        Console.WriteLine($"The max is: {maxValue}");


        

    }
}