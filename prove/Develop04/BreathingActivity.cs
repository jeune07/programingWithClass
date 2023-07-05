using System;

public class BreathingActivity:MindfulnessActivity
{
    public BreathingActivity(int duration, string startingMessage, string finishingMessage, string description)
        : base(duration, startingMessage, finishingMessage, description)
        {
            
        }

    public void ShowBreathingInstruction(){
        Console.WriteLine("Welcome to Breathing Activity. \n This Activity Will help you relax by Walking through in and out slowly. Clear your mind and focus on you breathing ");

    }

    public void SetDuration(int newDuration)
    {

        _duration = newDuration;
        Console.WriteLine("We can start with  " + _duration + "S");

    }
//Animation
    public void pauseWithSpinner(int newtimenumber)
    {
       for(int i = newtimenumber; i>0; i--){
        Console.Write("...");
        Thread.Sleep(3000);       
        Console.Write("\b\b\b   \b\b\b");       

       }
    }

    //Count down
 public  void pauseWithCountdown(int newSeconds)
    {
        for (int i = 0; i < (newSeconds/5); i++)
        {
            Console.Write("Breathing in... ");
            for (int j = 5; j > 0; j--)
            {
                Console.Write("{0}   ", j);
                Thread.Sleep(1000); // Pause for 1 second
            }
            Console.WriteLine(); // Move to the next line after the countdown is complete

            if (i < newSeconds - 1)
            {
                Console.Write("Breathing out... ");
                for (int j = 5; j > 0; j--)
                {
                    Console.Write("{0}   ", j);
                    Thread.Sleep(1000); // Pause for 1 second
                }
                Console.WriteLine(); // Move to the next line after the countdown is complete
            }
        }

        Console.WriteLine("Well done");
    }
}