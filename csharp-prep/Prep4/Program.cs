using System;

class Program
{
    static void Main(string[] args)
    {
         Scripture scripture = new Scripture
        {
            Reference = "John 3:16",
            Text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        };

        ScriptureManager scriptureManager = new ScriptureManager();
        ConsoleManager consoleManager = new ConsoleManager();

        while (!scriptureManager.AreAllWordsHidden(scripture))
        {
            consoleManager.ClearConsole();
            consoleManager.DisplayScripture(scripture);
            scriptureManager.HideRandomWords(scripture);
            consoleManager.WaitForInput();
        }
    }
}