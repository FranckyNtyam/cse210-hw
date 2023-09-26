
public class Journal
{
    public List<string> _entries = new List<string>();
   
    


    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (string index in _entries)
        {
          Console.WriteLine(index);
        }
    }
    public void SaveToFile(string file)
    {}
    public void LoadFromFile(string file)
    {}
}