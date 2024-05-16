using System;
using System.Threading;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> reflectionPrompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration = 0) : base(name, description, duration)
    {
    }

    public void Run()
    {

        SetDurationFromInput();
        DisplayStartingMessage();

        // Give a random prompt
        DisplayPrompt();
        ShowSpinner(5);

        // Give a random question about the prompt, and then give more
        DisplayQuestions();
        ShowSpinner(5);

        DisplayEndingMessage();

        // Continue showing questions until the duration is reached

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return reflectionPrompts[random.Next(reflectionPrompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return reflectionQuestions[random.Next(reflectionQuestions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(1000);
    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        foreach (string question in reflectionQuestions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
            if (DateTime.Now < stopTime)
            {
                //time has expired, breakout of loop
                break;
            }
        }
    }
}
