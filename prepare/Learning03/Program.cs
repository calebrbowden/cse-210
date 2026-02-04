using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Random random = new Random();
        for(int i = 1; i < 21; i++)
        {
            int top = random.Next(0, 9);
            int bottom = random.Next(1, 9);
            fraction.SetTop(top);
            fraction.SetBottom(bottom);
            string fractionString = fraction.GetFractionString();
            double fractionDecimal = fraction.GetDecimalValue();
            Console.WriteLine($"Fraction {i}: string: {fractionString} Number: {fractionDecimal}");
        }
    }
}