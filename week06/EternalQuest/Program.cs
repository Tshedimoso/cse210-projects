using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        // EXCEEDING REQUIREMENTS:
        // 1. Added a Level System (user levels up every 1000 points).
        // 2. Displays current level in main menu.
        // 3. Encouraging exit message.

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            Console.WriteLine("==== Eternal Quest Program ====");
            Console.WriteLine($"Current Score: {manager.GetScore()}");
            Console.WriteLine($"Current Level: {manager.GetLevel()}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal(manager);
                    break;

                case 2:
                    manager.DisplayGoals();
                    Pause();
                    break;

                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved!");
                    Pause();
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded!");
                    Pause();
                    break;

                case 5:
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoal(goalIndex);
                    Pause();
                    break;

                case 6:
                    Console.WriteLine("Goodbye! Keep progressing on your Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.Clear();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
