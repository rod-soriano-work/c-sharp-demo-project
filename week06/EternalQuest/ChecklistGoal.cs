public class ChecklistGoal : Goal
{
  private int targetCount;
  private int currentCount;
  private int bonus;

  public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
      : base(name, description, points)
  {
    this.targetCount = targetCount;
    this.bonus = bonus;
    this.currentCount = 0;
  }

  public override bool IsComplete() => currentCount >= targetCount;

  public override int RecordEvent()
  {
    if (!IsComplete())
    {
      currentCount++;
      if (IsComplete())
        return points + bonus;
      else
        return points;
    }
    return 0;
  }

  public override string GetStatus() => IsComplete() ? $"[X] Completed {currentCount}/{targetCount}" : $"[ ] Completed {currentCount}/{targetCount}";

  public override string Serialize() => $"Checklist|{name}|{description}|{points}|{targetCount}|{currentCount}|{bonus}";
}
