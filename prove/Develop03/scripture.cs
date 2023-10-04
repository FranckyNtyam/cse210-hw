public class Scripture
{
    private Reference _reference;
    private List<Word> _word;

    public void HideRandomWords(int numberToHide)
    {

    }
    public Scripture(Reference reference, string word)
    {
        _reference = reference;
        _word.Add(word);
    }
    public string GetDisplayText()
    {

    }
    public bool IsCompletelyHidden()
    {

    }
}