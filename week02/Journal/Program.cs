// Rebekah Harden
// CSE 210: Programming with Classes
// Brother Nathan Parrish
// Finished July 27, 2025

// To exceed the requirements for the Showing Creativity Portion, I thought about reasons someone might be kept from writing a journal. My solution was to add another menu option to work through emotions. I created another class that gets a random emotion or feeling from a list and displays it to the user.The user is then has the option to write about that emotion when they choose 1 and they get their writing prompt.

using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator aPrompt = new PromptGenerator();
        List<Entry> _entries = new List<Entry>();
        Journal theJournal = new Journal();

        Console.WriteLine("\nWelcome to the Journal Program!");

        string _userResponse = "";
        while (_userResponse != "6")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Work Through Your Emotions");
            Console.WriteLine("6. Quit\n");

            Console.Write("What would you like to do? ");

            _userResponse = Console.ReadLine();

            // 1. Write
            if (_userResponse == "1")
            {
                // create an entry object to pass to the jounral for storage
                // make an entry object to pass it through

                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._date = _date;

                anEntry._promptText = aPrompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);

                Console.Write("> ");

                anEntry._entryText = Console.ReadLine();

                theJournal.AddEntry(anEntry);
            }
            // 2. Display
            else if (_userResponse == "2")
            {
                theJournal.DisplayAll();
            }
            // 3. Load
            else if (_userResponse == "3")
            {
                Console.WriteLine("What is the name of the file?");
                Console.Write("> ");
                string _file = Console.ReadLine();
                theJournal.LoadFromFile(_file);
            }
            // 4. Save
            else if (_userResponse == "4")
            {
                Console.WriteLine("What is the name of the file?");
                Console.Write("> ");
                string _file = Console.ReadLine();
                theJournal.SaveToFile(_file);
            }
            // 5. 
            else if (_userResponse == "5")
            {
                Console.WriteLine("\nThink about when you have felt the following emotion and if you'd like to include this type of feeling in your journal entry today.");

                EmotionsGenerator eG = new EmotionsGenerator();
                Console.WriteLine($"\n'{eG.GetRandomEmotion()}'");

                Console.WriteLine("\nIf you're uncomfortable with this emotion, that is alright - you can skip it and choose another or move on to a different portion of your journal!\n");
            }
            // 6. Quit
            else if (_userResponse == "6")
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
// https://video.byui.edu/media/t/1_uoyhkbf2
// https://video.byui.edu/media/t/1_twcn0vdk