using System;

public class Running : Activity
{
    private double _distance;

    public Running(double min, double distance) : base(min)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }
}