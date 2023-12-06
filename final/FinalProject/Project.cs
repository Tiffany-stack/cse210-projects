using System;
using System.Collections.Generic;

// Class representing a project
public class Project
{
    public string ProjectName { get; set; }
    public List<Task> Tasks { get; set; }

    public Project(string projectName)
    {
        ProjectName = projectName;
        Tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }

    public void DisplayProjectInfo()
    {
        Console.WriteLine($"Project: {ProjectName}");
        Console.WriteLine("Tasks:");
        foreach (var task in Tasks)
        {
            task.DisplayTaskInfo();
            Console.WriteLine("------------------------------");
        }
    }
}
