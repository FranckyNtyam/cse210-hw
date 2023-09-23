

public class PromptGenerator
{

    public List<string> _prompt = new List<string>();

    public string GetRandomPrompt()
    {
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(_prompt.Count);
        
        Console.WriteLine(_prompt[index]);
        return _prompt[index];
    }
}