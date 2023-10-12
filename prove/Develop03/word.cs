using System.Collections.Generic;
using System;
public class Word
{
    private string _text;
    private bool _isHidden = true;
    
    // create getter and setter of text attribute
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }

    public Word()
    {}
    public Word(string text)
    {
        _text = text;
    }
    public string Hide(int randomWord)
    {
       List <string> words = _text.Split(" ").ToList();
        
            words[randomWord] = "___";
            
           return words[randomWord];
    }
    public string Show(int showRandomWord)
    {
         List<string> words = _text.Split(" ").ToList();
        
            return words[showRandomWord];
           
         
    }

    public bool IsHidden()
    {
      List<string> words = _text.Split(" ").ToList();
        words.Contains("___");

     return _isHidden;
    }

    public string GetDisplayText(int randomWord)
    {
       if (IsHidden())
       {
        _text = Hide(randomWord);
       }
       else
       {
        _text = Show(randomWord);
       }
        
       return _text;
    }
}