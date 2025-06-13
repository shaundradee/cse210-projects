using System;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
 

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
    }

    public override string GetStringRepresentation()
    {

    }
    public override string GetDetailsString()
    {
    }

}