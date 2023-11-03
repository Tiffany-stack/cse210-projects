using System;
using System.Threading;

class ReflectionActivity
{
    public static void StartReflectionActivity()
    {
        Console.WriteLine("Welcome to the Reflection Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // Allow the user to set the duration for reflection (in seconds)
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Starting the Reflection Activity. Get ready to reflect.");

            // Reflection guidance
            for (int seconds = 0; seconds < duration; seconds++)
            {
                // Display random prompts for reflection
                DisplayRandomPrompt();

                // Pause for a moment
                Thread.Sleep(1000);
            }

            Console.WriteLine("You've completed the Reflection Activity. Take time to acknowledge your strengths and resilience.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number of seconds.");
        }
    }

    // Display a random reflection prompt
    private static void DisplayRandomPrompt()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }
}
