using System.IO;
public abstract class Goal
{
    protected double goalWeight = 0;
    protected Goal(string goalName, string goalDesc, bool completed = false)
    {
        GoalName = goalName;
        GoalDesc = goalDesc;
        GeneratePointValue(0);
        Completed = completed;
    }
    protected string GoalName { get; set; }
    protected string GoalDesc { get; set; }
    protected int PointsAwarded { get; set; }
    protected bool Completed { get; set; }
    public abstract void GeneratePointValue(int goalWeight);
    public virtual int CompleteGoal()
    {
        Completed = true;
        return PointsAwarded;
    }
    public virtual string Show()
    {
        string confirmation = Completed ? confirmation = "Complete" : "Incomplete";
        return $"{GoalName} : {GoalDesc} - {confirmation}";
    }
    public abstract string SaveToCSV();
    public static Goal CreateGoal()
    {
        Console.Write("\nGoal Name: ");
        string name = Console.ReadLine();
        Console.Write("Goal Description: ");
        string desc = Console.ReadLine();
        Console.WriteLine("\n| Eternal  or  Step  or  Simple |\n");
        Console.Write("Type a Goal Kind: ");
        Goal nullGoal = null;
        switch (Console.ReadLine().ToLower())
        {
            case "eternal":
                nullGoal = new EternalGoal(name, desc);
                break;
            case "simple":
                nullGoal = new SimpleGoal(name, desc);
                break;
            case "step":
                Console.Write("How many steps: ");
                int steps = int.Parse(Console.ReadLine());
                nullGoal = new StepGoal(name, desc, steps);
                break;
            default:
                Console.Write("That was an incorrect input.\nPress any key to continue...");
                Console.ReadKey();
                break;
        }
        return nullGoal;
    }
}