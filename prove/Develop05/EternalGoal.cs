public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordGoal()
    {
        Console.WriteLine($"You have earned {_points} points for completing the eternal goal: {_name}!");
    }
}