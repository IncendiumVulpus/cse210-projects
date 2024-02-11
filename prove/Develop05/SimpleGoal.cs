public class SimpleGoal : Goal
{
    protected bool _isComplete;
    private GoalManager _goalManager;

    public SimpleGoal(string name, string description, int points, int id, GoalManager goalManager)
        : base(name, description, points, id)
    {
        _isComplete = false;
        _goalManager = goalManager;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        // Update user's score
        _goalManager.IncreasePlayerScore(_points);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{base.GetDetailsString()} - {completionStatus}";
    }
}
