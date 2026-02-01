public class Journal
{
    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();

    public string ChoosePrompt()
    {
        Random random = new Random();
        int num = random.Next(1, 6);
        string prompt = _prompts.ElementAt(num);
        Console.WriteLine(prompt);
        Console.Write("> ");
        return prompt;
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void Save()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine();
        }
    }
}