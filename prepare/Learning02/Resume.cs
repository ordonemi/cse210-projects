public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        
        foreach(Job value in _jobs)
        {
            value.DisplayJobDetails();
        }
    }

}