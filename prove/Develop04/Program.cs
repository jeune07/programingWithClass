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
                    BreathingActivity breathingActivity = new BreathingActivity(10, "Welcome to the Breathing Activity!", "Thank you for using our program to practice breathing exercises.", "This activity will help you relax by guiding you through slow and focused breathing.");
                    breathingActivity.SetDuration(10);
                    breathingActivity.ShowBreathingInstruction();
                    breathingActivity.pauseWithSpinner(10);
                    breathingActivity.pauseWithCountdown(10);
                    breathingActivity.pauseWithSpinner(10);
                    break;

                case "2":
                    Console.WriteLine("Start reflecting Activity");
                    ReflectionActivity reflectionActivity = new ReflectionActivity(10, "Welcome to the Reflecting Activity!", "Thank you for reflecting on your experiences.");
                    reflectionActivity.SetDuration(10);
                    reflectionActivity.BeginReflectionActivity();
                    break;

               case "3":
                    ListingActivity listingActivity = new ListingActivity(10, "Welcome to the Listing Activity!", "Thank you for participating in the Listing Activity.","");
                    listingActivity.SetDuration(GetDurationFromUser());
                     listingActivity.BeginListingActivity();
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
