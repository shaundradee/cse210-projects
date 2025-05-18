using System;


public class Entry
{
    //date, prompt text, entry text
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}