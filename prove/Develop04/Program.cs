using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nSelect an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity.StartBreathingActivity();
                    break;
                case "2":
                    ReflectionActivity.StartReflectionActivity();
                    break;
                case "3":
                    ListingActivity.StartListingActivity();
                    break;
                case "4":
                    VisualizationActivity.StartVisualizationActivity();
                    break;
                case "5":
                    Console.WriteLine("Exiting the Mindfulness Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
