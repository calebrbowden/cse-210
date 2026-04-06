public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordGoal()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }
}