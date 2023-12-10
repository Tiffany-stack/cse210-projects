// Class for managing tasks
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

    // Display information for all tasks
    public void DisplayAllTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task.DisplayTaskInfo());
            Console.WriteLine("------------------------------");
        }
    }
}
