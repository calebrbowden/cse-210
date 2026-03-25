public class Reflecting : Activity
{
    public string _info = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    public List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();    
    public void Reflect(int seconds)
    {
        _prompts.Add("Think of a time you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        Random random = new Random();
        int num = random.Next(0, 3);
        string prompt = _prompts.ElementAt(num);
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Thread.Sleep(3000);
        Console.WriteLine("Reflect on these questions.");
        while(seconds > 0)
        {
            Console.WriteLine();
            int num2 = random.Next(0, 8);
            string question = _questions.ElementAt(num2);
            Console.WriteLine(question);
            Thread.Sleep(3000);
            seconds -=3;
        }
    }
}