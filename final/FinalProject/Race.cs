using System.Collections.Generic;

public class Race
{
    private string _name;
    private Dictionary<string, int> _attributes;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAttributes(Dictionary<string, int> attributes)
    {
        _attributes = attributes;
    }

    public string GetName()
    {
        return _name;
    }

    public Dictionary<string, int> GetAttributes()
    {
        return _attributes;
    }
}
