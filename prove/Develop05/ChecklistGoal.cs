using System;

public class ChecklistGoal : Goal
{
    protected int _target;
    protected int _amountCompleted;
    protected int _bonus;
    private GoalManager _goalManager;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int id, GoalManager goalManager)
        : base(name, description, points, id)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
        _goalManager = goalManager;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        // Update user's score
        if (_amountCompleted >= _target)
        {
            _goalManager.IncreasePlayerScore(_bonus);
            Console.WriteLine($"Congratulations! Bonus points awarded for completing '{_name}'.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "Completed" : $"Completed {_amountCompleted}/{_target} times";
        string bonusStatus = IsComplete() ? $" (Bonus Points Achieved: {_bonus})" : $" (Bonus Points Remaining: {_bonus})";
        return $"{base.GetDetailsString()} - {completionStatus}{bonusStatus}";
    }
}
