public class Scripture
{
    private Reference _reference;
    private string _scriptureText;

    private string[] _arrayOfWords;
    private List<Word> _listOfWords = new List<Word>();

    public Scripture()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.SetRandomValues();
        _reference = library.GetRandomReference();
        _scriptureText = library.GetRandomVerse();
        _arrayOfWords = _scriptureText.Split(" ");

        for (int i = 0; i < _arrayOfWords.Length; i++)
        {
            Word wordToAdd = new Word(_arrayOfWords[i]);
            _listOfWords.Add(wordToAdd);
        }
    }

    public void ReadFile()
    {

    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.ReferenceRenderedText()} {_scriptureText}");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
    }


    public void HideWords()
    {
        Random rg = new Random();
        int numberOfWordsVisible = 0;
        int iterations;

        foreach(Word word in _listOfWords)
        {
            if (word.GetStatus())
            {
                numberOfWordsVisible++;
            }
        }

        if (numberOfWordsVisible >= 3)
        {
            iterations = 3;
        }
        else
        {
            iterations = numberOfWordsVisible;
        }
        
        for (int i = 0; i < iterations; i++)
        {
            int rI = rg.Next(_listOfWords.Count);

            bool isVisible = _listOfWords[rI].GetStatus();

            if (isVisible)
            {
                _arrayOfWords[rI] = _listOfWords[rI].Hide();
            }
            else
            {
                i--;
            }

            _scriptureText = String.Join(" ",_arrayOfWords);
            
        }
    }

    public bool IsAllHidden()
    {
        bool isAllHidden = true;
        foreach (Word word in _listOfWords)
        {
            if (word.GetStatus())
            {
                isAllHidden = false;
            }
        }

        return isAllHidden;
    }
}