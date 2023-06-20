using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("John", 3, 18);
       
        Scripture scripture = new Scripture(reference, "Whoever believes in Him is not condemned, but whoever does not believe has already been condemned, because he has not believed in the name of God's one and only Son.");

        Console.WriteLine($"Scripture Reference: {scripture}");
        Console.WriteLine($"{reference.Book} {reference.Chapter} {reference.Verse}: {scripture.GetDisplayText()}");

        Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            scripture.HideRandomWord();
            Console.WriteLine($"{reference.Book} {reference.Chapter} {reference.Verse}: {scripture.GetDisplayText()}");

            input = Console.ReadLine();
        }
    }
}
