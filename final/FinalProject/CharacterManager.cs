using System;
using System.Collections.Generic;

public class CharacterManager
{
    private List<Character> _characters;
    private List<Race> _races;

    public CharacterManager(List<Race> races)
    {
        _characters = new List<Character>();
        _races = races; 
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public void RemoveCharacter(Character character)
    {
        _characters.Remove(character);
    }

    public string GetCharacterInfo(Character character)
    {
        return character.GetInfo();
    }

    public List<Character> GetCharacters()
    {
        return _characters;
    }

    public List<Race> GetRaces()
    {
        return _races;
    }

    public void AddRace(Race race)
    {
        _races.Add(race);
    }
}
