public class Scripture
{
    public string _reference;
    private List<string> _words = new List<string>();
    private string [] words;

    public void Display(string scripture)
    {
        words = scripture.Split(" ");
        foreach (string word in words)
        {
            Console.Write(word);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void Hide(string scripture)
    {
        Random random = new Random();
        words = scripture.Split(" ");
        for (int i = 0; i < 3; i++)
        {
            int num = random.Next(0, words.Length);
            Console.WriteLine(words[num]);
            string blank = "____";
            words[num] = blank;
            Console.WriteLine(words[num]);
        }
        foreach (string word in words)
        {
            Console.Write(word);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}