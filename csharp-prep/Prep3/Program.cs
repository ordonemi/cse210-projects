using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            int count = 1;
            while (guess != magicNumber)
            {
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
                else
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {count} attempts to guess the magic number");

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();

            Console.WriteLine("");

        } while (response == "yes");
    }
}