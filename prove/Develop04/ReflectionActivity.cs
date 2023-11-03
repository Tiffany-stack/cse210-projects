using System;
using System.Threading;

class ReflectionActivity
{
    public static void StartReflectionActivity()
    {
        Console.WriteLine("Welcome to the Reflection Activity.");
        Console.WriteLine("Take a moment to reflect on your experiences.");

        // Allow the user to set the duration for reflection (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Reflection Activity. Begin your reflection.");

            // Reflection guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                Console.WriteLine("Keep reflecting...");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("You've completed the Reflection Activity. Continue to reflect or move on.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }
}
