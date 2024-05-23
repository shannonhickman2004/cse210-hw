using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetShortName() == goalName)
            {
                int pointsEarned = goal.RecordEvent();
                totalPoints += pointsEarned;
                Console.WriteLine($"Event recorded for goal: {goalName}");
                Console.WriteLine($"Points earned: {pointsEarned}");
                Console.WriteLine($"Total points: {totalPoints}");
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void SaveGoals(string fileName)
    {
        using (var writer = new StreamWriter(fileName))
        {
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        goals.Clear();

        using (var reader = new StreamReader(fileName))
        {
            string line;
            if ((line = reader.ReadLine()) != null)
            {
                totalPoints = int.Parse(line);
            }
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');

                switch (parts[0])
                {
                    case "SimpleGoal":
                        var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        simpleGoal.SetComplete(bool.Parse(parts[4]));
                        goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        checklistGoal.SetAmountCompleted(int.Parse(parts[6]));
                        goals.Add(checklistGoal);
                        break;
                }
            }
        }
    }
}
