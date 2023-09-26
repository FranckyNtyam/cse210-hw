
public class Entry
{
   public DateTime _date;
   public string _promptText;
   public string _entryText;

   public string Display()
   {
    return $"Date: {_date} - Prompt:  {_promptText} \n {_entryText}." ;
   }
}