using System;
using System.Threading;

public class Activity
{
    protected int DurationInSeconds;

    public Activity()
    {
        DurationInSeconds = 0;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {GetType().Name} activity...");
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        ConcludeActivity();
        Console.WriteLine($"Good job! You've completed the {GetType().Name} activity.");
        Pause();
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        DurationInSeconds = int.Parse(Console.ReadLine());
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine($"Get ready. Starting in 3...");
        Pause();
        Console.WriteLine("2...");
        Pause();
        Console.WriteLine("1...");
        Pause();
    }

    protected virtual void ConcludeActivity()
    {
        Console.WriteLine($"Activity completed in {DurationInSeconds} seconds.");
        Pause();
    }

    protected virtual void Pause()
    {
        Thread.Sleep(1000);
    }

    protected virtual void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    protected virtual void PerformActivity() { }
}
