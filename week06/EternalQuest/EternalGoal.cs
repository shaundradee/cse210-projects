using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        IsComplete();
    }

        public override int UpdateScore()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string CongratsMessage()
    {
        string[] messages = {
            "Another step forward on your eternal journey! Keep it up!",
            "Your dedication is blooming beautifully. Keep nurturing this goal!",
            "Your streak is alive! You earned more points — keep going!",
            "Small acts, big results. You're doing great!",
            "You're showing up even when it's hard. That's power.",
            "Eternal doesn't mean impossible — just limitless. You're thriving!",
            "Eternal progress made! More points earned — your journey continues...",
            "Discipline > motivation — and you've got both.",
            "You're gaining XP every day you show up.",
            "One drop at a time... before you know it, your bucket will be filled.",
            "GOAL REPEAT ALERT! Someone's in beast mode today."
        };

        Random rand = new Random();
        return messages[rand.Next(messages.Length)];
    }
}


