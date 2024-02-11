public class EternalGoal : Goal
{
    private GoalManager _goalManager;

    public EternalGoal(string name, string description, int points, int id, GoalManager goalManager)
        : base(name, description, points, id)
    {
        _goalManager = goalManager;
    }

    public override void RecordEvent()
    {
        // Update user's score
        _goalManager.IncreasePlayerScore(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }
}
