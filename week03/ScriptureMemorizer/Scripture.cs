public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string _text = text;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random r = new Random();
        


    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
}