using System;
using System.Threading;

class BreathingActivity
{
    public static void StartBreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Allow the user to set the duration for breathing (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Breathing Activity. Find a comfortable place and begin.");

            // Breathing guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                if (seconds % 2 == 0)
                    Console.WriteLine("Breathe in...");
                else
                    Console.WriteLine("Breathe out...");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("You've completed the Breathing Activity. Take a moment to relax and refresh yourself.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }
}
