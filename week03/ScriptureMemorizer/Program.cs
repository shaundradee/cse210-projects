using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLoader loader = new ScriptureLoader();
        string filePath = "scriptureList.txt";
        Scripture scripture = loader.LoadRandomScripture(filePath);

        Console.Clear();
        Console.WriteLine($"{scripture.GetDisplayText()}");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine();

        } while (scripture.IsCompletelyHidden() != true);

    }
}