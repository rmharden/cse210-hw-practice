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

        // This option works, but once the count gets to 0, there are no prompts for the zero... so how do you restart the count i the user presses 1 from the menu again?
        // Random r = new Random();
        // while (_prompts.Count > 0)
        // {
        //     int i = r.Next(_prompts.Count);
        //     string selectedPrompt = _prompts[i];
        //     _prompts.RemoveAt(i);
        //     return selectedPrompt;
        // }
        // return "";

        // this method doesn't work:
        // trying another way:
        // Random r = new Random();
        // List<string> _uniquePrompts = new List<string>(_prompts);
        // if (_uniquePrompts.Count == 0)
        // {
        //     _uniquePrompts = new List<string>(_prompts);
        // }
        // int i = r.Next(_uniquePrompts.Count);
        // string prompt = _uniquePrompts[i];
        // _uniquePrompts.RemoveAt(i);
        // return prompt;

        // Try to combine the two:
        Random r = new Random();
        
    }
}
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-9.0
// https://learn.microsoft.com/en-us/answers/questions/1661541/add-items-to-list-randomly