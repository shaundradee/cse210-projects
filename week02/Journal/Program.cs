using System;
using System.Text.Json;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGen genPrompt = new PromptGen();
        bool quit = false;

        while (quit == false)
        {
            //menu options
            Console.WriteLine();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string userSelect = Console.ReadLine();
            Console.WriteLine();

            try
            {
                if (userSelect == "1")
                {
                    Entry newEntry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    newEntry._date = theCurrentTime.ToShortDateString();
                    newEntry._promptText = genPrompt.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();
                    myJournal.AddEntry(newEntry);
                }
                else if (userSelect == "2")
                {
                    myJournal.DisplayAll();
                }
                else if (userSelect == "3")
                {
                    string jsonString = JsonSerializer.Serialize(myJournal);
                    Console.Write("Save as: ");
                    string fileName = Console.ReadLine();
                    File.WriteAllText(fileName, jsonString);
                    Console.WriteLine("File saved.");
                }
                else if (userSelect == "4")
                {
                    Console.Write("File Name: ");
                    string openFile = Console.ReadLine();
                    string jsonString = File.ReadAllText(openFile);
                    myJournal = JsonSerializer.Deserialize<Journal>(jsonString)!;
                    Console.WriteLine("File loaded.");
                }
                else
                {
                    Console.WriteLine("Have a fantastic day!");
                    quit = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}