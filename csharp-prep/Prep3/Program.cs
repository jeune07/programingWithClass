using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0;
        int userGuess = 0;
        int attempts = 0;
        do 
            {
                Random magicNumberGenerator = new Random();
                magicNumber = magicNumberGenerator.Next(1, 10);
                Console.WriteLine("what is the magic number?)");
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (userGuess >= magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                if (userGuess <= magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                // else
                // {
                //     Console.WriteLine("Igual !");
                // }

            } while (userGuess != magicNumber);
            attempts++;
            Console.WriteLine($"You got it! It took you {attempts} attempts", attempts);

            Console.WriteLine("Would you like to play again? (y/n)");
            string playAgain = Console.ReadLine();
            if (playAgain == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }

    }
}