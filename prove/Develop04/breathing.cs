using System;

public class BreathingActivity: Activity
{
    // create constructor without parameter

    public BreathingActivity()
    {
        base.SetName("Breathing");
        base.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.SetDuration(40);
    }

    public void Run(int userChoice)
    {
        if ( userChoice == 1)
        {
            Console.Clear();
            // Call the methods display starting message.
            DisplayStartingMessage();
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine("Now breathe out...");
            ShowSpinner(1000);
            Console.WriteLine();
            //Call the method display the end message.
            DisplayEndingMessage();
            
        }
        
    }

    public override void DisplayStartingMessage()
    {
         Console.WriteLine($"Welcome to the {base.GetName()} Activity.");
         Console.WriteLine();
         Console.WriteLine(base.GetDescription());
         Console.WriteLine();
         Console.Write("How long, in seconds, would you like for your session? ");
         string userInput = Console.ReadLine();
         base.SetDuration(int.Parse(userInput));
    }
    public override void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(1000);
        Console.WriteLine();
        Console.WriteLine($"You have complete another {base.GetDuration()} second of the {base.GetName()} Activity.");
        ShowSpinner(1000);
    }
}