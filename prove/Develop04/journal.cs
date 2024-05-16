using System;
using System.Threading;

public class JournalingActivity : Activity
{
    public JournalingActivity(string name, string description, int duration = 0) : base(name, description, duration)
    {

    }
    public void Run()
    {
        SetDurationFromInput();
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.WriteLine("Start journaling:");
            Console.Write("Write: ");
            string entry = Console.ReadLine();
            // Read entries to use later

        } while (DateTime.Now < stopTime);
        Console.WriteLine("Journaling complete.");
        DisplayEndingMessage();
    }
}
