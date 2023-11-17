using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

[Serializable]
public class EternalQuestProgram
{
    private List<Goal> goals;
    private int userXP;
    private int userLevel;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
        userXP = 0;
        userLevel = 1;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.GetName() == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            userXP += goal.GetXP();
            LevelUp();
        }
        else
        {
            Console.WriteLine("Error: Goal not found.");
        }
    }

    public int UserLevel => userLevel;
    public int UserXP => userXP;

    private void LevelUp()
    {
        int requiredXP = userLevel * 100; // Adjust the XP required for leveling up
        if (userXP >= requiredXP)
        {
            userLevel++;
            Console.WriteLine($"Level Up! You are now Level {userLevel}");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    public int CalculateScore()
    {
        int totalScore = 0;
        foreach (var goal in goals.Where(g => g.GetCompletionStatus()))
        {
            totalScore += goal.GetValue();
        }
        return totalScore;
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(fileName, json);
            Console.WriteLine($"Data saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

    public static EternalQuestProgram LoadFromFile(string fileName)
    {
        EternalQuestProgram program = null;
        try
        {
            string json = File.ReadAllText(fileName);
            program = JsonSerializer.Deserialize<EternalQuestProgram>(json);
            Console.WriteLine($"Data loaded from {fileName}.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Creating a new program.");
            program = new EternalQuestProgram();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
            program = new EternalQuestProgram();
        }
        return program;
    }
}
