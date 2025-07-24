using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string _userResponse = "";
        Word w = new Word("truth");
        while (w.IsHidden() && _userResponse.ToLower() != "quit")
        {
            Console.Write($"\n{w.GetDisplayText()}");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            _userResponse = Console.ReadLine();

        }
        
    }
}