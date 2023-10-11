using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public override string ToString()
    {
        return $"{Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response)
    {
        JournalEntry entry = new JournalEntry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries before loading from file

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    entries.Add(new JournalEntry(prompt, response) { Date = date });
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select a prompt:");
                    for (int i = 0; i < prompts.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {prompts[i]}");
                    }
                    Console.Write("Enter the number of the prompt: ");
                    int promptNumber;
                    if (int.TryParse(Console.ReadLine(), out promptNumber) && promptNumber >= 1 && promptNumber <= prompts.Length)
                    {
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(prompts[promptNumber - 1], response);
                        Console.WriteLine("Entry added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid prompt number.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter a filename to save the journal to: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file successfully!");
                    break;

                case "4":
                    Console.Write("Enter a filename to load the journal from: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file successfully!");
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
