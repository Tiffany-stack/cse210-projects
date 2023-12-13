using System;

// Entry class to represent a journal entry
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    // Override ToString for easy display
    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}\n";
    }
}
