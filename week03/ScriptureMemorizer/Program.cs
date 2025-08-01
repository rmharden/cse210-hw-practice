using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Console.WriteLine(r1.GetDisplayText());
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine();

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(r2.GetDisplayText());
        Scripture s2 = new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways, acknowledge him, and he shall direct thy paths.");
        Console.WriteLine();
    }
} 