// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string _userOption;

//         do
//         {
//             Console.WriteLine(" 1. Start breathing Activity \n 2. Start reflecting Activity \n 3. Start listing Activity \n 4. Quit \n Please select a choice from the menu");

//             _userOption = Console.ReadLine();

//             switch (_userOption)
//             {
//                 case "1":
//                     //BreathingActivity.GetStartingMessage();
//                     Console.WriteLine("Start breathing Activity");
//                     BreathingActivity breathingActivity = new BreathingActivity(10, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Thank for using our program", "Description");
//                     breathingActivity.ShowBreathingInstruction();
//                     breathingActivity.SetDuration(10);
//                     breathingActivity.pauseWithSpinner(10);
//                     breathingActivity.pauseWithCountdown(10);
//                     breathingActivity.pauseWithSpinner(10);
//                     break;

//                 case "2":
//                     Console.WriteLine("Start reflecting Activity");
//                     break;

//                 case "3":
//                     string startingMessage = "Welcome to the Listing Activity!";
//         string finishingMessage = "Thank you for participating in the Listing Activity. Goodbye!";

//         ListingActivity listingActivity = new ListingActivity(startingMessage, finishingMessage);
//         listingActivity.SetDuration(GetDurationFromUser());

//         listingActivity.BeginListingActivity();

//         Console.WriteLine("Press any key to exit.");
//         Console.ReadKey();
//     }

//     private static int GetDurationFromUser()
//     {
//         Console.WriteLine("Enter the duration in minutes for the Listing Activity:");
//         int duration;
//         while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
//         {
//             Console.WriteLine("Invalid duration. Please enter a positive integer value:");
//         }
//         return duration;
//     }
                    
//                     break;

//                 case "4":
//                     Console.WriteLine("Quitting...");
//                     // Add any necessary clean-up code or other actions for quitting.
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice");
//                     break;
//             }

//         } while (_userOption != "4");
//     }
// }


using System;

class Program
{
    static void Main(string[] args)
    {
        string _userOption;

        do
        {
            Console.WriteLine(" 1. Start breathing Activity \n 2. Start reflecting Activity \n 3. Start listing Activity \n 4. Quit \n Please select a choice from the menu");

            _userOption = Console.ReadLine();

            switch (_userOption)
            {
                case "1":                   
                    BreathingActivity breathingActivity = new BreathingActivity(10, "Welcome to the Listing Activity!","Thank you for using our program to practice","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.SetDuration(10);
                    breathingActivity.ShowBreathingInstruction();
                    breathingActivity.pauseWithSpinner(10);
                    breathingActivity.pauseWithCountdown(10);
                    breathingActivity.pauseWithSpinner(10);
                    break;

                case "2":
                    Console.WriteLine("Start reflecting Activity");
                    // Add the code for the ReflectingActivity here
                    break;

                case "3":
                   
                    ListingActivity listingActivity = new ListingActivity(10, "Welcome to the Listing Activity!","Thank you for using our program to practice","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    listingActivity.GetStartingMessage();            
                    listingActivity.SetDuration(GetDurationFromUser());
                    listingActivity.BeginListingActivity();
                    //listingActivity.GetFinishingMessage();

                   
                    break;

                case "4":
                    Console.WriteLine("Quitting...");
                    // Add any necessary clean-up code or other actions for quitting.
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (_userOption != "4");
    }

    private static int GetDurationFromUser()
    {
        Console.WriteLine("Enter the duration in minutes for the Listing Activity:");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer value:");
        }
        return duration;
    }
}

