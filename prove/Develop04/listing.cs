using System;

public class ListingActivity: Activity
{
    private int _count= 0;
    private List<string> _prompts ;

    // create constructor without parameter

    public ListingActivity()
    {
      base.SetName("Listing");
      base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
      base.SetDuration(50);
      _prompts = new List<string>(){"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }

    // create methods
    public void Run(int userChoice)
    {
        if (userChoice == 3)
        {
            Console.Clear();
           DisplayStartingMessage();
           Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(1000);
           Console.WriteLine();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"---{GetRandomPrompt()}---");
            Console.Write("You may begin in: ");
            ShowSpinner(1000);
            Console.WriteLine();
            GetListFromUser();
            Console.WriteLine();
            DisplayEndingMessage();

        }
        

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        return _prompts[randomPrompt];
    }
    

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        string userInput = Console.ReadLine();
        
        do
        {
            _count++;
            listFromUser.Add(userInput);
            userInput = Console.ReadLine();
            
        }while (userInput !="");
        Console.WriteLine($"You list {_count} items!");

        return listFromUser;
    }

    public override void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {base.GetName()} Activity");
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