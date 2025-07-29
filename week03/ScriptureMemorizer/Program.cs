// Rebekah Harden
// CSE 210: Programming with Classes
// Brother Nathan Parrish
// July 29, 2025

// W03 Project: Scripture Memorizer Program

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


// Here are all my resources to learn how to do this:

// https://learn.microsoft.com/en-us/dotnet/api/system.string.-ctor?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
// https://learn.microsoft.com/en-us/dotnet/api/system.math.min?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-9.0