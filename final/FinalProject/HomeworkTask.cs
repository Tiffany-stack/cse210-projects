using System;

// Derived class for a specific type of task
public class HomeworkTask : Task
{
    public string Subject { get; set; }

    public HomeworkTask(string title, string description, DateTime dueDate, string subject)
        : base(title, description, dueDate)
    {
        Subject = subject;
    }

    // Override base class method
    public override void DisplayTaskInfo()
    {
        base.DisplayTaskInfo();
        Console.WriteLine($"Subject: {Subject}");
    }

    // Override interface method
    public override void AssignTask(TeamMember teamMember)
    {
        // Additional logic specific to HomeworkTask assignment
        Console.WriteLine($"Homework assignment specific to {teamMember.Name}: {Title}");
    }
}
