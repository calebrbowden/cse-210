public class Breathing : Activity
{
    public string _info = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public void Breathe(int seconds)
    {
        Console.WriteLine("Get ready...");
        Console.WriteLine("");

        while(seconds > 0)
        {
            Console.Write("Breathe in...3");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.Write("Now breathe out...3");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}