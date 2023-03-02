//To satisfy the showing creativity requirement, I added more prompts to the _promptList found in Prompt.cs. Also, I expanded on the original design of the project so that it could handle when 
//the user wants to enter more than one entry without having to type in "1" in the menu everytime. I did this by asking the user if they would like to add another entry after they write their first entry.
//IF the user types yes, then another prompt is pulled at random from the _promptList and the user can write another entry. This entry is also saved in the _entryList in Journal.cs, so it will display correctly as well.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        journal.DisplayMenu();

        int choice = int.Parse(Console.ReadLine());

        while (choice != 5)
        {
            if (choice == 1)
            {
                journal.Write();

                Console.WriteLine();
                Console.Write("Would you like to write another entry (y/n)? ");
                string response = Console.ReadLine();

                while (response == "y")
                {   
                    if (response == "y")
                    {
                        journal.Write();
                    }

                    Console.WriteLine();
                    Console.Write("Would you like to write another entry (y/n)? ");
                    response = Console.ReadLine();
                }

            }
            else if (choice == 2)
            {
                journal.DisplayJournal();
            }
            else if (choice == 3)
            {
                journal.Load();
            }
            else if (choice == 4)
            {
                journal.Save();
            }

            journal.DisplayMenu();
            choice = int.Parse(Console.ReadLine());
        }
    }
}