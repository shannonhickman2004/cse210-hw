using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Total Points");
            Console.WriteLine("7. Quit");

            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to save goals:");
                    string saveFileName = Console.ReadLine();
                    manager.SaveGoals(saveFileName);
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to load goals:");
                    string loadFileName = Console.ReadLine();
                    manager.LoadGoals(loadFileName);
                    break;
                case "5":
                    Console.WriteLine("Enter the name of the goal to record an event:");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    break;
                case "6":
                    manager.DisplayTotalPoints();
                    break;
                case "7":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 7.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Nice work on setting goals!");
    }

    static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points for the goal:");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter the target number of completions for the goal:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for completing the goal:");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine(" Please enter 1, 2, or 3.");
                break;
        }
    }
}
