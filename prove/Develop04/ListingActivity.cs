using System;

public class ListingActivity: MindfulnessActivity
{
   public  ListingActivity (int duration, string startingMessage, string finishingMessage, string description)
   :base(duration,startingMessage,finishingMessage,description){

        Console.WriteLine("Listing Activity");
    }
}