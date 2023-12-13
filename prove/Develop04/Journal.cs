using System;
using System.Collections.Generic;
using System.IO;

// Journal class to manage entries
class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Save the journal to a file
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

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry loadedEntry = new Entry(parts[1], parts[2])
                        {
                            Date = date
                        };
                        entries.Add(loadedEntry);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No entries loaded.");
        }
    }
}
