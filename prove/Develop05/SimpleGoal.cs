public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override int RecordGoal()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
}