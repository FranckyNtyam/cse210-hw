using System.Collections.Generic;
using System.Text;
using System.IO;

public class Scripture
{
    
    
    private Reference _reference;
    private List<string> _words;
   

    public void HideRandomWords(int numberToHide)
    {
         
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words.AddRange(text.Split(" "));
    }

    public string GetDisplayText()
    {
        return " ";
    }
    public bool IsCompletelyHidden()
    {
       return true;
    }
}