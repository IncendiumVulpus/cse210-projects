using System;

public class UserInterface
{
    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Generate random character");
        Console.WriteLine("2. Customize character");
        Console.WriteLine("3. Display all characters");
        Console.Write("Enter your choice: ");
    }

    public int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write("Enter your choice: ");
        }
        return choice;
    }

    public void PromptForCharacterDetails()
    {
        Console.Write("Enter character name: ");
    }
}
