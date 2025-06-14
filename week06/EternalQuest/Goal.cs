using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract int UpdateScore();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    public virtual string CongratsMessage()
    {
        string[] messages = {
            "Nice Work! One step closer to completion, Quest Master!!",
            "Your dedication paid off ! Your points are dancing their way into your total!",
            "Look at you! You ROCKSTAR!!",
            "You showed up. You did the work. You scored.",
            "HIGH FIVES all around! Whoop-whoop! A record in the books!",
            "POW!! You just punched today's goal in the face and earned more *ka-ching!*. Nice work!",
            "Reward yourself with imaginary pizza. You've earned it!",
            "BOOMSHAKALAKA! A point blast to your scoreboard!",
            "That's how legends grind — one victory at a time!",
        };

        Random rand = new Random();
        return messages[rand.Next(messages.Length)];
    }

}