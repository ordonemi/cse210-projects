//To exceed requirements for this program, I added a 'ScriptureLibrary' class has a list of scriptures that I handpicked. That class
//can choose a random scripture from the ones it has saved, and that scripture is used for the rest of the program. I also added check on the user input,
//so that only the enter key and typing 'quit' are valid choices for the program.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Scripture scripture = new Scripture();
        scripture.DisplayScripture();
        string input = Console.ReadLine();
        while (input != "" && input != "quit")
        {
            Console.WriteLine("Invalid choice. Please try again.");
            input = Console.ReadLine();
        }
        while (input == "")
        {
            Console.Clear();
            scripture.HideWords();
            scripture.DisplayScripture();
            input = Console.ReadLine();
            while (input != "" && input != "quit")
            {
                Console.WriteLine("Invalid choice. Please try again.");
                input = Console.ReadLine();
            }
            
            if (scripture.IsAllHidden())
            {
                input = "quit";
            }

        }
    
    }
}