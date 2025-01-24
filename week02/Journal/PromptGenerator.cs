public class PromptGenerator
{
    public List<string> _promptList = new List<string> 
    {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "How did I take care of myself today—physically, mentally, emotionally and/or spiritually?",
    "Did I face any fears or discomforts today, and how did I handle them?"} ;

    public PromptGenerator()
    {
    }

    private static readonly Random random = new Random();
    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_promptList.Count);
        return _promptList[randomIndex];
    }
}