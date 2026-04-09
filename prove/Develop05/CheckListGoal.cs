public class CheckListGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int bonus, int timesToComplete, int timesCompleted) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusPoints = bonus;
    }

    public override int RecordGoal()
    {
        int totalPoints = _points;
        if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted++;
            if (_timesCompleted == _timesToComplete)
            {
                Console.WriteLine($"Congratulations! You've completed the checklist goal: {_name} and earned {_bonusPoints} bonus points!");
                totalPoints += _bonusPoints;
            }
            else
            {
                Console.WriteLine($"You have earned {_points} points for completing the checklist goal: {_name} Only {_timesToComplete - _timesCompleted} more to go!");
            }
            return totalPoints;
        }
        else
        {
            Console.WriteLine($"You've already completed the checklist goal: {_name}");
            return 0;
        }
    }
    public string GetStatus()
    {
        return $"- {_timesCompleted}/{_timesToComplete} times completed";
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public int GetTimesToComplete()
    {
        return _timesToComplete;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}