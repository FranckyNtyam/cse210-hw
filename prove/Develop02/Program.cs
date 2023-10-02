using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.IO;
using System.Text;
PromptGenerator prompt = new PromptGenerator();
Journal theJournal = new Journal();
Entry entries = new Entry();
DateTime date = DateTime.Now;
entries._date = date;
entries._promptText = prompt.GetRandomPrompt();
entries._entryText = "";
int menuSelect = 0;


Console.WriteLine("Welcome to the Journal Program!");
   do
   { 
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("0. Add New Prompt");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    string selectMenu = Console.ReadLine();
    menuSelect = int.Parse(selectMenu);
   
    
   
    if (menuSelect == 0)
    {
        Console.WriteLine("Add your new prompt");
        string newPrompt = Console.ReadLine();
        prompt.AddPrompt(newPrompt);
        Console.WriteLine("In what file to save new prompt?");
        string fileName = Console.ReadLine();
        prompt.SaveToFile(fileName);
       
        
    }
    if (menuSelect == 1)
    {
        Console.WriteLine(entries._promptText);
        entries._entryText = Console.ReadLine();
        theJournal.AddEntry(entries.Display());
    }
    if (menuSelect == 2)
    {
        
        theJournal.Display();
    }
    if ( menuSelect == 3)
    {
         Console.WriteLine("What is the filename ");
        string file = Console.ReadLine();
        theJournal.LoadFromFile(file);
       
    }

    if ( menuSelect == 4)
    {
        Console.WriteLine("What is the filename ");
        string file = Console.ReadLine();
        theJournal.SaveToFile(file);
        
    }

      
    }
    while (menuSelect < 5);
    







