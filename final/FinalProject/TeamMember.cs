// Class representing a team member
public class TeamMember
{
    public string Name { get; set; }

    public TeamMember(string name)
    {
        Name = name;
    }

    // Implement interface method
    public void AssignTask(Task task)
    {
        Console.WriteLine($"Task assigned to {Name}: {task.Title}");
    }
}
