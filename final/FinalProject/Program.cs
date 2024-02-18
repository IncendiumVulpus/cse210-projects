using System;

class Program
{
    static void Main(string[] args)
    {
        CharacterGenerator characterGenerator = new CharacterGenerator();
        CharacterManager characterManager = new CharacterManager();
        UserInterface userInterface = new UserInterface();

        // Display menu and get user choice
        userInterface.DisplayMenu();
        int choice = userInterface.GetUserChoice();

        switch (choice)
        {
            case 1:
                // Generate a random character
                Character randomCharacter = characterGenerator.GenerateCharacter();
                characterManager.AddCharacter(randomCharacter);
                Console.WriteLine("Random character generated and added.");
                break;
            case 2:
                // Prompt user for character details and customize
                userInterface.PromptForCharacterDetails();
                // Example: Obtain name, race, and class from user input
                string name = Console.ReadLine();
                Race race = new Race(); 
                Class characterClass = new Class(); 
                Character customizedCharacter = characterGenerator.CustomizeCharacter(name, race, characterClass);
                characterManager.AddCharacter(customizedCharacter);
                Console.WriteLine("Customized character added.");
                break;
            case 3:
                // Display all characters
                foreach (Character character in characterManager.GetCharacters())
                {
                    Console.WriteLine(character.GetInfo());
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
