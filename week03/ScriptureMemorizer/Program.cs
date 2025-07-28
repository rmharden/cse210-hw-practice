using System;
class Program
{
    static void Main(string[] args)
    {
        string _userResponse = "";

        while (_userResponse.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine("\nProverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            _userResponse = Console.ReadLine();
        }
    }
}