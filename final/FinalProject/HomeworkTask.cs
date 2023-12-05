// HomeworkTask.cs
using System;

public class HomeworkTask : Task
{
    public string Subject { get; set; }

    public HomeworkTask(string title, string description, DateTime dueDate, string subject)
        : base(title, description, dueDate)
    {
        Subject = subject;
    }

    public override void DisplayTaskInfo()
    {
        base.DisplayTaskInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
}
