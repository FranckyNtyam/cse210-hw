using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        menu menu = new menu();
        menu.DisplayMenu();
        string userInput = Console.ReadLine();
        int  userChoice = int.Parse(userInput);
        BreathingActivity breathing = new BreathingActivity();
        breathing.Run(userChoice);
        ReflectingActivity reflecting = new ReflectingActivity();
        reflecting.Run(userChoice);
        ListingActivity listing = new ListingActivity();
        listing.Run(userChoice);
    }
}