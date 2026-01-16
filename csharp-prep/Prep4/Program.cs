using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int num = 1;
        int sum = 0;
        int largest = 0;
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            numbers.Add(num);
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = sum / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}