using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("1. Load a default scripture");
        Console.WriteLine("2. Load a scripture from a file");
        Console.WriteLine("Enter your choice (1 or 2):");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Enter the scripture reference (e.g., 'John 3:16'):");
            string reference = Console.ReadLine();
            Scripture scripture = new Scripture(reference);

            while (!scripture.AllWordsHidden)
            {
                Console.Clear();
                scripture.HideRandomWords();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string userInput = Console.ReadLine();
                if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter the filename of the scripture to load:");
            string filename = Console.ReadLine();
            Scripture scripture = LoadScriptureFromFile(filename);

            if (scripture != null)
            {
                while (!scripture.AllWordsHidden)
                {
                    Console.Clear();
                    scripture.HideRandomWords();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                    string userInput = Console.ReadLine();
                    if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                        break;
                }
            }
            else
            {
                Console.WriteLine("Failed to load the scripture from the file.");
            }
        }
    }

    
    static Scripture LoadScriptureFromFile(string filename)
    {
        
        return null;
    }
}
