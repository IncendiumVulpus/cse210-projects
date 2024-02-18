using System;

public class Ability
{
    private string _name;
    private string _description;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetInfo()
    {
        return $"Ability: {_name}, Description: {_description}";
    }
}
