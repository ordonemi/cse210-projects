public class Prompt
{
    public List<string> _promptList = new List<string>();

    public void SetPrompts()
    {
        _promptList.Add("What are you most grateful for today?");
        _promptList.Add("Who and why did you help today?");
        _promptList.Add("How would you have done today differently?");
        _promptList.Add("What did you learn from your scripture study today?");
        _promptList.Add("What was your favorite part of today?");
        _promptList.Add("How did you feel the Spirit in your life today?");
        _promptList.Add("What's something you need to do tomorrow?");
        _promptList.Add("How was you day today?");
        
    }
    
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int max = _promptList.Count - 1;

        string prompt = _promptList[rnd.Next(0,max)];
        return prompt;
    }
    

}