public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDesc, bool completed = false, double goalWeight = 0) : base(goalName, goalDesc, completed) { }

    public override int CompleteGoal()
    {
        goalWeight += ((0.05 * goalWeight) * goalWeight);
        return Convert.ToInt32(PointsAwarded + goalWeight);
    }
    public override void GeneratePointValue(int goalWeight = 0)
    {
        if (goalWeight != 0)
        {
            Console.WriteLine("On a scale of 1 to 10, how influential is this goal on the rest of Eternity?");
            goalWeight = int.Parse(Console.ReadLine());
        }
        PointsAwarded = 50;
    }
    public override string SaveToCSV() { return $"eternal~{GoalName}~{GoalDesc}~{Completed}~{goalWeight}"; }
}