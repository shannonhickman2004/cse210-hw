using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({Minutes} min): Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}
