using System;

// Class for managing tasks
public class TaskManager
{
    public static void Main()
    {
        // Demonstrate abstraction, encapsulation, inheritance, and polymorphism

        // Create instances of tasks
        Task genericTask = new Task("Generic Task", "A simple task", DateTime.Now.AddDays(3));
        HomeworkTask homeworkTask = new HomeworkTask("Math Homework", "Complete exercises 1-5", DateTime.Now.AddDays(5), "Math");

        // Create instances of subjects
        Subject mathSubject = new MathSubject("Math");

        // Create Project
        Project project = new Project("Software Development");

        // Add tasks to Project
        project.AddTask(genericTask);
        project.AddTask(homeworkTask);

        // Display Project information
        project.DisplayProjectInfo();

        // Create TeamMember
        TeamMember teamMember = new TeamMember("John Doe");

        // Assign tasks to team member using polymorphism
        teamMember.AssignTask(genericTask);
        teamMember.AssignTask(homeworkTask);
    }
}
