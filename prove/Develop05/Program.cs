using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        //I made a level system based on the points the user has.
        Goal goal = new Goal("Test Goal", "This is a test goal.", 0);
        Console.WriteLine("Goal Program");
        int choice = 0;
        int numPoints = goal.GetPoints();
        while (choice != 6)
        {
        Console.WriteLine();
        Console.WriteLine($"You have {numPoints} points.");
        Console.WriteLine($"You are level {goal.GetLevel(numPoints)}.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        choice = int.Parse(input);
        if (choice == 1)
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalTypeInput = Console.ReadLine();
            int goalTypeChoice = int.Parse(goalTypeInput);
            if (goalTypeChoice == 1)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string pointsInput = Console.ReadLine();
                int points = int.Parse(pointsInput);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
                goal._goals.Add(simpleGoal);
            }
            if (goalTypeChoice == 2)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string pointsInput = Console.ReadLine();
                int points = int.Parse(pointsInput);
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                goal._goals.Add(eternalGoal);
            }
            if (goalTypeChoice == 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string pointsInput = Console.ReadLine();
                int points = int.Parse(pointsInput);
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string timesToCompleteInput = Console.ReadLine();
                int timesToComplete = int.Parse(timesToCompleteInput);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusPointsInput = Console.ReadLine();
                int bonusPoints = int.Parse(bonusPointsInput);
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonusPoints, timesToComplete, 0);
                goal._goals.Add(checkListGoal);
            }
        }
        if (choice == 2)
        {
            Console.WriteLine("The goals are:");
            goal.List();
        }
        if (choice == 3)
        {
            goal.Save(numPoints);
        }
        if (choice == 4)
        {
            numPoints = goal.Load();
        }
        if (choice == 5)
        {
            Console.WriteLine("The goals are:");
            goal.List();
            Console.Write("Which goal did you accomplish? ");
            string goalAccomplishedInput = Console.ReadLine();
            int goalAccomplishedChoice = int.Parse(goalAccomplishedInput);
            numPoints += goal._goals[goalAccomplishedChoice - 1].RecordGoal();
        }
        }
    }
}