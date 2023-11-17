class Program
{
    static void Main()
    {
        // Sample usage of the Enhanced Eternal Quest program
        EternalQuestProgram program = EternalQuestProgram.LoadFromFile("EternalQuestData.dat");

         // Add your goals here
        program.AddGoal(new SimpleGoal("Win a Pro Tournament", 1000, 50));
        program.AddGoal(new SimpleGoal("Read Scriptures", 100, 10));
        program.AddGoal(new ChecklistGoal("Attend the Temple", 50, 10, 500));

        Console.WriteLine("Welcome to the Enhanced Eternal Quest Program!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Calculate Score");
            Console.WriteLine("4. Display User Level and XP");
            Console.WriteLine("5. Save Program Data");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    program.DisplayGoals();
                    break;
                case "2":
                    Console.Write("Enter the name of the goal to record an event: ");
                    string goalName = Console.ReadLine();
                    program.RecordEvent(goalName);
                    break;
                case "3":
                    Console.WriteLine($"Total Score: {program.CalculateScore()}");
                    break;
                case "4":
                    Console.WriteLine($"User Level: {program.UserLevel}, XP: {program.UserXP}");
                    break;
                case "5":
                    program.SaveToFile("EternalQuestData.dat");
                    break;
                case "6":
                    program.SaveToFile("EternalQuestData.dat"); // Save before exiting
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
