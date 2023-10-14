using System.Collections.Generic;
using System;
public class Word
{
    private string _text;
    private bool _isHidden {get; set;}
    
    // create getter and setter of text attribute
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string Hide(int numberToHide)
    {
       List <string> words = _text.Split(" ").ToList();
          
        return words[numberToHide] = "___";
    }
    public string Show(int numberToShow)
    {
         List<string> words = _text.Split(" ").ToList();
           
         return words[numberToShow];
    }

    public bool IsHidden()
    {
            List<string> words = _text.Split(" ").ToList();
            
        
            if (words.TrueForAll(x => x == "___"))
            {
                _isHidden = true;
            }
            else
            {
                _isHidden = false;
            }
       


     return _isHidden;
    }

    public string GetDisplayText(int wordReturn)
    {
       List<string> words = _text.Split(" ").ToList();
       if (IsHidden())
       {
        _text = Hide(wordReturn);
       }
       else
       {
        _text = Show(wordReturn);
       }

        
       return _text;
    }
}