using System;

class Program
{
    static void Main(string[] args)
    {
       Address _address1 = new Address("123 Main St", "City 1", "State 1", "Country 1");

        Event _genericEvent = new Event("Generic Event", "This is a generic event.", DateTime.Now, TimeSpan.FromHours(2), _address1);
        Lecture _lecture = new Lecture("Lecture Event", "This is a lecture event.", DateTime.Now, TimeSpan.FromHours(3), _address1, "Speaker 1", 50);
        Reception _reception = new Reception("Reception Event", "This is a reception event.", DateTime.Now, TimeSpan.FromHours(4), _address1, "example@example.com");
        OutdoorGathering _outdoorGathering = new OutdoorGathering("Outdoor Gathering Event", "This is an outdoor gathering event.", DateTime.Now, TimeSpan.FromHours(5), _address1, "Sunny");

        Console.WriteLine("Generic Event:");
        Console.WriteLine(_genericEvent.GetStandardDetails());
        Console.WriteLine(_genericEvent.GetFullDetails());
        Console.WriteLine(_genericEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(_lecture.GetStandardDetails());
        Console.WriteLine(_lecture.GetFullDetails());
        Console.WriteLine(_lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(_reception.GetStandardDetails());
        Console.WriteLine(_reception.GetFullDetails());
        Console.WriteLine(_reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(_outdoorGathering.GetStandardDetails());
        Console.WriteLine(_outdoorGathering.GetFullDetails());
        Console.WriteLine(_outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}