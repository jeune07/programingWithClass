using System;
using System.Collections.Generic;
using System.Linq;

class ConsoleManager
{
    public void ClearConsole()
    {
        Console.Clear();
    }

    public void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.Reference);
        Console.WriteLine(scripture.Text);
    }

    public void WaitForInput()
    {
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            Environment.Exit(0);
        }
    }
}
