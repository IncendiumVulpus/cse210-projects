using System;

public class Character
{
    private string _name;
    private Race _race;
    private Class _characterClass;
    private int _level;
    private int _healthPoints;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetRace(Race race)
    {
        _race = race;
    }

    public void SetClass(Class characterClass)
    {
        _characterClass = characterClass;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void SetHealthPoints(int healthPoints)
    {
        _healthPoints = healthPoints;
    }

    public string GetInfo()
    {
        return $"Name: {_name}, Race: {_race.GetName()}, Class: {_characterClass.GetName()}, Level: {_level}, HP: {_healthPoints}";
    }
}
