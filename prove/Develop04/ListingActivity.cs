using System;
using System.Threading;

class ListingActivity
{
    public static void StartListingActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("Think about positive aspects of your life and list them.");

        // Allow the user to set the duration for listing (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Listing Activity. Begin listing positive things.");

            // Listing guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                Console.WriteLine("Keep listing...");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("You've completed the Listing Activity. Celebrate the positivity in your life.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }
}
