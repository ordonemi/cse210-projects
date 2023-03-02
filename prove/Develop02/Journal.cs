using System.IO;
public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
    public void Write()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Prompt prompt = new Prompt();
        prompt.SetPrompts();
        Entry entry = new Entry();

        string promptAsked = prompt.GetRandomPrompt();
        entry._promptAsked = promptAsked;

        Console.WriteLine(promptAsked);
        string userInput = Console.ReadLine();

        entry._textValue = userInput;
        entry._currDate = dateText;

        _entryList.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entries in _entryList)
        {
            entries.DisplayEntry(entries);
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string nameForFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(nameForFile))
        {
            foreach (Entry entries in _entryList)
            {
                outputFile.WriteLine($"{entries._currDate},{entries._promptAsked},{entries._textValue}");
            }
        }
    }

    public void Load()
    {   
        _entryList.Clear();
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();


        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split(",");

            entry._currDate = parts[0];
            entry._promptAsked = parts[1];
            entry._textValue = parts[2];

            _entryList.Add(entry);
                
        }
    }
}