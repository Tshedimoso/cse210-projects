public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(int index)
    {
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your Score: {_score}");
    }

    public void SaveGoals(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        writer.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }
}

public void LoadGoals(string filename)
{
    string[] lines = File.ReadAllLines(filename);

    _score = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(":");
        string type = parts[0];
        string[] data = parts[1].Split(",");

        if (type == "SimpleGoal")
        {
            var goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
            _goals.Add(goal);
        }
        else if (type == "EternalGoal")
        {
            var goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
            _goals.Add(goal);
        }
        else if (type == "ChecklistGoal")
        {
            var goal = new ChecklistGoal(
                data[0],
                data[1],
                int.Parse(data[2]),
                int.Parse(data[3]),
                int.Parse(data[4])
            );
            _goals.Add(goal);
        }
    }
}

public int GetScore()
{
    return _score;
}

public int GetLevel()
{
    return _score / 1000; // Level up every 1000 points
}

}

