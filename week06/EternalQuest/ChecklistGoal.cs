using System;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        _amountComplete++;
        //???? -not sure how this will be used yet... 
        // if (_amountComplete >= _target)
        //     return GetPoints() + _bonus; or Console.WriteLine("💫 Your dedication paid off — goal complete! Your bonus points are dancing their way into your total!")
        // else
        //     return GetPoints(); or Console.WriteLine("Nice Work! One step closer to completion, Quest Master!")
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetShortName()} ({GetDescription()}) -- Completed {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints}|{_bonus}|{_target}|{_amountComplete}";
    }

}