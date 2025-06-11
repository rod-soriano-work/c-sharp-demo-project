public class SimpleGoal : Goal
{
  private bool complete = false;

  public SimpleGoal(string name, string description, int points)
      : base(name, description, points) { }

  public override bool IsComplete() => complete;

  public override int RecordEvent()
  {
    if (!complete)
    {
      complete = true;
      return points;
    }
    return 0;
  }

  public override string GetStatus() => complete ? "[X]" : "[ ]";

  public override string Serialize() => $"Simple|{name}|{description}|{points}|{complete}";
}
