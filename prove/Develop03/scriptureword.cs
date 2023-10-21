class ScriptureWord
{
    public string Text { get; }
    public bool Hidden { get; set; }

    public ScriptureWord(string text)
    {
        Text = text;
        Hidden = false;
    }
}
