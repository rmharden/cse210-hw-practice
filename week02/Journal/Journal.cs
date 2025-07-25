public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {      
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        Entry dateEntry = new Entry(_date);

        PromptGenerator pG = new PromptGenerator();
        string _promptText = pG.GetRandomPrompt();
        Console.WriteLine(_promptText);

        Console.Write("> ");
        string _entryText = Console.ReadLine();

        foreach (Entry entry in _entries)
        {
            string[] parts = entry.ToString().Split(",");
            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[3];

            Console.WriteLine($"Date: {parts[1]} - Prompt: {parts[2]}\n{parts[3]}");
        }
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {
        string _file = file;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[3];
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                outputFile.WriteLine($"Date: {parts[1]} - Prompt: {parts[2]}\n{parts[3]}");
            }
        }  
    }
    public void LoadFromFile(string file)
    {
        string _file = file;
    }
}