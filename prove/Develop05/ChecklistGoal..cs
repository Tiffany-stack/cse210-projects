[Serializable]
public class ChecklistGoal : Goal
{
    private int requiredCount;
    private int completedCount;
    private int bonusXP;

    public ChecklistGoal(string name, int value, int requiredCount, int bonusXP) : base(name, value)
    {
        this.requiredCount = requiredCount;
        this.completedCount = 0;
        this.bonusXP = bonusXP;
    }

    public override void Complete()
    {
        base.Complete();
        Console.WriteLine($"Bonus: +{GetValue()} points and +{bonusXP} XP for completing {requiredCount} times");
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
        Console.WriteLine($"Checklist goal progress: {completedCount}/{requiredCount} times");
    }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            completedCount++;
            if (completedCount >= requiredCount)
            {
                Complete();
            }
        }
        else
        {
            Console.WriteLine($"Error: {name} is already completed.");
        }
    }

    public override int GetXP() => bonusXP; // Bonus XP for completing the checklist
}
