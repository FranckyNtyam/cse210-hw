using System.Collections.Generic;
using System.Text;
using System.IO;

public class Scripture
{
    
    
    private string _reference;
    private List<string> _words = new List<string>();
  
    private string _text;
    
    
    public void HideRandomWords( )
    {
          List<string>  words = _text.Split(" ").ToList();
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int index = random.Next(words.Count);
                _words.Add(words[index]);
            
    }
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
       
    }

    public void GetDisplayText()
    {
      Console.Write(_reference);
      List<string> words = _text.Split(" ").ToList();
      foreach (string word in words)
      {
        if (_words.Contains(word))
        {
          Console.Write(" ___");
          Console.Write(" ");
         
        }
        else
        {
           Console.Write(word + " ");
        }
        
      }
      Console.WriteLine();
      
    }
    public bool IsCompletelyHidden()
    {
        List<string> words = _text.Split(" ").ToList();
        

       return _words.TrueForAll(x => x == "__") ;
    }
}