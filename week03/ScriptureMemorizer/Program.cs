using System;
class Program
{
    static void Main(string[] args)
    {
        string _userResponse = "";

        while (_userResponse.ToLower() != "quit")
        {
            Console.Clear();
            Reference r1 = new Reference("John", 3, 16);
            Console.WriteLine(r1.GetDisplayText());

            Reference r2 = new Reference("Proverbs", 3, 5, 6);
            Console.WriteLine(r2.GetDisplayText());


            //Console.WriteLine("\nProverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            _userResponse = Console.ReadLine();
        }
    }
}