using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Word w = new Word("truth");
        Console.WriteLine($"\n{w.GetDisplayText()}");

    }
}