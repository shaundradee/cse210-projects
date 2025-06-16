using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(double min, int speed) : base(min)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / (GetLength() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    } 
}