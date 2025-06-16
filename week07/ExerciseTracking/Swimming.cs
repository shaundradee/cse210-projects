using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(double min, int laps) : base(min)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / (1000 * 0.62);
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

        public override string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetLength()} min) - Laps {_laps}, Distance {GetDistance()} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}
