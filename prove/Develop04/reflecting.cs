using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts ;
    private List<string> _questions ;

    // create constructor without parameter

    public ReflectingActivity()
    {
        base.SetName("Reflecting");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.SetDuration(30);
        _prompts =  new List<string>(){"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless." };
        _questions = new List<string>(){"> Why was this experience meaningful to you?","> Have you ever done anything like this before?","> How did you get started?","> How did you feel when it was complete?","> What made this time different than other times when you were not as successful?","> What is your favorite thing about this experience?","> What could you learn from this experience that applies to other situations?","> What did you learn about yourself through this experience?","> How can you keep this experience in mind in the future?"};
    }

    // create methods

    public void Run(int userChoice)
    {
        if (userChoice == 2)
        {
            Console.Clear();
            DisplayStartingMessage();
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(1000);
            Console.WriteLine();
            Console.WriteLine("Considered the following prompt:");
            Console.WriteLine();
            DisplayPrompt();
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            string userInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in : ");
            ShowCountDown(1000);
            Console.Clear();
            DisplayQuestion();
            Console.WriteLine();
            Console.WriteLine();
            DisplayEndingMessage();
        }

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        random.Next(_prompts.Count);
        return _prompts[random.Next(0, _prompts.Count-1)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(0, _questions.Count-1)];
    }
    public void DisplayPrompt()
    {
        

        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestion()
    {
        Console.Write($"Please choose the total number of questions you want to Answer between 1 and {_questions.Count} : ");
        string userInput = Console.ReadLine();
        int userChoice = int.Parse(userInput);
        if ( userChoice <= _questions.Count)
        {
             for (int i = 0; i < userChoice; i++)
            {
                Console.Write(GetRandomQuestion());
                ShowSpinner(1000);
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
        } 
        else if ( userChoice < 1 || userChoice > _questions.Count)
        {
            Console.WriteLine("The number you enter is out of 1 and {_questions.Count}");
            Console.WriteLine();
            Console.Write($"Please choose the total number of questions you want to Answer between 1 and {_questions.Count} : ");
            userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
        } 
           
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
    }
}