using System;

class Program
{
    static void Main(string[] args)
    {
        string _userResponse = "";
        while (_userResponse != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1.. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit\n");

            Console.Write("What would you like to do? ");

            _userResponse = Console.ReadLine();


        }

    }
}