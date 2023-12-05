// Program.cs
using System;

class Program
{
    static void Main()
    {
        Task genericTask = new Task("Generic Task", "A simple task", DateTime.Now.AddDays(3));
        HomeworkTask homeworkTask = new HomeworkTask("Math Homework", "Complete exercises 1-5", DateTime.Now.AddDays(5), "Math");

        TaskManager taskManager = new TaskManager();

        taskManager.AddTask(genericTask);
        taskManager.AddTask(homeworkTask);

        taskManager.DisplayAllTasks();
    }
}
