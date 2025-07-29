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
        string _userResponse = "";

        // This was test code, but I think need a Word object.
        // Word w = new Word("truth");


        // What do we do for the program that needs to be turned in? Are we supposed to make the program randomly choose one of these scriptures or do we need to only just have the program be capable of handling more than one verse?

        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways, acknowledge him, and he shall direct thy paths.");

        

        // I like this, but there might be another way.
        while (s1.IsCompletelyHidden() && _userResponse.Trim().ToLower() != "quit")
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
// https://learn.microsoft.com/en-us/dotnet/api/system.string.trim?view=net-9.0