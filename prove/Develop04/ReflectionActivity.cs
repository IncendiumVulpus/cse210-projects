using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Run()
    {
        string prompt = GetRandomPrompt();

        DisplayPrompt(prompt);
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5); 
        }
    }
}

// this isn't working
// using System;
// using System.Threading;

// public class ReflectionActivity : Activity
// {
//     private string[] prompts = { "Stand up for someone else", "Do something difficult", "Help someone in need", "Do something selfless" };

//     private string[] reflectionQuestions = {
//         "Why was this experience meaningful to you?",
//         "Have you ever done anything like this before?",
//         "How did you get started?",
//         "What made this time different than other times when you were not successful?",
//         "What is your favorite thing about this experience?",
//         "What could you learn from this experience that applies to other situations?",
//         "What did yu learn about yourself through this experience?",
//         "How can you keep this experience in mind in the future?",
//     };

//     protected override void PerformActivity()
//     {
//         Console.WriteLine("Reflect on times in your life when you have shown strength and resilience.");
//         Random random = new Random();

//         for (int i = 0; i < DurationInSeconds / 2; i++)
//         {
//             string randomPrompt = prompts[random.Next(prompts.Length)];
//             Console.WriteLine($"Prompt: {randomPrompt}");
//             Pause(5);

//             AskReflectionQuestions(random);
//         }
//     }

//     private void AskReflectionQuestions(Random random)
//     {
//         DateTime startTime = DateTime.Now;
//         double elapsedTime = 0;

//         while (elapsedTime < 5)
//         {
//             string randomQuestion = reflectionQuestions[random.Next(reflectionQuestions.Length)];
//             Console.WriteLine($"Reflection: {randomQuestion}");
//             Pause(5);

//             elapsedTime = (DateTime.Now - startTime).TotalSeconds;
//         }
//         // string[] reflectionQuestions = {
//         //     "Why was this experience meaningful to you?",
//         //     "Have you ever done anything like this before?",
//         //     "How did you get started?",
//         //     "What made this time different than other times when you were not successful?",
//         //     "What is your favorite thing about this experience?",
//         //     "What could you learn from this experience that applies to other situations?",
//         //     "What did yu learn about yourself through this experience?",
//         //     "How can you keep this experience in mind in the future?",
//         // };

//         // foreach (var question in reflectionQuestions)
//         // {
//         //     Console.WriteLine($"Reflection: {question}");
//         //     Pause(5);
//         // }
//     }

//     protected override void Pause()
//     {
//         base.Pause();
//     }

//     protected override void Pause(int seconds)
//     {
//         base.Pause(seconds);
//     }
// }
