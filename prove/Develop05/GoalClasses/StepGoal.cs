public class StepGoal : Goal
{
    private int _repetitions, _completions;
    public StepGoal(string goalName, string goalDesc, int repetitions, int completions = 0, bool completed = false) : base(goalName, goalDesc, completed)
    {
        _repetitions = repetitions;
        _completions = completions;
    }
    public override string Show()
    {
        string confirmation = Completed ? confirmation = "Complete" : "Incomplete";
        return $"{GoalName} : {GoalDesc} {Convert.ToInt32(100*(Convert.ToDouble(_completions)/Convert.ToDouble(_repetitions)))}% - {confirmation}";
    }
    public override int CompleteGoal()
    {
        if (_completions != _repetitions)
        {
            _completions ++;
            Completed = FinishedCheck();
            if (_completions < _repetitions)
            {
                return PointsAwarded;
            }
            return Convert.ToInt32(1.25 * PointsAwarded);
        }
        return 0;
    }
    private bool FinishedCheck()
    {
        return _completions == _repetitions ? true : false;
    }
    public override string SaveToCSV()
    {
        return $"step~{GoalName}~{GoalDesc}~{_repetitions}~{_completions}~{Completed}";
    }
    public override void GeneratePointValue(int goalWeight = 0)
    {
        PointsAwarded = 35;
    }
}