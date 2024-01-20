using System;

public class Entry
{
    public string Date { get; set; } //date
    public string PromptText { get; set; } //prompt user
    public string EntryText { get; set; } //entry
    public string Mood { get; set; } // Add Mood Property
    public string Location { get; set; } // Add location property

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}\n");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine($"Location: {Location}\n");
        
    }
}
