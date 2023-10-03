using System.Collections.Generic;
using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

    Fraction fraction1 = new Fraction();
    Fraction fraction2 = new Fraction(6);
    Fraction fraction3 = new Fraction(6, 7);

    fraction2.SetTop(5);
    fraction3.SetTop(3);
    fraction3.SetBottom(4);
    Console.WriteLine(fraction1.GetFractionString());
    Console.WriteLine(fraction1.GetDecimalValue());
    Console.WriteLine(fraction2.GetFractionString());
    Console.WriteLine(fraction2.GetDecimalValue());
    Console.WriteLine(fraction3.GetFractionString());
    Console.WriteLine(fraction3.GetDecimalValue());
    fraction3.SetTop(1);
    fraction3.SetBottom(3);
    Console.WriteLine(fraction3.GetFractionString());
    Console.WriteLine(fraction3.GetDecimalValue());
    

    }
}