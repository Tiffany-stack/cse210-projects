// Class representing a team member
public class TeamMember
{
    private string Name { get; set; }

    public TeamMember(string name)
    {
        Name = name;
    }

    // Avoid using Console here
    public void AssignTask(Task task)
    {
        // Additional logic for task assignment
    }
}
