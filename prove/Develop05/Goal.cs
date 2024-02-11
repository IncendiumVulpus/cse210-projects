using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _id;

    public Goal(string name, string description, int points, int id)
    {
        _name = name;
        _description = description;
        _points = points;
        _id = id;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description} - {_points} points";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name};{_description};{_points}";
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }
}
