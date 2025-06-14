using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        //maybe add a true bool here ...current score + points... random string for message?
        Console.WriteLine($"Eternal progress made! {GetPoints()} points earned — your journey continues...");
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


// string[] messages = {
//     "Another step forward on your eternal journey! Keep it up!",
//     "Your dedication is blooming beautifully. Keep nurturing this goal!",
//     "Your streak is alive! You earned more points — keep going!",
//     "Small acts, big results. You're doing great!",
//     "Eternal doesn’t mean impossible — just limitless. You’re thriving!"
// };

// Random rand = new Random();
// Console.WriteLine(messages[rand.Next(messages.Length)]);