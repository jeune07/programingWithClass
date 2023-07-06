using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int duration, string startingMessage, string finishingMessage, string description)
        : base(duration, startingMessage, finishingMessage, description)
    {
    }

    public void BeginListingActivity()
    {
        //DisplayStartingMessage();
        ShowBreathingInstruction();
        pauseWithSpinner(10);
        beginActivity();
        DisplayRandomPrompt();
        //StartCountdown(5);
        string response = Console.ReadLine();
        // Countdown for 5 seconds (adjust as needed)
        //int itemCount = StartListingItems();
        //DisplayItemCount(itemCount);
        //DisplayFinishingMessage();
    }

    private void StartCountdown(int seconds)
    {
        Console.WriteLine("Countdown started. Get ready...");
        for (int i = seconds; i > 0; i--)
        {

            Thread.Sleep(1000); // Sleep for 1 second
        }
        Console.WriteLine("Start listing items!");
    }

    private void DisplayRandomPrompt()
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }

    private int StartListingItems()
    {
        Console.WriteLine("List items: (Enter 'done' to finish)");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMinutes(GetDuration());

        string input;
        int itemCount = 0;

        while (DateTime.Now <= endTime)
        {
            input = Console.ReadLine();
            if (input != "done")
            {
                itemCount++;
            }
            else
            {
                break;
            }
        }

        return itemCount;
    }

    // private void DisplayItemCount(int itemCount)
    // {
    //     Console.WriteLine("Number of items listed: " + itemCount);
    // }

    private void DisplayFinishingMessage()
    {
        Console.WriteLine("Activity completed. " + GetFinishingMessage());
    }

    public void pauseWithSpinner(int newtimenumber)
    {
       for(int i = newtimenumber; i>0; i--){
        Console.Write("...");
        Thread.Sleep(3000);       
        Console.Write("\b\b\b   \b\b\b");       

       }
       
    }
    public void ShowBreathingInstruction(){
        Console.WriteLine("Welcome to Breathing Activity. \n This Activity Will help you relax by Walking through in and out slowly. Clear your mind and focus on you breathing ");

    }

    public void beginActivity()
    {
        Console.WriteLine("Consider this Following Promt");
    }
}
