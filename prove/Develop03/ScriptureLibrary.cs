using System.IO;
public class ScriptureLibrary
{
    List<Reference> _referenceLibrary = new List<Reference>();
    List<string> _textFromVerses = new List<string>();

    Reference _chosenReference;
    string _chosenVerse;

    public ScriptureLibrary()
    {
        Reference jeremiah = new Reference("Jeremiah",17,7);
        _referenceLibrary.Add(jeremiah);
        Reference psalm = new Reference("Psalm",34,4);
        _referenceLibrary.Add(psalm);
        Reference john = new Reference("John",14,27);
        _referenceLibrary.Add(john);
        Reference proverbs = new Reference("Proverbs",3,4,6);
        _referenceLibrary.Add(proverbs);
        Reference hebrews = new Reference("Hebrews",11,1);
        _referenceLibrary.Add(hebrews);
        Reference alma = new Reference("Alma", 32, 21);
        _referenceLibrary.Add(alma);
        Reference moroni1 = new Reference("Moroni", 7, 40);
        _referenceLibrary.Add(moroni1);
        Reference moroni2 = new Reference("Moroni", 10, 20);
        _referenceLibrary.Add(moroni2);

        _textFromVerses.Add("Blessed is the man that trusteth in the Lord, and whose hope the Lord is.");
        _textFromVerses.Add("I sought the Lord, and he heard me, and delivered me from all my fears.");
        _textFromVerses.Add("Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.");
        _textFromVerses.Add("Trust in the Lord with all your heart and lean not on your own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        _textFromVerses.Add("Now faith is the substance of things hoped for, the evidence of things not seen.");
        _textFromVerses.Add("And now as I said concerning faith-faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        _textFromVerses.Add("And again, my beloved brethren, I would speak unto you concerning hope. How is it that ye can attain faith, save ye shall have hope?");
        _textFromVerses.Add("Wherefore, there must be faith; and if there must be faith there must also be hope; and if there must be hope there must also be charity.");
    }

    public void SetRandomValues()
    {
        Random rg = new Random();
        int rI = rg.Next(_referenceLibrary.Count());

        _chosenReference = _referenceLibrary[rI];
        _chosenVerse = _textFromVerses[rI];
    }

    public Reference GetRandomReference()
    {
        return _chosenReference;
    }

    public string GetRandomVerse()
    {
        return _chosenVerse;
    }





}