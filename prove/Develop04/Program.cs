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
                    Console.WriteLine("Start breathing Activity");
                    BreathingActivity breathingActivity = new BreathingActivity(10, "Starting message", "Finishing message", "Description");
                    breathingActivity.ShowBreathingInstruction();
                    breathingActivity.SetDuration(10);
                    breathingActivity.pauseWithSpinner(10);
                    breathingActivity.pauseWithCountdown(10);
                    breathingActivity.pauseWithSpinner(10);
                    break;

                case "2":
                    Console.WriteLine("Start reflecting Activity");
                    break;

                case "3":
                    Console.WriteLine("Start listing Activity");
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
}
