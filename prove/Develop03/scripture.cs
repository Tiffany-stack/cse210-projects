using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private List<ScriptureWord> words;
    private Random random = new Random();

    public Scripture(string reference)
    {
        this.reference = reference;
        this.words = InitializeWordsFromText(GetScriptureTextFromReference(reference));
    }

    public bool AllWordsHidden => words.All(word => word.Hidden);

    public void HideRandomWords()
    {
        int wordsToHide = random.Next(1, words.Count(word => !word.Hidden) + 1);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            if (!words[index].Hidden)
            {
                words[index].Hidden = true;
            }
            else 
            {
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{reference}:\n{string.Join(" ", words.Select(word => word.Hidden ? "_____" : word.Text))}";
    }

    private string GetScriptureTextFromReference(string reference)
    {
        
        Dictionary<string, string> scriptureDatabase = new Dictionary<string, string>
        {
            { "John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life." },
            { "Proverbs 3:5-6", "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths." }
        };

        if (scriptureDatabase.ContainsKey(reference))
        {
            return scriptureDatabase[reference];
        }
        else
        {
            return "Scripture not found.";
        }
    }

    private List<ScriptureWord> InitializeWordsFromText(string text)
    {
        string[] words = text.Split(' ');
        return words.Select(word => new ScriptureWord(word)).ToList();
    }
}
