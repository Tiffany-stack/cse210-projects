// Base class for tasks
public class Task : ITaskAssignable
{
    private string Title { get; set; }
    private string Description { get; set; }
    private DateTime DueDate { get; set; }
    private bool IsCompleted { get; set; }

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    // Return formatted string instead of using Console
    public virtual string DisplayTaskInfo()
    {
        return $"Title: {Title}\nDescription: {Description}\nDue Date: {DueDate}\nStatus: {(IsCompleted ? "Completed" : "Incomplete")}";
    }

    // Keep this method virtual and remove the interface. Avoid using Console in classes.
    public virtual void AssignTask(TeamMember teamMember)
    {
        // Additional logic for task assignment
    }
}
