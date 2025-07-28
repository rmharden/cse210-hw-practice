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
                EmotionsGenerator eG = new EmotionsGenerator();
                Console.WriteLine($"\n{eG.GetRandomEmotion()}");

                Console.WriteLine("Think about when you have felt this emotion and if you'd like to include this type of feeling in your journal entry today.");

                Console.WriteLine("If you're uncomfortable with this emotion, that is alright - you can skip it and choose another or move on to the writing portion of your journal!\n");
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