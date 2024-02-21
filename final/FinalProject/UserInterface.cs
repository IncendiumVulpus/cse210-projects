using System;

public class UserInterface
{
    public CharacterGenerator _characterGenerator;
    public CharacterManager _characterManager;

    public UserInterface()
    {
        _characterGenerator = new CharacterGenerator();
        _characterManager = new CharacterManager(_characterGenerator.GetRaces());
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. Generate Random Character");
        Console.WriteLine("2. Create Custom Character");
        Console.WriteLine("3. Display Characters");
        Console.WriteLine("4. Exit");
    }

    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }

    public void PromptForCharacterDetails()
    {
        Console.WriteLine("Enter the name for your character:");
        string name = Console.ReadLine();

        // Prompt for race
        Console.WriteLine("Choose a race:");
        DisplayRaces(); // Display races
        int raceChoice;
        while (!int.TryParse(Console.ReadLine(), out raceChoice) || raceChoice < 1 || raceChoice > _characterManager.GetRaces().Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid race choice.");
            DisplayRaces();
        }
        Race selectedRace = _characterManager.GetRaces()[raceChoice - 1];

        // Prompt for class
        Console.WriteLine("Choose a class:");
        DisplayClasses(); // Display classes
        int classChoice;
        while (!int.TryParse(Console.ReadLine(), out classChoice) || classChoice < 1 || classChoice > _characterGenerator.GetClasses().Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid class choice.");
            DisplayClasses();
        }
        Class selectedClass = _characterGenerator.GetClasses()[classChoice - 1];

        // Generate custom character
        Character customCharacter = _characterGenerator.CustomizeCharacter(name, selectedRace, selectedClass, 1);
        //_characterManager.AddCharacter(customCharacter);
        Console.WriteLine("Custom character created successfully:");
        Console.WriteLine(customCharacter.GetInfo()); 
    }

    private void DisplayRaces()
    {
        var races = _characterManager.GetRaces();
        if (races != null)
        {
            for (int i = 0; i < races.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {races[i].GetName()}");
            }
        }
        else
        {
            Console.WriteLine("No races available.");
        }
    }

    private void DisplayClasses()
    {
        var classes = _characterGenerator.GetClasses();
        if (classes != null)
        {
            for (int i = 0; i < classes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {classes[i].GetName()}");
            }
        }
        else
        {
            Console.WriteLine("No classes available.");
        }
    }
    public void DisplayCharacters()
    {
        var characters = _characterManager.GetCharacters();
        if (characters != null)
        {
            foreach (var character in characters)
            {
                Console.WriteLine($"Name: {character.GetName()}, Race: {character.GetRace().GetName()}, Class: {character.GetClass().GetName()}, Level: {character.GetLevel()}, HP: {character.GetHealthPoints()}");

                // Display attributes
                Console.WriteLine("Attributes:");
                var attributes = character.GetAttributes();
                foreach (var attribute in attributes)
                {
                    Console.WriteLine($"{attribute.Key}: {attribute.Value}");
                }

                // Display abilities
                Console.WriteLine("Abilities:");
                var abilities = character.GetAbilities();
                foreach (var ability in abilities)
                {
                    Console.WriteLine($"{ability.GetName()}: {ability.GetDescription()}");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No characters available.");
        }
    }

    public void AddCharacter(Character character)
    {
        _characterManager.AddCharacter(character);
    }
}
