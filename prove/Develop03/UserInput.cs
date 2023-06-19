
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

