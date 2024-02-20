using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        UserInterface ui = new UserInterface();

        // Define attributes for Dragonborn race
        Dictionary<string, int> dragonbornAttributes = new Dictionary<string, int>
        {
            { "Strength", 2 },
            { "Dexterity", 0 },
            { "Constitution", 0 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 1 }
        };

        // Define attributes for Dwarf race
        Dictionary<string, int> dwarfAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 0 },
            { "Constitution", 2 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

        // Define attributes for Elf race
        Dictionary<string, int> elfAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 2 },
            { "Constitution", 0 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

        // Define attributes for Gnome race
        Dictionary<string, int> gnomeAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 0 },
            { "Constitution", 0 },
            { "Intelligence", 2 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

        // Define attributes for Half-Elf race
        Dictionary<string, int> halfElfAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 0 },
            { "Constitution", 0 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 2 }
        };

        // Define attributes for Halfling race
        Dictionary<string, int> halflingAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 2 },
            { "Constitution", 0 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

        // Define attributes for Half-Orc race
        Dictionary<string, int> halfOrcAttributes = new Dictionary<string, int>
        {
            { "Strength", 2 },
            { "Dexterity", 0 },
            { "Constitution", 1 },
            { "Intelligence", 0 },
            { "Wisdom", 0 },
            { "Charisma", 0 }
        };

        // Define attributes for Human race
        Dictionary<string, int> humanAttributes = new Dictionary<string, int>
        {
            { "Strength", 1 },
            { "Dexterity", 1 },
            { "Constitution", 1 },
            { "Intelligence", 1 },
            { "Wisdom", 1 },
            { "Charisma", 1 }
        };

        // Define attributes for Tiefling race
        Dictionary<string, int> tieflingAttributes = new Dictionary<string, int>
        {
            { "Strength", 0 },
            { "Dexterity", 0 },
            { "Constitution", 0 },
            { "Intelligence", 1 },
            { "Wisdom", 0 },
            { "Charisma", 2 }
        };

        // Define attributes for Barbarian class
        List<Ability> barbarianAbilities = new List<Ability>
        {
            new Ability("Rage"),
            new Ability("Reckless Attack"),
            new Ability("Primal Path")
        };
        Class barbarianClass = new Class();
        barbarianClass.SetName("Barbarian");
        barbarianClass.SetAbilities(barbarianAbilities);

        // Define attributes for Bard class
        List<Ability> bardAbilities = new List<Ability>
        {
            new Ability("Bardic Inspiration"),
            new Ability("Spellcasting"),
            new Ability("Jack of All Trades")
        };
        Class bardClass = new Class();
        bardClass.SetName("Bard");
        bardClass.SetAbilities(bardAbilities);

        // Define attributes for Cleric class
        List<Ability> clericAbilities = new List<Ability>
        {
            new Ability("Divine Domain"),
            new Ability("Channel Divinity"),
            new Ability("Spellcasting")
        };
        Class clericClass = new Class();
        clericClass.SetName("Cleric");
        clericClass.SetAbilities(clericAbilities);

        // Define attributes for Druid class
        List<Ability> druidAbilities = new List<Ability>
        {
            new Ability("Wild Shape"),
            new Ability("Druidic"),
            new Ability("Spellcasting")
        };
        Class druidClass = new Class();
        druidClass.SetName("Druid");
        druidClass.SetAbilities(druidAbilities);

        // Define attributes for Fighter class
        List<Ability> fighterAbilities = new List<Ability>
        {
            new Ability("Slash"),
            new Ability("Block"),
            new Ability("Charge")
        };
        Class fighterClass = new Class();
        fighterClass.SetName("Fighter");
        fighterClass.SetAbilities(fighterAbilities);

        // Define attributes for Monk class
        List<Ability> monkAbilities = new List<Ability>
        {
            new Ability("Martial Arts"),
            new Ability("Ki"),
            new Ability("Unarmored Movement")
        };
        Class monkClass = new Class();
        monkClass.SetName("Monk");
        monkClass.SetAbilities(monkAbilities);

        // Define attributes for Paladin class
        List<Ability> paladinAbilities = new List<Ability>
        {
            new Ability("Divine Sense"),
            new Ability("Lay on Hands"),
            new Ability("Divine Smite")
        };
        Class paladinClass = new Class();
        paladinClass.SetName("Paladin");
        paladinClass.SetAbilities(paladinAbilities);

        // Define attributes for Ranger class
        List<Ability> rangerAbilities = new List<Ability>
        {
            new Ability("Favored Enemy"),
            new Ability("Natural Explorer"),
            new Ability("Spellcasting")
        };
        Class rangerClass = new Class();
        rangerClass.SetName("Ranger");
        rangerClass.SetAbilities(rangerAbilities);

        // Define attributes for Rogue class
        List<Ability> rogueAbilities = new List<Ability>
        {
            new Ability("Sneak Attack"),
            new Ability("Thieves' Cant"),
            new Ability("Cunning Action")
        };
        Class rogueClass = new Class();
        rogueClass.SetName("Rogue");
        rogueClass.SetAbilities(rogueAbilities);

        // Define attributes for Sorcerer class
        List<Ability> sorcererAbilities = new List<Ability>
        {
            new Ability("Sorcerous Origin"),
            new Ability("Spellcasting"),
            new Ability("Metamagic")
        };
        Class sorcererClass = new Class();
        sorcererClass.SetName("Sorcerer");
        sorcererClass.SetAbilities(sorcererAbilities);

        // Define attributes for Warlock class
        List<Ability> warlockAbilities = new List<Ability>
        {
            new Ability("Pact Magic"),
            new Ability("Eldritch Invocations"),
            new Ability("Pact Boon")
        };
        Class warlockClass = new Class();
        warlockClass.SetName("Warlock");
        warlockClass.SetAbilities(warlockAbilities);

        // Define attributes for Wizard class
        List<Ability> wizardAbilities = new List<Ability>
        {
            new Ability("Fireball"),
            new Ability("Teleport"),
            new Ability("Summon Familiar")
        };
        Class wizardClass = new Class();
        wizardClass.SetName("Wizard");
        wizardClass.SetAbilities(wizardAbilities);

        while (true)
        {
            ui.DisplayMenu();
            int choice = ui.GetUserChoice();

            switch (choice)
            {
                case 1:
                    Character randomCharacter = ui._characterGenerator.GenerateCharacter();
                    ui._characterManager.AddCharacter(randomCharacter);
                    Console.WriteLine("Random character generated successfully:");
                    Console.WriteLine(randomCharacter.GetInfo()); // Display character information
                    break;
                case 2:
                    ui.PromptForCharacterDetails();
                    break;
                case 3:
                    ui.DisplayCharacters();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
