using System;

public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description, int duration = 0): base (name, description, duration)
    {

    }

    public void Run() {
        SetDurationFromInput();
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do {
        

//Have the user breathe in for 5 seconds
        Console.WriteLine("Breathe In");
        ShowCountDown(5);
//Have the user breathe in for 5 seconds
        Console.WriteLine("Breathe Out");
//Repeat this for the duration (loop)

        ShowCountDown(5);
        //Have the user breathe in for 5 seconds
        //Have the user breathe out for 5 seconds
        }while (DateTime.Now < stopTime);
        DisplayEndingMessage();
        
    }
}

