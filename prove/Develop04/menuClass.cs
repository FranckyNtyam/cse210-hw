using System;

public class menu
{
   private string _breathing {get;  set;}
   private string _reflecting{get;  set;} 
   private string _listing {get;  set;} 
   public int userChoice;

   public menu()
   {
    _breathing = "Breathing";
    _reflecting = "Reflecting";
    _listing = "Listing";
   }
// create the menu system to allow user to choose an activity.
   public void DisplayMenu()
   {
    Console.WriteLine($"1. Start {_breathing} activity");
    Console.WriteLine($"2. Start {_reflecting} activity");
    Console.WriteLine($"3. Start {_listing} activity");
    Console.WriteLine($"4. Quit");
    Console.Write("Select a choice from the menu: ");

   }
  
  

}
