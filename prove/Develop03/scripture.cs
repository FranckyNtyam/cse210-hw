using System.Collections.Generic;
using System.Text;
using System.IO;

public class Scripture
{
    
    
    private string _reference;
    private List<string> _words = new List<string>();
    private string _text;
    
    Word word1 = new Word();
    public void HideRandomWords()
    {
          List<string>  words = _text.Split(" ").ToList();
            Random random = new Random();
            int index = random.Next(0, words.Count);
            string hideWord = words[index];
      // add words to the list _words
           _words.Add(hideWord);
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
          Console.Write("___");
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
       string[] words = _text.Split(" ");

       return _words.Count == words.Length;
    }
}