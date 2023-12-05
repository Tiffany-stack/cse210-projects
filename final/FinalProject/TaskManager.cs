// TaskManager.cs
using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void DisplayAllTasks()
    {
        foreach (var task in tasks)
        {
            task.DisplayTaskInfo();
            Console.WriteLine("------------------------------");
        }
    }
}
