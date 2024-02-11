using System;

public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points, int id)
        : base(name, description, points, id)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        // Update user's score
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
