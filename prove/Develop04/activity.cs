using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime StartTime;

    public Activity(string name, string description, int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"{_description}");
        ShowSpinner(1);
    }

    public void SetDurationFromInput()
    {
        {
            Console.WriteLine("How many seconds would you like to allocate for this activity?");
            int durationSeconds;
            while (!int.TryParse(Console.ReadLine(), out durationSeconds) || durationSeconds <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the duration in minutes:");
            }
            _duration = durationSeconds;
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(1);
        Console.Clear();
    }

    public void ShowCountDown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "|", "/", "-", "\\", "|", "/", "-", "\\" };

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}
