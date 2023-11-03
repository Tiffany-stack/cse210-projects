using System;
using System.Threading;

class BreathingActivity
{
    public static void StartBreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("Take a moment to relax and focus on your breathing.");

        // Allow the user to set the duration for breathing (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Breathing Activity. Close your eyes and begin.");

            // Breathing guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(1000); // Pause for 1 second
                Console.WriteLine("Breathe out...");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("You've completed the Breathing Activity. Take a moment to recenter yourself.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }
}
