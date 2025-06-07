using System;
using Microsoft.VisualBasic;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        PauseAnimation();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        PauseAnimation();
    }

    public void PauseAnimation()
    {
        string[] spinner = { "\u25D0", "\u25D3", "\u25D1", "\u25D2" };
        DateTime start = DateTime.Now;
        DateTime length = start.AddSeconds(4);
        int index = 0;

        while (DateTime.Now < length)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(500);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
        }
    }
    public void CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

}