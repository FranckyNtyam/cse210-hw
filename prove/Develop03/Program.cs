using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Word word = new Word(" Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him,and he will make your paths straight.");
        Reference reference = new Reference("Proverbs", 3, 5, 6);
         word.SetIshidden(false);
        if (word.GetIshidden())
        {
            Console.Write(reference.GetDisplayText());
            word.Hide();
        }
        else
        {
            Console.Write(reference.GetDisplayText());
            word.Show();
        }

        Console.ReadLine();

    }
}