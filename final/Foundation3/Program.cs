using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Address address1 = new Address("BYU-Idaho", "Rexburg", "ID", "USA");
        Address address2 = new Address("123 1st Street", "Rexburg", "ID", "USA");
        Address address3 = new Address("Park", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture("Programming with Classes", "Learn the fundamentals of object-oriented programming.", "3/31", "1pm", address1, "Brother Gibbons", 100);
        Reception reception = new Reception("Reception", "Food will be provided.", "3/31", "5pm", address2, "email@email.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("5k Race", "Race a 5k in the park.", "3/31", "3pm", address3, "Sunny");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}