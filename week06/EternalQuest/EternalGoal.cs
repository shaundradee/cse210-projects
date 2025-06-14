using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        //maybe add a true bool here ...current score + points
        Console.WriteLine($"Congratulaions! You did it again! Keep it up! {GetPoints()} points will be added to your total!");
    }

    public override bool IsComplete()
    {
        //need to return a condition for bool... or just return as true? Goal is supposed to be continuous.
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }

}