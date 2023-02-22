using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        } while (number != 0);

        int sum = 0;
        int max = numbers[0];
        int smallest = numbers[0];

        foreach (int value in numbers)
        {
            sum = sum + value;

            if (value > max)
            {
                max = value;
            }

            if (value > 0 && value < smallest)
            {
                smallest = value;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / (numbers.Count - 1);

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is:  {max}");

        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();

        Console.WriteLine($"The sorted list is:");

        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }


    }
}