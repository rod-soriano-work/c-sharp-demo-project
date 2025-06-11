class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choice))
                continue;

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") break;
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(type)) return;

        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) return;

        Console.Write("Description: ");
        string desc = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(desc)) return;

        Console.Write("Points: ");
        string ptsInput = Console.ReadLine();
        if (!int.TryParse(ptsInput, out int pts)) return;

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, pts));
        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, pts));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            string targetInput = Console.ReadLine();
            if (!int.TryParse(targetInput, out int target)) return;

            Console.Write("Bonus: ");
            string bonusInput = Console.ReadLine();
            if (!int.TryParse(bonusInput, out int bonus)) return;

            goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()} - {goals[i].GetDescription()}");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        string idxInput = Console.ReadLine();
        if (!int.TryParse(idxInput, out int idx)) return;
        idx -= 1;
        if (idx >= 0 && idx < goals.Count)
            score += goals[idx].RecordEvent();
    }
}
