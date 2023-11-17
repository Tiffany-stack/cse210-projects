using System;

[Serializable]
public abstract class Goal
{
    protected string name;
    protected int value;
    protected bool isCompleted;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        this.isCompleted = false;
    }

    public virtual void Complete()
    {
        isCompleted = true;
        Console.WriteLine($"Goal completed: {name} (+{value} points)");
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"Goal: {name} - {(isCompleted ? "Completed" : "In progress")}");
    }

    public string GetName() => name;

    public bool GetCompletionStatus() => isCompleted;

    public int GetValue() => value;

    public abstract void RecordEvent();

    public virtual int GetXP() => 0; // Default XP for goals
}
