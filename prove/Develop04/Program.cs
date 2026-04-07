using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //I added a feature so the question prompts in the reflecting activity won't repeat.
        Console.WriteLine("Mindfulness Program");
        int choice = 0;
        while(choice != 4)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        Activity activity = new Activity();
        string input = Console.ReadLine();
        choice = int.Parse(input);
        if (choice == 1)
        {
            Breathing breathe = new Breathing();
            int time = activity.ShowIntro("Breathing", breathe._info);
            breathe.Breathe(time);
            activity.ShowEnd(time, "Breathing");
        }
        if (choice == 2)
        {
            Reflecting reflect = new Reflecting();
            int time = activity.ShowIntro("Reflecting", reflect._info);
            reflect.Reflect(time);
            activity.ShowEnd(time, "Reflecting");
        }
        if (choice == 3)
        {
            Listing list = new Listing();
            int time = activity.ShowIntro("Listing", list._info);
            list.List(time);
            activity.ShowEnd(time, "Reflecting");
        }
        }
    }
}