
public class Journal
{
    public List<string> _entries = new List<string>();
    public int counter;
   
    


    public void AddEntry(string newEntry)
    {
        _entries.Insert(counter, newEntry);
         
    }

    public void Display()
    {
        foreach (string i in _entries)
        {
          Console.WriteLine(i);
        }
    }
    public void SaveToFile(string file)
    {}
    public void LoadFromFile(string file)
    {}
}