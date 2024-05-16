using System;

class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            DisplayMenu();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    StartActivity(new BreathingActivity(GetDuration()));
                    break;
                case "2":
                    StartActivity(new ListeningActivity(GetDuration()));
                    break;
                case "3":
                    StartActivity(new ReflectingActivity(GetDuration()));
                    break;
                case "4":
                    Console.WriteLine("Exiting the program...");
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listening Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Which activity would you like to do today?");
    }

    static void StartActivity(Activity activity)
    {
        Console.WriteLine($"Starting {activity.GetName()}...");
        activity.Run();
    }

    static int GetDuration()
    {
        Console.WriteLine("How many minutes would you like to allocate for this activity?");
        int durationMinutes;
        while (!int.TryParse(Console.ReadLine(), out durationMinutes) || durationMinutes <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the duration in minutes:");
        }
        return durationMinutes * 60; // Convert minutes to seconds
    }
}

//This is old code for activity just in case

                breathingActivity.Run();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.ShowSpinner(5);
                breathingActivity.ShowCountDown(5);