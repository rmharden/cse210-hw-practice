using System.IO;
public class Journal
{
    List<Entry> _entries = new List<Entry>();
    Entry anEntry = new Entry();
    // This is what Chad Macbeth has there

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        //loop through each item in _entries and save it in a file
        //string _file = file;
        // this part only saves one entry to the file, not all of them
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // This is working now.
            foreach (Entry entry in _entries)
            {
                // outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}");

                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
        Console.WriteLine($"{file} saved.");
    }
    public void LoadFromFile(string file)
    {
        // loop through each line in the file and create Entry objects to put in the list - clear the list so there are not duplicates
        Console.WriteLine($"Loading {file}...");
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] parts = line.Split("~|~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}

// https://video.byui.edu/media/t/1_uoyhkbf2
// https://video.byui.edu/media/t/1_twcn0vdk
