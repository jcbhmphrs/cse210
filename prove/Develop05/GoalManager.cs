public class GoalManager
{
    private List<Goal> MasterGoalList = new List<Goal>();
    public int Wallet { get; set; }
    internal void AddGoal()
    {
       Goal newGoal = Goal.CreateGoal();
       MasterGoalList.Add(newGoal);
       Console.Clear();
    }
    internal void CompleteGoal()
    {
        Console.Clear();
        Console.WriteLine("_GOALS_\n");
        for (int i = 0; i < MasterGoalList.Count; i++)
        {
            Console.WriteLine($"#{i + 1} )\t{MasterGoalList[i].Show()}");
        }
        Console.Write("\nWhat number goal have you have completed: ");
        Wallet += MasterGoalList[int.Parse(Console.ReadLine()) - 1].CompleteGoal();
        Console.Clear();
    }
    internal void LoadFromCSV()
    {
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();
        foreach (string line in System.IO.File.ReadAllLines(fileName = fileName.EndsWith(".txt") ? fileName : fileName + ".txt"))
        {
            string[] parts = line.Split("~");
            Goal loadingGoal = null;
            if (line.StartsWith("$") && line.Length > 0)
            {
                Wallet = int.Parse(parts[0].Remove(0,1));
            }
            else if (line.Contains("simple"))
            {
                loadingGoal = new SimpleGoal(parts[1], parts[2], bool.Parse(parts[3]));
            }
            else if (line.Contains("step"))
            {
                loadingGoal = new StepGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5]));
            }
            else
            {
                loadingGoal = new EternalGoal(parts[1], parts[2], bool.Parse(parts[3]), double.Parse(parts[4]));
            }
            if (loadingGoal != null) MasterGoalList.Add(loadingGoal);
        }
        Console.Clear();
    }
    internal void SaveGoals()
    {
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();
        using (StreamWriter newStreamWriter = new StreamWriter(fileName = fileName.EndsWith(".txt") ? fileName : fileName + ".txt"))
        {
            newStreamWriter.WriteLine($"${Wallet}~");
            MasterGoalList.ForEach(goal => { newStreamWriter.WriteLine(goal.SaveToCSV()); });
        }
        Console.Clear();
    }
    internal void ShowGoals()
    {
        if (MasterGoalList.Count() != 0)
        {
            MasterGoalList.ForEach(goal => { Console.WriteLine(goal.Show()); });
            Console.Write("\nPress any key to Continue...");
            Console.ReadKey();
        }
        else
        {
            Console.Write("Uh Oh... You have no goals\nPress any key to continue...");
            Console.ReadKey();
        }
        Console.Clear();
    }
}