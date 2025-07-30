// Rebekah Harden
// CSE 210: Programming with Classes
// Brother Nathan Parrish
// July 29, 2025

// Week 03: Encapsulation
// W03 Project: Scripture Memorizer Program


using System;

class Program
{
    static void Main(string[] args)
    {
        string _userResponse = "";
        Random r = new Random();

        // What do we do for the program that needs to be turned in? Are we supposed to make the program randomly choose one of these scriptures or do we need to only just have the program be capable of handling more than one verse?

        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways, acknowledge him, and he shall direct thy paths.");

        // The instructions say that the the program has multiple constructors for the scripture reference to handle, but it doesn't say what should actually display out of the two, since the demo only showed one scripture. I chose to make the program pick a random scripture with it's reference display when the program is run.
        // This chooses a scripture randomly from the list of local variables - though, you can get the same scripture for a few times when you start the program each time.
        List<Scripture> scriptures = new List<Scripture>()
        {
            s1, s2
        };

        Scripture selected = scriptures[r.Next(scriptures.Count)];

        // Directions from Chad Macbeth's video on BYU-I Videos:
        // loop
        // display, hide, check if we need to quit:
        // call the functions in the scripture class.
        // Chad macbeth said not to use any other functions here.

        Console.WriteLine(selected.GetDisplayText());

        // I like this, but there might be another way.
        // Once IsCompletelyHidden, !seleced will return 'true' which the ! makes false and stops the loop.
        while (!selected.IsCompletelyHidden() && _userResponse.Trim().ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(selected.GetDisplayText());
            Console.WriteLine(" ");

            // This is getting a random numberToHide value from 1-3:
            int numberToHide = r.Next(1, 4);
            selected.HideRandomWords(numberToHide);

            // I needed to move this here because it wasn't showing until the end:
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            _userResponse = Console.ReadLine();
        }
        // Not having clearing the console shows words are left.
        Console.Clear();
        // Do I need this here? Not having it here means the console clears after and then it doesn't show anything when it ends the program. Having this by itself will write a duplicate at the end if the console isn't cleared.
        Console.WriteLine(selected.GetDisplayText());
    }
}


// Here are all my resources to learn how to do this:

// https://learn.microsoft.com/en-us/dotnet/api/system.string.-ctor?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
// https://learn.microsoft.com/en-us/dotnet/api/system.math.min?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.string.trim?view=net-9.0
// https://video.byui.edu/media/t/1_sv3gxgzs
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
// https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
// "The operators include the unary logical negation (!)..."