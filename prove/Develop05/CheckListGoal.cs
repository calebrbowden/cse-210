public class CheckListGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int timesToComplete, int bonus) : base(name, description, points)
    {
        _timesCompleted = 0;
        _timesToComplete = timesToComplete;
        _bonusPoints = bonus;
    }

    public override void RecordGoal()
    {
        if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted++;
            if (_timesCompleted == _timesToComplete)
            {
                Console.WriteLine($"Congratulations! You've completed the checklist goal: {_name}");
            }
        }
        else
        {
            Console.WriteLine($"You've already completed the checklist goal: {_name}");
        }
    }

    public string GetStatus()
    {
        return $"{_name} - {_timesCompleted}/{_timesToComplete} times completed";
    }
}