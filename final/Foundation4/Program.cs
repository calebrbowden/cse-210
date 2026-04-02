using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        DateTime date = DateTime.Now;
        Running run = new Running(date, 12, 1.5);
        Cycling cycle = new Cycling(date, 18, 20);
        Swimming swim = new Swimming(date, 6, 8);
        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}