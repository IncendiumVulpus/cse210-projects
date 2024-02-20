using System;
using System.Collections.Generic;

public class Character
{
    private string _name;
    private Race _race;
    private Class _class;
    private int _level;
    private int _healthPoints;
    private Dictionary<string, int> _attributes;
    private List<Ability> _abilities;

    public Character()
    {
        _attributes = new Dictionary<string, int>();
        _abilities = new List<Ability>();
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetRace(Race race)
    {
        _race = race;
    }

    public Race GetRace()
    {
        return _race;
    }

    public void SetClass(Class characterClass)
    {
        _class = characterClass;
    }

    public Class GetClass()
    {
        return _class;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void SetHealthPoints(int healthPoints)
    {
        _healthPoints = healthPoints;
    }

    public int GetHealthPoints()
    {
        return _healthPoints;
    }

    public void SetAttributes(Dictionary<string, int> attributes)
    {
        _attributes = attributes;
    }

    public Dictionary<string, int> GetAttributes()
    {
        return _attributes;
    }

    public void AddAbility(Ability ability)
    {
        _abilities.Add(ability);
    }

    public List<Ability> GetAbilities()
    {
        return _abilities;
    }

    public string GetInfo()
    {
        string info = $"Name: {_name}, Race: {_race.GetName()}, Class: {_class.GetName()}, Level: {_level}, HP: {_healthPoints}\n";
        info += "Attributes:\n";
        foreach (var attribute in _attributes)
        {
            info += $"{attribute.Key}: {attribute.Value}\n";
        }
        info += "Abilities:\n";
        foreach (var ability in _abilities)
        {
            info += $"{ability.GetName()}\n";
        }
        return info;
    }
}
