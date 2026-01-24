public class PromptGenerator
{
    private List<string>_prompts;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? " ,
            "What was the strongest emotion i felt today? ",
            "How did i see the hand of the Lord in my life today? ",
            "If i had one thing i could do over today, what would it be? ",
            "Describe your perfect day."
        };
    }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }


    
