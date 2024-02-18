using System;
using System.Collections.Generic;

public class CharacterManager
{
    private List<Character> _characters;

    public CharacterManager()
    {
        _characters = new List<Character>(); // Initialize the list in the constructor
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public void RemoveCharacter(Character character)
    {
        _characters.Remove(character);
    }

    public List<Character> GetCharacters()
    {
        return _characters;
    }

    public string GetCharacterInfo(Character character)
    {
        return character.GetInfo();
    }
}
