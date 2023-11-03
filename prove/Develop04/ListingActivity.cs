using System;
using System.Threading;

class ListingActivity
{
    public static void StartListingActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // Allow the user to set the duration for listing (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Listing Activity. Get ready to list.");

            // Listing guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                // Display a random listing prompt
                DisplayRandomPrompt();

                // Pause for a moment
                Thread.Sleep(1000);
            }

            Console.WriteLine("You've completed the Listing Activity. Count the blessings in your life.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }

    // Display a random listing prompt
    private static void DisplayRandomPrompt()
    {
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }
}
