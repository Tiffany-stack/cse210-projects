[Serializable]
public class EternalGoal : Goal
{
    private int xp;

    public EternalGoal(string name, int value, int xp) : base(name, value)
    {
        this.xp = xp;
    }

    public override void RecordEvent()
    {
        Complete(); // Eternal goals are considered completed each time they are recorded
    }

    public override int GetXP() => xp;
}
