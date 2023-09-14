using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string grade_percentage = Console.ReadLine();
        int number = int.Parse(grade_percentage);
        string letter;
        int remainder = number%10;
        string sign;
        if (number >= 90)
        {
            letter = "A";
        }
         else if (number >= 80)
        {
            letter = "B";
        }
         else if (number >= 70)
        {
            letter = "C";
        }
         else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (remainder >= 7 && number >= 90)
        {
            sign = "";
        }
        else if (remainder < 3 && number >= 90)
        {
            sign = "-";
        }
        else if (number < 60 )
        {
            sign = "";
        }
        else if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");
        if (number >= 70)
        {
            Console.WriteLine("Congratulation you passed your examen.");
        }
        else
        {Console.WriteLine("Never give up! go ahead");
        }
    }
}