using System;

public abstract class Activity
{
    private string _date;
    private double _min;

    public Activity(double min)
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _min = min;
    }

    public double GetLength()
    {
        return _min;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_min} min) - Distance {GetDistance()} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}