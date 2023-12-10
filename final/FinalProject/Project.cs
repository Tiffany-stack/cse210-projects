public class Project
{
    private string ProjectName { get; set; }
    private List<Task> Tasks { get; set; }

    public Project(string projectName)
    {
        ProjectName = projectName;
        Tasks = new List<Task>();
    }

    // Return formatted string instead of using Console
    public string GetProjectInfo()
    {
        return $"Project: {ProjectName}";
    }
}
