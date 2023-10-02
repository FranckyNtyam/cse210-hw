

public class PromptGenerator
{

    public List<string> _prompt = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?",
"What things you want to improve today?",
"What quotes that inspire or motivate you?"
    }; 

    public string GetRandomPrompt()
    {
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(_prompt.Count);
        
        return _prompt[index];
    }

     public void AddPrompt(string newPrompt)
   {
       _prompt.Add(newPrompt);
   }
   public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true))
        {
            
            
        
          writer.WriteLine(_prompt[_prompt.Count -1]);
        
        }

    }
  
}