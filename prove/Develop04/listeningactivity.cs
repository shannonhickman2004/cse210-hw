using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity(string name, string description, int duration = 0): base (name, description, duration)
    {
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        SetDurationFromInput();
        DisplayStartingMessage();

        GetRandomPrompt(); // Display a random prompt

        // Prompt the user to list items
        List<string> items = GetListFromUser();

        // Display the number of items listed
        Console.WriteLine($"You listed {items.Count} items.");

        // Store the count of items
        _count = items.Count;

        // Display ending message
        base.DisplayEndingMessage();
    }

    public int GetItemCount()
    {
        return _count;
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(randomPrompt);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        Console.WriteLine("Start listing items:");
        DateTime startTime = DateTime.Now;

        // Allow user to list items until duration is reached
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        return items;
    }
}
