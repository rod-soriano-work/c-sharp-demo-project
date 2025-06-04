using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
  private List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

  public ListingActivity()
  {
    name = "Listing Activity";
    description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  protected override void RunActivity()
  {
    Random rand = new();
    Console.WriteLine(prompts[rand.Next(prompts.Count)]);
    Console.WriteLine("You will begin in:");
    ShowCountdown(3);

    List<string> items = new();
    DateTime endTime = DateTime.Now.AddSeconds(duration);
    while (DateTime.Now < endTime)
    {
      Console.Write("List an item: ");
      string item = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(item))
        items.Add(item);
    }
    Console.WriteLine($"You listed {items.Count} items!");
  }
}
