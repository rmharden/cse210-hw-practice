public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        // split up the words in text and store each as a word in the list_words

        string[] scripture = text.Split(" ");
        // split and then loop through each word
        // create a word object
        string aScripture = scripture.ToString();
        Word aWord = new Word(aScripture);
        foreach (Word w in _words)
        {
            _words.Add(aWord);
        }
        
          

        // List<Word> _words = new List<Word>();
        // Reference _reference = reference;
        // foreach (string t in text.Split(" "))
        // {
        //     Word w = new Word(t);
        //     _words.Add(w);
        // }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        foreach (Word aWord in _words)
        {
            return aWord + " ";
        }
        return "";
    }
}