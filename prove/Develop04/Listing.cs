using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
        _count = 0;
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }

    public override void Run()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.WriteLine("Take the next 5 seconds to think about this, and you will be prompted to list as many items as you can for the duration you have entered...");
        ShowCountDown(5);

        GetListFromUser();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    {
        Console.WriteLine($"List as many items as you can for {_duration} seconds...");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");
    }
}


// using System;

// public class ListingActivity : Activity
// {
//     private string[] listingPrompts = { "People you appreciate", "Your personal strengths", "People you helped this week", "Times you felt the Holy Ghost this month", "Your personal heroes" };

//     protected override void PerformActivity()
//     {
//         Console.WriteLine("Reflect on the good things in your life by listing items.");
//         Random random = new Random();

//         string randomPrompt = listingPrompts[random.Next(listingPrompts.Length)];
//         Console.WriteLine($"Prompt: {randomPrompt}");
//         Pause();

//         Console.WriteLine("Think about the prompt. Starting in 3...");
//         Pause();
//         Console.WriteLine("2...");
//         Pause();
//         Console.WriteLine("1...");
//         Pause();

//         Console.WriteLine("Start listing items:");

//         for (int i = 1; i <= DurationInSeconds; i++)
//         {
//             Console.Write($"{i}. ");
//             string listItem = Console.ReadLine();
//             if (string.IsNullOrWhiteSpace(listItem))
//             {
//                 Console.WriteLine($"You listed {i - 1} items.");
//                 break;
//             }
//         }
//     }
// }
