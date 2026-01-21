using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            if (choice == 1)
            {
                Console.WriteLine("Hooray!");
            }
            
            else if (choice == 2)
            {
                Console.WriteLine("Yay!");
            }

            else if (choice == 3)
            {
                Console.WriteLine("Good!");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Very Good!");
            }

            else
            {
                
            }


        }

    }
}