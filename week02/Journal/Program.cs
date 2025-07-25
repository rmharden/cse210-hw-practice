using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> _entries = new List<Entry>();
        Journal j1 = new Journal();

        string _userResponse = "";
        while (_userResponse != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit\n");

            Console.Write("What would you like to do? ");

            _userResponse = Console.ReadLine();

            // 1. Write
            if (_userResponse == "1")
            {

            }
            // 2. Display
            else if (_userResponse == "2")
            {
                Entry newEntry = new Entry();
                newEntry.Display();
            }
            // 3. Load
            else if (_userResponse == "3")
            {

            }
            // 4. Save
            else if (_userResponse == "4")
            {

            }
            // 5. Quit
            else if (_userResponse == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program!\n");
            }
            else
            {
                Console.WriteLine("Invalid number\n");
            }
        }

    }
}