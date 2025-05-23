using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLoader loader = new ScriptureLoader();
        string filePath = "scriptures.txt";
        Scripture scripture = loader.LoadRandomScripture(filePath);

        while (scripture.IsCompletelyHidden() != true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine();
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
        }
    }
}