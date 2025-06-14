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
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }

    public override int UpdateScore()
    {
        if (IsComplete() && _amountComplete == _target)
        {
            return _bonus + GetPoints();
        }
        else
        {
            return GetPoints();
        }
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetShortName()} ({GetDescription()}) -- Completed {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountComplete}";
    }

}
