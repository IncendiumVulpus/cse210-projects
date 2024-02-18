using System;
using System.Collections.Generic;

public class Class
{
    private string _name;
    private List<string> _abilities;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAbilities(List<string> abilities)
    {
        _abilities = abilities;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetInfo()
    {
        // Format abilities to string
        string abilitiesString = string.Join(", ", _abilities);
        return $"Class: {_name}, Abilities: {abilitiesString}";
    }
}
