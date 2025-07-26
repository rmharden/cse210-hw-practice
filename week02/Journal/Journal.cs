public class Journal
{
    List<Entry> _entries = new List<Entry>();
    // This is what Chad Macbeth has there

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        //loop through each item in _entries and save it in a file
        
        string _file = file;


    }
    public void LoadFromFile(string file)
    {
        // loop through each line in the file and create Entry objects to put in the list - clear the list so there are not duplicates
        string _file = file;
    }
}