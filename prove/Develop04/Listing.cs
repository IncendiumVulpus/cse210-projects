using System;

public class ListingActivity : Activity
{
    private string[] listingPrompts = { "People you appreciate", "Your personal strengths", "People you helped this week", "Times you felt the Holy Ghost this month", "Your personal heroes" };

    protected override void PerformActivity()
    {
        Console.WriteLine("Reflect on the good things in your life by listing items.");
        Random random = new Random();

        string randomPrompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine($"Prompt: {randomPrompt}");
        Pause();

        Console.WriteLine("Think about the prompt. Starting in 3...");
        Pause();
        Console.WriteLine("2...");
        Pause();
        Console.WriteLine("1...");
        Pause();

        Console.WriteLine("Start listing items:");

        for (int i = 1; i <= DurationInSeconds; i++)
        {
            Console.Write($"{i}. ");
            string listItem = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(listItem))
            {
                Console.WriteLine($"You listed {i - 1} items.");
                break;
            }
        }
    }
}
