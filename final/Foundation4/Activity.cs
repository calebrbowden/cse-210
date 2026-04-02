public class Activity
{
    private DateTime _date;
    private double _length;
    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_length} min) - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}