using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator=new Random();
        int randomNumber=randomGenerator.Next(1,10);
        Console.WriteLine("Guess a number between 1 and 10");
        int userGuess=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(randomNumber);

    }
}
