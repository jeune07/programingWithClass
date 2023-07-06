using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration, string startingMessage, string finishingMessage)
        : base(duration, startingMessage, finishingMessage, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void BeginReflectionActivity()
    {
        DisplayStartingMessage();
        int durationInSeconds = GetDuration() * 60;
        int remainingSeconds = durationInSeconds;
        Random random = new Random();

        while (remainingSeconds > 0)
        {
            string prompt = GetRandomPrompt(random);
            string question = GetRandomQuestion(random);

            Console.WriteLine("Prompt: " + prompt);
            PauseWithSpinner(2); // Pause for 2 seconds (adjust as needed)
            Console.WriteLine("Reflect on the following question:");
            Console.WriteLine("Question: " + question);
            PauseWithSpinner(5); // Pause for 5 seconds (adjust as needed)

            remainingSeconds -= 7; // Adjusted time for prompt and question

            if (remainingSeconds > 0)
            {
                Console.Clear();
                remainingSeconds -= 2; // Adjusted time for clearing console
            }
        }

        ShowFinishingMessage(); // Add this line to display the finishing message
    }

    private string GetRandomPrompt(Random random)
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    private string GetRandomQuestion(Random random)
    {
        int index = random.Next(questions.Length);
        return questions[index];
    }

    private void PauseWithSpinner(int seconds)
    {
        Console.CursorVisible = false;
        int milliseconds = seconds * 1000;
        int spinnerIndex = 0;
        string[] spinnerFrames = { "/", "-", "\\", "|" };

        DateTime startTime = DateTime.Now;
        TimeSpan elapsed;

        do
        {
            Console.Write("Processing... " + spinnerFrames[spinnerIndex]);
            Thread.Sleep(100);
            elapsed = DateTime.Now - startTime;
            spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;
            Console.SetCursorPosition(0, Console.CursorTop);
        } while (elapsed.TotalMilliseconds < milliseconds);

        Console.CursorVisible = true;
        Console.WriteLine();
    }
}
