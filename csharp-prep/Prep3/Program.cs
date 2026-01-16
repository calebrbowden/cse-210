using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Random random = new Random();
        int randomNum = random.Next(1, 101);
        Console.Write("What is your guess? ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);
        while (guess != randomNum)
        {
            if (guess > randomNum)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
            }
            else if ( guess < randomNum)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
            }
        }
        Console.WriteLine("You guessed it!");
    }
}