public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public List<Goal> _goals = new List<Goal>();
    protected int _level;

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
    public virtual int RecordGoal()
    {
        return 0;
    }
    public int GetLevel(int points)
    {
        if (points >= 1000)
        {
            _level = 5;
        }
        else if (points >= 750)
        {
            _level = 4;
        }
        else if (points >= 500)
        {
            _level = 3;
        }
        else if (points >= 250)
        {
            _level = 2;
        }
        else
        {
            _level = 1;
        }
        return _level;
    }
    public void List()
    {
        foreach (Goal goal in _goals)
        {
            int number = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{number}. [{(goal is SimpleGoal ? ((SimpleGoal)goal).GetIsCompleted() ? "X" : " " : "")}{(goal is EternalGoal ? " " : "")}{(goal is CheckListGoal ? ((CheckListGoal)goal).GetTimesCompleted() >= ((CheckListGoal)goal).GetTimesToComplete() ? "X" : " " : "")}] {goal.GetName()} - {goal.GetDescription()} ({goal.GetPoints()} points) {goal.GetType().Name switch {
                "CheckListGoal" => ((CheckListGoal)goal).GetStatus(),
                _ => ""
            }}");
        }
    }
    public void Save(int points)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{points}, {_level}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name}: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}{goal.GetType().Name switch {
                    "SimpleGoal" => $", {((SimpleGoal)goal).GetIsCompleted()}",
                    "CheckListGoal" => $", {((CheckListGoal)goal).GetBonusPoints()}, {((CheckListGoal)goal).GetTimesToComplete()}, {((CheckListGoal)goal).GetTimesCompleted()}",
                    _ => ""
                }}");
                //outputFile.WriteLine();
            }
        }
    }
    public int Load()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            if (parts.Length < 2)
            {
                string[] subParts = parts[0].Split(",");
                _points = int.Parse(subParts[0].Trim());
                _level = int.Parse(subParts[1].Trim());
            }
            else
            {
                string[] subParts = parts[1].Split(",");
                string type = parts[0].Trim();
                _name = subParts[0].Trim();
                _description = subParts[1].Trim();
                int _goalPoints = int.Parse(subParts[2].Trim());
                if (type == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(_name, _description, _goalPoints, bool.Parse(subParts[3].Trim()));
                    _goals.Add(simpleGoal);
                }
                if (type == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(_name, _description, _goalPoints);
                    _goals.Add(eternalGoal);
                }
                if (type == "CheckListGoal")
                {
                    int bonusPoints = int.Parse(subParts[3].Trim());
                    int timesToComplete = int.Parse(subParts[4].Trim());
                    int timesCompleted = int.Parse(subParts[5].Trim());
                    CheckListGoal checkListGoal = new CheckListGoal(_name, _description, _goalPoints, bonusPoints, timesToComplete, timesCompleted);
                    _goals.Add(checkListGoal);
                }
            }
        }
        return _points;
    }
}