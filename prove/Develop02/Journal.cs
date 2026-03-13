public class Journal
{
    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();
    public List<int> _nums = new List<int>();

    public string ChoosePrompt()
    {
            Random random = new Random();
            int num = random.Next(_nums.First(), _nums.Last());
            string prompt = _prompts.ElementAt(num);
            _prompts.Remove(_prompts.ElementAt(num));
            _prompts.Insert(num, "Prompt");
            _nums.Remove(num);
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
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
                outputFile.WriteLine($"Input: {entry._input}");
                outputFile.WriteLine();
            }
        }
    }
    public void Load()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}