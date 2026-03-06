public class Breathing
{
    public string _info = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public void Breathe(int milliseconds)
    {
        Console.WriteLine("Get ready...");
        Console.WriteLine("");

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Breathe in...3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.Write("Now breathe out...3");
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
        Console.WriteLine("");
    }
}