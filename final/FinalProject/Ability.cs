using System;

public class Ability
{
    private string _name;
    private string _description;

    public Ability(string name)
    {
        _name = name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }
}
