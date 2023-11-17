[Serializable]
public class SimpleGoal : Goal
{
    private int xp;

    public SimpleGoal(string name, int value, int xp) : base(name, value)
    {
        this.xp = xp;
    }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            Complete();
        }
        else
        {
            Console.WriteLine($"Error: {name} is already completed.");
        }
    }

    public override int GetXP() => xp;
}
