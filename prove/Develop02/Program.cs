using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        prompt._prompt = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?","How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        Entry entries = new Entry();
        entries._promptText = prompt.GetRandomPrompt();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string selectMenu = Console.ReadLine();
        int menuSelect = int.Parse(selectMenu);
        if (menuSelect == 1)
        {
           Console.WriteLine(entries._promptText);
           entries._entryText = Console.ReadLine();
        }
        
         
    }
}