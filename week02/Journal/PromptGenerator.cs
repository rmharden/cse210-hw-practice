public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        // This works:
        // Random r = new Random();
        // //get a random index value and lookup the string in _prompts
        // int i = r.Next(_prompts.Count);
        // return _prompts[i];

        // Trying to make a random prompt that is different each time:
        Random r = new Random();
        while (_prompts.Count > 0)
        {
            int i = r.Next(_prompts.Count);
            string selectedPrompt = _prompts[i];
            _prompts.RemoveAt(i);
            return selectedPrompt;
        }
        return "";
    }
}