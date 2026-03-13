using System;

class Program
{
    static void Main(string[] args)
    {
        //I added a feature so the prompts won't repeat.
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();
        journal._prompts.Add("What was the best part of my day?");
        journal._prompts.Add("What was the worst part of my day?");
        journal._prompts.Add("What am I grateful for today?");
        journal._prompts.Add("What would I do differently today?");
        journal._prompts.Add("Who did I interact with today and how did it go?");
        journal._nums.Add(0);
        journal._nums.Add(1);
        journal._nums.Add(2);
        journal._nums.Add(3);
        journal._nums.Add(4);
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        while (choice != 5)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string input = Console.ReadLine();
        choice = int.Parse(input);
            if (choice == 1)
            {
                if(journal._nums.Sum() > 0)
                {
                    Entry newEntry = new Entry();
                    string prompt = journal.ChoosePrompt();
                    string entry = Console.ReadLine();
                    newEntry._input = entry;
                    newEntry._prompt = prompt;
                    newEntry._date = date;
                    journal._entries.Add(newEntry);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No more prompts are left.");
                    Console.WriteLine();
                }
            }
            if (choice == 2)
            {
                journal.Display();
            }
            if (choice == 3)
            {
                journal.Load();
            }
            if (choice == 4)
            {
                journal.Save();
            }
        }
    }
}