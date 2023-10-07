public class Word
{
    private string _text;
    private bool _isHidden;
    
    Random random = new Random();
    // create the getter and setter of attribute _text.
    public bool GetIshidden()
    {
        return _isHidden;
    }
    public void SetIshidden(bool ishidden)
    {
        _isHidden = ishidden;
    }

    public Word()
    {}
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        
        
            string[] wordArray = _text.Split(" ");
            int index = random.Next(wordArray.Count());
           
            for (int i = 0; i < wordArray.Length; i++)
            {
                 wordArray[index] = "_";
                Console.Write(wordArray[i]);
                Console.Write(" ");
         }
        
    }
    public void Show()
    {
        
        
            
            string[] wordArray = _text.Split(" ");
            int index = random.Next(wordArray.Count());
            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.Write(wordArray[i]);
                Console.Write(" ");
            }
        
    }

    public bool IsHidden()
    {
       return true;
    }

    public string GetDisplayText()
    {
       return _text;
    }
}