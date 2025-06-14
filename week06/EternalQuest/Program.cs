using System;

// Added creativity by implementing tryParse for incorrect user inputs
// Added virtual method to provide a randomly selected message for points earned
//   -message method overridden in eternal sub class for different messages directed more
//   towards repeated tasks
// Added a message for after program closed

class Program
{
    static void Main(string[] args)
    {
        GoalManager g1 = new GoalManager();
        g1.Start();
        Console.WriteLine("Thanks for visiting the Eternal Quest! Hope to see you again soon!");

    }
}