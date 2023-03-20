public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDesc, bool completed = false) : base(goalName, goalDesc, completed) { }
    public override int CompleteGoal()
    {
        Completed = true;
        return PointsAwarded;
    }
    public override void GeneratePointValue(int goalWeight = 0)
    {
        PointsAwarded = 35;
    }
    public override string SaveToCSV() { return $"simple~{GoalName}~{GoalDesc}~{Completed}"; }
}