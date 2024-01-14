using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // can I add the + or - sign?
        string sign = "";
        if (percent % 10 >= 7)
        {
            sign = "+";
        }
        else if (percent % 10 < 3)
        {
            sign = "-";
        }
        
        if (letter != "F")
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"Your Grade is: {letter}");
        }

        if (percent >= 70)
        {
            Console.WriteLine("You have passed!");
        }
        else
        {
            Console.WriteLine("Oh, too bad. You did not pass, but you can try again and do better!");        }

    }
}