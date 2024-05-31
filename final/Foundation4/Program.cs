using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("05 May 2024", 30, 3.0),
            new Cycling("10 May 2024", 45, 15.0),
            new Swimming("15 May 2024", 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}