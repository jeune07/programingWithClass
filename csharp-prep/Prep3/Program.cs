using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the Journal App!");
//        UserInput.GetUserInput();

      
//     }
// }

// public class PromptBank
// {
//     public static string _randomQuestion;
//     private static string[] journalPrompts = new string[]
//         {
//             "What are three things you're grateful for today, and why?",
//             "Reflect on a recent accomplishment and describe how it made you feel.",
//             "What are your short-term and long-term goals? How can you work towards them?",
//             "Write about a challenge you faced recently. How did you overcome it, and what did you learn from the experience?",
//             "Describe a person who has had a significant impact on your life. What lessons have you learned from them?",
//             "Write about a book, article, or podcast that inspired you recently. What key takeaways did you gain from it?",
//             "How do you practice self-care and maintain a healthy work-life balance?",
//             "Reflect on a mistake or failure you experienced. What lessons did you learn, and how did you grow from it?",
//             "Write about a place you've always wanted to visit. What attracts you to it, and what would you like to do there?",
//             "How do you handle stress or difficult emotions? Share your coping strategies."
//         };

//     public static string GetRandomPrompt(){
//         Random rand = new Random();
//         int index = rand.Next(0, journalPrompts.Length);
//         _randomQuestion = journalPrompts[index];
//         return _randomQuestion;
//     }
// }

// public class UserInput
// {   public static string _userInput; 
//     public static void GetUserInput()
//     {
//          switch (_userInput=Console.ReadLine())
//     {
        
//        case "1":
//          Utiity.Write();
//             break;
//         case "2":
//             Utiity.Display();
//             break;

//         case "3":

//             Utiity.Load();
//             break;
            
//         case "4":

//             Utiity.Save();
//             break;

//         case "5":
            
//             Utiity.Quit();
//             break;
//         default:
//             Console.WriteLine("Invalid input");
//             break;
//     }
//     }

   
// }

// public class Utiity{
    
//     public static void Write(){
//         Console.WriteLine(PromptBank._randomQuestion);
//         string userInput = Console.ReadLine();
//         Console.WriteLine(userInput);
//     }

//     public static void Display(){

//     }
//     public static void Load(){

//     }
//     public static void Save(){

//     }
//     public static void Quit(){

//     }
// }



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App!");
        UserInput.GetUserInput();
    }
}

public class PromptBank
{
    private static string[] journalPrompts = new string[]
    {
        "What are three things you're grateful for today, and why?",
        "Reflect on a recent accomplishment and describe how it made you feel.",
        "What are your short-term and long-term goals? How can you work towards them?",
        "Write about a challenge you faced recently. How did you overcome it, and what did you learn from the experience?",
        "Describe a person who has had a significant impact on your life. What lessons have you learned from them?",
        "Write about a book, article, or podcast that inspired you recently. What key takeaways did you gain from it?",
        "How do you practice self-care and maintain a healthy work-life balance?",
        "Reflect on a mistake or failure you experienced. What lessons did you learn, and how did you grow from it?",
        "Write about a place you've always wanted to visit. What attracts you to it, and what would you like to do there?",
        "How do you handle stress or difficult emotions? Share your coping strategies."
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, journalPrompts.Length);
        return journalPrompts[index];
    }
}

public class UserInput
{
    public static void GetUserInput()
    {
        Console.WriteLine("Options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What will you do ?");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Utility.Write();
                break;
            case "2":
                Utility.Display();
                break;
            case "3":
                Utility.Load();
                break;
            case "4":
                Utility.Save();
                break;
            case "5":
                Utility.Quit();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        while(userInput !="5"){
            GetUserInput();
        }
    }
}

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
