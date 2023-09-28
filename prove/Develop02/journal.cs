
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
        for (int i = 0; i < _entries.Count-1; i++)
        {
          Console.WriteLine(_entries[i]);
        }
    }
    public void SaveToFile(string file)
    {}
    public void LoadFromFile(string file)
    {}
}