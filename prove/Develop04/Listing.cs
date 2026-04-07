public class Listing : Activity
{
    public string _info = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public List<string> _prompts = new List<string>();

    public void List(int seconds)
    {
        int numItems = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        Random random = new Random();
        int num = random.Next(0, 4);
        string prompt = _prompts.ElementAt(num);
        Console.Clear();
        CountDown();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Thread.Sleep(3000);
        while(seconds > 0)
        {
            Console.Write(">");
            Console.ReadLine();
            seconds -= 3;
            numItems++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {numItems} items.");
        Console.WriteLine();
    }
}