public class Word
{
    private string _word;
    private bool _isVisible;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public string Hide()
    {
        _isVisible = false;
        char[] characters = _word.ToCharArray();
        for (int i = 0; i < characters.Length; i++ )
        {
            characters[i] = '_';
        }

        string hiddenWord = new string(characters);

        return hiddenWord;
    }

    public bool GetStatus()
    {
        return _isVisible;
    }

    

    
}