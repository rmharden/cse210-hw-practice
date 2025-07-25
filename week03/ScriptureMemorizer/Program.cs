using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string _userResponse = "";
        Word w = new Word("truth");
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (s1.IsCompletelyHidden() && _userResponse.ToLower() != "quit")
        {
            Console.Clear();

            // Console.WriteLine(r1.GetDisplayText());
            Console.Write(s1.GetDisplayText());

            Console.Write($"{w.GetDisplayText()}");

            Console.WriteLine(" ");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            _userResponse = Console.ReadLine();
        }
        
    }
}