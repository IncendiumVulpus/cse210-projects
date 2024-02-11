using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, int id)
        : base(name, description, points, id)
    {
    }

    public override void RecordEvent()
    {
        // Update user's score
    }

    public override bool IsComplete()
    {
        return false;
    }
}
