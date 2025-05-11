using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        string letter = "";
        bool passed = false;

        if (percent >= 90)
        {
            letter = "A";
            passed = true;
        }
        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
            passed = true;
        }
        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
            passed = true;

        }
        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
            passed = false;

        }
        else
        {
            letter = "F";
            passed = false;
        }

        Console.WriteLine($"Your grade percentage of {percent} is letter grade {letter}.");

        if (passed == true)
        {
            Console.WriteLine("You passed! Great job!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}