using System.IO;
public class Journal
{
    public List<string> _entries = new List<string>();

    public int counter;
    public string[] arrayLine;
   
   DateTime date = DateTime.Now;
     
    

    public void AddEntry(string newEntry)
    {
       
        _entries.Insert(counter, newEntry);
         
    }

    public void Display()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
          Console.WriteLine(_entries[i]);
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true))
        {
            
             for (int i = 0; i < _entries.Count; i++)
        {
          writer.WriteLine(_entries[i]);
        }
        }

    }
    public void LoadFromFile(string file)
    {
       string[] entries = File.ReadAllLines(file);
       
        
        foreach (string line in entries)
       {
         _entries.Add(line);
           
       }
        

    }
}