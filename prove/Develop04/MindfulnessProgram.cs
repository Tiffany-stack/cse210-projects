using System;

class MindfulnessProgram
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Reflection Activity");
            Console.WriteLine("2. Breathing Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Select an activity (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ReflectionActivity.StartReflectionActivity();
                        break;
                    case 2:
                        BreathingActivity.StartBreathingActivity();
                        break;
                    case 3:
                        ListingActivity.StartListingActivity();
                        break;
                    case 4:
                        VisualizationActivity.StartVisualizationActivity();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1-5).");
            }
        }
    }
}
