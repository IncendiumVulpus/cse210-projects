using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        //smaple scripture, you can change this to a different scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His Only Begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        //we need to display the scripture
        DisplayScripture(scripture);

        //loop the words
        while (!scripture.Words.All(word => word.IsHidden))
        {
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to close the program");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
                break;

            HideRandomWords(scripture);
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine($"{scripture.Reference.Book} {scripture.Reference.Chapter}:{scripture.Reference.VerseStart}");

        foreach (var word in scripture.Words)
        {
            Console.Write(word.IsHidden ? "___ " : $"{word.Value} ");
        }
        Console.WriteLine();
    }

    static void HideRandomWords(Scripture scripture)
    {
        Random random = new Random();

        int wordsToHide = random.Next(1, 4);
        int hiddenCount = 0;

        foreach (var word in scripture.Words)
        {
            if (!word.IsHidden && random.Next(2) == 0)
            {
                word.IsHidden = true;
                hiddenCount++;
                if (hiddenCount >= wordsToHide)
                    break;
            }
        }
    }
}