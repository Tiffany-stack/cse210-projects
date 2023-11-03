using System;
using System.Threading;

class VisualizationActivity
{
    public static void StartVisualizationActivity()
    {
        Console.WriteLine("Welcome to the Visualization Activity.");
        Console.WriteLine("Close your eyes, take a deep breath, and let your mind wander to a peaceful place.");
        Console.WriteLine("Visualize the sounds, sights, and sensations of this serene place.");

        // Allow the user to set the duration for visualization (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Visualization Activity. Close your eyes and begin.");

            // Visualization guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                Console.WriteLine("Visualize something peaceful...");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("You've completed the Visualization Activity. Take a moment to recenter yourself and open your eyes when you're ready.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }
}
