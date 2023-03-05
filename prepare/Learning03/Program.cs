using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(3,4);


        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        test3.SetTop(1);
        test3.SetBottom(3);

        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());


    }
}

