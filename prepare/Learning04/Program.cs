using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        assignment.GetSummary();
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeWorkList();
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();
    }
}