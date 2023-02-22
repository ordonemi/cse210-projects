using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentange? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        Console.WriteLine("");
        
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        int remainder = grade % 10;
        string sign;

        if (remainder >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
        else if (remainder < 3)
        {
            if (letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");
        
        if (letter == "F")
        {
            Console.WriteLine("Sorry, you did not pass the course.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
    }
}