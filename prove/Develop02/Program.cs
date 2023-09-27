using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Journal theJournal = new Journal();
        Entry entries = new Entry();
        DateTime date = DateTime.Now;
        entries._date = date;
        entries._promptText = prompt.GetRandomPrompt();
        entries._entryText = "";
        int menuSelect = 0;
        

        Console.WriteLine();
        do
        {Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string selectMenu = Console.ReadLine();
        menuSelect = int.Parse(selectMenu);

        if (menuSelect == 1)
        {
           Console.WriteLine(entries._promptText);
           entries._entryText = Console.ReadLine();
        }
            
           
        theJournal.AddEntry(entries.Display());

        if (menuSelect == 2)
        {
           theJournal.Display();
        }
         theJournal.counter++;
        }
        while (menuSelect < 5);
        Console.WriteLine(theJournal.counter);
      
        
        
       
       
        
         
    }
}