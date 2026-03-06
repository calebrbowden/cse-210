public class Activity
{
    //int _timer;
    public int ShowIntro(string activity, string info)
    {
        Console.WriteLine($"Welcome to the {activity} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"This activity will help you {info}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int milliseconds = int.Parse(input);
        milliseconds *= 1000;
        return milliseconds;
    }

    public void ShowEnd(int time, string activity)
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        time /= 1000;
        Console.WriteLine($"You have completed another {time} seconds of the {activity} Activity.");
    }
}