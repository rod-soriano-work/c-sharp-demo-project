using System;

class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    name = "Breathing Activity";
    description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  protected override void RunActivity()
  {
    int elapsed = 0;
    while (elapsed < duration)
    {
      Console.Write("Breathe in... ");
      ShowCountdown(3);
      elapsed += 3;
      if (elapsed >= duration) break;
      Console.Write("Breathe out... ");
      ShowCountdown(3);
      elapsed += 3;
    }
  }
}
