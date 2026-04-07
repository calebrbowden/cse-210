public class Activity
{
    //int _timer;
    private string _name;
    private string _description;
    private int _duration;
    public int ShowIntro(string activity, string info)
    {
        Console.WriteLine($"Welcome to the {activity} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"This activity will help you {info}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int seconds = int.Parse(input);
        //milliseconds *= 1000;
        return seconds;
    }

    public void ShowEnd(int time, string activity)
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        //time /= 1000;
        Console.WriteLine($"You have completed another {time} seconds of the {activity} Activity.");
        Console.WriteLine("");
    }

    public void CountDown()
    {
        Console.Write("Get ready...");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    public void Spinner()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
}