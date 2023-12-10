// Derived class for a specific type of task
public class HomeworkTask : Task
{
    private string Subject { get; set; }

    public HomeworkTask(string title, string description, DateTime dueDate, string subject)
        : base(title, description, dueDate)
    {
        Subject = subject;
    }

    // Override base class method
    // Avoid using Console in classes
    public override string DisplayTaskInfo()
    {
        return $"{base.DisplayTaskInfo()}\nSubject: {Subject}";
    }

    // Override interface method
    // Avoid using Console in classes
    public override void AssignTask(TeamMember teamMember)
    {
        // Additional logic specific to HomeworkTask assignment
    }
}
