using System;
using System.Collections.Generic;

public class CharacterGenerator
{
    private Random _random;
    private List<Class> _classes;
    private List<Race> _races;

    public CharacterGenerator()
    {
        _random = new Random();
        _classes = GetClasses();
        _races = GetRaces();
    }

    public Character GenerateCharacter()
    {
        Character character = new Character();

        // Generate a random name
        string[] names = { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Ian", "Julia" };
        string randomName = names[_random.Next(names.Length)];
        character.SetName(randomName);

        // Generate a random race with ability score bonuses
        Race randomRace = RandomRaceWithBonuses();
        character.SetRace(randomRace);

        // Retrieve attributes from the race and set them for the character
        Dictionary<string, int> raceAttributes = randomRace.GetAttributes();
        character.SetAttributes(raceAttributes);

        // Generate a random class based on the chosen race
        List<Class> raceClasses = GetClassesForRace(randomRace);
        Class randomClass = raceClasses[_random.Next(raceClasses.Count)];
        character.SetClass(randomClass);

        // Retrieve abilities from the class and add them to the character
        List<Ability> classAbilities = randomClass.GetAbilities();
        foreach (Ability ability in classAbilities)
        {
            character.AddAbility(ability);
        }

        // Set the Character level and health
        int level = _random.Next(1, 21);
        character.SetLevel(level);
        character.SetHealthPoints(10 * level);

        return character;
    }

    private List<Class> GetClassesForRace(Race race)
    {
        // Define the available classes for each race (customize as needed)
        Dictionary<string, List<Class>> raceClassMapping = new Dictionary<string, List<Class>>
        {
            { "Dragonborn", new List<Class> { _classes[0], _classes[1], _classes[8], _classes[9] } },
            { "Dwarf", new List<Class> { _classes[2], _classes[1], _classes[6] } },
            { "Elf", new List<Class> { _classes[3], _classes[7], _classes[6], _classes[8] } },
            { "Gnome", new List<Class> { _classes[1], _classes[6], _classes[8] } },
            { "Half-Elf", new List<Class> { _classes[1], _classes[3], _classes[4], _classes[6], _classes[8], _classes[9] } },
            { "Halfling", new List<Class> { _classes[1], _classes[2], _classes[6] } },
            { "Half-Orc", new List<Class> { _classes[0], _classes[2], _classes[6] } },
            { "Human", new List<Class> { _classes[0], _classes[1], _classes[2], _classes[3], _classes[4], _classes[5], _classes[6], _classes[7], _classes[8], _classes[9] } },
            { "Tiefling", new List<Class> { _classes[1], _classes[2], _classes[8], _classes[9] } }
        };

        // Return the list of classes available for the given race
        if (raceClassMapping.ContainsKey(race.GetName()))
        {
            return raceClassMapping[race.GetName()];
        }
        else
        {
            // If the race is not found in the mapping, return an empty list
            return new List<Class>();
        }
    }

    public Character CustomizeCharacter(string name, Race race, Class characterClass, int level)
    {
        Character character = new Character();
        character.SetName(name);
        character.SetRace(race);

        if (characterClass != null) 
        {
            character.SetClass(characterClass);
            
            // Set other character properties
            character.SetLevel(level);
            character.SetHealthPoints(10 * level);

            // Set attributes
            Dictionary<string, int> raceAttributes = race.GetAttributes();
            if (raceAttributes != null)
            {
                character.SetAttributes(raceAttributes);
            }
            else
            {
                Console.WriteLine("Error: Race attributes are not available.");
            }

            // Add abilities
            List<Ability> classAbilities = characterClass.GetAbilities();
            foreach (Ability ability in classAbilities)
            {
                character.AddAbility(ability);
            }
        }
        else
        {
            Console.WriteLine("Error: Character class is not provided.");
        }

        return character;
    }


    private Race RandomRaceWithBonuses()
    {
        // Define attributes for each race including ability score bonuses
        Dictionary<string, int[]> raceAttributes = new Dictionary<string, int[]>
        {
            { "Dragonborn", new int[] { 2, 0, 0, 0, 0, 1 } },
            { "Dwarf", new int[] { 0, 0, 2, 0, 0, 0 } },
            { "Elf", new int[] { 0, 2, 0, 0, 0, 0 } },
            { "Gnome", new int[] { 0, 0, 0, 2, 0, 0 } },
            { "Half-Elf", new int[] { 0, 0, 0, 0, 0, 2 } },
            { "Halfling", new int[] { 0, 2, 0, 0, 0, 0 } },
            { "Half-Orc", new int[] { 2, 0, 1, 0, 0, 0 } },
            { "Human", new int[] { 1, 1, 1, 1, 1, 1 } },
            { "Tiefling", new int[] { 0, 0, 0, 1, 0, 2 } }
        };

        // Randomly select a race
        string[] raceNames = { "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling", "Half-Orc", "Human", "Tiefling" };
        string randomRaceName = raceNames[_random.Next(raceNames.Length)];
        int[] abilityBonuses = raceAttributes[randomRaceName];

        // Generate a race instance and set its attributes with bonuses
        Race race = new Race();
        race.SetName(randomRaceName);
        Dictionary<string, int> attributes = new Dictionary<string, int>
        {
            { "Strength", _random.Next(1, 21) + abilityBonuses[0] },
            { "Dexterity", _random.Next(1, 21) + abilityBonuses[1] },
            { "Constitution", _random.Next(1, 21) + abilityBonuses[2] },
            { "Intelligence", _random.Next(1, 21) + abilityBonuses[3] },
            { "Wisdom", _random.Next(1, 21) + abilityBonuses[4] },
            { "Charisma", _random.Next(1, 21) + abilityBonuses[5] }
        };
        race.SetAttributes(attributes);
        return race;
    }

    public List<Class> GetClasses()
    {
        List<Class> classes = new List<Class>();

        // Define classes
        Class barbarian = new Class();
        barbarian.SetName("Barbarian");
        classes.Add(barbarian);

        Class bard = new Class();
        bard.SetName("Bard");
        classes.Add(bard);

        Class cleric = new Class();
        cleric.SetName("Cleric");
        classes.Add(cleric);

        Class druid = new Class();
        druid.SetName("Druid");
        classes.Add(druid);

        Class monk = new Class();
        monk.SetName("Monk");
        classes.Add(monk);

        Class paladin = new Class();
        paladin.SetName("Paladin");
        classes.Add(paladin);

        Class ranger = new Class();
        ranger.SetName("Ranger");
        classes.Add(ranger);

        Class rogue = new Class();
        rogue.SetName("Rogue");
        classes.Add(rogue);

        Class sorcerer = new Class();
        sorcerer.SetName("Sorcerer");
        classes.Add(sorcerer);

        Class warlock = new Class();
        warlock.SetName("Warlock");
        classes.Add(warlock);

        return classes;
    }

    public List<Race> GetRaces()
    {
        List<Race> races = new List<Race>();

        // Define races
        Race dragonborn = new Race();
        dragonborn.SetName("Dragonborn");
        races.Add(dragonborn);

        Race dwarf = new Race();
        dwarf.SetName("Dwarf");
        races.Add(dwarf);

        Race elf = new Race();
        elf.SetName("Elf");
        races.Add(elf);

        Race gnome = new Race();
        gnome.SetName("Gnome");
        races.Add(gnome);

        Race halfElf = new Race();
        halfElf.SetName("Half-Elf");
        races.Add(halfElf);

        Race halfling = new Race();
        halfling.SetName("Halfling");
        races.Add(halfling);

        Race halfOrc = new Race();
        halfOrc.SetName("Half-Orc");
        races.Add(halfOrc);

        Race human = new Race();
        human.SetName("Human");
        races.Add(human);

        Race tiefling = new Race();
        tiefling.SetName("Tiefling");
        races.Add(tiefling);

        return races;
    }
}
