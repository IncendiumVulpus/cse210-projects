using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1,101);
        int userGuess;
        
        Console.WriteLine("Welcome to my Guess the Magic Number Game!");
        Console.Write("Enter your guess ");

        int enteredMagicNumber = int.Parse(Console.ReadLine());

        if (enteredMagicNumber == magicNumber)
        {
            Console.WriteLine("WOW!! You guessed the Magic Number! Congratulations!");
        }
        else
        {
            Console.WriteLine("Oh, I'm sorry. That was not the right number. Try again!");

            do
            {
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("oh, that's too low. Try guessing higher!");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Too high, try guessing lower!");
                }
                else 
                {
                    Console.WriteLine("Congratulations!! You guessed the Magic Number!!");
                }
            } while (userGuess != magicNumber);
        }
        
    }
}