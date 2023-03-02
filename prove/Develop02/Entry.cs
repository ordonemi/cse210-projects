public class Entry
{
    public string _currDate;

    public string _textValue;

    public string _promptAsked;

    public void DisplayEntry(Entry entry)
    {
            Console.WriteLine($"Date: {entry._currDate} - Prompt: {entry._promptAsked}");
            Console.WriteLine(entry._textValue);
            Console.WriteLine();
    }
}