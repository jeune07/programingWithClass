using System;
using System.Collections.Generic;

public class Utility
{
    private static List<string> journalEntries = new List<string>();
    public static void Write()
    {
        Console.WriteLine(PromptBank.GetRandomPrompt());
        string userInput = Console.ReadLine();
        journalEntries.Add(userInput);        
        Console.WriteLine("User input: " + userInput);
    }

    public static void Display()
    {
        Console.WriteLine("Displaying journal entries:");
        for (int i = 0; i < journalEntries.Count; i++)
        {
            Console.WriteLine($"Entry {i + 1}: {journalEntries[i]}");
            Console.WriteLine($"Date and Time: {DateTime.Now}");
            Console.WriteLine();
        }
    }

    public static void Load()
    {
         Console.WriteLine("Loading journal entries...");
         Console.WriteLine("Enter the name of the file that you want to read");
         
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            journalEntries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    journalEntries.Add(line);
                    Console.WriteLine(line);
                }
            }

           // Console.WriteLine("Journal entries loaded from file: " + fileName);
        }
        else
        {
            Console.WriteLine("No journal entries found. Create new entries.");
        }
    }

    public static void Save()
    {
        Console.WriteLine("Enter the name your file");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving journal entries..."); 
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string entry in journalEntries)
            {
                writer.WriteLine(entry);
            }
        }

        Console.WriteLine("Journal entries saved to file: " + fileName);
    }

    public static void Quit()
    {
        Console.WriteLine("Quitting the Journal App...");
        Environment.Exit(0);
    }
}
