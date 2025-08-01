public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        Reference _reference = reference;
        List<Word> _words = new List<Word>();

        // split the words in text and store each as a word object in the list _words.

        // Split and loop through each word.
        // Create a word object and out them into _words.

        foreach (string w in text.Split(" "))
        {
            Word aWord = new Word(w);
            _words.Add(aWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random r = new Random();
    }

    public string GetDisplayText()
    {
        // Is this a if statement or a loop?
        return "";
    }

    public bool IsCompletelyHidden()
    {
        // I am pretty sure this is an if statement.
        return false;
    }
}