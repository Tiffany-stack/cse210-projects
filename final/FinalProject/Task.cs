using System;

// Base class for tasks
public class Task : ITaskAssignable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public virtual void DisplayTaskInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Due Date: {DueDate}");
        Console.WriteLine($"Status: {(IsCompleted ? "Completed" : "Incomplete")}");
    }

    // Implement interface method
    public virtual void AssignTask(TeamMember teamMember)
    {
        Console.WriteLine($"Task assigned to {teamMember.Name}: {Title}");
    }
}

