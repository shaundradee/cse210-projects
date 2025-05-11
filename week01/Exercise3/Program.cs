using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game! Let's play!");
        Random randomGen = new Random();
        int magicNumber = randomGen.Next(1, 101);
        bool guessedIt = false;
        int numGuesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            int guess = int.Parse(userInputGuess);
            numGuesses += 1;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it! The number of tries: {numGuesses}");
                guessedIt = true;
            }
        } while (guessedIt == false);
    }
}