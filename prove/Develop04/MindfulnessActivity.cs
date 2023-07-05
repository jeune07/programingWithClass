using System;

public class MindfulnessActivity
{
    protected  int _duration;
    private string _description;
    private string _startingMessage;
    private string _finishingMessage;

    public int GetDuration()
    {
        return _duration;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    public string GetFinishingMessage()
    {
        return _finishingMessage;
    }

    public void SetDuration(int newDuration)
    {
        _duration = newDuration;
    }

    public void SetDescription(string newDescription)
    {
        _description = newDescription;
    }

    public void SetStartingMessage(string newStartingMessage)
    {
        _startingMessage = newStartingMessage;
    }

    public void SetFinishingMessage(string newFinishingMessage)
    {
        _finishingMessage = newFinishingMessage;
    }

    public MindfulnessActivity(int duration, string startingMessage, string finishingMessage, string description)
    {
        _duration = duration;
        _startingMessage = startingMessage;
        _finishingMessage = finishingMessage;
        _description = description;
    }

    public void beginActivity()
    {
        // Implementation of beginActivity
    }

    public void showStartingMessage()
    {
        Console.WriteLine("This is the stating message");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("This is the Display Starting Message");
    }

    public void showDescription()
    {
        Console.WriteLine("This is the show Description ");
    }

    public void showFinishingMessage()
    {

        Console.WriteLine("This is the showFinishingMessage ");
        
    }

    public void pauseWithSpinner(int seconds)
    {
        Console.WriteLine("This is the pauseWithSpinner  ");
        
    }

    public void pauseWithCountdown(int seconds)
    {
        Console.WriteLine("This is the pauseWithCountdown  ");
        
    }
}
