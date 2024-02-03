using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Run()
    {
        Console.WriteLine("This method should be overridden in derived classes... I hope... the user should not see this");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} Activity: {_description}");
        Console.WriteLine($"Please enter how many seconds you would like this activity to last: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_name} Activity for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        // spinner animation
        Console.Write(".");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        // countdown timer for user to see
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}


// using System;
// using System.Threading;

// public class Activity
// {
//     protected int DurationInSeconds;

//     public Activity()
//     {
//         DurationInSeconds = 0;
//     }

//     public virtual void StartActivity()
//     {
//         Console.WriteLine($"Starting {GetType().Name} activity...");
//         SetDuration();
//         PrepareToBegin();
//         PerformActivity();
//         ConcludeActivity();
//         Console.WriteLine($"Good job! You've completed the {GetType().Name} activity.");
//         Pause();
//     }

//     protected virtual void SetDuration()
//     {
//         Console.Write("Enter duration (in seconds): ");
//         DurationInSeconds = int.Parse(Console.ReadLine());
//     }

//     protected virtual void PrepareToBegin()
//     {
//         Console.WriteLine($"Get ready. Starting in 3...");
//         Pause();
//         Console.WriteLine("2...");
//         Pause();
//         Console.WriteLine("1...");
//         Pause();
//     }

//     protected virtual void ConcludeActivity()
//     {
//         Console.WriteLine($"Activity completed in {DurationInSeconds} seconds.");
//         Pause();
//     }

//     protected virtual void Pause()
//     {
//         Thread.Sleep(1000);
//     }

//     protected virtual void Pause(int seconds)
//     {
//         Thread.Sleep(seconds * 1000);
//     }

//     protected virtual void PerformActivity() { }
// }
