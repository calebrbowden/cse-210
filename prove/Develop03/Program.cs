using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture();
        string scriptureString = "";
        Console.WriteLine("Scripture Memorizer Program");
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. D&C 4:1-7");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        if (choice == 1)
        {
            scripture._reference = "John 3:16";
            scriptureString = "For God so loved the world";
            Console.WriteLine(scripture._reference);
            scripture.Display(scriptureString);
        }
        if (choice == 2)
        {
            scripture._reference = "D&C 4:1-7";
            scriptureString= "1 Now behold, a marvelous work is about to come forth among the children of men. 2 Therefore, O ye that embark in the service of God, see that ye serve Him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. 3 Therefore, if ye have desires to serve God ye are called to the work; 4 For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; 5 And faith, hope, charity and love. with an eye single to the glory of God, qualify him for the work. 6 Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. 7 Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.";
            Console.WriteLine(scripture._reference);
            scripture.Display(scriptureString);
        }
        while (input != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(scripture._reference);
            scripture.Hide(scriptureString);
            Console.WriteLine(scriptureString);
            scripture.Display(scriptureString);
        }
    }
}