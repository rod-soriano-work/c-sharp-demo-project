public abstract class Goal
{
  protected string name;
  protected string description;
  protected int points;

  public Goal(string name, string description, int points)
  {
    this.name = name;
    this.description = description;
    this.points = points;
  }

  public string GetName() => name;

  public string GetDescription() => description;

  public int GetPoints() => points;

  public abstract bool IsComplete();

  public abstract int RecordEvent();

  public abstract string GetStatus();

  public abstract string Serialize();
}
