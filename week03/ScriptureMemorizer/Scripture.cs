public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        Reference _reference = reference;
        List<Word> _words = new List<Word>();


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