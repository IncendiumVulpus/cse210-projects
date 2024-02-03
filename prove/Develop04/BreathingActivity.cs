public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Each breath in and out will last 3 seconds.")
    {
    }

    public override void Run()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
    }
}


// using System;

// public class BreathingActivity : Activity
// {
//     public BreathingActivity()
//     {
//     }

//     protected override void PerformActivity()
//     {
//         Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

//         for (int i = 0; i < DurationInSeconds / 2; i++)
//         {
//             Console.WriteLine("Breathe in...");
//             Pause(2);
//             Console.WriteLine("Breathe out...");
//             Pause(2);
//         }
//     }
// }
