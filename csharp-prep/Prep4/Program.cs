using System.Collections.Generic;

Console.WriteLine("Hello Prep4 World!");
Console.WriteLine();
Console.WriteLine("Assignment Prep 4");
Console.WriteLine();
Console.WriteLine("Enter a list of numbers, type 0 when finished.");
List<double> numbers = new List<double>();
Console.Write("Enter number: ");
string enterNumbers = Console.ReadLine();
double number = double.Parse(enterNumbers);

while (number != 0)
{
    numbers.Add(number); // added numbers in the list.
    Console.Write("Enter number: ");
    enterNumbers = Console.ReadLine();
    number = double.Parse(enterNumbers);

}
double sum = 0;
foreach (double num in numbers)
{
    sum += num; // compute the sum of the numbers in the list.
}
double average = sum / numbers.Count; //compute the average of the numbers in the list.
double largest_number = numbers.Max(); // Find the maximum, or largest, number in the list.
List<double> positiveNumbers = new List<double>();
foreach (double num in numbers)
{
    if (num > 0)
    {
        positiveNumbers.Add(num);
    }
}
double smallestPositiveNumber = positiveNumbers.Min();
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");
Console.WriteLine($"The largest number is: {largest_number}");
Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
Console.WriteLine("The sorted list is:");
numbers.Sort();
foreach (double num in numbers)
{
    Console.WriteLine(num);
}
