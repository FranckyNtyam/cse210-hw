public class Reference
{
    // create attributes private
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        
    }
    // create the first constructor with three paramaters.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    } 


     // create the first constructor with four paramaters.
    public Reference(string book, int chapter, int startVerse, int endVerse )
    {
        _book = book;
        _chapter = chapter;
        _endVerse = endVerse;
        _verse = startVerse;
    } 

    public string GetDisplayText()
    {
        string verse ;
        if (_verse != null && _endVerse == 0)
        {
          verse = _verse.ToString();
        }
        else
        {
            verse = $"{_verse}-{_endVerse}";
        }
       return $"{_book} {_chapter}:{verse}";
    }

}