using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        Console.WriteLine("Assignment Prep 3");
        Console.WriteLine();
        static void Game()
        {
             Console.WriteLine("Guess the magic number");
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int guess_number = 0;
        int numberOfGuesses = 0;
        while (guess_number != magic_number)
        {
             Console.Write("What is your guess? ");
        string guess_requested = Console.ReadLine();
         guess_number = int.Parse(guess_requested);
            if (magic_number == guess_number)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (magic_number > guess_number)
        {
            Console.WriteLine("Higher");
        }
        else if (magic_number < guess_number)
        {
            Console.WriteLine("Lower");
        }
        numberOfGuesses ++;

        }
        Console.WriteLine($"The total guesses you made is: {numberOfGuesses}");
        }
        Game();
       
        string answer = "yes";
         while ( answer == "yes")
         {
            Console.WriteLine("Do you want to play again? ");

        answer = Console.ReadLine();
         answer = answer.ToLower();
         if (answer == "yes")
         {
            Game();
         }
         else
         {
            Console.WriteLine("Game Over!");
         }
         }
        
    }
}