using System;
using System.Threading;

abstract class Activity
{
  protected int duration;
  protected string name;
  protected string description;

  public void Start()
  {
    Console.Clear();
    Console.WriteLine($"--- {name} ---");
    Console.WriteLine(description);
    Console.Write("How many seconds would you like for your session? ");
    duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Prepare to begin...");
    ShowSpinner(3);
    RunActivity();
    End();
  }

  protected abstract void RunActivity();

  protected void End()
  {
    Console.WriteLine("\nWell done!");
    ShowSpinner(2);
    Console.WriteLine($"You have completed the {name} for {duration} seconds.");
    ShowSpinner(3);
  }

  protected void ShowSpinner(int seconds)
  {
    for (int i = 0; i < seconds; i++)
    {
      Console.Write(".");
      Thread.Sleep(1000);
    }
    Console.WriteLine();
  }

  protected void ShowCountdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write($"{i} ");
      Thread.Sleep(1000);
    }
    Console.WriteLine();
  }
}
