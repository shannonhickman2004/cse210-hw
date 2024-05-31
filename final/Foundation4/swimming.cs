using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1609.34); // Convert meters to miles (1 mile = 1609.34 meters)
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
        return $"{Date} Swimming ({Minutes} min): Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}
