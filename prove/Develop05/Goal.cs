public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public List<Goal> _goals = new List<Goal>();

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual void RecordGoal()
    {
        
    }
    public void List()
    {
        foreach (Goal goal in _goals)
        {
            int number = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{number}. [ ] {goal.GetName()} - {goal.GetDescription()} ({goal.GetPoints()} points)");
        }
    }
    public void Save()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"You have {_points} points.");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name}: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}");
                outputFile.WriteLine();
            }
        }
    }
    public void Load()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string type = parts[0].Trim();
            Console.WriteLine(type);
            _name = parts[1].Trim();
            Console.WriteLine(_name);
            _description = parts[2].Trim();
            Console.WriteLine(_description);
            _points = int.Parse(parts[3].Trim());
            Console.WriteLine(_points);
            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(_name, _description, _points);
                _goals.Add(simpleGoal);
            }
            if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(_name, _description, _points);
                _goals.Add(eternalGoal);
            }
            if (type == "CheckListGoal")
            {
                int timesToComplete = int.Parse(parts[4].Trim());
                int bonusPoints = int.Parse(parts[5].Trim());
                CheckListGoal checkListGoal = new CheckListGoal(_name, _description, _points, timesToComplete, bonusPoints);
                _goals.Add(checkListGoal);
            }
        }
    }
}