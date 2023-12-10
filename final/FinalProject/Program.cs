// Class for managing tasks
public class Program
{
    public static void Main()
    {
        // Demonstrate abstraction, encapsulation, inheritance, and polymorphism

        // Create instances of tasks
        Task genericTask = new Task("Generic Task", "A simple task", DateTime.Now.AddDays(3));
        HomeworkTask homeworkTask = new HomeworkTask("Math Homework", "Complete exercises 1-5", DateTime.Now.AddDays(5), "Math");

        // Create TaskManager
        TaskManager taskManager = new TaskManager();

        // Add tasks to TaskManager
        taskManager.AddTask(genericTask);
        taskManager.AddTask(homeworkTask);

        // Display all tasks
        taskManager.DisplayAllTasks();
    }
}
