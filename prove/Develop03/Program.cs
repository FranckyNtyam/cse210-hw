using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            Scripture scripture = new Scripture(reference.GetDisplayText(), " Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him,and he will make your paths straight.");
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();
           string enterOfUser = " ";
            while(enterOfUser.ToLower() != "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to hide a word or type quit to exit:");
                enterOfUser = Console.ReadLine();
                if (enterOfUser.ToLower() == "quit" )
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    scripture.HideRandomWords();
                    scripture.GetDisplayText();
                    Console.WriteLine();
                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("Good job, you are able to memorized the scripture.");

                        return;
                    }
                }
           }

    }
}