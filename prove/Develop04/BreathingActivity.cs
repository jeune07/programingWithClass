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
        Console.WriteLine("The new duration is " + _duration);

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

     
    
    // set the time 

    // use the time in 
}