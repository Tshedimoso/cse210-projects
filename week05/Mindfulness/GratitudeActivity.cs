using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of someone who made your life easier recently.",
        "Think of something simple you are grateful for today.",
        "Think of a challenge that helped you grow.",
        "Think of a small moment that made you smile."
    };

    public GratitudeActivity()
        : base(
            "Gratitude",
            "This activity will help you focus on gratitude by reflecting on positive moments and expressing appreciation."
        )
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("Reflecting begins in: ");
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing things you are grateful for:");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"You expressed gratitude for {responses.Count} things!");
    }
}
