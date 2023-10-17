using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();
        /*
        Console.WriteLine("Assignment Prep 5");
         DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square_Number = SquareNumber(userNumber);
        DisplayResult(userName, square_Number);
        */

        Student student = new Student("Ntyam", "07");
        string number = student.GetName();
        Console.WriteLine (number);
        
    }
/*
        // the first function display the message.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // The second function asks and returns the user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        // The third function Asks and returns the user's favorite number.
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            int userNumber = int.Parse(answer);
            return userNumber;
        }
        // The forth function Accepts an integer as a parameter and returns that number squared
        static int SquareNumber( int number)
        {
             int square_Number = number * number;
             return square_Number;
        }
        // the fifth function Accepts the user's name and the squared number and displays them
        static void DisplayResult(string userName, int square_number)
        {
            Console.WriteLine($"{userName}, the square of your number is {square_number}");
        }*/

}